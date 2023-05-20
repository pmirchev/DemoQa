namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class AutoCompletePage : BasePage
    {
        public AutoCompletePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/auto-complete";
    }
}