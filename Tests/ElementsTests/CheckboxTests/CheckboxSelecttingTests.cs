namespace DemoQa.Tests.ElementsTests.CheckboxTests
{
    using DemoQa.Base;
    using DemoQa.Pages;
    using OpenQA.Selenium;

    [TestFixture]
    public class CheckboxSelecttingTests : BaseTest
    {
        private CheckBoxPage _checkBoxPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            //InitializeHeadless();
            _checkBoxPage = new CheckBoxPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            //Screenshot();
            Driver.Quit();
        }

        //[Test]
        //public void SuccessfullySelectAllCheckboxesWhenClickOnHomeCheckbox()
        //{
        //    _checkBoxPage.NavigateTo();

        //    Assert.IsFalse(Driver.FindElements(By.Id("result")).Any());
        //    Assert.IsFalse(_checkBoxPage.HomeDirectoryCheckBox.Selected);

        //    _checkBoxPage.HomeDirectoryCheckBox.Click();

        //    var selectedElements = _checkBoxPage.Results;

        //    Assert.That(selectedElements.Any() && selectedElements.Count.Equals(17));
        //}
    }
}