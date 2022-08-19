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
    public partial class Form1 : Form
    {
        UserControl1 uc1;
        UserControl2 uc2;
        UserControl3 uc3;
        UserControl4 uc4;
        CDriver d = new CDriver();
        Timer t = new Timer();

        PostActionController pAC = new PostActionController();
        FollowActionController fAC = new FollowActionController();
        UnfollowActionController uAC = new UnfollowActionController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc1 = new UserControl1();
            uc1.Hide();
            pnlControl.Controls.Add(uc1);
            uc2 = new UserControl2();
            uc2.Hide();
            pnlControl.Controls.Add(uc2);
            uc3 = new UserControl3();
            uc3.Hide();            
            pnlControl.Controls.Add(uc3);
            uc4 = new UserControl4();
            uc4.Hide();
            pnlControl.Controls.Add(uc4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            d.Delete();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            uc1.PInitValues();
            uc2.PostInitValues();
            uc3.FollowInitValues();
            uc4.UnfollowInitValues();

            if (uc1.IsUsernameFilled())
            {
                d.ExtractResource();
                
                await Task.Run(() =>
                {
                    if (uc2.chBoxPost.Checked)
                    {
                        t.PostStart();
                    }

                    if (uc3.chBoxFollow.Checked)
                    {
                        t.FollowStart();
                    }

                    if (uc4.chBoxUnfollow.Checked)
                    {
                        t.UnfollowStart();
                    }
                });
            }
            else if (!uc1.IsUsernameFilled())
            {
                MessageBox.Show("Fill folder username.");
            }
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uc1.BringToFront();
            uc1.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            uc2.BringToFront();
            uc2.Show();           
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            uc3.BringToFront();
            uc3.Show();            
        }

        private void btnUnfollow_Click(object sender, EventArgs e)
        {
            uc4.BringToFront();
            uc4.Show();            
        }       
    }
}
