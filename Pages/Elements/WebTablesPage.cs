namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class WebTablesPage : BasePage
    {
        public WebTablesPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/webtables";


    }
}
