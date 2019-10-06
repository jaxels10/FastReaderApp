namespace JesperFormAppTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FontLabel = new System.Windows.Forms.Label();
            this.DisplayText = new System.Windows.Forms.Label();
            this.FontSizeSelector = new System.Windows.Forms.NumericUpDown();
            this.ClipBoardCopyButton = new System.Windows.Forms.Button();
            this.WPMLabel = new System.Windows.Forms.Label();
            this.WPMSelector = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPMSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(809, 25);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(49, 13);
            this.FontLabel.TabIndex = 1;
            this.FontLabel.Text = "Text size:";
            // 
            // DisplayText
            // 
            this.DisplayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DisplayText.Location = new System.Drawing.Point(12, 12);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(791, 182);
            this.DisplayText.TabIndex = 2;
            this.DisplayText.Text = "Copy something!";
            this.DisplayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSizeSelector
            // 
            this.FontSizeSelector.Location = new System.Drawing.Point(864, 23);
            this.FontSizeSelector.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.FontSizeSelector.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FontSizeSelector.Name = "FontSizeSelector";
            this.FontSizeSelector.Size = new System.Drawing.Size(60, 20);
            this.FontSizeSelector.TabIndex = 3;
            this.FontSizeSelector.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.FontSizeSelector.ValueChanged += new System.EventHandler(this.FontSizeSelector_ValueChanged);
            // 
            // ClipBoardCopyButton
            // 
            this.ClipBoardCopyButton.Location = new System.Drawing.Point(800, 105);
            this.ClipBoardCopyButton.Name = "ClipBoardCopyButton";
            this.ClipBoardCopyButton.Size = new System.Drawing.Size(124, 44);
            this.ClipBoardCopyButton.TabIndex = 4;
            this.ClipBoardCopyButton.Text = "Copy from clipboard!";
            this.ClipBoardCopyButton.UseVisualStyleBackColor = true;
            this.ClipBoardCopyButton.Click += new System.EventHandler(this.ClipBoardCopyButton_Click);
            // 
            // WPMLabel
            // 
            this.WPMLabel.AutoSize = true;
            this.WPMLabel.Location = new System.Drawing.Point(768, 61);
            this.WPMLabel.Name = "WPMLabel";
            this.WPMLabel.Size = new System.Drawing.Size(90, 13);
            this.WPMLabel.TabIndex = 5;
            this.WPMLabel.Text = "Words per minute";
            // 
            // WPMSelector
            // 
            this.WPMSelector.Location = new System.Drawing.Point(864, 61);
            this.WPMSelector.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.WPMSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WPMSelector.Name = "WPMSelector";
            this.WPMSelector.Size = new System.Drawing.Size(60, 20);
            this.WPMSelector.TabIndex = 6;
            this.WPMSelector.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WPMSelector.ValueChanged += new System.EventHandler(this.WPMSelector_ValueChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(800, 155);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(124, 44);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start reading!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 211);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.WPMSelector);
            this.Controls.Add(this.WPMLabel);
            this.Controls.Add(this.ClipBoardCopyButton);
            this.Controls.Add(this.FontSizeSelector);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.FontLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPMSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label DisplayText;
        private System.Windows.Forms.NumericUpDown FontSizeSelector;
        private System.Windows.Forms.Button ClipBoardCopyButton;
        private System.Windows.Forms.Label WPMLabel;
        private System.Windows.Forms.NumericUpDown WPMSelector;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
    }
}

