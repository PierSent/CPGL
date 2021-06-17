namespace labGame
{
    partial class LoginForm
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
            this.buLogin = new System.Windows.Forms.Button();
            this.buReg = new System.Windows.Forms.Button();
            this.teUser = new System.Windows.Forms.TextBox();
            this.tePass = new System.Windows.Forms.TextBox();
            this.laUser = new System.Windows.Forms.Label();
            this.laPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buLogin
            // 
            this.buLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buLogin.Location = new System.Drawing.Point(207, 235);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(94, 29);
            this.buLogin.TabIndex = 0;
            this.buLogin.Text = "Login";
            this.buLogin.UseVisualStyleBackColor = true;
            // 
            // buReg
            // 
            this.buReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buReg.Location = new System.Drawing.Point(207, 281);
            this.buReg.Name = "buReg";
            this.buReg.Size = new System.Drawing.Size(94, 29);
            this.buReg.TabIndex = 1;
            this.buReg.Text = "REGISTER";
            this.buReg.UseVisualStyleBackColor = true;
            // 
            // teUser
            // 
            this.teUser.Location = new System.Drawing.Point(191, 116);
            this.teUser.Name = "teUser";
            this.teUser.Size = new System.Drawing.Size(125, 27);
            this.teUser.TabIndex = 2;
            // 
            // tePass
            // 
            this.tePass.Location = new System.Drawing.Point(191, 184);
            this.tePass.Name = "tePass";
            this.tePass.Size = new System.Drawing.Size(125, 27);
            this.tePass.TabIndex = 3;
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Location = new System.Drawing.Point(212, 93);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(86, 20);
            this.laUser.TabIndex = 4;
            this.laUser.Text = "USERNAME";
            // 
            // laPass
            // 
            this.laPass.AutoSize = true;
            this.laPass.Location = new System.Drawing.Point(211, 161);
            this.laPass.Name = "laPass";
            this.laPass.Size = new System.Drawing.Size(87, 20);
            this.laPass.TabIndex = 5;
            this.laPass.Text = "PASSWORD";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 392);
            this.Controls.Add(this.laPass);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.tePass);
            this.Controls.Add(this.teUser);
            this.Controls.Add(this.buReg);
            this.Controls.Add(this.buLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buLogin;
        private System.Windows.Forms.Button buReg;
        private System.Windows.Forms.TextBox teUser;
        private System.Windows.Forms.TextBox tePass;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laPass;
    }
}