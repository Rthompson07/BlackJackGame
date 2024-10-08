using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class Login : Form
    {
        PlayerManager playerManager;
        public Login()
        {
            InitializeComponent();
            playerManager = new PlayerManager();
            lblPassword.Visible = false;
            tbPassword.Visible = false;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAdmin.Checked) 
            {
                lblPassword.Visible = true;
                tbPassword.Visible = true;
            }
            else
            {
                lblPassword.Visible = false;
                tbPassword.Visible = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cbAdmin.Checked)
            {

            }
            else
            {
                string usernameInput = tbUsername.Text;

                playerManager.GetOrMakePlayer(usernameInput);

            }
        }
    }
}
