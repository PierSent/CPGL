namespace lab15
{
    partial class Game15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teLenght = new System.Windows.Forms.TextBox();
            this.teLvl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buStart
            // 
            this.buStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buStart.BackColor = System.Drawing.Color.SpringGreen;
            this.buStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStart.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buStart.Location = new System.Drawing.Point(32, 150);
            this.buStart.Name = "buStart";
            this.buStart.Size = new System.Drawing.Size(142, 49);
            this.buStart.TabIndex = 0;
            this.buStart.Text = "НАЧАТЬ";
            this.buStart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сторона квадрата:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уровень сложности:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teLenght
            // 
            this.teLenght.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teLenght.Location = new System.Drawing.Point(32, 47);
            this.teLenght.Name = "teLenght";
            this.teLenght.Size = new System.Drawing.Size(142, 23);
            this.teLenght.TabIndex = 3;
            this.teLenght.Text = "4";
            this.teLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teLvl
            // 
            this.teLvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teLvl.Location = new System.Drawing.Point(32, 95);
            this.teLvl.Name = "teLvl";
            this.teLvl.Size = new System.Drawing.Size(142, 23);
            this.teLvl.TabIndex = 4;
            this.teLvl.Text = "50";
            this.teLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(208, 230);
            this.Controls.Add(this.teLvl);
            this.Controls.Add(this.teLenght);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buStart);
            this.MinimumSize = new System.Drawing.Size(224, 269);
            this.Name = "StartDialog";
            this.Text = "15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teLenght;
        private System.Windows.Forms.TextBox teLvl;
    }
}