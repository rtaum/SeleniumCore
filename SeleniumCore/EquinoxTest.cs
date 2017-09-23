using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumCore
{
    public class EquinoxTest
    {
        [Fact]
        public void CustomerEmailTest()
        {
            const string userName = "artyom@mail.com";
            const string password = "VMAdmin111_";
            const string customerEmail = "jan@mail.com";
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("headless");
            using (var driver = new ChromeDriver(chromeOptions))
            {
                var equinoxPage = new EquinoxPage(driver, "http://10.0.2.22/");
                equinoxPage.Login(userName, password);
                equinoxPage.NavigateToCustomersPage();
                var customerEmailHref = equinoxPage.GetCustomerRef(customerEmail);
                Assert.Equal($"mailto:{customerEmail}", customerEmailHref);
            }
        }
    }
}
