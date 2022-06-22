namespace PresentationLayer
{
    partial class FrmAddOutput
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
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.dt_DataOutput = new System.Windows.Forms.DateTimePicker();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.btn_OutputSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TotalPriceOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(39, 17);
            this.Status.Text = "Status";
            // 
            // dt_DataOutput
            // 
            this.dt_DataOutput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DataOutput.Location = new System.Drawing.Point(97, 33);
            this.dt_DataOutput.Name = "dt_DataOutput";
            this.dt_DataOutput.Size = new System.Drawing.Size(271, 20);
            this.dt_DataOutput.TabIndex = 15;
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.Location = new System.Drawing.Point(6, 133);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(362, 23);
            this.btn_CloseFrm.TabIndex = 13;
            this.btn_CloseFrm.Text = "Cancel";
            this.btn_CloseFrm.UseVisualStyleBackColor = true;
            this.btn_CloseFrm.Click += new System.EventHandler(this.btn_CloseFrm_Click);
            // 
            // btn_OutputSave
            // 
            this.btn_OutputSave.Location = new System.Drawing.Point(6, 104);
            this.btn_OutputSave.Name = "btn_OutputSave";
            this.btn_OutputSave.Size = new System.Drawing.Size(362, 23);
            this.btn_OutputSave.TabIndex = 12;
            this.btn_OutputSave.Text = "Save";
            this.btn_OutputSave.UseVisualStyleBackColor = true;
            this.btn_OutputSave.Click += new System.EventHandler(this.btn_OutputSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TotalPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DateOutput";
            // 
            // txt_TotalPriceOutput
            // 
            this.txt_TotalPriceOutput.Location = new System.Drawing.Point(97, 59);
            this.txt_TotalPriceOutput.Multiline = true;
            this.txt_TotalPriceOutput.Name = "txt_TotalPriceOutput";
            this.txt_TotalPriceOutput.Size = new System.Drawing.Size(271, 24);
            this.txt_TotalPriceOutput.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 177);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_DataOutput);
            this.groupBox1.Controls.Add(this.btn_CloseFrm);
            this.groupBox1.Controls.Add(this.btn_OutputSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TotalPriceOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Infomation Data";
            // 
            // FrmAddOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 199);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddOutput";
            this.Text = "FrmAddOutput";
            this.Load += new System.EventHandler(this.FrmAddOutput_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.DateTimePicker dt_DataOutput;
        private System.Windows.Forms.Button btn_CloseFrm;
        private System.Windows.Forms.Button btn_OutputSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TotalPriceOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}