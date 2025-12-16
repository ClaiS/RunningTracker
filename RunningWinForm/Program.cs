using RunningWinForm.Data;
using RunningWinForm.Data.Repositories;
using RunningWinForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RunningWinForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Tạo DbContext
            var context = new RunningContext();

            // 2. Tạo Repository
            var userRepository = new UserRepository(context);

            // 3. Tạo Service
            var accountService = new AccountServices(userRepository);

            // 4. Tạo Form với Service đã tạo
            var loginForm = new frmLogin(accountService);

            // 5. Hiển thị form đăng nhập
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = new frmMain(loginForm.LoggedInUser);
                Application.Run(mainForm);
            }

        }
    }
}
