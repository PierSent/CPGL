namespace labGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.start_button = new System.Windows.Forms.Button();
            this.finish_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buTicTacToe = new System.Windows.Forms.Button();
            this.buFindFigure = new System.Windows.Forms.Button();
            this.buRacing = new System.Windows.Forms.Button();
            this.bu15 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Transparent;
            this.start_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_button.BackgroundImage")));
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_button.ForeColor = System.Drawing.Color.White;
            this.start_button.Location = new System.Drawing.Point(62, 139);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(89, 83);
            this.start_button.TabIndex = 0;
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // finish_button
            // 
            this.finish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finish_button.ForeColor = System.Drawing.Color.DimGray;
            this.finish_button.Location = new System.Drawing.Point(589, 15);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(35, 36);
            this.finish_button.TabIndex = 0;
            this.finish_button.Text = "Х";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сыграем?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(51, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Virus Game";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(207, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 83);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SudokuGame);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(207, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sudoku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(354, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Match";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(341, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 83);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buTicTacToe
            // 
            this.buTicTacToe.BackColor = System.Drawing.Color.White;
            this.buTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buTicTacToe.ForeColor = System.Drawing.Color.Black;
            this.buTicTacToe.Location = new System.Drawing.Point(488, 140);
            this.buTicTacToe.Name = "buTicTacToe";
            this.buTicTacToe.Size = new System.Drawing.Size(94, 83);
            this.buTicTacToe.TabIndex = 7;
            this.buTicTacToe.UseVisualStyleBackColor = false;
            // 
            // buFindFigure
            // 
            this.buFindFigure.BackColor = System.Drawing.Color.White;
            this.buFindFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buFindFigure.ForeColor = System.Drawing.Color.Black;
            this.buFindFigure.Location = new System.Drawing.Point(62, 301);
            this.buFindFigure.Name = "buFindFigure";
            this.buFindFigure.Size = new System.Drawing.Size(94, 83);
            this.buFindFigure.TabIndex = 7;
            this.buFindFigure.UseVisualStyleBackColor = false;
            // 
            // buRacing
            // 
            this.buRacing.BackColor = System.Drawing.Color.White;
            this.buRacing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buRacing.ForeColor = System.Drawing.Color.Black;
            this.buRacing.Location = new System.Drawing.Point(207, 301);
            this.buRacing.Name = "buRacing";
            this.buRacing.Size = new System.Drawing.Size(94, 83);
            this.buRacing.TabIndex = 7;
            this.buRacing.UseVisualStyleBackColor = false;
            // 
            // bu15
            // 
            this.bu15.BackColor = System.Drawing.Color.White;
            this.bu15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bu15.ForeColor = System.Drawing.Color.Black;
            this.bu15.Location = new System.Drawing.Point(341, 301);
            this.bu15.Name = "bu15";
            this.bu15.Size = new System.Drawing.Size(94, 83);
            this.bu15.TabIndex = 7;
            this.bu15.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(480, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tic Tac Toe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(55, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Find Figure";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(218, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Racing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(372, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "15";
            // 
            // buSettings
            // 
            this.buSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buSettings.ForeColor = System.Drawing.Color.Black;
            this.buSettings.Location = new System.Drawing.Point(515, 533);
            this.buSettings.Name = "buSettings";
            this.buSettings.Size = new System.Drawing.Size(94, 79);
            this.buSettings.TabIndex = 8;
            this.buSettings.Text = "Settings";
            this.buSettings.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(638, 640);
            this.Controls.Add(this.buSettings);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bu15);
            this.Controls.Add(this.buRacing);
            this.Controls.Add(this.buFindFigure);
            this.Controls.Add(this.buTicTacToe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.start_button);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Figure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buTicTacToe;
        private System.Windows.Forms.Button buFindFigure;
        private System.Windows.Forms.Button buRacing;
        private System.Windows.Forms.Button bu15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buSettings;
    }
}

