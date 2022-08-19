using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDo
{
    internal class CDriver
    {
        UserControl1 uc1 = new UserControl1();

        public void ExtractResource()
        {
            byte[] bytes1 = Properties.Resources.chromedriver;
            File.WriteAllBytes(uc1.GetPath() + "\\chromedriver.exe", bytes1);

            byte[] bytes2 = Properties.Resources.SeleniumExtras_WaitHelpers;
            File.WriteAllBytes(uc1.GetPath() + "\\SeleniumExtras.WaitHelpers.dll", bytes2);

            byte[] bytes3 = Properties.Resources.WebDriver;
            File.WriteAllBytes(uc1.GetPath() + "\\WebDriver.dll", bytes3);
        }

        public void Delete()
        {
            File.Delete(uc1.GetPath() + "\\chromedriver.exe");
            File.Delete(uc1.GetPath() + "\\SeleniumExtras.WaitHelpers.dll");
            File.Delete(uc1.GetPath() + "\\WebDriver.dll");
        }
    }
}
