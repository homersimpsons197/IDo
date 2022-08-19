using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using OpenQA.Selenium.Chrome;

namespace IDo
{
    internal class PostActionController
    {
        IWebDriver d;
        AutoItX3 x = new AutoItX3();
        
        UserControl1 uc1 = new UserControl1();
        UserControl2 uc2 = new UserControl2();
        Random r = new Random();
        Email m = new Email();

        static int picsArrayCounter;
        static String message;

        public void Post()
        {
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

                var newPost = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='New Post']")));
                newPost.Click();
                r.Sleep();

                x.ControlSetText("Open", "", "Edit1", String.Format("{0}", uc2.GetPicsArray()[picsArrayCounter]));
                x.ControlClick("Open", "", "Button1");

                if (picsArrayCounter < uc2.GetNbOfPics())
                    picsArrayCounter++;
                else
                    m.Mail("Manque de photos.");
                
                r.Sleep();

                var next = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Next']")));
                next.Click();
                r.Sleep();

                System.Random randomHashtags = new System.Random();
                int hashtags = randomHashtags.Next(0, 10);

                switch (hashtags)
                {
                    case 0:
                        var hashtag0 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag0.SendKeys("#memes #mamas #memesdaily #dankmemes #funnymemes #memesaccount #memes4ever #memes4life #mamasein #memessad #memesftw #memesminecraft #memestragram #memessimpsons #memesportugal");
                        break;

                    case 1:
                        var hashtag1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag1.SendKeys("#edgymemes #offensivememes #dailymemes #memesespañol #memesbrasil #memesargentinos #memesinstagram #memesespaña #memesdobrasil #mamasbaby #memesnaruto #memeshitpost #memestwitter #memes2k17 #mamasabcyberjaya");
                        break;

                    case 2:
                        var hashtag2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag2.SendKeys("#spicymemes #fortnitememes #mamasboy #memestar #btsmemes #mamasablovers #jojomemes #mamasabwarrior #mamasboys #chileanmemes #dankmemesmeltsteelbeams #mamasprimerizas #mamashelter #memestarterpack #memesday #memesvirales");
                        break;

                    case 3:
                        var hashtag3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag3.SendKeys("#funny #lol #meme #memes #dank #comedy #dankmemes #offensivememes #jokes #memelord #dailymemes #funmeme #memespages #legendarymemes #memesgram");
                        break;

                    case 4:
                        var hashtag4 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag4.SendKeys("#haha #edgymeme #memepage #humor #memes4life #mememachine #memeking #hillarious #dankmemer #bestmeme #memelords #memers #memedealer #memestagramm #englishmemes");
                        break;

                    case 5:
                        var hashtag5 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag5.SendKeys("#funnymemes #memeoftheday #memez #edgymemes #joke #relatable #bestmemes #memegod #rofl #hilariousmemes #dailydankmemes #memesforever #instagrammemes #memelover #newmeme");
                        break;

                    case 6:
                        var hashtag6 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag6.SendKeys("#memetime #darkhumor #dankestmemes #instamemes #instameme #newmemes #dailymeme #relatablememes #freshmemes #wtfmemes #epicmemes #bhfyp #fun #likeforlikes #viral");
                        break;

                    case 7:
                        var hashtag7 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag7.SendKeys("#lolmemes #weirdmemes #deadmemes #surrealmemes #stupidmemes #shitpostmemes #cringymemes #firememes #dailydankmemes #memesworld #memeslol #toxicmemes #breakupmemes #kanyememes #psychologymemes");
                        break;

                    case 8:
                        var hashtag8 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag8.SendKeys("#memes #memesdaily #dankmemes #funnymemes #memesfunny #savagememes #memeslayer #sillymemes #immortalmemes #soccermemes #mexicanmemes #shitpostmemes #memestragram #memessimpsons #memesportugal");
                        break;

                    case 9:
                        var hashtag9 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label='Write a caption…']")));
                        hashtag9.SendKeys("#memes #memesdaily #dankmemes #memesargentina #memesaccount #memes4ever #qualitymemes #historymemes #memesftw #memesminecraft #memesgram #memestuff #memes4u #memesbrs #memesfortnite");
                        break;
                }
                r.Sleep();

                var share = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[text()='Share']")));
                share.Click();
                r.Sleep();

                message = "Post succesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm") + "\n" + "Photo posted: " + (picsArrayCounter - 1).ToString() + "\n" + "Photos total: " + uc2.GetNbOfPics().ToString();

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();

            }
            catch (Exception ex)
            {
                message = "Post unsuccesfully made => " + DateTime.Now.ToString("MM / dd  HH: mm");

                m.Mail(message);
                r.Sleep();

                d.Quit();
                r.Sleep();
            }
        }
    }
}
