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

            bool isRunning = true;

            while(isRunning)
            {
                var loginForm = new frmLogin(accountService);

                DialogResult loginResult = loginForm.ShowDialog();

                if(loginResult == DialogResult.OK && loginForm.LoggedInUser != null)
                {
                    var mainForm = new frmMain(loginForm.LoggedInUser);
                    Application.Run(mainForm);
                    if (mainForm.IsLogout)
                    {
                        // Quay lại form đăng nhập
                        continue;
                    }
                    else
                    {
                        // Thoát ứng dụng
                        isRunning = false;
                    }
                }
                else
                {
                    // Đóng form đăng nhập hoặc đăng nhập thất bại, thoát ứng dụng
                    isRunning = false;
                }
            }

        }
    }
}
