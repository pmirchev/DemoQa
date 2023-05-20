namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class AccordianPage : BasePage
    {
        public AccordianPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/accordian";

    }
}
