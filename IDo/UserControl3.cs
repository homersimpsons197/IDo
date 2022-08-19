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
    public partial class UserControl3 : UserControl
    {
        static int nbOfFollows;
        static int intervalFollow;
        static String[] followsAccounts;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void chBoxFollow_CheckedChanged(object sender, EventArgs e)
        {
            txtIntervalFollow.Enabled = (chBoxFollow.CheckState == CheckState.Checked);
            txtNbOfFollows.Enabled = (chBoxFollow.CheckState == CheckState.Checked);
            rTxtAccounts.Enabled = (chBoxFollow.CheckState == CheckState.Checked);
        }

        public void FollowInitValues()
        {
            if (txtNbOfFollows.Text != String.Empty && txtIntervalFollow.Text != String.Empty && rTxtAccounts.Text != String.Empty)
            {
                nbOfFollows = int.Parse(txtNbOfFollows.Text);
                intervalFollow = int.Parse(txtIntervalFollow.Text) * 1000 * 60 * 60;
                followsAccounts = rTxtAccounts.Lines;
            }
        }

        public int GetNbOfFollows()
        {
            return nbOfFollows;
        }

        public int GetIntervalFollow()
        {
            return intervalFollow;
        }

        public String[] GetFollowsAccounts()
        {
            return followsAccounts;
        }
    }
}
