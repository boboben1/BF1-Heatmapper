using System;
using System.Windows.Forms;



namespace Heatmapper
{
    public static class Server
    {
        public static MainForm MainForm { get; private set; }

        public static bool DesignMode { get; private set; } = true;

        [STAThread]
        public static void Main()
        {
            DesignMode = false;

            MainForm = new MainForm();

            Application.Run(MainForm);
        }
    }
}