namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class ElementsPage : BasePage
    {
        public ElementsPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/elements";

        public ICollection<IWebElement> ElementsSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}
