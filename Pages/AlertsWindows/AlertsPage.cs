namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class AlertsPage : BasePage
    {
        public AlertsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/alerts";
    }
}
