﻿namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class TextBoxPage : BasePage
    {
        public TextBoxPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/text-box";
    }
}
