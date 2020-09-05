namespace VisualProgrammingProject
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
            this.playBttn = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.highScoresBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameRequiredError = new System.Windows.Forms.Label();
            this.MillionaireLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MillionaireLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playBttn
            // 
            this.playBttn.Location = new System.Drawing.Point(346, 342);
            this.playBttn.Margin = new System.Windows.Forms.Padding(2);
            this.playBttn.Name = "playBttn";
            this.playBttn.Size = new System.Drawing.Size(279, 30);
            this.playBttn.TabIndex = 1;
            this.playBttn.Text = "Play";
            this.playBttn.UseVisualStyleBackColor = true;
            this.playBttn.Click += new System.EventHandler(this.PlayBttn_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(346, 286);
            this.inputName.Margin = new System.Windows.Forms.Padding(2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(280, 20);
            this.inputName.TabIndex = 2;
            this.inputName.Text = "Guest";
            this.inputName.TextChanged += new System.EventHandler(this.InputName_TextChanged);
            // 
            // highScoresBttn
            // 
            this.highScoresBttn.Location = new System.Drawing.Point(346, 376);
            this.highScoresBttn.Margin = new System.Windows.Forms.Padding(2);
            this.highScoresBttn.Name = "highScoresBttn";
            this.highScoresBttn.Size = new System.Drawing.Size(279, 30);
            this.highScoresBttn.TabIndex = 3;
            this.highScoresBttn.Text = "High Scores";
            this.highScoresBttn.UseVisualStyleBackColor = true;
            this.highScoresBttn.Click += new System.EventHandler(this.HighScoresBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(346, 410);
            this.exitBttn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(279, 26);
            this.exitBttn.TabIndex = 4;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(343, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // nameRequiredError
            // 
            this.nameRequiredError.AutoSize = true;
            this.nameRequiredError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameRequiredError.ForeColor = System.Drawing.Color.Red;
            this.nameRequiredError.Location = new System.Drawing.Point(343, 308);
            this.nameRequiredError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameRequiredError.Name = "nameRequiredError";
            this.nameRequiredError.Size = new System.Drawing.Size(76, 13);
            this.nameRequiredError.TabIndex = 6;
            this.nameRequiredError.Text = "Name required";
            this.nameRequiredError.Visible = false;
            // 
            // MillionaireLogo
            // 
            this.MillionaireLogo.Image = global::VisualProgrammingProject.Properties.Resources.imagesCAG5P2IF;
            this.MillionaireLogo.Location = new System.Drawing.Point(314, 50);
            this.MillionaireLogo.Margin = new System.Windows.Forms.Padding(2);
            this.MillionaireLogo.Name = "MillionaireLogo";
            this.MillionaireLogo.Size = new System.Drawing.Size(347, 199);
            this.MillionaireLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MillionaireLogo.TabIndex = 23;
            this.MillionaireLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(9, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 622);
            this.Controls.Add(this.MillionaireLogo);
            this.Controls.Add(this.nameRequiredError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.highScoresBttn);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.playBttn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MillionaireLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playBttn;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button highScoresBttn;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameRequiredError;
        private System.Windows.Forms.PictureBox MillionaireLogo;
    }
}

