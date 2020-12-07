using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ColorReductionMethods.ReductionMethods;

namespace ColorReductionMethods
{
    public partial class MainForm : Form
    {
        private readonly string rootPath;
        private DirectBitmap SourceImage;
        private DirectBitmap KMeansImage;

        private readonly ErrorDiffusionDithering Dithering;
        private readonly PopularityMethod Popularity;

        public MainForm()
        {
            InitializeComponent();

            rootPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFileDialog.InitialDirectory = rootPath;

            // Initialize methods
            Dithering = new ErrorDiffusionDithering(3, 3, 3);
            Popularity = new PopularityMethod(() => (int)KNumeric.Value);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceImage = new DirectBitmap(OpenFileDialog.FileName);
                SourceImageOutput.Image = SourceImage.Bitmap;
                //KMeansOutput.Image = SourceImage.Bitmap;
            }
        }

        private void FloydButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.FloydSteinbergFilter).Bitmap;
        }

        private void BurkesButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.BurkesFilter).Bitmap;
        }

        private void StuckyButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.StuckyFilter).Bitmap;
        }

        private void KrNumeric_ValueChanged(object sender, EventArgs e)
        {
            Dithering.Kr = (int)(sender as NumericUpDown).Value;
        }

        private void KgNumeric_ValueChanged(object sender, EventArgs e)
        {
            Dithering.Kg = (int)(sender as NumericUpDown).Value;
        }

        private void KbNumeric_ValueChanged(object sender, EventArgs e)
        {
            Dithering.Kb = (int)(sender as NumericUpDown).Value;
        }

        private void PopularityButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            PopularityOutput.Image = Popularity.Calculate(SourceImage).Bitmap;
        }
    }
}
