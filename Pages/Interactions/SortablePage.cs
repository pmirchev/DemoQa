namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/sortable";
    }
}
