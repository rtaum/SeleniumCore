using OpenQA.Selenium.Firefox;
using Xunit;

namespace SeleniumCore
{
    public class WebTest
    {
        [Fact]
        public void Test1()
        {
            var service = FirefoxDriverService.CreateDefaultService(@"F:\", "geckodriver.exe");
            using (var driver = new FirefoxDriver(service))
            {
                driver.Url = "https://www.google.com";
                driver.Navigate();
                Assert.Equal("Google", driver.Title);
            }
        }
    }
}
