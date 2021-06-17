namespace Racing
{
    partial class RacingMenu
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
            this.laHead = new System.Windows.Forms.Label();
            this.laScore = new System.Windows.Forms.Label();
            this.laCoins = new System.Windows.Forms.Label();
            this.buCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buStart
            // 
            this.buStart.BackColor = System.Drawing.Color.Red;
            this.buStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStart.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buStart.ForeColor = System.Drawing.Color.Black;
            this.buStart.Location = new System.Drawing.Point(121, 205);
            this.buStart.Name = "buStart";
            this.buStart.Size = new System.Drawing.Size(168, 74);
            this.buStart.TabIndex = 0;
            this.buStart.Text = "START";
            this.buStart.UseVisualStyleBackColor = false;
            // 
            // laHead
            // 
            this.laHead.BackColor = System.Drawing.Color.Transparent;
            this.laHead.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.laHead.ForeColor = System.Drawing.Color.Red;
            this.laHead.Location = new System.Drawing.Point(28, 9);
            this.laHead.Name = "laHead";
            this.laHead.Size = new System.Drawing.Size(378, 61);
            this.laHead.TabIndex = 1;
            this.laHead.Text = "LET\'S RACE";
            this.laHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laScore
            // 
            this.laScore.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laScore.ForeColor = System.Drawing.Color.White;
            this.laScore.Location = new System.Drawing.Point(12, 107);
            this.laScore.Name = "laScore";
            this.laScore.Size = new System.Drawing.Size(394, 23);
            this.laScore.TabIndex = 2;
            this.laScore.Text = "Last score: 1023 m";
            this.laScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCoins
            // 
            this.laCoins.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laCoins.ForeColor = System.Drawing.Color.White;
            this.laCoins.Location = new System.Drawing.Point(12, 132);
            this.laCoins.Name = "laCoins";
            this.laCoins.Size = new System.Drawing.Size(394, 23);
            this.laCoins.TabIndex = 2;
            this.laCoins.Text = "Coins: 345";
            this.laCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buCar
            // 
            this.buCar.BackColor = System.Drawing.Color.Red;
            this.buCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buCar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buCar.Location = new System.Drawing.Point(319, 205);
            this.buCar.Name = "buCar";
            this.buCar.Size = new System.Drawing.Size(74, 74);
            this.buCar.TabIndex = 3;
            this.buCar.Text = "🚗";
            this.buCar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buCar.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(418, 305);
            this.Controls.Add(this.buCar);
            this.Controls.Add(this.laCoins);
            this.Controls.Add(this.laScore);
            this.Controls.Add(this.laHead);
            this.Controls.Add(this.buStart);
            this.MaximumSize = new System.Drawing.Size(434, 344);
            this.MinimumSize = new System.Drawing.Size(434, 344);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buStart;
        private System.Windows.Forms.Label laHead;
        private System.Windows.Forms.Label laScore;
        private System.Windows.Forms.Label laCoins;
        private System.Windows.Forms.Button buCar;
    }
}