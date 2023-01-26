
using OpenQA.Selenium;
using WebCommonCore;
namespace PolicyCenter9Pages.Pages.NewSubmission
{
	public class CL_BOBuildings_PC9 : Page
	{
		string btnAddILMBldgs = "span[id$=':AddILMBuilding-btnInnerEl']";
		string btnNext = "span[id$=':Next-btnInnerEl']";
		string lnkLocClassSearch = "a[id$=':BOPBuildingClassCodePicker']";
		string btnAddBlanket = "span[id$=':BOPBlanket_JMICPanelSet:BOPBlanket_tb:AddBlanket-btnInnerEl']";
		string btnAddAllExistingLocs = "span[id$=':LocationsEdit_DP_tb:addAllLocationsButton-btnInnerEl']";
		string tblBOLocations = "div[id$=':LocationsEdit_DP:LocationsEdit_LV-body']";
		string txtRecentInv = "input[id$=':LastInvTotal-inputEl']";

		public void BOAddILMLocation()
		{
			driver.FindElement(By.CssSelector(btnAddILMBldgs)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(lnkLocClassSearch));
		}

		public void BOAddAllExistingLocations()
		{
			driver.FindElement(By.CssSelector(btnAddAllExistingLocs)).Click();
			WaitUntilElementInvisible(driver, By.CssSelector(txtRecentInv), 5);
		}
		public void ClickNext()
		{
			driver.FindElement(By.CssSelector(btnNext)).Click();
			WaitUntilElementVisible(driver, By.CssSelector(btnAddBlanket));
		}

		public CL_BOBuildings_PC9(IWebDriver driver) : base(driver)
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
