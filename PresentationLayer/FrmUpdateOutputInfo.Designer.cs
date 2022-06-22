namespace PresentationLayer
{
    partial class FrmUpdateOutputInfo
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_StatusOutput = new System.Windows.Forms.TextBox();
            this.txt_OutputPrice = new System.Windows.Forms.TextBox();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.btn_OutputSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CountOutput = new System.Windows.Forms.TextBox();
            this.txt_IdCustomer = new System.Windows.Forms.TextBox();
            this.txt_IdInputInfo = new System.Windows.Forms.TextBox();
            this.txt_IdOutput = new System.Windows.Forms.TextBox();
            this.txt_IdFood = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "StatusOutput";
            // 
            // txt_StatusOutput
            // 
            this.txt_StatusOutput.Location = new System.Drawing.Point(97, 208);
            this.txt_StatusOutput.Multiline = true;
            this.txt_StatusOutput.Name = "txt_StatusOutput";
            this.txt_StatusOutput.Size = new System.Drawing.Size(271, 24);
            this.txt_StatusOutput.TabIndex = 15;
            // 
            // txt_OutputPrice
            // 
            this.txt_OutputPrice.Location = new System.Drawing.Point(97, 178);
            this.txt_OutputPrice.Multiline = true;
            this.txt_OutputPrice.Name = "txt_OutputPrice";
            this.txt_OutputPrice.Size = new System.Drawing.Size(271, 24);
            this.txt_OutputPrice.TabIndex = 14;
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.Location = new System.Drawing.Point(6, 285);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(362, 23);
            this.btn_CloseFrm.TabIndex = 13;
            this.btn_CloseFrm.Text = "Cancel";
            this.btn_CloseFrm.UseVisualStyleBackColor = true;
            this.btn_CloseFrm.Click += new System.EventHandler(this.btn_CloseFrm_Click);
            // 
            // btn_OutputSave
            // 
            this.btn_OutputSave.Location = new System.Drawing.Point(6, 256);
            this.btn_OutputSave.Name = "btn_OutputSave";
            this.btn_OutputSave.Size = new System.Drawing.Size(362, 23);
            this.btn_OutputSave.TabIndex = 12;
            this.btn_OutputSave.Text = "Save";
            this.btn_OutputSave.UseVisualStyleBackColor = true;
            this.btn_OutputSave.Click += new System.EventHandler(this.btn_OutputSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "OutputPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CountOutput";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IdCustomer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IdInputInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IdOutput";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(397, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 17);
            this.Status.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_StatusOutput);
            this.groupBox1.Controls.Add(this.txt_OutputPrice);
            this.groupBox1.Controls.Add(this.btn_CloseFrm);
            this.groupBox1.Controls.Add(this.btn_OutputSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CountOutput);
            this.groupBox1.Controls.Add(this.txt_IdCustomer);
            this.groupBox1.Controls.Add(this.txt_IdInputInfo);
            this.groupBox1.Controls.Add(this.txt_IdOutput);
            this.groupBox1.Controls.Add(this.txt_IdFood);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 317);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OutputInfo Infomation Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IdFood";
            // 
            // txt_CountOutput
            // 
            this.txt_CountOutput.Location = new System.Drawing.Point(97, 148);
            this.txt_CountOutput.Multiline = true;
            this.txt_CountOutput.Name = "txt_CountOutput";
            this.txt_CountOutput.Size = new System.Drawing.Size(271, 24);
            this.txt_CountOutput.TabIndex = 4;
            // 
            // txt_IdCustomer
            // 
            this.txt_IdCustomer.Location = new System.Drawing.Point(97, 118);
            this.txt_IdCustomer.Multiline = true;
            this.txt_IdCustomer.Name = "txt_IdCustomer";
            this.txt_IdCustomer.Size = new System.Drawing.Size(271, 24);
            this.txt_IdCustomer.TabIndex = 3;
            // 
            // txt_IdInputInfo
            // 
            this.txt_IdInputInfo.Location = new System.Drawing.Point(97, 88);
            this.txt_IdInputInfo.Multiline = true;
            this.txt_IdInputInfo.Name = "txt_IdInputInfo";
            this.txt_IdInputInfo.Size = new System.Drawing.Size(271, 24);
            this.txt_IdInputInfo.TabIndex = 2;
            // 
            // txt_IdOutput
            // 
            this.txt_IdOutput.Location = new System.Drawing.Point(97, 58);
            this.txt_IdOutput.Multiline = true;
            this.txt_IdOutput.Name = "txt_IdOutput";
            this.txt_IdOutput.Size = new System.Drawing.Size(271, 24);
            this.txt_IdOutput.TabIndex = 1;
            // 
            // txt_IdFood
            // 
            this.txt_IdFood.Location = new System.Drawing.Point(97, 28);
            this.txt_IdFood.Multiline = true;
            this.txt_IdFood.Name = "txt_IdFood";
            this.txt_IdFood.Size = new System.Drawing.Size(271, 24);
            this.txt_IdFood.TabIndex = 0;
            // 
            // FrmUpdateOutputInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 357);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUpdateOutputInfo";
            this.Text = "FrmUpdateOutputInfo";
            this.Load += new System.EventHandler(this.FrmUpdateOutputInfo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_StatusOutput;
        private System.Windows.Forms.TextBox txt_OutputPrice;
        private System.Windows.Forms.Button btn_CloseFrm;
        private System.Windows.Forms.Button btn_OutputSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CountOutput;
        private System.Windows.Forms.TextBox txt_IdCustomer;
        private System.Windows.Forms.TextBox txt_IdInputInfo;
        private System.Windows.Forms.TextBox txt_IdOutput;
        private System.Windows.Forms.TextBox txt_IdFood;
    }
}