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
            
            driver.Navigate().GoToUrl("https://s1.demo.opensourcecms.com/wordpress/wp-login.php/");
            driver.Manage().Window.Maximize();

            
            driver.FindElement(By.Name("log")).SendKeys("opensourcecms");
            driver.FindElement(By.Name("pwd")).SendKeys("opensourcecms"+ Keys.Enter);

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/ul/li[3]/a/div[3]")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/ul/li[3]/ul/li[5]/a")).Click();

            driver.FindElement(By.Id("tag-name")).SendKeys("1234"+ Keys.Enter);
        }
    }
}
