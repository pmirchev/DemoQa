namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class CheckBoxPage : BasePage
    {
        public CheckBoxPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/checkbox";


    }
}
