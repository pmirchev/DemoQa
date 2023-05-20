namespace DemoQa.Base
{
    using OpenQA.Selenium;

    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public IWebDriver Driver { get; private set; }

        public abstract string Url { get; }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public string GetHeaderName(string categoryName)
        {
            var expectedHeader = categoryName;

            switch (categoryName)
            {
                case "Book Store Application":
                    expectedHeader = "Book Store";
                    break;
                case "Book Store API":
                    expectedHeader = "Book Store API\r\n v1 ";
                    break;
                default:
                    expectedHeader = categoryName;
                    break;
            }

            return expectedHeader;
        }
    }
}
