using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReductionMethods
{
    public partial class MainForm : Form
    {
        readonly string rootPath;
        private DirectBitmap dbm;

        public MainForm()
        {
            InitializeComponent();

            rootPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFileDialog.InitialDirectory = rootPath;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbm = new DirectBitmap(OpenFileDialog.FileName);
                SourceImageOutput.Image = dbm.Bitmap;
                KMeansOutput.Image = dbm.Bitmap;
                PropagationOutput.Image = dbm.Bitmap;
                PopularityOutput.Image = dbm.Bitmap;
                //MakeCharts();
                //groupBox1.Enabled = true;
                //groupBox2.Enabled = true;
            }
        }
    }
}
