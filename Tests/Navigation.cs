namespace DemoQa.Tests
{
    using DemoQa.Base;
    using DemoQa.Pages;
    using DemoQa.Utilities;
    using OpenQA.Selenium;

    [TestFixture]
    public class Navigation : BaseTest
    {
        private const string FooterText = "© 2013-2020 TOOLSQA.COM | ALL RIGHTS RESERVED.";

        private HomePage _homePage;
        private ElementsPage _elementsPage;
        private FormsPage _formPage;
        private AlertsWindowsPage _alertsWindowsPage;
        private WidgetsPage _widgetsPage;
        private InteractionsPage _interactionsPage;
        private BookStorePage _bookStorePage;

        [SetUp]
        public void Setup()
        {
            //Initialize();
            InitializeHeadless();
            _homePage = new HomePage(Driver);
            _elementsPage = new ElementsPage(Driver);
            _formPage = new FormsPage(Driver);
            _alertsWindowsPage = new AlertsWindowsPage(Driver);
            _widgetsPage = new WidgetsPage(Driver);
            _interactionsPage = new InteractionsPage(Driver);
            _bookStorePage = new BookStorePage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            //Screenshot();
            Driver.Quit();
        }

        [Test]
        public void SuccessfullyNavigatToHomePage()
        {
            _homePage.NavigateTo();

            Assert.IsTrue(_homePage.BannerOnHomePage.Displayed);
            Assert.That(_homePage.Footer.Text, Is.EqualTo(FooterText));
        }

        [Test]
        [TestCase("Elements")]
        [TestCase("Forms")]
        [TestCase("Alerts, Frame & Windows")]
        [TestCase("Widgets")]
        [TestCase("Interactions")]
        [TestCase("Book Store Application")]
        public void SuccessfullyNavigatToCategoriesWhenClickOnButton(string categoryName)
        {
            _homePage.NavigateTo();

            var categoryButtonsList = _homePage.Categories.ToList();
            var categoryButton = categoryButtonsList.FirstOrDefault(c => c.Text.Equals(categoryName));

            Driver.ScrollTo(categoryButton);
            categoryButton.Click();

            var headerText = Driver.FindElement(By.ClassName("main-header")).Text;
            var expectedHeader = _homePage.GetHeaderName(categoryName);

            Assert.That(expectedHeader, Is.EqualTo(headerText));
        }

        [Test]
        [TestCase("Text Box")]
        [TestCase("Check Box")]
        [TestCase("Radio Button")]
        [TestCase("Web Tables")]
        [TestCase("Buttons")]
        [TestCase("Links")]
        [TestCase("Broken Links - Images")]
        [TestCase("Upload and Download")]
        [TestCase("Dynamic Properties")]
        public void SuccessfullyNavigatToElementsSectionsWhenClickOnButton(string sectionName)
        {
            _elementsPage.NavigateTo();

            var elementsButtonsList = _elementsPage.ElementsSectionsButtons.ToList();
            var elementButton = elementsButtonsList.FirstOrDefault(c => c.Text.Equals(sectionName));

            Driver.ScrollTo(elementButton);
            elementButton.Click();

            var headerText = Driver.FindElement(By.ClassName("main-header")).Text;

            Assert.That(sectionName, Is.EqualTo(headerText));
        }

        [Test]
        public void SuccessfullyNavigatToFormsSectionsWhenClickOnButton()
        {
            _formPage.NavigateTo();

            _formPage.PracticeFormButton.Click();

            var expecteHeader = "Practice Form";
            var actualHeader = Driver.FindElement(By.ClassName("main-header")).Text;

            Assert.That(expecteHeader, Is.EqualTo(actualHeader));
        }

        [Test]
        [TestCase("Browser Windows")]
        [TestCase("Alerts")]
        [TestCase("Frames")]
        [TestCase("Nested Frames")]
        [TestCase("Modal Dialogs")]
        public void SuccessfullyNavigatToAlertsWindowsSectionsWhenClickOnButton(string sectionName)
        {
            _alertsWindowsPage.NavigateTo();

            var alertsSectionsButtons = _alertsWindowsPage.AlertsSectionsButtons.ToList();
            var sectionButton = alertsSectionsButtons.FirstOrDefault(c => c.Text.Equals(sectionName))!;

            Driver.ScrollTo(sectionButton);
            sectionButton.Click();

            var headerText = Driver.FindElement(By.ClassName("main-header")).Text;

            Assert.That(sectionName, Is.EqualTo(headerText));
        }

        [Test]
        [TestCase("Accordian")]
        [TestCase("Auto Complete")]
        [TestCase("Date Picker")]
        [TestCase("Slider")]
        [TestCase("Progress Bar")]
        [TestCase("Tabs")]
        [TestCase("Tool Tips")]
        [TestCase("Menu")]
        [TestCase("Select Menu")]
        public void SuccessfullyNavigatToWidgetsSectionsWhenClickOnButton(string sectionName)
        {
            _widgetsPage.NavigateTo();

            var widgetsSectionsButtons = _widgetsPage.WidgetsSectionsButtons.ToList();
            var sectionButton = widgetsSectionsButtons.FirstOrDefault(c => c.Text.Equals(sectionName))!;

            Driver.ScrollTo(sectionButton);
            sectionButton.Click();

            var headerText = Driver.FindElement(By.ClassName("main-header")).Text;

            Assert.That(sectionName, Is.EqualTo(headerText));
        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyNavigatToInteractionsSectionsWhenClickOnButton(string sectionName)
        {
            _interactionsPage.NavigateTo();

            var widgetsSectionsButtons = _interactionsPage.InteractionsSectionsButtons.ToList();
            var sectionButton = widgetsSectionsButtons.FirstOrDefault(c => c.Text.Equals(sectionName))!;

            Driver.ScrollTo(sectionButton);
            sectionButton.Click();

            var headerText = Driver.FindElement(By.ClassName("main-header")).Text;

            Assert.That(sectionName, Is.EqualTo(headerText));
        }

        [Test]
        [TestCase("Profile")]
        [TestCase("Login")]
        [TestCase("Book Store")]
        [TestCase("Book Store API")]
        public void SuccessfullyNavigatToBookStoreSectionsWhenClickOnButton(string sectionName)
        {
            _bookStorePage.NavigateTo();

            var bookStoreSectionsButtons = _bookStorePage.BookStoreSectionsButtons.ToList();
            var sectionButton = bookStoreSectionsButtons.FirstOrDefault(c => c.Text.Equals(sectionName))!;

            Driver.ScrollTo(sectionButton);
            sectionButton.Click();

            var headerText = string.Empty;
            if (sectionName == "Book Store API")
            {
                headerText = Driver.FindElement(By.ClassName("title")).Text;
            }
            else
            {
                headerText = Driver.FindElement(By.ClassName("main-header")).Text;
            }
            var expectedHeader = _bookStorePage.GetHeaderName(sectionName);

            Assert.That(expectedHeader, Is.EqualTo(headerText));
        }
    }
}