namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class BookStorePage : BasePage
    {
        public BookStorePage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/books";

        public ICollection<IWebElement> BookStoreSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}
