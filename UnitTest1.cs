using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace NUnitTestProject
{
    public class Tests
    {
        IWebDriver webDriver;

        [OneTimeSetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
        }

        // Test Case for Success with no error
        [Test]
        public void Test1()
        {
            webDriver.Url = "file:///C:/Assignment%20Final/newcar.html";
            // Accessing all fields in page
            IWebElement sellerName = webDriver.FindElement(By.Name("Name"));
            IWebElement email = webDriver.FindElement(By.Name("Email"));
            IWebElement phone = webDriver.FindElement(By.Name("Phone"));
            IWebElement city = webDriver.FindElement(By.Name("City"));
            IWebElement address = webDriver.FindElement(By.Name("Address"));
            IWebElement maker = webDriver.FindElement(By.Name("ModelMaker"));
            IWebElement model = webDriver.FindElement(By.Name("Model"));
            IWebElement year = webDriver.FindElement(By.Name("Year"));

            // Entering Data for test
            sellerName.SendKeys("Neeraj Kumar");
            email.SendKeys("ennkay161@gmail.com");
            phone.SendKeys("123-123-1234");
            city.SendKeys("RPeo");
            address.SendKeys("Vill Brelangi");
            maker.SendKeys("Ford");
            model.SendKeys("Mustang");
            year.SendKeys("2012");
            IWebElement submitBtn = webDriver.FindElement(By.Id("btnSubmit"));
            submitBtn.Click();
            Assert.Pass();
           // webDriver.Close();
        }

        // Test for if email id is not valid
        [Test]
        public void Test2()
        {
            webDriver.Url = "file:///C:/Assignment%20Final/newcar.html";
            // Accessing all fields in page
            IWebElement sellerName = webDriver.FindElement(By.Name("Name"));
            IWebElement email = webDriver.FindElement(By.Name("Email"));
            IWebElement phone = webDriver.FindElement(By.Name("Phone"));
            IWebElement city = webDriver.FindElement(By.Name("City"));
            IWebElement address = webDriver.FindElement(By.Name("Address"));
            IWebElement maker = webDriver.FindElement(By.Name("ModelMaker"));
            IWebElement model = webDriver.FindElement(By.Name("Model"));
            IWebElement year = webDriver.FindElement(By.Name("Year"));
            IWebElement emailError = webDriver.FindElement(By.Id("emailError"));


            // Entering Data for test
            sellerName.SendKeys("Neeraj Kumar");
            //Wrong email
            email.SendKeys("test.com");
            phone.SendKeys("123-123-1234");
            city.SendKeys("RPeo");
            address.SendKeys("Vill Brelangi");
            maker.SendKeys("Ford");
            model.SendKeys("Mustang");
            year.SendKeys("2012");
            IWebElement submitBtn = webDriver.FindElement(By.Id("btnSubmit"));
            submitBtn.Click();
            // Which means email is not correct
            if(emailError.Text.Length > 0)
            {
                Assert.That(true, "Email id is not correct!");
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        // Test case for wrong phone number input
        /*[Test]
        public void Test3()
        {
            webDriver.Url = "file:///C:/Assignment%20Final/newcar.html";
            // Accessing all fields in page
            IWebElement sellerName = webDriver.FindElement(By.Name("Name"));
            IWebElement email = webDriver.FindElement(By.Name("Email"));
            IWebElement phone = webDriver.FindElement(By.Name("Phone"));
            IWebElement city = webDriver.FindElement(By.Name("City"));
            IWebElement address = webDriver.FindElement(By.Name("Address"));
            IWebElement maker = webDriver.FindElement(By.Name("ModelMaker"));
            IWebElement model = webDriver.FindElement(By.Name("Model"));
            IWebElement year = webDriver.FindElement(By.Name("Year"));
            IWebElement phoneError = webDriver.FindElement(By.Id("phoneError"));


            // Entering Data for test
            sellerName.SendKeys("Neeraj Kumar");
            email.SendKeys("test@test.com");
            //Wrong Phone number - Other than format [123-123-1234, (123)123-1234]
            phone.SendKeys("1234567890");
            city.SendKeys("RPeo");
            address.SendKeys("Vill Brelangi");
            maker.SendKeys("Ford");
            model.SendKeys("Mustang");
            year.SendKeys("2012");
            IWebElement submitBtn = webDriver.FindElement(By.Id("btnSubmit"));
            submitBtn.Click();
            if (phoneError.Text.Length > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        // Error Test case
        [Test]
        public void Test4()
        {
            webDriver.Url = "file:///C:/Assignment%20Final/newcar.html";
            // Accessing all fields in page
            IWebElement sellerName = webDriver.FindElement(By.Name("Name"));
            IWebElement email = webDriver.FindElement(By.Name("Email"));
            IWebElement phone = webDriver.FindElement(By.Name("Phone"));
            IWebElement city = webDriver.FindElement(By.Name("City"));
            IWebElement address = webDriver.FindElement(By.Name("Address"));
            IWebElement maker = webDriver.FindElement(By.Name("ModelMaker"));
            IWebElement model = webDriver.FindElement(By.Name("Model"));
            IWebElement year = webDriver.FindElement(By.Name("Year"));
            // Creating Error in code
            IWebElement yearError = webDriver.FindElement(By.Id("yearError"));

            // Entering Data for test
            sellerName.SendKeys("Neeraj Kumar");
            email.SendKeys("ennkay161@gmail.com");
            phone.SendKeys("123-123-1234");
            city.SendKeys("RPeo");
            address.SendKeys("Vill Brelangi");
            maker.SendKeys("Ford");
            model.SendKeys("Mustang");
            year.SendKeys("2012");
            IWebElement submitBtn = webDriver.FindElement(By.Id("btnSubmit"));
            submitBtn.Click();
            if(yearError.Text.Length > 0)
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]
        public void Test5()
        {
            webDriver.Url = "file:///C:/Assignment%20Final/newcar.html";
            // Accessing all fields in page
            IWebElement sellerName = webDriver.FindElement(By.Name("Name"));
            IWebElement email = webDriver.FindElement(By.Name("Email"));
            IWebElement phone = webDriver.FindElement(By.Name("Phone"));
            IWebElement city = webDriver.FindElement(By.Name("City"));
            IWebElement address = webDriver.FindElement(By.Name("Address"));
            IWebElement maker = webDriver.FindElement(By.Name("ModelMaker"));
            IWebElement model = webDriver.FindElement(By.Name("Model"));
            IWebElement year = webDriver.FindElement(By.Name("Year"));
            IWebElement phoneError = webDriver.FindElement(By.Id("phoneError"));


            // Entering Data for test
            sellerName.SendKeys("Neeraj Kumar");
            email.SendKeys("test@test.com");
            //Wrong Phone number - Other than format [123-123-1234, (123)123-1234]
            phone.SendKeys("1234567890");
            city.SendKeys("RPeo");
            address.SendKeys("Vill Brelangi");
            maker.SendKeys("Ford");
            model.SendKeys("Mustang");
            year.SendKeys("123");
            IWebElement submitBtn = webDriver.FindElement(By.Id("btnSubmit"));
            submitBtn.Click();
            // Phone Number digit error
            if (phoneError.Text.Length > 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }*/

        [OneTimeTearDown]
        public void CloseTest()
        {
        }
    }
}