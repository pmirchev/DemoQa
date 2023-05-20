namespace DemoQa.Pages;

using DemoQa.Base;
using OpenQA.Selenium;

public class PracticeFormPage : BasePage
{
    public PracticeFormPage(IWebDriver driver) : base(driver)
    {
    }

    public override string Url => "https://demoqa.com/automation-practice-form";
}
