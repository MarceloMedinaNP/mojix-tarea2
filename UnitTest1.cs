using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void OpenBrowser() 
        {
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path+"/driver/chromedriver.exe");
            driver.Navigate().GoToUrl("https://todoist.com/es");
        }

        [TestCleanup]
        public void CloseBrowser() 
        {
            Console.WriteLine("clean");
            driver.Quit();
        }

        [TestMethod]
        public void VerifyTheLoginIsSuccessfuly()
        {
            // click login button
            driver.FindElement(By.XPath("//ul/li/a[text()='Iniciar sesión']")).Click();
            // fill email textbox
            driver.FindElement(By.XPath("//input[@id=\"element-0\"]")).SendKeys("marcelomedinamojix@gmail.com");
            // fill password textbox
            driver.FindElement(By.XPath("//input[@id=\"element-3\"]")).SendKeys("abc12345*");
            // click login button
            driver.FindElement(By.XPath("//button[@data-gtm-id=\"start-email-login\"]")).Click();
            // verify -> the logout button should be displayed

            Thread.Sleep(15000);

            Assert.IsTrue(driver.FindElement(By.XPath("//button[@data-testid=\"upgrade-button-top-bar\"]")).Displayed, 
                "ERROR !! the login was not successfully, review credentials please");

        }
    }
}