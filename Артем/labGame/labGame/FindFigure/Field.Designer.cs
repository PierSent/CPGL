namespace labGame
{
    partial class Field
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
            this.taGrid = new System.Windows.Forms.TableLayoutPanel();
            this.laTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.laScore = new System.Windows.Forms.Label();
            this.laTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taGrid
            // 
            this.taGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taGrid.ColumnCount = 1;
            this.taGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.taGrid.Location = new System.Drawing.Point(319, 92);
            this.taGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taGrid.Name = "taGrid";
            this.taGrid.RowCount = 1;
            this.taGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.taGrid.Size = new System.Drawing.Size(750, 724);
            this.taGrid.TabIndex = 0;
            // 
            // laTimer
            // 
            this.laTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laTimer.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.laTimer.Location = new System.Drawing.Point(319, 1);
            this.laTimer.Name = "laTimer";
            this.laTimer.Size = new System.Drawing.Size(750, 87);
            this.laTimer.TabIndex = 1;
            this.laTimer.Text = "00:00";
            this.laTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // laScore
            // 
            this.laScore.AutoSize = true;
            this.laScore.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.laScore.Location = new System.Drawing.Point(14, 1);
            this.laScore.Name = "laScore";
            this.laScore.Size = new System.Drawing.Size(122, 57);
            this.laScore.TabIndex = 1;
            this.laScore.Text = "00:00";
            // 
            // laTry
            // 
            this.laTry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.laTry.AutoSize = true;
            this.laTry.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.laTry.Location = new System.Drawing.Point(1089, 1);
            this.laTry.Name = "laTry";
            this.laTry.Size = new System.Drawing.Size(366, 57);
            this.laTry.TabIndex = 1;
            this.laTry.Text = "Кол-во попыток: 2";
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1425, 832);
            this.Controls.Add(this.laTry);
            this.Controls.Add(this.laScore);
            this.Controls.Add(this.laTimer);
            this.Controls.Add(this.taGrid);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Field";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel taGrid;
        private System.Windows.Forms.Label laTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label laScore;
        private System.Windows.Forms.Label laTry;
    }
}

