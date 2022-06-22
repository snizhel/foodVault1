
namespace PresentationLayer
{
    partial class FrmInputInfoDetails
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txt_InputPrice = new System.Windows.Forms.TextBox();
            this.txt_CountInput = new System.Windows.Forms.TextBox();
            this.txt_IdInput = new System.Windows.Forms.TextBox();
            this.txt_IdFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdBilling = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_Status);
            this.groupBox1.Controls.Add(this.txt_InputPrice);
            this.groupBox1.Controls.Add(this.txt_CountInput);
            this.groupBox1.Controls.Add(this.txt_IdInput);
            this.groupBox1.Controls.Add(this.txt_IdFood);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_IdBilling);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing Details";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(9, 199);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(275, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
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
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Food";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Shipping",
            "Received"});
            this.cb_Status.Location = new System.Drawing.Point(96, 172);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(188, 21);
            this.cb_Status.TabIndex = 6;
            // 
            // txt_InputPrice
            // 
            this.txt_InputPrice.Location = new System.Drawing.Point(96, 146);
            this.txt_InputPrice.Name = "txt_InputPrice";
            this.txt_InputPrice.ReadOnly = true;
            this.txt_InputPrice.Size = new System.Drawing.Size(188, 20);
            this.txt_InputPrice.TabIndex = 5;
            // 
            // txt_CountInput
            // 
            this.txt_CountInput.Location = new System.Drawing.Point(96, 120);
            this.txt_CountInput.Name = "txt_CountInput";
            this.txt_CountInput.ReadOnly = true;
            this.txt_CountInput.Size = new System.Drawing.Size(188, 20);
            this.txt_CountInput.TabIndex = 4;
            // 
            // txt_IdInput
            // 
            this.txt_IdInput.Location = new System.Drawing.Point(96, 94);
            this.txt_IdInput.Name = "txt_IdInput";
            this.txt_IdInput.ReadOnly = true;
            this.txt_IdInput.Size = new System.Drawing.Size(188, 20);
            this.txt_IdInput.TabIndex = 3;
            // 
            // txt_IdFood
            // 
            this.txt_IdFood.Location = new System.Drawing.Point(96, 68);
            this.txt_IdFood.Name = "txt_IdFood";
            this.txt_IdFood.ReadOnly = true;
            this.txt_IdFood.Size = new System.Drawing.Size(188, 20);
            this.txt_IdFood.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Billing";
            // 
            // txt_IdBilling
            // 
            this.txt_IdBilling.Location = new System.Drawing.Point(96, 42);
            this.txt_IdBilling.Name = "txt_IdBilling";
            this.txt_IdBilling.ReadOnly = true;
            this.txt_IdBilling.Size = new System.Drawing.Size(188, 20);
            this.txt_IdBilling.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmInputInfoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 264);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInputInfoDetails";
            this.Text = "FrmInputInfoDetails";
            this.Load += new System.EventHandler(this.FrmInputInfoDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txt_InputPrice;
        private System.Windows.Forms.TextBox txt_CountInput;
        private System.Windows.Forms.TextBox txt_IdInput;
        private System.Windows.Forms.TextBox txt_IdFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdBilling;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}