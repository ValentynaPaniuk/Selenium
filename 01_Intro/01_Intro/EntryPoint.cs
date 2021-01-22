using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://rutracker.org");

        IWebElement loginElement;
        IWebElement passElement;

        IWebElement enter;
        IWebElement enter2;
        IWebElement exit;





        try
        {
            enter = driver.FindElement(By.LinkText("Вход"));
            enter.Click();

            loginElement = driver.FindElement(By.Id("top-login-uname"));
            loginElement.SendKeys("Cyber1993");


            passElement = driver.FindElement(By.Id("top-login-pwd"));
            passElement.SendKeys("Cyber1993");

            enter2 = driver.FindElement(By.Id("top-login-btn"));
            enter2.Click();


            driver.FindElement(By.Id("search-text")).SendKeys("Jeffrey Richter");
            driver.FindElement(By.Id("search-submit")).Click();
            driver.FindElement(By.LinkText("Jeffrey Richter - CLR via C# [2015, PDF, CHN]")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/table/tbody/tr/td/div/table[3]/tbody[2]/tr[1]/td[2]/div[2]/table[1]/tbody/tr[2]/td[3]/a")).Click();
            driver.FindElement(By.ClassName("log-out-icon")).Click();



            exit = driver.FindElement(By.ClassName("log-out-icon"));
            exit.Click();


           




            if (loginElement.Displayed)
            {
                WriteGreen("Login element is visible: True");
            }
            else
            {
                WriteRed("Login element is visible: False");
            }

        }
        catch (NoSuchElementException)
        {
            WriteRed("This element not found");
        }





        Thread.Sleep(15000);

        driver.Quit();
    }

    private static void WriteRed(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void WriteGreen(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}