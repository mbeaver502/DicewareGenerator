namespace DicewareGenerator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.nudNumWords = new System.Windows.Forms.NumericUpDown();
            this.grpCase = new System.Windows.Forms.GroupBox();
            this.rbUpper = new System.Windows.Forms.RadioButton();
            this.rbLower = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cbDelimiters = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumWords)).BeginInit();
            this.grpCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblDelimiter);
            this.grpOptions.Controls.Add(this.cbDelimiters);
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.grpCase);
            this.grpOptions.Controls.Add(this.nudNumWords);
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(217, 108);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = " Options ";
            // 
            // nudNumWords
            // 
            this.nudNumWords.Location = new System.Drawing.Point(120, 32);
            this.nudNumWords.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumWords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumWords.Name = "nudNumWords";
            this.nudNumWords.Size = new System.Drawing.Size(87, 20);
            this.nudNumWords.TabIndex = 2;
            this.nudNumWords.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudNumWords.ValueChanged += new System.EventHandler(this.nudNumWords_ValueChanged);
            // 
            // grpCase
            // 
            this.grpCase.Controls.Add(this.rbLower);
            this.grpCase.Controls.Add(this.rbUpper);
            this.grpCase.Location = new System.Drawing.Point(6, 19);
            this.grpCase.Name = "grpCase";
            this.grpCase.Size = new System.Drawing.Size(94, 83);
            this.grpCase.TabIndex = 2;
            this.grpCase.TabStop = false;
            this.grpCase.Text = " Case ";
            // 
            // rbUpper
            // 
            this.rbUpper.AutoSize = true;
            this.rbUpper.Checked = true;
            this.rbUpper.Location = new System.Drawing.Point(6, 23);
            this.rbUpper.Name = "rbUpper";
            this.rbUpper.Size = new System.Drawing.Size(77, 17);
            this.rbUpper.TabIndex = 3;
            this.rbUpper.TabStop = true;
            this.rbUpper.Text = "Uppercase";
            this.rbUpper.UseVisualStyleBackColor = true;
            this.rbUpper.CheckedChanged += new System.EventHandler(this.rbUpper_CheckedChanged);
            // 
            // rbLower
            // 
            this.rbLower.AutoSize = true;
            this.rbLower.Location = new System.Drawing.Point(7, 52);
            this.rbLower.Name = "rbLower";
            this.rbLower.Size = new System.Drawing.Size(77, 17);
            this.rbLower.TabIndex = 4;
            this.rbLower.TabStop = true;
            this.rbLower.Text = "Lowercase";
            this.rbLower.UseVisualStyleBackColor = true;
            this.rbLower.CheckedChanged += new System.EventHandler(this.rbLower_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(60, 126);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(258, 20);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.WordWrap = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(235, 22);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(83, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(235, 51);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(83, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(235, 80);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cbDelimiters
            // 
            this.cbDelimiters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDelimiters.FormattingEnabled = true;
            this.cbDelimiters.Items.AddRange(new object[] {
            "Space",
            "_",
            "~",
            "/",
            "\\",
            "^"});
            this.cbDelimiters.Location = new System.Drawing.Point(120, 77);
            this.cbDelimiters.MaxLength = 1;
            this.cbDelimiters.Name = "cbDelimiters";
            this.cbDelimiters.Size = new System.Drawing.Size(87, 21);
            this.cbDelimiters.TabIndex = 4;
            this.cbDelimiters.SelectedIndexChanged += new System.EventHandler(this.cbDelimiters_SelectedIndexChanged);
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(117, 61);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(50, 13);
            this.lblDelimiter.TabIndex = 5;
            this.lblDelimiter.Text = "Delimiter:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 161);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diceware Passphrase Generator v0.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumWords)).EndInit();
            this.grpCase.ResumeLayout(false);
            this.grpCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCase;
        private System.Windows.Forms.RadioButton rbLower;
        private System.Windows.Forms.RadioButton rbUpper;
        private System.Windows.Forms.NumericUpDown nudNumWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbDelimiters;
        private System.Windows.Forms.Label lblDelimiter;
    }
}

