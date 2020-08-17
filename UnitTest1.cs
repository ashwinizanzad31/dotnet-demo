using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTest
{
    public class Tests
    
    {
        FirefoxDriver  driver=null;
        //IWebDriver driver=null;
        //[SetUp]
        // public void Setup()
        // {
        //     Console.WriteLine("Launching driver>>>>>>>>>>>>>>");
        //     driver = new ChromeDriver("/Users/Ashwini/Downloads");
        //      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //     driver.Url ="https://www.seleniumeasy.com/test/";
        //     String title = driver.Title;
        //     Console.WriteLine("title of site is : " +title);
        // }

         [SetUp]
        public void Setup()
        {
            Console.WriteLine("Launching driver>>>>>>>>>>>>>>");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Users/Ashwini/Downloads/", "geckodriver 2");
            driver = new FirefoxDriver(service);
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.seleniumeasy.com/test/";
            driver.Manage().Window.Maximize();  
            String title = driver.Title;
            Console.WriteLine("title of site is : " +title);
            System.Threading.Thread.Sleep(10000);

             driver.FindElement(By.Id("at-cv-lightbox-close")).Click();

        }

        [Test]
        public void testSimpleInputForm()
        {
            System.Threading.Thread.Sleep(1000);
             driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Input Forms')]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Simple Form Demo'])[1]")).Click();
             //driver.FindElement(By.XPath("//*[contains(text(),'Single Input Field')]").Displayed();
             Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'first example to start with Selenium')]")).Displayed);
             driver.FindElement(By.Id("user-message")).SendKeys("Test message");
             System.Threading.Thread.Sleep(10000);
             driver.FindElement(By.XPath("//button[@type='button' and contains(text(),'Show Message')]")).Click();
             System.Threading.Thread.Sleep(10000);
            Assert.IsTrue(driver.FindElement(By.XPath("//span[@id='display' and contains(text(),'Test message')]")).Displayed);
        }

        [Test]
        public void testSimpleRadioButton()
        {
             driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Input Forms')]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Checkbox Demo'])[1]")).Click();
            System.Threading.Thread.Sleep(1000);
             Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'This would be a basic example to start with checkboxes using selenium')]")).Displayed);
             System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.Id("isAgeSelected")).Click();
            Console.WriteLine("Text"+ driver.FindElement(By.Id("txtAge")).Text);
        }

        //[Test]
        public void testMultipleRadioButton()
        {
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Input Forms')]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Checkbox Demo'])[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'This would be a basic example to start with checkboxes using selenium')]")).Displayed);
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[text()='Option 1']//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//*[text()='Option 2']//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//*[text()='Option 3']//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//*[text()='Option 4']//input[@type='checkbox']")).Click();

        }

       // [Test]
        public void testDropDown()
        {
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Input Forms')]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Select Dropdown List'])[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'Select List Demo')]")).Displayed);
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.Id("select-demo")).Click();
            driver.FindElement(By.XPath("//select[@id='select-demo']//option[@value='Monday']")).Click();

        }

        //[Test]
        public void testInPutFormSubmit()
        {
            driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Input Forms')]")).Click();
            driver.FindElement(By.XPath("(//a[text()='Input Form Submit'])[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'Input form with validations')]")).Displayed);
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("//input[@name='first_name']")).SendKeys("test first");
            driver.FindElement(By.XPath("//input[@name='last_name']")).SendKeys("test last");
            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("test@gmail.com");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("1234567890");
            driver.FindElement(By.XPath("//input[@name='address']")).SendKeys("Vinoba Nagar");
            driver.FindElement(By.XPath("//input[@name='city']")).SendKeys("Nagpur");
            driver.FindElement(By.XPath("//input[@name='zip']")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@name='website']")).SendKeys("www.google.com");
            System.Threading.Thread.Sleep(10000);

        }

                //[Test]
                public void testCalendar()
                {
                    driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Date pickers')]")).Click();
                    driver.FindElement(By.XPath("(//a[text()='Bootstrap Date Picker'])[1]")).Click();
                    System.Threading.Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'Bootstrap Date Pickers Example')]")).Displayed);
                    System.Threading.Thread.Sleep(10000);
                    driver.FindElement(By.XPath("//div[@class='input-group date']//input")).SendKeys("31/05/1994");
                    driver.FindElement(By.XPath("//div[@class='input-group date']//input")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(10000);

                }


                //[Test]
                public void testDateRangeCalendar()
                {
                    driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Date pickers')]")).Click();
                    driver.FindElement(By.XPath("(//a[text()='Bootstrap Date Picker'])[1]")).Click();
                    System.Threading.Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'Bootstrap Date Pickers Example')]")).Displayed);
                    System.Threading.Thread.Sleep(10000);
                    driver.FindElement(By.XPath("//input[@placeholder='Start date']")).SendKeys("31/05/1994");
                    driver.FindElement(By.XPath("//input[@placeholder='Start date']")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//input[@placeholder='End date']")).SendKeys("01/06/1994");
                    driver.FindElement(By.XPath("//input[@placeholder='End date']")).SendKeys(Keys.Return);
                    driver.FindElement(By.XPath("//input[@placeholder='End date']")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(10000);

                }

               // [Test]
                public void testJQueryDateRangeCalendar()
                {
                    driver.FindElement(By.XPath("//a[@class='dropdown-toggle' and contains(text(),'Date pickers')]")).Click();
                    driver.FindElement(By.XPath("(//a[text()='JQuery Date Picker'])[1]")).Click();
                    System.Threading.Thread.Sleep(1000);
                    Assert.IsTrue(driver.FindElement(By.XPath("//*[contains(text(),'JQuery Date Picker Demo')]")).Displayed);
                    System.Threading.Thread.Sleep(10000);
                    driver.FindElement(By.Id("from")).SendKeys("31/05/1994");
                    driver.FindElement(By.Id("from")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(2000);
                    driver.FindElement(By.Id("to")).SendKeys("31/05/1994");
                    driver.FindElement(By.Id("to")).SendKeys(Keys.Return);
                    System.Threading.Thread.Sleep(10000);

                }


    
        [TearDown]
        public void TestCleanup()
        {
             driver.Quit(); 
        }
    }

}