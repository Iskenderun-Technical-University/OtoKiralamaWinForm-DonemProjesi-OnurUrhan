using DevExpress.XtraEditors;
using OtoKiralama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelForm
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public formLogin()
        {
            InitializeComponent();
            this.MouseDown += formLogin_MouseDown;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "ADMIN" && txtPassword.Text == "123")
            {
                this.Hide();
                var mainPage = new frmAnasayfa();
                mainPage.Show();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı !!!");
                return;
            }
            

        }
    }
}