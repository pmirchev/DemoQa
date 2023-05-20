namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class UploadDownloadPage : BasePage
    {
        public UploadDownloadPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/upload-download";


    }
}
