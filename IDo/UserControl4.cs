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
    public partial class UserControl4 : UserControl
    {
        static int nbOfUnfollows;
        static int intervalUnfollow;

        public UserControl4()
        {
            InitializeComponent();
        }

        private void chBoxUnfollow_CheckedChanged(object sender, EventArgs e)
        {
            txtIntervalUnfollow.Enabled = (chBoxUnfollow.CheckState == CheckState.Checked);
            txtNbOfUnfollows.Enabled = (chBoxUnfollow.CheckState == CheckState.Checked);
        }

        public void UnfollowInitValues()
        {
            if (txtNbOfUnfollows.Text != String.Empty && txtIntervalUnfollow.Text != String.Empty)
            {
                nbOfUnfollows = int.Parse(txtNbOfUnfollows.Text);
                intervalUnfollow = int.Parse(txtIntervalUnfollow.Text) * 1000 * 60 * 60;
            }          
        }

        public int GetNbOfUnfollows()
        {
            return nbOfUnfollows;
        }

        public int GetIntervalUnfollow()
        {
            return intervalUnfollow;
        }
    }
}
