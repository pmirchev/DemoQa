namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class BrokenLinksPage : BasePage
    {
        public BrokenLinksPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/broken";


    }
}
