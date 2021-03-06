namespace PresentationLayer
{
    partial class FrmOutputInfoDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OutputPrice = new System.Windows.Forms.TextBox();
            this.txt_CountOutput = new System.Windows.Forms.TextBox();
            this.txt_IdInputInfo = new System.Windows.Forms.TextBox();
            this.txt_food = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.status_OutputInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.status_OutputInfo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_customer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_OutputPrice);
            this.groupBox1.Controls.Add(this.txt_CountOutput);
            this.groupBox1.Controls.Add(this.txt_IdInputInfo);
            this.groupBox1.Controls.Add(this.txt_food);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer";
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(96, 172);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.ReadOnly = true;
            this.txt_customer.Size = new System.Drawing.Size(188, 20);
            this.txt_customer.TabIndex = 12;
            this.txt_customer.TextChanged += new System.EventHandler(this.txt_customer_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Food";
            // 
            // txt_OutputPrice
            // 
            this.txt_OutputPrice.Location = new System.Drawing.Point(96, 146);
            this.txt_OutputPrice.Name = "txt_OutputPrice";
            this.txt_OutputPrice.ReadOnly = true;
            this.txt_OutputPrice.Size = new System.Drawing.Size(188, 20);
            this.txt_OutputPrice.TabIndex = 5;
            // 
            // txt_CountOutput
            // 
            this.txt_CountOutput.Location = new System.Drawing.Point(96, 120);
            this.txt_CountOutput.Name = "txt_CountOutput";
            this.txt_CountOutput.ReadOnly = true;
            this.txt_CountOutput.Size = new System.Drawing.Size(188, 20);
            this.txt_CountOutput.TabIndex = 4;
            // 
            // txt_IdInputInfo
            // 
            this.txt_IdInputInfo.Location = new System.Drawing.Point(96, 94);
            this.txt_IdInputInfo.Name = "txt_IdInputInfo";
            this.txt_IdInputInfo.ReadOnly = true;
            this.txt_IdInputInfo.Size = new System.Drawing.Size(188, 20);
            this.txt_IdInputInfo.TabIndex = 3;
            // 
            // txt_food
            // 
            this.txt_food.Location = new System.Drawing.Point(96, 68);
            this.txt_food.Name = "txt_food";
            this.txt_food.ReadOnly = true;
            this.txt_food.Size = new System.Drawing.Size(188, 20);
            this.txt_food.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id ";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(96, 42);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(188, 20);
            this.txt_Id.TabIndex = 0;
            // 
            // status_OutputInfo
            // 
            this.status_OutputInfo.Location = new System.Drawing.Point(96, 204);
            this.status_OutputInfo.Name = "status_OutputInfo";
            this.status_OutputInfo.ReadOnly = true;
            this.status_OutputInfo.Size = new System.Drawing.Size(188, 20);
            this.status_OutputInfo.TabIndex = 14;
            // 
            // FrmOutputInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOutputInfoDetail";
            this.Text = "FrmOutputInfoDetail";
            this.Load += new System.EventHandler(this.FrmOutputInfoDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OutputPrice;
        private System.Windows.Forms.TextBox txt_CountOutput;
        private System.Windows.Forms.TextBox txt_IdInputInfo;
        private System.Windows.Forms.TextBox txt_food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.TextBox status_OutputInfo;
    }
}