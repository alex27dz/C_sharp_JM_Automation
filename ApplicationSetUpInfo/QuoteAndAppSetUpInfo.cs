using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using log4net;

namespace ApplicationSetUpInfo
{
    /// <summary>
    /// Class for all the QuoteAndApply urls across all environments.
    /// </summary>
    public class QuoteAndAppSetUpInfo
    {
        /// <summary>
        /// URL dictionary where all the QuoteAndApply urls are stored
        /// </summary>
        private Dictionary<string, string> urlDictionary = new Dictionary<string, string>();

        /// <summary>
        /// Logger Instance for the QuoteAndAppSetUpInfo class
        /// </summary>
        public static readonly ILog logger = LogManager.GetLogger(typeof(GWSetUpInfo));

        /// <summary>
        /// Constructor for QuoteAndAppSetUpInfo class 
        /// </summary>

       
        public QuoteAndAppSetUpInfo()
        {
            Console.WriteLine("ApplicationSetUpInfo Version 1.0.334");
            Console.WriteLine("US24661 and US23344 updated");

            string currEnvironment = ScenarioContext.Current["AUTEnv"].ToString();

            logger.Info("Current Environment:" + currEnvironment);

            Console.WriteLine("Current Environment--{0}", currEnvironment);

            switch (currEnvironment.ToLower().Trim())
            {
                case "local":
                    // Add local host details here
                    urlDictionary.Add("", "");
                    break;
               
                case "qa1":
                    urlDictionary.Add("QNA", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp01/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest01.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest01.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest01.jewelersmutual.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest01.jewelersnt.local/AgentportalProfile/");
                    urlDictionary.Add("AI", "http://mytest01.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest01.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp01.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe001.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest01.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa2":
                    urlDictionary.Add("QNA", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp02/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest02.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest02.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest02.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest02.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest02.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest02.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp02.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe002.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest02.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    urlDictionary.Add("JMPG", "https://portal.training.jewelersmutual.com");
                    urlDictionary.Add("QPS", "https://my.training.jewelersmutual.com/QuoteApplyPartnerSales");
                    urlDictionary.Add("PLATFORM", "https://platformservices.training-zing.jewelersmutual.com/external/login");
                    break;

                case "qa3":
                    urlDictionary.Add("QNA", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp03/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest03.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest03.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest03.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest03.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest03.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest03.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp03.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe003.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest03.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    urlDictionary.Add("QBP", "http://mytest03.jewelersnt.local/quickbillpay");
                    break;

                case "qa4":
                    urlDictionary.Add("QNA", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp04/QuoteApply/Internal");            
                    urlDictionary.Add("QPS", "http://mytest04.jewelersnt.local/quoteapplypartnersales");
                    urlDictionary.Add("JMPG", "https://qa-portal.jewelersmutual.com");
                    urlDictionary.Add("QP", "http://mytest04.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest04.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest04.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest04.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest04.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest04.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp04.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe004.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest04.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    urlDictionary.Add("QBP", "http://mytest04.jewelersnt.local/quickbillpay");
                    break;

                case "qa5":
                    urlDictionary.Add("QNA", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp05/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest05.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest05.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest05.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest05.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest05.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest05.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp05.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe005.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest05.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa6":
                    urlDictionary.Add("QNA", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp06/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest06.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest06.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest06.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest06.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest06.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest06.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp06.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe006.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest06.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa7":
                    urlDictionary.Add("QNA", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp07/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest07.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest07.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest07.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest07.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest07.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest07.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp07.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe007.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest07.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa8":
                    urlDictionary.Add("QNA", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp08/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest08.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest08.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest08.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest08.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest08.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest08.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp08.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe008.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest08.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa9":
                    urlDictionary.Add("QNA", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp09/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest09.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest09.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest09.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest09.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest09.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest09.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp09.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe009.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest09.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa10":
                    urlDictionary.Add("QNA", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp10/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest10.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest10.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest10.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest10.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest10.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest10.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp10.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe002.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest10.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa11":
                    urlDictionary.Add("QNA", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp11/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest11.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest11.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest11.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest11.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest11.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest11.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp11.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe011.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest11.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa12":
                    urlDictionary.Add("QNA", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp12/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest12.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest12.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest12.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest12.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest12.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest12.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp12.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jtn-vm-gpe012.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest12.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "stage":
                    urlDictionary.Add("QNA", "http://my.testjewelersmutual.com/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/Partner?partnerName=Geico&p=Marketing");
                    urlDictionary.Add("QG", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmsapp01/QuoteApply/Internal");
                    urlDictionary.Add("QP", "https://partners.testjewelersmutual.com");
                    urlDictionary.Add("QPS", "https://my.testjewelersmutual.com/quoteapplypartnersales");
                    urlDictionary.Add("JMPG", "https://uat-portal.jewelersmutual.com");
                    urlDictionary.Add("PP", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://appstage.jewelersmutual.jewelersnt.local/CLPortal");
                    // urlDictionary.Add("PLP", "http://appstage.jewelersmutual.jewelersnt.local/PLPortal");
                    urlDictionary.Add("PLP", "https://my.testjewelersmutual.com/plportal");
                    urlDictionary.Add("AP", "http://my.testjewelersmutual.com/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://my.testjewelersmutual.com/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "https://my.testjewelersmutual.com/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmsapp01.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("PEPORTAL", "https://jsn-vm-gpe001.jewelersnt.local/GatewayApplication/dist/html/index-agents.html#/auth/login");
                    urlDictionary.Add("LOOS", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "https://my.testjewelersmutual.com/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    urlDictionary.Add("QBP", "https://my.testjewelersmutual.com/quickbillpay");
                    break;

                case "qa13":
                    urlDictionary.Add("QNA", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jmtapp13/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest13.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("PP", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest13.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest13.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest13.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest13.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest13.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jmtapp13.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("LOOS", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest13.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "qa15":
                    urlDictionary.Add("QNA", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QNABLT", "https://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/retrieve/partner/bolt?extAppKey={external_application_key}");
                    urlDictionary.Add("QAGGS", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QG", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Geico");
                    urlDictionary.Add("QI", "http://jtn-vm-app015/QuoteApply/Internal");
                    urlDictionary.Add("QP", "http://mytest15.jewelersnt.local/quoteapplypartner");
                    urlDictionary.Add("QPS", "http://mytest15.jewelersnt.local/quoteapplypartnersales");
                    urlDictionary.Add("JMPG", "https://dev-portal.jewelersmutual.com");
                    urlDictionary.Add("PP", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/");
                    urlDictionary.Add("QABUNG", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=Bungalow");
                    urlDictionary.Add("QABBT", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/Partner?partnerName=bbt");
                    urlDictionary.Add("CLP", "http://mytest15.jewelersmutual.jewelersnt.local/CLPortal/Security/Login?ReturnUrl=/CLPortal");
                    urlDictionary.Add("PLP", "http://mytest15.jewelersnt.local/PLPortal/Security/Login?ReturnUrl=/PLPortal/Account");
                    urlDictionary.Add("AP", "http://mytest15.jewelersnt.local/AgentPortalProfile/");
                    urlDictionary.Add("AI", "http://mytest15.jewelersnt.local/AgentPortalInquiry/");
                    urlDictionary.Add("CA", "http://mytest15.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("PLREG", "http://jtn-vm-app015.jewelersnt.local/PLAdminPortal");
                    urlDictionary.Add("LOOS", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/OutOfStoreLanding");
                    urlDictionary.Add("QAADIAMOR", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/adiamor");
                    urlDictionary.Add("QABLUENILE", " http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/bluenile");
                    urlDictionary.Add("QABGDIAMOND", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/briangavindiamonds");
                    urlDictionary.Add("QAJALLEN", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/jamesallen");
                    urlDictionary.Add("QAWHITEFLASH", "http://mytest15.jewelersnt.local/jewelry-insurance-quote-apply/express/Provider/whiteflash");
                    break;

                case "dev1":
                    urlDictionary.Add("CA", "http://mydev01.jewelersnt.local/start-a-claim");
                    urlDictionary.Add("QBP", "http://mydev01.jewelersnt.local/quickbillpay");
                    break;

                case "prod":
                    urlDictionary.Add("JMPG", "https://portal.jewelersmutual.com");
                    break;

                default:
                    logger.Info("Environment Does not exist:" + currEnvironment);

                    break;
            }
        }


        /// <summary>
        /// Method to return the URL for the environment being tested.
        /// </summary>
        /// <param name="key">The Key to pass</param>
        /// <returns></returns>
        public string getEnvironmentURL(string key)
        {
            logger.Info("SetUpInfo - key :" + key);

            Console.WriteLine("SetUpInfo - key :{0}", key);

            if (urlDictionary.ContainsKey(key))
            {
                string value = urlDictionary[key];

                logger.Info("SetUpInfo - value :" + value);

                Console.WriteLine("SetUpInfo - URL :{0}", value);

                Console.WriteLine("SuperQAPM URL added. Version Number 1.0.133");

                return value;
            }
            else
            {
                logger.Info("Key does not exist.");

                return null;
            }
        }
    }
}
