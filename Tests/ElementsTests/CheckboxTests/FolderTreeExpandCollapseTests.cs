namespace DemoQa.Tests.ElementsTests.CheckboxTests
{
    using DemoQa.Base;
    using DemoQa.Pages;

    [TestFixture]
    public class FolderTreeExpandCollapseTests : BaseTest
    {
        private CheckBoxPage _checkBoxPage;

        [SetUp]
        public void Setup()
        {
            //Initialize();
            InitializeHeadless();
            _checkBoxPage = new CheckBoxPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            //Screenshot();
            Driver.Quit();
        }

        [Test]
        public void SuccessfullyExpandHomeDirextoryWhenClickOnArrow()
        {
            _checkBoxPage.NavigateTo();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDesktop()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DesktopDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.NotesDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.CommandsDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDocuments()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.WorkSpaceDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.OfficeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderWorkSpace()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.WorkSpaceDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.OfficeDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.ReactDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.AngularDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.VeuDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderOffice()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.OfficeDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.WorkSpaceDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.OfficeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.PublicDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.PrivateDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.ClassifiedDirectoryTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.GeneralDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDownloads()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.IsTrue(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.WordFileDocumentTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.ExcelFileDocumentTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.IsTrue(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
        }
    }
}
