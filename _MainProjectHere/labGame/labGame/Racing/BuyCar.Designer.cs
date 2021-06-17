namespace Racing
{
    partial class BuyCar
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
            this.buBuy = new System.Windows.Forms.Button();
            this.buNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buBuy
            // 
            this.buBuy.BackColor = System.Drawing.Color.Red;
            this.buBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buBuy.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buBuy.Location = new System.Drawing.Point(12, 144);
            this.buBuy.Name = "buBuy";
            this.buBuy.Size = new System.Drawing.Size(240, 74);
            this.buBuy.TabIndex = 0;
            this.buBuy.Text = "BUY";
            this.buBuy.UseVisualStyleBackColor = false;
            // 
            // buNo
            // 
            this.buNo.BackColor = System.Drawing.Color.Red;
            this.buNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNo.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buNo.Location = new System.Drawing.Point(258, 144);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(240, 74);
            this.buNo.TabIndex = 0;
            this.buNo.Text = "NO, THANKS";
            this.buNo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do You want to buy?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buNo);
            this.Controls.Add(this.buBuy);
            this.Name = "BuyCar";
            this.Text = "BuyCar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buBuy;
        private System.Windows.Forms.Button buNo;
        private System.Windows.Forms.Label label1;
    }
}