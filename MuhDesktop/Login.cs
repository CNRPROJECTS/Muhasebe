using System;
using System.Windows.Forms;
using MuhDesktop.Service;
using MuhShared;

namespace MuhDesktop
{
    public partial class FrmLogin : Form
    {
        Services services = new Services();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private  void BtnGiris_Click(object sender, EventArgs e)
        {
            MUserLogin userlogin = new MUserLogin();
            userlogin.Username = TxtUsername.Text;
            userlogin.Password = TxtPassword.Text;
            services.UserLogin(userlogin);
          
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
