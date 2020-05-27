using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Test_task.AddRemovePageClass
{
    class AddRemovePage
    {
        public By content = By.Id("content");
        public IWebDriver driver;

        private By addElementButton = By.CssSelector(".example button");
        private By deleteButton = By.CssSelector("#elements .added-manually");

        public AddRemovePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnAddElementButton()
        {
            driver.FindElement(this.addElementButton).Click();
        }

        public void ClickOnDeleteButton()
        {
            driver.FindElement(this.deleteButton).Click();
        }

        public ReadOnlyCollection<IWebElement> getDeleteButtons()
        {
            return driver.FindElements(this.deleteButton);
        }
    }
}
