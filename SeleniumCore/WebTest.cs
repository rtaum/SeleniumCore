using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using Xunit;

namespace SeleniumCore
{
    public class WebTest
    {
        [Fact]
        public void Test1()
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string driverFolder = currentDirectory + @"/Drivers/Windows/";
            var service = ChromeDriverService.CreateDefaultService(driverFolder, "chromedriver.exe");
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            using (var driver = new ChromeDriver(service, chromeOptions))
            {
                driver.Url = "https://www.google.com";
                driver.Navigate();
                Assert.Equal("Google", driver.Title);
            }
        }
    }
}
