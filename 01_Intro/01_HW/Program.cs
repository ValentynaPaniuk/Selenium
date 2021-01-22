//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Threading;

//class EntryPoint
//{
//    static void Main(string[] args)
//    {
//        IWebDriver driver = new ChromeDriver();

//        driver.Navigate().GoToUrl("https://www.google.com.ua");



//        try
//        {

//             driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/div/div[2]/div[2]/div/a")).Click();
//             driver.FindElement(By.Id("identifierId")).SendKeys("vpaniuk@gmail.com");
//             driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button/div[2]")).Click();


//             driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input")).SendKeys("azsxd159");
//             driver.FindElement(By.XPath("")).Click();
//             driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/div/div[1]/div[1]/a")).Click();



//        }
//        catch (NoSuchElementException)
//        {
//            WriteRed("This element not found");
//            Console.WriteLine("$$$");
//        }





//        Thread.Sleep(15000);

//        driver.Quit();
//    }

//    private static void WriteRed(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }

//    private static void WriteGreen(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _01._Selectors
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.ukr.net/");

            try
            {
                driver.FindElement(By.Id("id-l")).SendKeys("valentyna.paniuk@ukr.net");
                driver.FindElement(By.Id("id-p")).SendKeys("qawse123");
                driver.FindElement(By.XPath("/html/body/div/div/main/form/button")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"content\"]/aside/button")).Click();
                driver.FindElement(By.Name("toFieldInput")).SendKeys("trofimchuk.an@gmail.com");
                driver.FindElement(By.Name("subject")).SendKeys("Test selenium web driver. Valentyna Paniuk");
                driver.FindElement(By.Id("mce_0_ifr")).SendKeys("Test selenium web driver. Valentyna Paniuk");
                driver.FindElement(By.XPath("//*[@id=\"screens\"]/div/div[2]/div/button[1]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"screens\"]/div/div[3]/div[1]/div[2]/button[2]")).Click();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}