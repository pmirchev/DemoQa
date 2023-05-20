namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class TabsPage : BasePage
    {
        public TabsPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/tabs";
    }
}