using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace VanduDecember2023
{
    class LaunchTurnUpPortal
    {
        public static void LaunchAppandLogintoApplication()
        {

            //Open the Chrome browser
            IWebDriver driver = new ChromeDriver();
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch TurnUp portal and navigate to website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            Console.WriteLine("2. Launch Application Successful");


            //Identify username textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

            //Check if user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in.");
            }

            Console.WriteLine("3. Loginto TurnUp Application Successful");

        }
    }

}
