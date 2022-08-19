using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDo
{
    public partial class UserControl1 : UserControl
    {
        static bool pChecked;
        static String usedP;
        static String path;
        static String profile;
        static String folderUsername;
        static bool usernameFilled;
        CDriver d;
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void chBoxP_CheckedChanged(object sender, EventArgs e)
        {
            txtP.Enabled = (chBoxP.CheckState == CheckState.Checked);
        }

        public void PInitValues()
        {
            if (chBoxP.Checked)
            {
                pChecked = true;
            }
            else
            {
                pChecked = false;
            }

            if(chBoxP.Checked && txtP.Text != String.Empty)
            {
                usedP = txtP.Text;
            }

            if(cmBoxProfile.GetItemText(cmBoxProfile.SelectedItem) != String.Empty)
            {
                profile = cmBoxProfile.GetItemText(cmBoxProfile.SelectedItem);
            }

            if(txtFolderUsername.Text != String.Empty)
            {
                folderUsername = txtFolderUsername.Text;
                path = String.Format("C:\\Users\\{0}\\AppData\\Local\\Google\\Chrome\\User Data", folderUsername);
                usernameFilled = true;
            }
            else
            {
                usernameFilled = false;
            }
        }

        public bool GetPChecked()
        {
            return pChecked;
        }

        public String GetUsedP()
        {
            return usedP;
        }

        public String GetProfile()
        {
            return profile;
        }

        public String GetFolderUsername()
        {
            return folderUsername;
        }

        public String GetPath()
        {
            return path;
        }
        
        public bool IsUsernameFilled()
        {
            return usernameFilled;
        }
    }
}
