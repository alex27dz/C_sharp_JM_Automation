using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using HelperClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechTalk.SpecFlow;
using WebCommonCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickBillPayPages.Pages
{
    public class SQL_Queries : Page
    {
        public void getAccountNumberFromDb(Table table)
        {
            ClearRegistryValues();
            string sScnearioName = table.Rows[0]["ScenarioName"];
            string connectionString = "Server=dbBillingCenter_stage;Database=BillingCenter;Trusted_Connection=Yes";
            string DbAccountNumber = "";
            string sqlQuery = "";
            switch (sScnearioName)
            {
                case "TS01_PastDue_ActivePolicy":
                    sqlQuery = "select top 1 * from ( " +
                               " select top 10 acc.AccountNumber,inv.AmountDue,inv.PaymentDueDate,ins.NAME Status from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Due' and inv.Retired = 0" +
                               " and inv.AmountDue > 5" +
                               " and acc.AccountNumber in (select acc.AccountNumber from bc_delinquencyprocess dp" +
                               " inner join bc_account acc on acc.ID = dp.AccountID" +
                               " inner join bc_delinquencyprocessevent dpevent on dpevent.DelinquencyProcessID =dp.ID" +
                               " inner join bctl_delinquencyeventname dpeventname on dpeventname.ID = dpevent.EventName" +
                               " inner join bctl_delinquencytriggerbasis dptrigger on dptrigger.ID = dpevent.TriggerBasis" +
                               " where acc.AccountNumber in (select acc.AccountNumber from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Planned' and inv.Retired = 0" +
                               " and inv.AmountDue > 5)" +
                               " and dpeventname.DESCRIPTION = 'Cancellation Billing Instruction Received'" +
                               " and dpevent.CompletionTime is null" +
                               " and acc.DelinquencyStatus = 1" +
                               " and dp.Status = 4)" +
                               " order by inv.PaymentDueDate " +
                               " ) TestData order by newid()";
                    break;
                case "TS02_Past_CurrentDue_ActivePolicy":
                    sqlQuery = "select top 1 * from ( " + 
                               "select TOP 10 acc.AccountNumber,inv.AmountDue,inv.PaymentDueDate,ins.NAME Status,inv.EventDate from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Due' and inv.Retired = 0" +
                               " and AccountNumber not in (3000411110) " +
                               " and inv.AmountDue > 100" +
                               " and acc.AccountNumber in (select acc.AccountNumber from bc_delinquencyprocess dp" +
                               " inner join bc_account acc on acc.ID = dp.AccountID" +
                               " inner join bc_delinquencyprocessevent dpevent on dpevent.DelinquencyProcessID =dp.ID" +
                               " inner join bctl_delinquencyeventname dpeventname on dpeventname.ID = dpevent.EventName" +
                               " inner join bctl_delinquencytriggerbasis dptrigger on dptrigger.ID = dpevent.TriggerBasis" +
                               " where acc.AccountNumber in (select acc.AccountNumber from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Billed' and inv.Retired = 0" +
                               " and inv.AmountDue > 5)" +
                               " and dpeventname.DESCRIPTION = 'Cancellation Billing Instruction Received'" +
                               " and dpevent.CompletionTime is null" +
                               " and acc.DelinquencyStatus = 1" +
                               " and dp.Status = 4)" +
                               " order by inv.PaymentDueDate" +
                               " ) TestData order by newid()";
                    break;
                case "TS03_Current_FutureDue_ActivePolicy":
                    sqlQuery = "select top 1 * from ( " + 
                               "select top 10 acc.AccountNumber,inv.AmountDue,inv.PaymentDueDate,ins.NAME Status from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Billed' and inv.Retired = 0" +
                               " and inv.AmountDue > 500" +
                               " and acc.AccountNumber in (select acc.AccountNumber from bc_invoice inv" +
                               " inner join bc_account acc on acc.ID = inv.AccountID" +
                               " inner join bctl_invoicestatus ins on ins.ID = inv.Status" +
                               " where ins.NAME = 'Planned' and inv.Retired = 0" +
                               " and inv.AmountDue > 5)" +
                               " order by inv.PaymentDueDate" +
                               " ) TestData order by newid()";
                    break;
                case "TS04_PlcyCancel_StillActivePolicy":
                    sqlQuery = "select top 1 * from ( " + 
                               "select top 10 acc.AccountNumber,acc.DelinquencyStatus,dp.Status,dpeventname.DESCRIPTION,dpevent.ExactTargetDate,dptrigger.NAME from bc_delinquencyprocess dp" +
                               " inner join bc_account acc on acc.ID = dp.AccountID" +
                               " inner join bc_delinquencyprocessevent dpevent on dpevent.DelinquencyProcessID =dp.ID" +
                               " inner join bctl_delinquencyeventname dpeventname on dpeventname.ID = dpevent.EventName" +
                               " inner join bctl_delinquencytriggerbasis dptrigger on dptrigger.ID = dpevent.TriggerBasis" +
                               " where dpeventname.DESCRIPTION = 'Cancellation Billing Instruction Received'" +
                               " and dpevent.CompletionTime is not null" +
                               " and acc.DelinquencyStatus = 1" +
                               " and dp.Status = 4" +
                               " and AccountNumber not in (3000398296)" +
                               " order by dpevent.CreateTime" +
                               " ) TestData order by newid()";
                    break;
                case "TS05_ActiveDeliq_PolicyNotCancelled":
                    sqlQuery = "select top 1 * from ( " + 
                               "select top 10 acc.AccountNumber,wftype.NAME,wf.ProcessVersion,wf.CreateTime,wf.UpdateTime,wf.CurrentStep,wf.TimeoutTime,acc.DelinquencyStatus" +
                               " from bc_delinquencyprocess del" +
                               " inner join bc_account acc on acc.ID = del.AccountID" +
                               " inner join bctl_delinquencyprocessstatus delststatus on delststatus.ID = del.Status" +
                               " inner join bc_workflow wf on wf.DelinquencyProcessID  = del.ID" +
                               " inner join bctl_workflow wftype on wftype.ID = wf.Subtype" +
                               " inner join bctl_workflowstate wfstate on wfstate.ID = wf.State" +
                               " inner join bctl_workflowactivestate wfactivestate on wfactivestate.ID = wf.ActiveState" +
                               " where" +
                               " wftype.NAME = 'Standard Delinquency' and" +
                               " wfstate.NAME = 'Active' and" +
                               " wf.CurrentStep = 'Cancellation'" +
                               " order by wf.CreateTime desc" +
                               " ) TestData order by newid()";
                    break;
                case "TS06_ReinstatedByPC":
                    connectionString = "Server=dbPolicyCenter_stage;Database=PolicyCenter;Trusted_Connection=Yes";
                    sqlQuery = "select top 1 * from ( " + 
                               "select top 10 acc.AccountNumber,pp.PolicyNumber,j.JobNumber,pp.PeriodStart policyEffectiveDate,pp.EditEffectiveDate jobEffectiveDate,j.CreateTime jobCreateTime" +
                               " from pc_policyperiod pp" +
                               " inner join pc_job j on j.ID = pp.JobID" +
                               " inner join pc_policy p on p.ID = pp.PolicyID" +
                               " inner join pc_account acc on acc.ID = p.AccountID" +
                               " inner join pc_user usr on usr.ID = pp.CreateUserID" +
                               " inner join pc_credential cred on cred.ID = usr.CredentialID" +
                               " where j.Subtype = 6" +
                               " and pp.Status = 9" +
                               " and cred.UserName like 'svc-bc%'" +
                               " order by j.CreateTime desc" +
                               " ) TestData order by newid()";
                    break;
                default:
                    break;
            }
            Console.WriteLine("SQL Query: " + sqlQuery);
            SqlConnection con = new SqlConnection(connectionString);
            List<string> AccountNumber = new List<string>();

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AccountNumber.Add(reader.GetValue(0).ToString());
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceptiion:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


            if (AccountNumber.Count == 1)
            {
                DbAccountNumber = AccountNumber[0].ToString();
                DataStorage RegistryValues = new DataStorage();
                RegistryValues.StoreTempValue("guidewire", "ACCNO", DbAccountNumber);
                RegistryValues.StoreTempValue("guidewire", "PLCYNO", "");
                Console.WriteLine("DB Result: " + AccountNumber[0].ToString());
                Console.WriteLine("Account: " + DbAccountNumber);
            }
            else
            {
                Assert.Fail("Account not found in database.");
            }

        }
        public void ClearRegistryValues()
        {
            DataStorage RegistryValues = new DataStorage();
            RegistryValues.StoreTempValue("guidewire", "ACCNO", "");
            RegistryValues.StoreTempValue("guidewire", "ACC_ADDRESS", "");
            RegistryValues.StoreTempValue("guidewire", "ACC_NAME", "");
            RegistryValues.StoreTempValue("guidewire", "EMAIL", "");
            RegistryValues.StoreTempValue("guidewire", "FNAME", "");
            RegistryValues.StoreTempValue("guidewire", "LNAME", "");
            RegistryValues.StoreTempValue("guidewire", "PRODUCT", "");
        }

        public SQL_Queries(IWebDriver driver) : base(driver)
        {
        }

        public override void VerifyPage()
        {
        }

        public override void WaitForLoad()
        {
        }
    }
}
