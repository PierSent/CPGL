namespace labGame
{
    partial class SettingsForm
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
            this.chMusic = new System.Windows.Forms.CheckBox();
            this.laUserName = new System.Windows.Forms.Label();
            this.piAva = new System.Windows.Forms.PictureBox();
            this.chTheme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.piAva)).BeginInit();
            this.SuspendLayout();
            // 
            // chMusic
            // 
            this.chMusic.AutoSize = true;
            this.chMusic.Location = new System.Drawing.Point(235, 149);
            this.chMusic.Name = "chMusic";
            this.chMusic.Size = new System.Drawing.Size(69, 24);
            this.chMusic.TabIndex = 0;
            this.chMusic.Text = "Music";
            this.chMusic.UseVisualStyleBackColor = true;
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Location = new System.Drawing.Point(235, 77);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(50, 20);
            this.laUserName.TabIndex = 1;
            this.laUserName.Text = "label1";
            // 
            // piAva
            // 
            this.piAva.BackColor = System.Drawing.SystemColors.Control;
            this.piAva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piAva.Location = new System.Drawing.Point(46, 61);
            this.piAva.Name = "piAva";
            this.piAva.Size = new System.Drawing.Size(138, 142);
            this.piAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piAva.TabIndex = 2;
            this.piAva.TabStop = false;
            // 
            // chTheme
            // 
            this.chTheme.AutoSize = true;
            this.chTheme.Location = new System.Drawing.Point(235, 188);
            this.chTheme.Name = "chTheme";
            this.chTheme.Size = new System.Drawing.Size(108, 24);
            this.chTheme.TabIndex = 3;
            this.chTheme.Text = "Dark theme";
            this.chTheme.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 459);
            this.Controls.Add(this.chTheme);
            this.Controls.Add(this.piAva);
            this.Controls.Add(this.laUserName);
            this.Controls.Add(this.chMusic);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.piAva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chMusic;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.PictureBox piAva;
        private System.Windows.Forms.CheckBox chTheme;
    }
}