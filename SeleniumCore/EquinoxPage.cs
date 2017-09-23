using OpenQA.Selenium;

namespace SeleniumCore
{
    public class EquinoxPage
    {
        private IWebDriver Driver { get; }

        private string Url { get; }

        public EquinoxPage(IWebDriver driver, string url)
        {
            Driver = driver;
            Driver.Url = url;
        }


        protected IWebElement LogInLink { get; set; }

        protected IWebElement UserEmailTextBox { get; set; }

        protected IWebElement UserPasswordTextBox { get; set; }

        protected IWebElement LogInSubmit { get; set; }

        protected IWebElement CustomersLink { get; set; }

        public void Login(string userName, string password)
        {
            LogInLink = Driver.FindElement(By.LinkText("Log in"));
            LogInLink.Click();
            UserPasswordTextBox = Driver.FindElement(By.Id("Email"));
            UserPasswordTextBox.SendKeys(userName);
            UserPasswordTextBox = Driver.FindElement(By.Id("Password"));
            UserPasswordTextBox.SendKeys(password);
        }

        public void NavigateToCustomersPage()
        {
            CustomersLink = Driver.FindElement(By.LinkText("Customers"));
            CustomersLink.Click();
        }

        public string GetCustomerRef(string customerEmail)
        {
            var CustomerEmail = Driver.FindElement(By.LinkText(customerEmail));
            return CustomerEmail.GetAttribute("href");
        }
    }
}
