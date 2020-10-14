using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://s1.demo.opensourcecms.com/wordpress/wp-login.php");
            //driver.Navigate().GoToUrl("https://www.opensourcecms.com/wordpress/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[1]/div[2]/div[3]/ul/li[2]/a")).Click();


            driver.FindElement(By.Name("log")).SendKeys("opensourcecms");
            driver.FindElement(By.Name("pwd")).SendKeys("opensourcecms"+ Keys.Enter);

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/ul/li[3]/a/div[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/ul/li[3]/ul/li[5]/a")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.Id("tag-name")).SendKeys("1234"+ Keys.Enter);
        }
    }
}
