using Library.Proxies;
using Library.WindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace Library.WindowsClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var form = DependencyResolver.Kernel.Get<LoginForm>()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    Application.Run(DependencyResolver.Kernel.Get<MainForm>());
                }
            }
        }
    }
}
