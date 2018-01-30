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

namespace KermitRansom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String File = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            Thread.Sleep(100);
            Process.Start(fileName: File);
            Close();
        }
    }
}
