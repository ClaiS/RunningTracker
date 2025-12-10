using RunningWinForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningWinForm.Data.Repositories;

namespace RunningWinForm
{
    public partial class frmLogin : Form
    {
        private readonly UserRepository _userRepository;

        public frmLogin(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            
            var user = 
        }
    }
}
