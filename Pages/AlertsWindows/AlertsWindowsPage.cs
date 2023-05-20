namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class AlertsWindowsPage : BasePage
    {
        public AlertsWindowsPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/alertsWindows";

        public ICollection<IWebElement> AlertsSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}
