using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartApp
{
    public partial class Form1 : Form
    {
        string startPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);



        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Form1()
        {
            InitializeComponent();
        }

        private void consoleAplicationLabel_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(startPath + @"\Console Pokedex\bin\Debug\net5.0\Console Pokedex.exe");
            Thread.Sleep(100);
            this.Close();
        }

        private void windowAplicationLabel_Click(object sender, EventArgs e)
        {
            Process p = Process.Start(startPath + @"\Pokedex\bin\Debug\net5.0-windows\Pokedex.exe");
            Thread.Sleep(100);
            this.Close();
        }

        private void consoleAplicationLabel_MouseEnter(object sender, EventArgs e)
        {
            consoleAplicationLabel.ForeColor = Color.Yellow;
        }

        private void consoleAplicationLabel_MouseLeave(object sender, EventArgs e)
        {
            consoleAplicationLabel.ForeColor = Color.White;
        }



        private void windowAplicationLabel_MouseEnter(object sender, EventArgs e)
        {
            windowAplicationLabel.ForeColor = Color.Yellow;
        }

        private void windowAplicationLabel_MouseLeave(object sender, EventArgs e)
        {
            windowAplicationLabel.ForeColor = Color.White;
        }
    }
}
