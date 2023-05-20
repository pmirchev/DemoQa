namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class ToolTipsPage : BasePage
    {
        public ToolTipsPage(IWebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/tool-tips";

        public ICollection<IWebElement> AlertsSectionsButtons => Driver.FindElements(By.XPath("//*[@class='element-list collapse show']//li"));
    }
}
