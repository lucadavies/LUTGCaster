using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUTGCaster
{
    public partial class About : Form
    {
        List<TextBox> txts;

        public About()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tbPgAbout;
            txts = new List<TextBox>()
            {
                txt1,
                txt2,
                txt3,
                txt4,
                txt5,
                txt6,
                txt7,
                txt8,
                txt9
            };
        }

        private void LLblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/lucadavies/LUTGCaster");
        }

        private void LLblLUTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lutg.org");
        }

        private void Flash(TextBox textBox, int interval, Color color, int flashes)
        {
            new Thread(() => FlashInternal(textBox, interval, color, flashes)).Start();
        }

        private delegate void UpdateTextboxDelegate(TextBox textBox, Color originalColor);
        private void UpdateTextbox(TextBox textBox, Color color)
        {
            if (textBox.InvokeRequired)
            {
                this.Invoke(new UpdateTextboxDelegate(UpdateTextbox), new object[] { textBox, color });
            }
            textBox.BackColor = color;
        }

        private void FlashInternal(TextBox textBox, int interval, Color flashColor, int flashes)
        {
            Color original = textBox.BackColor;
            for (int i = 0; i < flashes; i++)
            {
                UpdateTextbox(textBox, flashColor);
                Thread.Sleep(interval / 2);
                UpdateTextbox(textBox, original);
                Thread.Sleep(interval / 2);
            }
        }

        private void txt_DoubleClick(object sender, EventArgs e)
        {
            foreach(TextBox t in txts)
            {
                Flash(t, 250, Color.FromArgb(0xFFFFFF ^ t.BackColor.ToArgb()), 5);
            }
        }
    }
}
