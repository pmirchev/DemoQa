namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/droppable";
    }
}
