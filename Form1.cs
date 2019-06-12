using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS204
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser
                .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

        }

        private void RdMan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMan.Checked)
            {
                btnApply.Enabled = true;
            }
            else
            {
                btnApply.Enabled = true;
            }
        }


    }
}
