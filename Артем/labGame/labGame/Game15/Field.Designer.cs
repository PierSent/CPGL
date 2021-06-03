namespace lab15
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
            this.taGrid = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // taGrid
            // 
            this.taGrid.BackColor = System.Drawing.SystemColors.Window;
            this.taGrid.ColumnCount = 1;
            this.taGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.taGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taGrid.Location = new System.Drawing.Point(0, 0);
            this.taGrid.Name = "taGrid";
            this.taGrid.RowCount = 1;
            this.taGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.taGrid.Size = new System.Drawing.Size(456, 425);
            this.taGrid.TabIndex = 0;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 425);
            this.Controls.Add(this.taGrid);
            this.MinimumSize = new System.Drawing.Size(472, 464);
            this.Name = "Field";
            this.Text = "Кол-во шагов: 0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel taGrid;
    }
}

