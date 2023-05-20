namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class ModalDialogsPage : BasePage
    {
        public ModalDialogsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/modal-dialogs";
    }
}
