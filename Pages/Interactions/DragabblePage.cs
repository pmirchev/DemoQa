namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class DragabblePage : BasePage
    {
        public DragabblePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/dragabble";
    }
}
