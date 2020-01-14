using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUTGCaster
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LLblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/lucadavies/LUTGCaster");
        }

        private void LLblLUTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lutg.org");
        }
    }
}
