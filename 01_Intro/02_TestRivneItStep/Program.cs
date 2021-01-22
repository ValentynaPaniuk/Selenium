using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://rivne.itstep.org");

      

        try
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            if (driver.FindElement(By.XPath("/html/body/header/div[2]/div/div[2]/div/div/a")).Text== "+38 (067) 557-87-04")
            {
                WriteGreen("Telephone is True");
            }
            else
            {
                WriteRed("Telephone is False");
            }

            Console.WriteLine("====================================");

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