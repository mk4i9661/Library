using Library.Proxies;
using Library.WindowsClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Threading;
using Library.UI.DevExpressControls.Forms;

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
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            using (var form = DependencyResolver.Kernel.Get<LoginForm>()) {
                if (form.ShowDialog() == DialogResult.OK) {
                    Application.Run(DependencyResolver.Kernel.Get<MainForm>());
                }
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            var exception = e.ExceptionObject as Exception;
            if (exception != null) {
                DialogMessages.Error(exception.Message);
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e) {
            DialogMessages.Error(e.Exception.Message);
        }
    }
}
