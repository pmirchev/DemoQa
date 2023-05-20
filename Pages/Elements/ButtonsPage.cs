namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class ButtonsPage : BasePage
    {
        public ButtonsPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/buttons";


    }
}
