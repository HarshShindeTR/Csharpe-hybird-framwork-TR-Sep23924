using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MedicalRecordAutomation
{
    public class LoginUITest
    {
        [Test]
        public void TitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void ApplicationDescriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            string descrption = driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;
            Assert.That(descrption, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }
    }
}