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

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDesktop()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DesktopDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.NotesDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.CommandsDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDocuments()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.WorkSpaceDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.OfficeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderWorkSpace()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.WorkSpaceDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.OfficeDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.ReactDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.AngularDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.VeuDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderOffice()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.OfficeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.WorkSpaceDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.OfficeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.PublicDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.PrivateDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.ClassifiedDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.GeneralDirectoryTitle.Displayed);
        }

        [Test]
        public void OnlyFirstLevelChildFoldersDisplayedWhenExpandParentFolderDownloads()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.WordFileDocumentTitle.Displayed);
            Assert.That(_checkBoxPage.ExcelFileDocumentTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_AllFoldersCollapsed()
        {
            _checkBoxPage.NavigateTo();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_HomeFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);
           
            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_DesktopFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.DesktopDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_DesktopAndDocumentsFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.DesktopDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_DocumentsFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_DownloadsFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_DocumentsAndDownloadsFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersDisplayedWhenExpandAllButtonIsClicked_SecondLevelFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.WorkSpaceDirectoryArrow.Click();

            Assert.That(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.ReactDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.AngularDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.VeuDirectoryTitle.Displayed);

            _checkBoxPage.ExpandAllButton.Click();

            Assert.That(_checkBoxPage.AllFoldersExpandedSuccessfully());
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_HomeFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_DesktopFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DesktopDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_DesktopAndDocumentsFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DesktopDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_DocumentsFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_DownloadsFolderExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_DocumentsAndDownloadsFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void AllFoldersCollapsedWhenCollapseAllButtonIsClicked_SecondLevelFoldersExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.WorkSpaceDirectoryArrow.Click();

            Assert.That(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);

            _checkBoxPage.CollapseAllButton.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void InnerFoldersRemainExopandedWhenHomeFolderCollapsed_DesktopExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DesktopDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DesktopDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.NotesDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.CommandsDirectoryTitle.Displayed);
        }

        [Test]
        public void InnerFoldersRemainExopandedWhenHomeFolderCollapsed_DocumentsExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DocumentsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.WorkSpaceDirectoryCollapsedTitle.Displayed);
            Assert.That(_checkBoxPage.OfficeDirectoryCollapsedTitle.Displayed);
        }

        [Test]
        public void InnerFoldersRemainExopandedWhenHomeFolderCollapsed_DownloadsExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DownloadsDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.DownloadsDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.WordFileDocumentTitle.Displayed);
            Assert.That(_checkBoxPage.ExcelFileDocumentTitle.Displayed);
        }

        [Test]
        public void InnerFoldersRemainExopandedWhenHomeFolderCollapsed_WorkSpaceExpanded()
        {
            _checkBoxPage.NavigateTo();

            _checkBoxPage.HomeDirectoryArrow.Click();
            _checkBoxPage.DocumentsDirectoryArrow.Click();
            _checkBoxPage.WorkSpaceDirectoryArrow.Click();

            Assert.That(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.HomeDirectoryCollapsedTitle.Displayed);

            _checkBoxPage.HomeDirectoryArrow.Click();

            Assert.That(_checkBoxPage.WorkSpaceDirectoryExpandedTitle.Displayed);
            Assert.That(_checkBoxPage.ReactDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.AngularDirectoryTitle.Displayed);
            Assert.That(_checkBoxPage.VeuDirectoryTitle.Displayed);
        }
    }
}
