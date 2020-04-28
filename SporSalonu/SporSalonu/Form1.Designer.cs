namespace SporSalonu
{
    partial class Form1
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
            this.girisLbl = new System.Windows.Forms.Label();
            this.eMailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.remindMeChck = new System.Windows.Forms.CheckBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisLbl
            // 
            this.girisLbl.AutoSize = true;
            this.girisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisLbl.Location = new System.Drawing.Point(222, 73);
            this.girisLbl.Name = "girisLbl";
            this.girisLbl.Size = new System.Drawing.Size(162, 32);
            this.girisLbl.TabIndex = 0;
            this.girisLbl.Text = "Giriş Ekranı";
            // 
            // eMailLbl
            // 
            this.eMailLbl.AutoSize = true;
            this.eMailLbl.Location = new System.Drawing.Point(147, 158);
            this.eMailLbl.Name = "eMailLbl";
            this.eMailLbl.Size = new System.Drawing.Size(46, 17);
            this.eMailLbl.TabIndex = 1;
            this.eMailLbl.Text = "E Mail";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(156, 189);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(37, 17);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Şifre";
            // 
            // remindMeChck
            // 
            this.remindMeChck.AutoSize = true;
            this.remindMeChck.Location = new System.Drawing.Point(228, 226);
            this.remindMeChck.Name = "remindMeChck";
            this.remindMeChck.Size = new System.Drawing.Size(101, 21);
            this.remindMeChck.TabIndex = 3;
            this.remindMeChck.Text = "Beni hatırla";
            this.remindMeChck.UseVisualStyleBackColor = true;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(228, 155);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(321, 22);
            this.eMailTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(228, 186);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(321, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(474, 224);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "Giriş";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(381, 224);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "Kaydol";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 413);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.remindMeChck);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.eMailLbl);
            this.Controls.Add(this.girisLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girisLbl;
        private System.Windows.Forms.Label eMailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.CheckBox remindMeChck;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button signUpBtn;
    }
}

