using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumCore
{
    public class WebTest
    {
        [Fact]
        public void Test1()
        {            
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            using (var driver = new ChromeDriver(chromeOptions))
            {
                driver.Url = "http://10.0.2.22/";
                driver.Navigate();
                Assert.Equal("Home Page - test", driver.Title);
            }
        }
    }
}
