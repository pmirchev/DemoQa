namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class WidgetsPage : BasePage
    {
        public WidgetsPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/widgets";

        public ICollection<IWebElement> WidgetsSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}