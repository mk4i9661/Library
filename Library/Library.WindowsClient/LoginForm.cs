using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library.UI.DevExpressControls.Forms;
using Library.DataContracts.Concrete;
using Library.Proxies;
using System.Security.Cryptography;
using Ninject;

namespace Library.WindowsClient
{
    partial class LoginForm : LibraryForm
    {

        public LoginForm() {
            InitializeComponent();
            InitHandlers();
       //     teLogin.Text = "Администратор";
       //     tePassword.Text = "Администратор";
        }

        void InitHandlers() {
            bLogIn.Click += bLogIn_Click;
            bCancel.Click += bCancel_Click;
            KeyDown += LoginForm_KeyDown;
        }

        void LoginForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                LogIn();
            }
        }

        void bCancel_Click(object sender, EventArgs e) {
            CloseCancel();
        }

        void bLogIn_Click(object sender, EventArgs e) {
            LogIn();
        }

        Task<AuthenticationData> LogIn(string name, string password) {
            return Task.Factory.StartNew(() => {
                return GetAuthenticationProxy().Authenticate(name, password);
            });
        }

        async void LogIn() {
            try {
                var result = await LogIn(Login, Password);
                if (result != null) {
                    Ninject.Bind<AuthenticationData>().ToConstant(result);
                    DialogResult = DialogResult.OK;
                } else {
                    throw new Exception("Неудалось подключиться к серверу. Неверное имя пользователя или пароль");
                }
            } catch (Exception exc) {
                DialogMessages.Error(exc.Message);
            }
        }

        string Login {
            get {
                return teLogin.Text.Trim();
            }
        }

        string Password {
            get {
                var text = tePassword.Text;
                var hash = SHA256.Create().ComputeHash(Encoding.Unicode.GetBytes(text));
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}