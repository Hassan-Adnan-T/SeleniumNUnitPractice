using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeSelenium.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //modify this to enter credentials and login to the application
        using IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
        Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));

        Assert.That(driver.FindElement(By.XPath("//input[@type='text']")).Displayed, Is.True);
        driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("standard_user");

        Assert.That(driver.FindElement(By.XPath("//input[@type='password']")).Displayed, Is.True);
        driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("secret_sauce");

        Assert.That(driver.FindElement(By.XPath("//input[@type='submit']")).Displayed, Is.True);
        Assert.That(driver.FindElement(By.XPath("//input[@type='submit']")).Enabled, Is.True);
        driver.FindElement(By.XPath("//input[@type='submit']")).Click();

        System.Threading.Thread.Sleep(2000);

        driver.Quit();
    }
}
