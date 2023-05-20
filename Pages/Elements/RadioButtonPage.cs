namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class RadioButtonPage : BasePage
    {
        public RadioButtonPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/radio-button";


    }
}
