using System;
using System.Windows.Forms;
using MuhDesktop.Service;


namespace MuhDesktop
{
    public partial class FrmLogin : Form
    {
        Services services = new Services();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
         services.UserLogin(TxtUsername.Text,TxtPassword.Text);
        }
    }
}
