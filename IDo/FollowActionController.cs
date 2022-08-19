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
    internal class FollowActionController
    {
        IWebDriver d;
        
        UserControl1 uc1 = new UserControl1();
        UserControl3 uc3 = new UserControl3();
        Random r = new Random();
        Email m = new Email();

        static int followersCounter;
        static int followBtnCounter;
        static String message;

        public void Follow()
        {
            if (followBtnCounter == 0)
            {
                followBtnCounter = 1;
            }

            int nbOfAcc = int.Parse(uc3.GetFollowsAccounts().Length.ToString());
            System.Random random = new System.Random();
            int randomAccounts = random.Next(0, nbOfAcc);

            String accounts = uc3.GetFollowsAccounts()[randomAccounts];

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

                d.Navigate().GoToUrl(String.Format("https://www.instagram.com/{0}/", accounts));
                r.Sleep();

                var followers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='react-root']/section/main/div/header/section/ul/li[2]/a")));
                followers.Click();
                r.Sleep();

                do
                {
                    var currentUser = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(String.Format("/html/body/div[5]/div/div/div/div[2]/ul/div/li[{0}]", followBtnCounter))));
                    var button = currentUser.FindElement(By.XPath(".//button"));

                    if (button.Text.Equals("Follow"))
                    {
                        button.Click();
                        followersCounter++;
                    }

                    followBtnCounter++;
                    r.Sleep();

                }
                while (followersCounter != uc3.GetNbOfFollows());

                followersCounter = 0;
                followBtnCounter = 1;

                message = "Follows succesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm");

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();

            }
            catch (Exception ex)
            {
                message = "Follows unsuccesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm");

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();
            }
        }
    }
}
