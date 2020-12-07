
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
            this.DitheringOutput = new System.Windows.Forms.PictureBox();
            this.PopularityOutput = new System.Windows.Forms.PictureBox();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SourceImageOutput = new System.Windows.Forms.PictureBox();
            this.ControlsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.KGroupBox = new System.Windows.Forms.GroupBox();
            this.KLabel = new System.Windows.Forms.Label();
            this.KNumeric = new System.Windows.Forms.NumericUpDown();
            this.KrgbGroupBox = new System.Windows.Forms.GroupBox();
            this.KbLabel = new System.Windows.Forms.Label();
            this.KgLabel = new System.Windows.Forms.Label();
            this.KrLabel = new System.Windows.Forms.Label();
            this.KbNumeric = new System.Windows.Forms.NumericUpDown();
            this.KgNumeric = new System.Windows.Forms.NumericUpDown();
            this.KrNumeric = new System.Windows.Forms.NumericUpDown();
            this.ButtonGroup = new System.Windows.Forms.GroupBox();
            this.StuckyButton = new System.Windows.Forms.Button();
            this.PopularityButton = new System.Windows.Forms.Button();
            this.BurkesButton = new System.Windows.Forms.Button();
            this.KMeansButton = new System.Windows.Forms.Button();
            this.FloydButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.OutputLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KMeansOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DitheringOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularityOutput)).BeginInit();
            this.InputLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageOutput)).BeginInit();
            this.ControlsLayout.SuspendLayout();
            this.KGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KNumeric)).BeginInit();
            this.KrgbGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KbNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrNumeric)).BeginInit();
            this.ButtonGroup.SuspendLayout();
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
            this.OutputLayout.Controls.Add(this.DitheringOutput, 1, 0);
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
            this.KMeansLabel.Text = "K-Means Alg.";
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
            this.PropagationLabel.Text = "Error Diffusion Dithering";
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
            this.PopularityLabel.Text = "Popularity Method";
            this.PopularityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KMeansOutput
            // 
            this.KMeansOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KMeansOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KMeansOutput.Location = new System.Drawing.Point(3, 3);
            this.KMeansOutput.Name = "KMeansOutput";
            this.KMeansOutput.Size = new System.Drawing.Size(337, 247);
            this.KMeansOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KMeansOutput.TabIndex = 3;
            this.KMeansOutput.TabStop = false;
            // 
            // DitheringOutput
            // 
            this.DitheringOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DitheringOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DitheringOutput.Location = new System.Drawing.Point(346, 3);
            this.DitheringOutput.Name = "DitheringOutput";
            this.DitheringOutput.Size = new System.Drawing.Size(337, 247);
            this.DitheringOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DitheringOutput.TabIndex = 4;
            this.DitheringOutput.TabStop = false;
            // 
            // PopularityOutput
            // 
            this.PopularityOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PopularityOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PopularityOutput.Location = new System.Drawing.Point(689, 3);
            this.PopularityOutput.Name = "PopularityOutput";
            this.PopularityOutput.Size = new System.Drawing.Size(338, 247);
            this.PopularityOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PopularityOutput.TabIndex = 5;
            this.PopularityOutput.TabStop = false;
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.InputLayout.Controls.Add(this.SourceImageOutput, 0, 0);
            this.InputLayout.Controls.Add(this.ControlsLayout, 1, 0);
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
            this.SourceImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceImageOutput.TabIndex = 0;
            this.SourceImageOutput.TabStop = false;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.Controls.Add(this.KGroupBox);
            this.ControlsLayout.Controls.Add(this.KrgbGroupBox);
            this.ControlsLayout.Controls.Add(this.ButtonGroup);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(415, 3);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.Size = new System.Drawing.Size(612, 271);
            this.ControlsLayout.TabIndex = 1;
            // 
            // KGroupBox
            // 
            this.KGroupBox.Controls.Add(this.KLabel);
            this.KGroupBox.Controls.Add(this.KNumeric);
            this.KGroupBox.Location = new System.Drawing.Point(3, 3);
            this.KGroupBox.Name = "KGroupBox";
            this.KGroupBox.Size = new System.Drawing.Size(200, 50);
            this.KGroupBox.TabIndex = 3;
            this.KGroupBox.TabStop = false;
            this.KGroupBox.Text = "K";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(7, 21);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(17, 13);
            this.KLabel.TabIndex = 1;
            this.KLabel.Text = "K:";
            // 
            // KNumeric
            // 
            this.KNumeric.Location = new System.Drawing.Point(74, 19);
            this.KNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KNumeric.Name = "KNumeric";
            this.KNumeric.Size = new System.Drawing.Size(120, 20);
            this.KNumeric.TabIndex = 0;
            this.KNumeric.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // KrgbGroupBox
            // 
            this.KrgbGroupBox.Controls.Add(this.StuckyButton);
            this.KrgbGroupBox.Controls.Add(this.KbLabel);
            this.KrgbGroupBox.Controls.Add(this.KgLabel);
            this.KrgbGroupBox.Controls.Add(this.BurkesButton);
            this.KrgbGroupBox.Controls.Add(this.KrLabel);
            this.KrgbGroupBox.Controls.Add(this.KbNumeric);
            this.KrgbGroupBox.Controls.Add(this.FloydButton);
            this.KrgbGroupBox.Controls.Add(this.KgNumeric);
            this.KrgbGroupBox.Controls.Add(this.KrNumeric);
            this.KrgbGroupBox.Location = new System.Drawing.Point(209, 3);
            this.KrgbGroupBox.Name = "KrgbGroupBox";
            this.KrgbGroupBox.Size = new System.Drawing.Size(200, 192);
            this.KrgbGroupBox.TabIndex = 2;
            this.KrgbGroupBox.TabStop = false;
            this.KrgbGroupBox.Text = "Error Diffusion Dithering";
            // 
            // KbLabel
            // 
            this.KbLabel.AutoSize = true;
            this.KbLabel.Location = new System.Drawing.Point(6, 75);
            this.KbLabel.Name = "KbLabel";
            this.KbLabel.Size = new System.Drawing.Size(23, 13);
            this.KbLabel.TabIndex = 5;
            this.KbLabel.Text = "Kb:";
            this.KbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KgLabel
            // 
            this.KgLabel.AutoSize = true;
            this.KgLabel.Location = new System.Drawing.Point(6, 49);
            this.KgLabel.Name = "KgLabel";
            this.KgLabel.Size = new System.Drawing.Size(23, 13);
            this.KgLabel.TabIndex = 4;
            this.KgLabel.Text = "Kg:";
            this.KgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KrLabel
            // 
            this.KrLabel.AutoSize = true;
            this.KrLabel.Location = new System.Drawing.Point(6, 22);
            this.KrLabel.Name = "KrLabel";
            this.KrLabel.Size = new System.Drawing.Size(20, 13);
            this.KrLabel.TabIndex = 3;
            this.KrLabel.Text = "Kr:";
            this.KrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KbNumeric
            // 
            this.KbNumeric.Location = new System.Drawing.Point(47, 73);
            this.KbNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KbNumeric.Name = "KbNumeric";
            this.KbNumeric.Size = new System.Drawing.Size(146, 20);
            this.KbNumeric.TabIndex = 2;
            this.KbNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KbNumeric.ValueChanged += new System.EventHandler(this.KbNumeric_ValueChanged);
            // 
            // KgNumeric
            // 
            this.KgNumeric.Location = new System.Drawing.Point(47, 47);
            this.KgNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KgNumeric.Name = "KgNumeric";
            this.KgNumeric.Size = new System.Drawing.Size(146, 20);
            this.KgNumeric.TabIndex = 1;
            this.KgNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KgNumeric.ValueChanged += new System.EventHandler(this.KgNumeric_ValueChanged);
            // 
            // KrNumeric
            // 
            this.KrNumeric.Location = new System.Drawing.Point(47, 20);
            this.KrNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KrNumeric.Name = "KrNumeric";
            this.KrNumeric.Size = new System.Drawing.Size(147, 20);
            this.KrNumeric.TabIndex = 0;
            this.KrNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KrNumeric.ValueChanged += new System.EventHandler(this.KrNumeric_ValueChanged);
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Controls.Add(this.PopularityButton);
            this.ButtonGroup.Controls.Add(this.KMeansButton);
            this.ButtonGroup.Location = new System.Drawing.Point(415, 3);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(158, 200);
            this.ButtonGroup.TabIndex = 4;
            this.ButtonGroup.TabStop = false;
            this.ButtonGroup.Text = "Methods";
            // 
            // StuckyButton
            // 
            this.StuckyButton.Location = new System.Drawing.Point(9, 157);
            this.StuckyButton.Name = "StuckyButton";
            this.StuckyButton.Size = new System.Drawing.Size(184, 23);
            this.StuckyButton.TabIndex = 7;
            this.StuckyButton.Text = "Stucky";
            this.StuckyButton.UseVisualStyleBackColor = true;
            this.StuckyButton.Click += new System.EventHandler(this.StuckyButton_Click);
            // 
            // PopularityButton
            // 
            this.PopularityButton.Location = new System.Drawing.Point(6, 49);
            this.PopularityButton.Name = "PopularityButton";
            this.PopularityButton.Size = new System.Drawing.Size(75, 23);
            this.PopularityButton.TabIndex = 2;
            this.PopularityButton.Text = "Popularity";
            this.PopularityButton.UseVisualStyleBackColor = true;
            this.PopularityButton.Click += new System.EventHandler(this.PopularityButton_Click);
            // 
            // BurkesButton
            // 
            this.BurkesButton.Location = new System.Drawing.Point(9, 128);
            this.BurkesButton.Name = "BurkesButton";
            this.BurkesButton.Size = new System.Drawing.Size(184, 23);
            this.BurkesButton.TabIndex = 6;
            this.BurkesButton.Text = "Burkes";
            this.BurkesButton.UseVisualStyleBackColor = true;
            this.BurkesButton.Click += new System.EventHandler(this.BurkesButton_Click);
            // 
            // KMeansButton
            // 
            this.KMeansButton.Location = new System.Drawing.Point(6, 19);
            this.KMeansButton.Name = "KMeansButton";
            this.KMeansButton.Size = new System.Drawing.Size(75, 23);
            this.KMeansButton.TabIndex = 0;
            this.KMeansButton.Text = "K-Means";
            this.KMeansButton.UseVisualStyleBackColor = true;
            // 
            // FloydButton
            // 
            this.FloydButton.Location = new System.Drawing.Point(9, 99);
            this.FloydButton.Name = "FloydButton";
            this.FloydButton.Size = new System.Drawing.Size(184, 23);
            this.FloydButton.TabIndex = 1;
            this.FloydButton.Text = "Floyd-Steinberg";
            this.FloydButton.UseVisualStyleBackColor = true;
            this.FloydButton.Click += new System.EventHandler(this.FloydButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DitheringOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularityOutput)).EndInit();
            this.InputLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageOutput)).EndInit();
            this.ControlsLayout.ResumeLayout(false);
            this.KGroupBox.ResumeLayout(false);
            this.KGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KNumeric)).EndInit();
            this.KrgbGroupBox.ResumeLayout(false);
            this.KrgbGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KbNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrNumeric)).EndInit();
            this.ButtonGroup.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox DitheringOutput;
        private System.Windows.Forms.PictureBox PopularityOutput;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.PictureBox SourceImageOutput;
        private System.Windows.Forms.FlowLayoutPanel ControlsLayout;
        private System.Windows.Forms.GroupBox KrgbGroupBox;
        private System.Windows.Forms.Label KbLabel;
        private System.Windows.Forms.Label KgLabel;
        private System.Windows.Forms.Label KrLabel;
        private System.Windows.Forms.NumericUpDown KbNumeric;
        private System.Windows.Forms.NumericUpDown KgNumeric;
        private System.Windows.Forms.NumericUpDown KrNumeric;
        private System.Windows.Forms.GroupBox KGroupBox;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.NumericUpDown KNumeric;
        private System.Windows.Forms.GroupBox ButtonGroup;
        private System.Windows.Forms.Button PopularityButton;
        private System.Windows.Forms.Button FloydButton;
        private System.Windows.Forms.Button KMeansButton;
        private System.Windows.Forms.Button BurkesButton;
        private System.Windows.Forms.Button StuckyButton;
    }
}

