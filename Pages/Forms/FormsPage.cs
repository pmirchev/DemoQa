namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class FormsPage : BasePage
    {
        public FormsPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/forms";

        public IWebElement PracticeFormButton => Driver.FindElement(By.XPath("//*[normalize-space(text())='Practice Form']"));
    }
}
