namespace DemoQa.Base
{
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using System.Text;

    public abstract class BaseTest
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;
        protected Actions Builder;

        public void Initialize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            Builder = new Actions(Driver);
        }
        public void InitializeHeadless()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() {
                "--silent-launch",
                "--no-startup-window",
                "no-sandbox",
                "headless",
            });

            //var chromeDriverService = ChromeDriverService.CreateDefaultService();
            //chromeDriverService.HideCommandPromptWindow = true;    // This is to hidden the console.
            //ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);

            Driver = new ChromeDriver(chromeOptions);
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
            Builder = new Actions(Driver);
        }

        public void Screenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var dirPath = Path.GetFullPath(@"..\..\..\Screenshots\", Directory.GetCurrentDirectory());
                var testClassName = TestContext.CurrentContext.Test.ClassName;
                var testName = TestContext.CurrentContext.Test.MethodName;

                var sb = new StringBuilder();
                foreach (var arg in TestContext.CurrentContext.Test.Arguments)
                {
                    sb.Append($"_{arg}");
                }
                string argumentName = sb.ToString().TrimEnd();

                string fileName = $@"{dirPath}{testClassName}.{testName}{argumentName}.{DateTime.Now:u}.png";

                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                //screenshot.SaveAsFile($@"{dirPath}\Screenshots\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
                screenshot.SaveAsFile($@"{fileName}", ScreenshotImageFormat.Png);
            }
        }
    }
}
