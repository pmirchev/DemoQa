namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class InteractionsPage : BasePage
    {
        public InteractionsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/interaction";

        public ICollection<IWebElement> InteractionsSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}
