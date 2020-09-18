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

namespace Rarcopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string startPath = @"c:\example\start";
            string zipPath = @"c:\example\result.zip";
            string extractPath = @"c:\example\extract";

            System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

        }
    }
}
