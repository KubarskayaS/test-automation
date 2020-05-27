using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using Test_task.BaseClass;
using Test_task.AddRemovePageClass;

namespace Test_task
{
    [TestFixture]
    public class AddRemoveTests: BaseTest
    {

        [Test]
        [Obsolete]
        public void OpenPage()
        {
            AddRemovePage addRemovePage = new AddRemovePage(this.driver);
            driver.Url = "http://the-internet.herokuapp.com/add_remove_elements/";
            wait.Until(ExpectedConditions.ElementExists(addRemovePage.content));
        }

        [Test]
        [Obsolete]
        public void ClickAdd()
        {
            int numberOfClicks = 2;
            AddRemovePage addRemovePage = new AddRemovePage(this.driver);

            OpenPage();

            for (int i = 0;i < numberOfClicks; i++)
            {
                addRemovePage.ClickOnAddElementButton();
            }

            Assert.AreEqual(addRemovePage.getDeleteButtons().Count, numberOfClicks);
        }

        [Test]
        [Obsolete]
        public void ClickDelete()
        {
            OpenPage();
            ClickAdd();

            AddRemovePage addRemovePage = new AddRemovePage(this.driver);
            ReadOnlyCollection<IWebElement> buttons = addRemovePage.getDeleteButtons();

            foreach (IWebElement button in buttons)
            {
                button.Click();
            }

            Assert.AreEqual(addRemovePage.getDeleteButtons().Count, 0);
        }
    }
}
