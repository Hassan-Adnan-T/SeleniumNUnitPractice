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
        using IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
        driver.Quit();
    }
}
