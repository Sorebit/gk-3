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
        private readonly int GeneratedImageWidth = 400;
        private readonly int GeneratedImageHeight = 270;
        private readonly int GeneratedImageBorderThickness = 20;
        private readonly int GeneratedImageRadius = 80;
        private DirectBitmap GeneratedImage;

        private readonly ErrorDiffusionDithering Dithering;
        private readonly PopularityMethod Popularity;
        private readonly KMeansAlgorithm KMeans;

        public MainForm()
        {
            InitializeComponent();

            rootPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            OpenFileDialog.InitialDirectory = rootPath;

            // Initialize methods
            Dithering = new ErrorDiffusionDithering(3, 3, 3);
            Popularity = new PopularityMethod(() => (int)PopularityKNumeric.Value);
            KMeans = new KMeansAlgorithm(() => (int)KMeansKNumeric.Value, () => (int)KMeansIterNumeric.Value);

            // Generate image
            GenerateImage();
        }

        private void GenerateImage()
        {
            GeneratedImage = new DirectBitmap(GeneratedImageWidth, GeneratedImageHeight);
            Color black = Color.Black;
            Color white = Color.White;

            // Top and bottom border
            for (int y = 0; y < GeneratedImageBorderThickness; y++)
            {
                for (int x = 0; x < GeneratedImage.Width; x++)
                {
                    GeneratedImage.SetPixel(x, y, black);
                    GeneratedImage.SetPixel(x, GeneratedImage.Height - y - 1, black);
                }
            }

            // Left and right border
            for (int x = 0; x < GeneratedImageBorderThickness; x++)
            {
                for (int y = GeneratedImageBorderThickness; y < GeneratedImage.Height - GeneratedImageBorderThickness; y++)
                {
                    GeneratedImage.SetPixel(x, y, black);
                    GeneratedImage.SetPixel(GeneratedImage.Width - x - 1, y , black);
                }
            }

            // Fill inside with white
            for (int x = GeneratedImageBorderThickness; x < GeneratedImage.Width - GeneratedImageBorderThickness; x++)
            {
                for (int y = GeneratedImageBorderThickness; y < GeneratedImage.Height - GeneratedImageBorderThickness; y++)
                {
                    GeneratedImage.SetPixel(x, y, white);
                }
            }

            // HSV circle
            int ox = GeneratedImageWidth / 2;
            int oy = GeneratedImageHeight / 2;
            for (int x = ox - GeneratedImageRadius; x < ox + GeneratedImageRadius; x++)
            {
                for (int y = oy - GeneratedImageRadius; y < oy + GeneratedImageRadius; y++)
                {
                    double distance = Helpers.Distance(x, y, ox, oy);
                    
                    if (distance <= GeneratedImageRadius)
                    {
                        double S = distance / GeneratedImageRadius;
                        double H = (Math.Atan2(x-ox, y-oy) - Math.PI/2) / (Math.PI * 2) * 360;
                        GeneratedImage.SetPixel(x, y, Helpers.HsvToRgb(H, S, 1));
                    }
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceImage = new DirectBitmap(OpenFileDialog.FileName);
                SourceImageOutput.Image = SourceImage.Bitmap;
            }
        }

        //
        // -- Buttons --
        // 

        private void FloydButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DisableGroups();
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.FloydSteinbergFilter).Bitmap;
            FinishedWrapper();
        }

        private void BurkesButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DisableGroups();
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.BurkesFilter).Bitmap;
            FinishedWrapper();
        }

        private void StuckyButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DisableGroups();
            DitheringOutput.Image = Dithering.Calculate(SourceImage, ErrorDiffusionDithering.StuckyFilter).Bitmap;
            FinishedWrapper();
        }

        private void PopularityButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DisableGroups();
            PopularityOutput.Image = Popularity.Calculate(SourceImage).Bitmap;
            FinishedWrapper();
        }

        private void KMeansButton_Click(object sender, EventArgs e)
        {
            if (SourceImage == null) return;
            DisableGroups();
            KMeansOutput.Image = KMeans.Calculate(SourceImage).Bitmap;
            FinishedWrapper();
        }

        //
        // -- Misc --
        //

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

        private void CreateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SourceImage = GeneratedImage;
            SourceImageOutput.Image = SourceImage.Bitmap;
        }


        private void DisableGroups()
        {
            KMeansGroup.Enabled = false;
            DitheringGroupBox.Enabled = false;
            PopularityBox.Enabled = false;
        }

        private void FinishedWrapper()
        {
            MessageBox.Show("Finished", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KMeansGroup.Enabled = true;
            DitheringGroupBox.Enabled = true;
            PopularityBox.Enabled = true;
        }
    }
}
