namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class LinksPage : BasePage
    {
        public LinksPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/links";


    }
}
