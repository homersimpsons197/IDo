using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDo
{
    internal class UnfollowActionController
    {
        IWebDriver d;
        
        UserControl1 uc1 = new UserControl1();
        UserControl4 uc4 = new UserControl4();
        Random r = new Random();
        Email m = new Email();

        static int unfollowCounter;
        static int unfollowBtnCounter;
        static String message;

        public void Unfollow()
        {
            if (unfollowBtnCounter == 0)
            {
                unfollowBtnCounter = 1;
            }

            try
            {
                var c = new ChromeOptions();

                c.AddArguments(String.Format(@"--user-data-dir=C:\Users\{0}\AppData\Local\Google\Chrome\User Data", uc1.GetFolderUsername()));
                c.AddArguments(String.Format(@"--profile-directory={0}", uc1.GetProfile()));
                c.AddExcludedArgument("--enable-automation");
                c.AcceptInsecureCertificates = true;
                c.AddArguments("--ignore-certificate-errors");
                c.AddArguments("--ignore-ssl-errors");
                c.AddArgument("start-maximized");
                c.AddArguments("--lang=en");
                c.AddArguments("--disable-blink-features=AutomationControlled");
                c.AddArguments("--user-agent=Mozilla/5.0 (Linux; Android 12) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.87 Mobile Safari/537.36");

                var commandTimeout = TimeSpan.FromSeconds(20);

                if (uc1.GetPChecked())
                {
                    String usedP = uc1.GetUsedP();

                    Proxy p = new Proxy();
                    p.Kind = ProxyKind.Manual;
                    p.IsAutoDetect = false;
                    p.HttpProxy = usedP;
                    p.SslProxy = usedP;
                    c.Proxy = p;
                }

                d = new ChromeDriver(String.Format(@"C:\Users\{0}\AppData\Local\Google\Chrome\User Data", uc1.GetFolderUsername()), c);

                var wait = new WebDriverWait(d, new TimeSpan(0, 0, 30));

                d.Navigate().GoToUrl("https://www.instagram.com/");
                r.Sleep();

                var profile = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='react-root']/section/nav[2]/div/div/div/div/div/div[5]/a")));
                profile.Click();
                r.Sleep();

                var following = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='react-root']/section/main/div/header/section/ul/li[3]/a")));
                following.Click();
                r.Sleep();

                do
                {
                    var currentUser2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(String.Format("/html/body/div[5]/div/div/div/div[3]/ul/div/li[{0}]", unfollowBtnCounter))));
                    var button2 = currentUser2.FindElement(By.XPath(".//button"));

                    if (button2.Text.Equals("Following"))
                    {
                        button2.Click();
                        r.Sleep();

                        var unfollow = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Unfollow']")));
                        unfollow.Click();
                        r.Sleep();

                        unfollowCounter++;
                    }

                    unfollowBtnCounter++;
                    r.Sleep();

                }
                while (unfollowCounter != uc4.GetNbOfUnfollows());

                unfollowCounter = 0;
                unfollowBtnCounter = 1;

                message = "Unfollows succesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm");

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();

            }
            catch (Exception ex)
            {
                message = "Unfollows unsuccesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm");

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();
            }
        }
    }
}
