namespace labGame
{
    partial class RegForm
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
            this.laPass = new System.Windows.Forms.Label();
            this.laUser = new System.Windows.Forms.Label();
            this.tePass = new System.Windows.Forms.TextBox();
            this.teUser = new System.Windows.Forms.TextBox();
            this.buReg = new System.Windows.Forms.Button();
            this.laConPass = new System.Windows.Forms.Label();
            this.teConPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // laPass
            // 
            this.laPass.AutoSize = true;
            this.laPass.Location = new System.Drawing.Point(195, 110);
            this.laPass.Name = "laPass";
            this.laPass.Size = new System.Drawing.Size(87, 20);
            this.laPass.TabIndex = 5;
            this.laPass.Text = "PASSWORD";
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Location = new System.Drawing.Point(196, 42);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(86, 20);
            this.laUser.TabIndex = 4;
            this.laUser.Text = "USERNAME";
            // 
            // tePass
            // 
            this.tePass.Location = new System.Drawing.Point(175, 133);
            this.tePass.Name = "tePass";
            this.tePass.Size = new System.Drawing.Size(125, 27);
            this.tePass.TabIndex = 3;
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(175, 65);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(125, 27);
            this.teUser.TabIndex = 2;
            // 
            // buReg
            // 
            this.buReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReg.Location = new System.Drawing.Point(191, 254);
            this.buReg.Name = "buReg";
            this.buReg.Size = new System.Drawing.Size(94, 29);
            this.buReg.TabIndex = 1;
            this.buReg.Text = "REGISTER";
            this.buReg.UseVisualStyleBackColor = true;
            // 
            // laConPass
            // 
            this.laConPass.AutoSize = true;
            this.laConPass.Location = new System.Drawing.Point(159, 176);
            this.laConPass.Name = "laConPass";
            this.laConPass.Size = new System.Drawing.Size(155, 20);
            this.laConPass.TabIndex = 5;
            this.laConPass.Text = "CONFIRM PASSWORD";
            // 
            // teConPass
            // 
            this.teConPass.Location = new System.Drawing.Point(175, 199);
            this.teConPass.Name = "teConPass";
            this.teConPass.Size = new System.Drawing.Size(125, 27);
            this.teConPass.TabIndex = 3;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 311);
            this.Controls.Add(this.teConPass);
            this.Controls.Add(this.laConPass);
            this.Controls.Add(this.buReg);
            this.Controls.Add(this.teUser);
            this.Controls.Add(this.tePass);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.laPass);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laPass;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.TextBox tePass;
        private System.Windows.Forms.TextBox teUser;
        private System.Windows.Forms.Button buReg;
        private System.Windows.Forms.Label laConPass;
        private System.Windows.Forms.TextBox teConPass;
    }
}