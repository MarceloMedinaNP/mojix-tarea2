using OpenQA.Selenium;
using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class todoIST : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite(); 



        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("marcelomedinamojix@gmail.com", "abc12345*");

            Thread.Sleep(10000);

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("P_ADD");
            leftSite.addButton.Click();


            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("P_ADD"), "ERROR!The project was not created");

            leftSite.ClickProjectName("P_ADD");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("P_MODIFIED");
            leftSite.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("P_MODIFIED"), "ERROR!The project was not updated");


            leftSite.ClickProjectName("P_MODIFIED");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();
            leftSite.delButtonAccept.Click();

            // add verificacion
           Assert.IsFalse(leftSite.ProjectNameIsDisplayed("P_MODIFIED"), "ERROR!The project was not deleted");


        }

    }
}
