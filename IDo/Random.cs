using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDo
{
    internal class Random
    {
        public void Sleep()
        {
            System.Random randomSleep = new System.Random();
            int sleep = randomSleep.Next(1, 5);

            switch (sleep)
            {
                case 1:
                    Thread.Sleep(2000);
                    break;
                case 2:
                    Thread.Sleep(3000);
                    break;
                case 3:
                    Thread.Sleep(4000);
                    break;
                case 4:
                    Thread.Sleep(5000);
                    break;
                case 5:
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
}
