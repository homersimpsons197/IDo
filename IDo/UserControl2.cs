using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDo
{
    public partial class UserControl2 : UserControl
    {
        static int intervalPost;
        static String path;
        static String[] picsArray;
        static int nbOfPics;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void chBoxPost_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Enabled = (chBoxPost.CheckState == CheckState.Checked);
            txtIntervalPost.Enabled = (chBoxPost.CheckState == CheckState.Checked);
        }

        public void PostInitValues()
        {

            if (chBoxPost.Checked)
            {
                intervalPost = int.Parse(txtIntervalPost.Text) * 1000 * 60 * 60;
                path = txtPath.Text;
                picsArray = Directory.GetFiles(String.Format("{0}", path));
                nbOfPics = picsArray.Length;
            }
        }

        public int GetIntervalPost()
        {
            return intervalPost;
        }

        public String GetPath()
        {
            return path;
        }

        public String[] GetPicsArray()
        {
            return picsArray;
        }

        public int GetNbOfPics()
        {
            return nbOfPics;
        }

    }
}
