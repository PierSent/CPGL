namespace labGame
{
    partial class FindFigure
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
            this.buStart = new System.Windows.Forms.Button();
            this.laScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buStart
            // 
            this.buStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.buStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buStart.Location = new System.Drawing.Point(134, 169);
            this.buStart.Name = "buStart";
            this.buStart.Size = new System.Drawing.Size(123, 29);
            this.buStart.TabIndex = 0;
            this.buStart.Text = "FIND FIGURE";
            this.buStart.UseVisualStyleBackColor = false;
            // 
            // laScore
            // 
            this.laScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.laScore.Location = new System.Drawing.Point(12, 9);
            this.laScore.Name = "laScore";
            this.laScore.Size = new System.Drawing.Size(358, 157);
            this.laScore.TabIndex = 1;
            this.laScore.Text = "label1";
            this.laScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(382, 230);
            this.Controls.Add(this.laScore);
            this.Controls.Add(this.buStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buStart;
        private System.Windows.Forms.Label laScore;
    }
}