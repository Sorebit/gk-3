
namespace ColorReductionMethods
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OutputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.KMeansLabel = new System.Windows.Forms.Label();
            this.PropagationLabel = new System.Windows.Forms.Label();
            this.PopularityLabel = new System.Windows.Forms.Label();
            this.KMeansOutput = new System.Windows.Forms.PictureBox();
            this.PropagationOutput = new System.Windows.Forms.PictureBox();
            this.PopularityOutput = new System.Windows.Forms.PictureBox();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SourceImageOutput = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.OutputLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropagationOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularityOutput)).BeginInit();
            this.InputLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1036, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenToolStripMenuItem.Text = "Open File...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Image files (*.jpg, *.bmp)|*.jpg;*.bmp";
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.OutputLayout, 0, 1);
            this.MainLayout.Controls.Add(this.InputLayout, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 24);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(1036, 566);
            this.MainLayout.TabIndex = 1;
            // 
            // OutputLayout
            // 
            this.OutputLayout.ColumnCount = 3;
            this.OutputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OutputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.OutputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.OutputLayout.Controls.Add(this.KMeansLabel, 0, 1);
            this.OutputLayout.Controls.Add(this.PropagationLabel, 1, 1);
            this.OutputLayout.Controls.Add(this.PopularityLabel, 2, 1);
            this.OutputLayout.Controls.Add(this.KMeansOutput, 0, 0);
            this.OutputLayout.Controls.Add(this.PropagationOutput, 1, 0);
            this.OutputLayout.Controls.Add(this.PopularityOutput, 2, 0);
            this.OutputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputLayout.Location = new System.Drawing.Point(3, 286);
            this.OutputLayout.Name = "OutputLayout";
            this.OutputLayout.RowCount = 2;
            this.OutputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OutputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.OutputLayout.Size = new System.Drawing.Size(1030, 277);
            this.OutputLayout.TabIndex = 0;
            // 
            // KMeansLabel
            // 
            this.KMeansLabel.AutoSize = true;
            this.KMeansLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KMeansLabel.Location = new System.Drawing.Point(3, 253);
            this.KMeansLabel.Name = "KMeansLabel";
            this.KMeansLabel.Size = new System.Drawing.Size(337, 24);
            this.KMeansLabel.TabIndex = 0;
            this.KMeansLabel.Text = "KMeansLabel";
            this.KMeansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PropagationLabel
            // 
            this.PropagationLabel.AutoSize = true;
            this.PropagationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropagationLabel.Location = new System.Drawing.Point(346, 253);
            this.PropagationLabel.Name = "PropagationLabel";
            this.PropagationLabel.Size = new System.Drawing.Size(337, 24);
            this.PropagationLabel.TabIndex = 1;
            this.PropagationLabel.Text = "Error Propagation";
            this.PropagationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopularityLabel
            // 
            this.PopularityLabel.AutoSize = true;
            this.PopularityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopularityLabel.Location = new System.Drawing.Point(689, 253);
            this.PopularityLabel.Name = "PopularityLabel";
            this.PopularityLabel.Size = new System.Drawing.Size(338, 24);
            this.PopularityLabel.TabIndex = 2;
            this.PopularityLabel.Text = "Popularity";
            this.PopularityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KMeansOutput
            // 
            this.KMeansOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KMeansOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KMeansOutput.Location = new System.Drawing.Point(3, 3);
            this.KMeansOutput.Name = "KMeansOutput";
            this.KMeansOutput.Size = new System.Drawing.Size(337, 247);
            this.KMeansOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KMeansOutput.TabIndex = 3;
            this.KMeansOutput.TabStop = false;
            // 
            // PropagationOutput
            // 
            this.PropagationOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PropagationOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropagationOutput.Location = new System.Drawing.Point(346, 3);
            this.PropagationOutput.Name = "PropagationOutput";
            this.PropagationOutput.Size = new System.Drawing.Size(337, 247);
            this.PropagationOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PropagationOutput.TabIndex = 4;
            this.PropagationOutput.TabStop = false;
            // 
            // PopularityOutput
            // 
            this.PopularityOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopularityOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopularityOutput.Location = new System.Drawing.Point(689, 3);
            this.PopularityOutput.Name = "PopularityOutput";
            this.PopularityOutput.Size = new System.Drawing.Size(338, 247);
            this.PopularityOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PopularityOutput.TabIndex = 5;
            this.PopularityOutput.TabStop = false;
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.InputLayout.Controls.Add(this.SourceImageOutput, 0, 0);
            this.InputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayout.Location = new System.Drawing.Point(3, 3);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 1;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputLayout.Size = new System.Drawing.Size(1030, 277);
            this.InputLayout.TabIndex = 1;
            // 
            // SourceImageOutput
            // 
            this.SourceImageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceImageOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceImageOutput.Location = new System.Drawing.Point(3, 3);
            this.SourceImageOutput.Name = "SourceImageOutput";
            this.SourceImageOutput.Size = new System.Drawing.Size(406, 271);
            this.SourceImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SourceImageOutput.TabIndex = 0;
            this.SourceImageOutput.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 590);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Color Reduction Methods";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainLayout.ResumeLayout(false);
            this.OutputLayout.ResumeLayout(false);
            this.OutputLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropagationOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularityOutput)).EndInit();
            this.InputLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel OutputLayout;
        private System.Windows.Forms.Label KMeansLabel;
        private System.Windows.Forms.Label PropagationLabel;
        private System.Windows.Forms.Label PopularityLabel;
        private System.Windows.Forms.PictureBox KMeansOutput;
        private System.Windows.Forms.PictureBox PropagationOutput;
        private System.Windows.Forms.PictureBox PopularityOutput;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.PictureBox SourceImageOutput;
    }
}

