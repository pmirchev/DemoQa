namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class DynamicPropertiesPage : BasePage
    {
        public DynamicPropertiesPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/dynamic-properties";


    }
}
