using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.HeapProfiler;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftSite
    {
        public Button addNewProjectButton = new Button(By.XPath("//div[@id='left_menu']//button[@class='_8313bd46 f169a390 _8b7f1a82 _8644eccb _2a3b75a1']"));
        public TextBox projectNameTxtBox = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));
        public Button addButton = new Button(By.XPath("//footer/div/button[@type='submit']"));

        public Button subMenuIcon = new Button(By.XPath(("//div/div/header/div/div/button[last()]")));
        public Button editButton = new Button(By.XPath("//div[text()='Editar proyecto']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));
        public Button saveButton = new Button(By.XPath("//form/footer/div/button[2]"));

        public Button deleteButton = new Button(By.XPath("//div[text()='Eliminar proyecto']"));
        public Button delButtonAccept = new Button(By.XPath("//form/footer/div/button[2]"));
       
        public Boolean ProjectNameIsDisplayed(String nameValue) 
        {      
            Label nameProject = new Label(By.XPath("//li/div/div/a[contains(.,'"+nameValue+"')]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("//li/div/div/a[contains(.,'" + nameValue + "')]"));
            nameProject.Click();
        }

    }
}
