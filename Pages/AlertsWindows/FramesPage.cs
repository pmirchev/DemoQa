namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class FramesPage : BasePage
    {
        public FramesPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/frames";
    }
}
