namespace DemoQa.Pages
{
    using DemoQa.Base;
    using OpenQA.Selenium;

    public class CheckBoxPage : BasePage
    {
        public CheckBoxPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override string Url => "https://demoqa.com/checkbox";

        //Home Directory elements
        public IWebElement HomeDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-home']"));

        public IWebElement HomeDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-home']"));

        public IWebElement HomeDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-home']]/child::*[@title='Toggle']"));

        public IWebElement HomeDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-home']/child::*[@class='rct-checkbox']"));

        //Desktop Directory elements
        public IWebElement DesktopDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-desktop']"));

        public IWebElement DesktopDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-desktop']"));

        public IWebElement DesktopDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-desktop']/child::*[@class='rct-checkbox']"));

        public IWebElement DesktopDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-desktop']]/child::*[@title='Toggle']"));

        //Notes Directory elements
        public IWebElement NotesDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-notes']"));

        public IWebElement NotesDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-notes']/child::*[@class='rct-checkbox']"));

        //Commands Directory elements
        public IWebElement CommandsDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-commands']"));

        public IWebElement CommandsDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-commands']/child::*[@class='rct-checkbox']"));

        //Documents Directory elements
        public IWebElement DocumentsDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-documents']"));

        public IWebElement DocumentsDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-documents']"));

        public IWebElement DocumentsDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-documents']/child::*[@class='rct-checkbox']"));

        public IWebElement DocumentsDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-documents']]/child::*[@title='Toggle']"));

        //WorkSpace Directory elements
        public IWebElement WorkSpaceDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-workspace']"));

        public IWebElement WorkSpaceDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-workspace']"));

        public IWebElement WorkSpaceDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-workspace']/child::*[@class='rct-checkbox']"));

        public IWebElement WorkSpaceDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-workspace']]/child::*[@title='Toggle']"));

        //React Directory elements
        public IWebElement ReactDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-react']"));

        public IWebElement ReactDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-react']/child::*[@class='rct-checkbox']"));

        //Angular Directory elements
        public IWebElement AngularDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-angular']"));

        public IWebElement AngularDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-angular']/child::*[@class='rct-checkbox']"));

        //Veu Directory elements
        public IWebElement VeuDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-veu']"));

        public IWebElement VeuDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-veu']/child::*[@class='rct-checkbox']"));

        //Office Directory elements
        public IWebElement OfficeDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-office']"));

        public IWebElement OfficeDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-office']"));

        public IWebElement OfficeDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-office']/child::*[@class='rct-checkbox']"));

        public IWebElement OfficeDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-office']]/child::*[@title='Toggle']"));

        //Public Directory elements
        public IWebElement PublicDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-public']"));

        public IWebElement PublicDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-public']/child::*[@class='rct-checkbox']"));

        //Private Directory elements
        public IWebElement PrivateDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-private']"));

        public IWebElement PrivateDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-private']/child::*[@class='rct-checkbox']"));

        //Classified Directory elements
        public IWebElement ClassifiedDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-classified']"));

        public IWebElement ClassifiedDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-classified']/child::*[@class='rct-checkbox']"));

        //General Directory elements
        public IWebElement GeneralDirectoryTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-general']"));

        public IWebElement GeneralDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-general']/child::*[@class='rct-checkbox']"));

        //Downloads Directory elements
        public IWebElement DownloadsDirectoryCollapsedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-collapsed']//child::*[@for='tree-node-downloads']"));

        public IWebElement DownloadsDirectoryExpandedTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-downloads']"));

        public IWebElement DownloadsDirectoryCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-downloads']/child::*[@class='rct-checkbox']"));

        public IWebElement DownloadsDirectoryArrow => 
            Driver.FindElement(By.XPath("//*[@class='rct-text' and child::*[@for='tree-node-downloads']]/child::*[@title='Toggle']"));

        //Word File elements
        public IWebElement WordFileDocumentTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-wordFile']"));

        public IWebElement WordFileDocumentCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-wordFile']/child::*[@class='rct-checkbox']"));

        //Excel File elements
        public IWebElement ExcelFileDocumentTitle => 
            Driver.FindElement(By.XPath("//*[@class='rct-node rct-node-parent rct-node-expanded']//child::*[@for='tree-node-excelFile']"));

        public IWebElement ExcelFileDocumentCheckBox => 
            Driver.FindElement(By.XPath("//*[@for='tree-node-excelFile']/child::*[@class='rct-checkbox']"));

        //Expand - Collapse buttons elements
        public IWebElement ExpandAllButton => 
            Driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-expand-all']"));

        public IWebElement CollapseAllButton => 
            Driver.FindElement(By.XPath("//*[@class='rct-icon rct-icon-collapse-all']"));

        //Results section
        public ICollection<IWebElement> Results => 
            Driver.FindElements(By.Id("result"));

        public bool AllFoldersExpandedSuccessfully()
        {
            return HomeDirectoryExpandedTitle.Displayed &&
                DesktopDirectoryExpandedTitle.Displayed &&
                NotesDirectoryTitle.Displayed && 
                CommandsDirectoryTitle.Displayed &&
                DocumentsDirectoryExpandedTitle.Displayed &&
                WorkSpaceDirectoryExpandedTitle.Displayed &&
                ReactDirectoryTitle.Displayed &&
                AngularDirectoryTitle.Displayed &&
                VeuDirectoryTitle.Displayed &&
                OfficeDirectoryExpandedTitle.Displayed &&
                PublicDirectoryTitle.Displayed &&
                PrivateDirectoryTitle.Displayed &&
                ClassifiedDirectoryTitle.Displayed &&
                GeneralDirectoryTitle.Displayed &&
                DownloadsDirectoryExpandedTitle.Displayed &&
                WordFileDocumentTitle.Displayed &&
                ExcelFileDocumentTitle.Displayed;
        }
    }
}
