using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace GoogleSniffer
{
    public partial class GoogleSniffer : MetroForm
    {
        public GoogleSniffer()
        {
            InitializeComponent();
        }

        private void SearchButton1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string text = "Site:"+ TextInput.Text.ToString()+" segmentnext";
            string generatedURL = "www.google.com/search?q=site:" + TextInput.Text.ToString() + "%20%22segmentnext%22";
            System.Diagnostics.Process.Start(generatedURL);
            TextInput.Text = "";
            this.BringToFront();

        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void TextInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = "Site:" + TextInput.Text.ToString() + " segmentnext";
                string generatedURL = "www.google.com/search?q=site:" + TextInput.Text.ToString() + "%20%22segmentnext%22";
                System.Diagnostics.Process.Start(generatedURL);
                TextInput.Text = "";

                this.Activate();

                this.ActiveControl = TextInput;
            }
        }
    }
}
