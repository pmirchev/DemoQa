namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class BookStoreApiPage : BasePage
    {
        public BookStoreApiPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/swagger/";
    }
}
