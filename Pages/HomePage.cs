namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => ("https://demoqa.com/");

        public IWebElement BannerOnHomePage => Driver.FindElement(By.ClassName("banner-image"));

        public ICollection<IWebElement> Categories => Driver.FindElements(By.XPath("//*[@class='card mt-4 top-card']"));

        public IWebElement Footer => Driver.FindElement(By.XPath("//*[normalize-space(text())='© 2013-2020 TOOLSQA.COM | ALL RIGHTS RESERVED.']"));
    }
}
