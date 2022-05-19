
namespace PresentationLayer
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_loginNavigate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_displayUserName = new System.Windows.Forms.TextBox();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_confirmPasssword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Already have a account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_loginNavigate
            // 
            this.btn_loginNavigate.Location = new System.Drawing.Point(185, 304);
            this.btn_loginNavigate.Name = "btn_loginNavigate";
            this.btn_loginNavigate.Size = new System.Drawing.Size(236, 25);
            this.btn_loginNavigate.TabIndex = 85;
            this.btn_loginNavigate.Text = "I WANT TO LOGIN...";
            this.btn_loginNavigate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loginNavigate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(26, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 2);
            this.label3.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(107, 227);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(152, 25);
            this.btn_register.TabIndex = 79;
            this.btn_register.Text = "Register";
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(269, 227);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(152, 25);
            this.btn_cancel.TabIndex = 78;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_displayUserName
            // 
            this.txt_displayUserName.Location = new System.Drawing.Point(107, 92);
            this.txt_displayUserName.Multiline = true;
            this.txt_displayUserName.Name = "txt_displayUserName";
            this.txt_displayUserName.Size = new System.Drawing.Size(314, 22);
            this.txt_displayUserName.TabIndex = 77;
            // 
            // pic_avatar
            // 
            this.pic_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pic_avatar.Image")));
            this.pic_avatar.Location = new System.Drawing.Point(26, 12);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(345, 75);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 83;
            this.pic_avatar.TabStop = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(107, 148);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(314, 22);
            this.txt_password.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Account Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(107, 120);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(314, 22);
            this.txt_username.TabIndex = 90;
            // 
            // txt_confirmPasssword
            // 
            this.txt_confirmPasssword.Location = new System.Drawing.Point(107, 182);
            this.txt_confirmPasssword.Multiline = true;
            this.txt_confirmPasssword.Name = "txt_confirmPasssword";
            this.txt_confirmPasssword.Size = new System.Drawing.Size(314, 22);
            this.txt_confirmPasssword.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Confirm Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 341);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_confirmPasssword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_loginNavigate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_avatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_displayUserName);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_loginNavigate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_displayUserName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_confirmPasssword;
        private System.Windows.Forms.Label label5;
    }
}