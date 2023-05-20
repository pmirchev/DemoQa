namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class NestedFramesPage : BasePage
    {
        public NestedFramesPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/nestedframes";
    }
}
