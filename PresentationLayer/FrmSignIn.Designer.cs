
namespace PresentationLayer
{
    partial class FrmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignIn));
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_navigateRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(109, 85);
            this.txt_userName.Multiline = true;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(314, 22);
            this.txt_userName.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(271, 154);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(152, 25);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(109, 154);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(152, 25);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(109, 113);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(314, 22);
            this.txt_password.TabIndex = 5;
            // 
            // pic_avatar
            // 
            this.pic_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pic_avatar.Image")));
            this.pic_avatar.Location = new System.Drawing.Point(28, 5);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(273, 75);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 71;
            this.pic_avatar.TabStop = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(28, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 2);
            this.label3.TabIndex = 72;
            // 
            // btn_navigateRegister
            // 
            this.btn_navigateRegister.Location = new System.Drawing.Point(187, 206);
            this.btn_navigateRegister.Name = "btn_navigateRegister";
            this.btn_navigateRegister.Size = new System.Drawing.Size(236, 25);
            this.btn_navigateRegister.TabIndex = 74;
            this.btn_navigateRegister.Text = "CREATE A NEW ACCOUNT...";
            this.btn_navigateRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navigateRegister.UseVisualStyleBackColor = true;
            this.btn_navigateRegister.Click += new System.EventHandler(this.btn_navigateRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Dont have a user account?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 294);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_navigateRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_avatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_userName);
            this.Name = "FrmSignIn";
            this.Text = "Food Warehouse Login";
            this.Load += new System.EventHandler(this.FrmSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_navigateRegister;
        private System.Windows.Forms.Label label5;
    }
}