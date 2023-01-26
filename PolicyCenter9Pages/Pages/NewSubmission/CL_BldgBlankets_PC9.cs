
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BldgBlankets_PC9 : Page
	{
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkBldgModifier = "span[id$=':BOPModifiersCV:BOPModifiersCV:ModifiersTab-btnInnerEl']";
		public void ClickNext()
		{
			UIActionExt(By.CssSelector(btnNext), "click");
			WaitUntilElementVisible(driver, By.CssSelector(lnkBldgModifier));
		}
		public void AddBlanket(Table table)
		{
			string btnAddBlanket = "span[id$=':AddBlanket-btnInnerEl']";
			string lstBlanketType = "input[id$=':BlanketType-inputEl']";
			string lstGroupType = "input[id$=':BlanketGroupType-inputEl']";
			string lstLocation = "input[id$=':BlanketLocation-inputEl']";
			string txtLimit = "input[id$=':DirectTermInput-inputEl']";
			string btnShowCovgs = "span[id$=':ShowCoverages-btnInnerEl']";
			string chkSelectAll = "div[class='x-grid-checkcolumn']";
			string btnIncldSelCovgs = "span[id$=':AddCoverages-btnInnerEl']";
			string lstDed = "input[id$='BOPBlanket_JMICPopup:BOPBlanketCovDeductible-inputEl']";
			string btnOK = "span[id$=':Update-btnInnerEl']";
			string btnClear = "span[id$=':WebMessageWorksheet_ClearButton-btnInnerEl']";

			UIActionExt(By.CssSelector(btnAddBlanket), "click");
			UIActionExt(By.CssSelector(lstBlanketType), "text", table.Rows[0]["BOP_Blanket_Type"]);
			UIActionExt(By.CssSelector(lstGroupType), "List", table.Rows[0]["BOP_Blanket_GroupType"]);
			UIActionExt(By.CssSelector(lstLocation), "List", ScenarioContext.Current["BLANKETADDRESS"].ToString());
			UIActionExt(By.CssSelector(btnShowCovgs), "click");
			UIActionExt(By.CssSelector(chkSelectAll), "click");
			UIActionExt(By.CssSelector(btnIncldSelCovgs), "click");
			UIActionExt(By.CssSelector(txtLimit), "text", "20000");
			UIActionExt(By.CssSelector(btnOK), "click");
			UIActionExt(By.CssSelector(btnClear), "click");
			UIActionExt(By.CssSelector(lstDed), "text", "500");
			UIActionExt(By.CssSelector(btnOK), "click");
		}

		public CL_BldgBlankets_PC9(IWebDriver driver) : base(driver)
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


