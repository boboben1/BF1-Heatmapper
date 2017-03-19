using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Heatmapper.Properties;

namespace Heatmapper
{
    public partial class MainForm : Form
    {

        public bool HideOnMinimize { get; private set; } = true;
        public bool PreventClosing { get; private set; } = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowWindow()
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

        private void CloseWindow()
        {
            PreventClosing = false;
            Close();
        }

        private void MinimizeWindow()
        {
            WindowState = FormWindowState.Minimized;
            if (HideOnMinimize)
                Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text += Environment.NewLine;
            richTextBox1.Text += string.Format(Resources.MainForm_MainForm_Load_Built_on__0_, Properties.Resources.BuildDate);
            richTextBox1.Text += string.Format(Resources.MainForm_MainForm_Load_Heatmapper_Version___0_, Assembly.GetExecutingAssembly().GetName().Version.ToString());
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.HideSelection = true;
            richTextBox1.BorderStyle = BorderStyle.None;


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PreventClosing) return;
            e.Cancel = true;
            MinimizeWindow();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowWindow();
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
    }
}
