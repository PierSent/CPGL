namespace Racing
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.laCoinSum = new System.Windows.Forms.Label();
            this.laFinalDist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laCoinSum
            // 
            this.laCoinSum.AutoSize = true;
            this.laCoinSum.BackColor = System.Drawing.Color.Transparent;
            this.laCoinSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laCoinSum.ForeColor = System.Drawing.Color.Red;
            this.laCoinSum.Location = new System.Drawing.Point(12, 9);
            this.laCoinSum.Name = "laCoinSum";
            this.laCoinSum.Size = new System.Drawing.Size(78, 24);
            this.laCoinSum.TabIndex = 0;
            this.laCoinSum.Text = "Coins: 0";
            // 
            // laFinalDist
            // 
            this.laFinalDist.BackColor = System.Drawing.Color.Transparent;
            this.laFinalDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laFinalDist.ForeColor = System.Drawing.Color.Red;
            this.laFinalDist.Location = new System.Drawing.Point(12, 30);
            this.laFinalDist.Name = "laFinalDist";
            this.laFinalDist.Size = new System.Drawing.Size(480, 34);
            this.laFinalDist.TabIndex = 1;
            this.laFinalDist.Text = "0 m";
            this.laFinalDist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.laFinalDist.Click += new System.EventHandler(this.laFinalDist_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 659);
            this.Controls.Add(this.laFinalDist);
            this.Controls.Add(this.laCoinSum);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(520, 698);
            this.MinimumSize = new System.Drawing.Size(520, 698);
            this.Name = "Game";
            this.Text = "RACING";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label laCoinSum;
        private System.Windows.Forms.Label laFinalDist;
    }
}

