namespace Racing
{
    partial class ChangeCar
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
            this.buClassic = new System.Windows.Forms.Button();
            this.buGreen = new System.Windows.Forms.Button();
            this.buNeon = new System.Windows.Forms.Button();
            this.buOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buClassic
            // 
            this.buClassic.BackColor = System.Drawing.Color.Transparent;
            this.buClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buClassic.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buClassic.ForeColor = System.Drawing.Color.Black;
            this.buClassic.Location = new System.Drawing.Point(12, 12);
            this.buClassic.Name = "buClassic";
            this.buClassic.Size = new System.Drawing.Size(148, 260);
            this.buClassic.TabIndex = 0;
            this.buClassic.UseVisualStyleBackColor = false;
            // 
            // buGreen
            // 
            this.buGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buGreen.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buGreen.ForeColor = System.Drawing.Color.Black;
            this.buGreen.Location = new System.Drawing.Point(166, 12);
            this.buGreen.Name = "buGreen";
            this.buGreen.Size = new System.Drawing.Size(148, 260);
            this.buGreen.TabIndex = 0;
            this.buGreen.UseVisualStyleBackColor = true;
            // 
            // buNeon
            // 
            this.buNeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buNeon.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buNeon.ForeColor = System.Drawing.Color.Black;
            this.buNeon.Location = new System.Drawing.Point(320, 12);
            this.buNeon.Name = "buNeon";
            this.buNeon.Size = new System.Drawing.Size(148, 260);
            this.buNeon.TabIndex = 0;
            this.buNeon.UseVisualStyleBackColor = true;
            // 
            // buOk
            // 
            this.buOk.BackColor = System.Drawing.Color.Red;
            this.buOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buOk.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buOk.ForeColor = System.Drawing.Color.Black;
            this.buOk.Location = new System.Drawing.Point(155, 297);
            this.buOk.Name = "buOk";
            this.buOk.Size = new System.Drawing.Size(168, 74);
            this.buOk.TabIndex = 0;
            this.buOk.Text = "OK";
            this.buOk.UseVisualStyleBackColor = false;
            // 
            // ChangeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(478, 388);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.buNeon);
            this.Controls.Add(this.buGreen);
            this.Controls.Add(this.buClassic);
            this.Name = "ChangeCar";
            this.Text = "CHOOSE CAR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buClassic;
        private System.Windows.Forms.Button buGreen;
        private System.Windows.Forms.Button buNeon;
        private System.Windows.Forms.Button buOk;
    }
}