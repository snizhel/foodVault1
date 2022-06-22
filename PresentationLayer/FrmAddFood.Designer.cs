
namespace PresentationLayer
{
    partial class FrmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFood));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_Food = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_namefood = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.dt_InputDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_CreateTotalPriceAndInput = new System.Windows.Forms.Button();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_StatusInputInfo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_Suplier = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_PathFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Food)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_PathFile);
            this.groupBox1.Controls.Add(this.btn_Upload);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_Suplier);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cb_StatusInputInfo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_TotalPrice);
            this.groupBox1.Controls.Add(this.btn_CreateTotalPriceAndInput);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dt_InputDate);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Browse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_end);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_start);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_namefood);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pic_Food);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Food Details";
            // 
            // pic_Food
            // 
            this.pic_Food.Image = ((System.Drawing.Image)(resources.GetObject("pic_Food.Image")));
            this.pic_Food.Location = new System.Drawing.Point(5, 18);
            this.pic_Food.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Food.Name = "pic_Food";
            this.pic_Food.Size = new System.Drawing.Size(366, 176);
            this.pic_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Food.TabIndex = 71;
            this.pic_Food.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(253, 208);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(58, 20);
            this.btn_Browse.TabIndex = 96;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Image";
            // 
            // date_end
            // 
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(67, 287);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(304, 20);
            this.date_end.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Name";
            // 
            // date_start
            // 
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(67, 260);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(304, 20);
            this.date_start.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(473, 73);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(295, 20);
            this.txt_Quantity.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Start Date";
            // 
            // txt_namefood
            // 
            this.txt_namefood.Location = new System.Drawing.Point(67, 234);
            this.txt_namefood.Name = "txt_namefood";
            this.txt_namefood.Size = new System.Drawing.Size(304, 20);
            this.txt_namefood.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(392, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 300);
            this.label5.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Input Info";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(473, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 2);
            this.label9.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(473, 99);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(295, 20);
            this.txt_Price.TabIndex = 102;
            // 
            // dt_InputDate
            // 
            this.dt_InputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_InputDate.Location = new System.Drawing.Point(473, 125);
            this.dt_InputDate.Name = "dt_InputDate";
            this.dt_InputDate.Size = new System.Drawing.Size(295, 20);
            this.dt_InputDate.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Input Date";
            // 
            // btn_CreateTotalPriceAndInput
            // 
            this.btn_CreateTotalPriceAndInput.Location = new System.Drawing.Point(412, 215);
            this.btn_CreateTotalPriceAndInput.Name = "btn_CreateTotalPriceAndInput";
            this.btn_CreateTotalPriceAndInput.Size = new System.Drawing.Size(355, 50);
            this.btn_CreateTotalPriceAndInput.TabIndex = 105;
            this.btn_CreateTotalPriceAndInput.Text = "Calculate Total Price - Create new food";
            this.btn_CreateTotalPriceAndInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTotalPriceAndInput.UseVisualStyleBackColor = true;
            this.btn_CreateTotalPriceAndInput.Click += new System.EventHandler(this.btn_CreateTotalPriceAndInput_Click);
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txt_TotalPrice.Location = new System.Drawing.Point(473, 178);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.Size = new System.Drawing.Size(295, 20);
            this.txt_TotalPrice.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Total Price";
            // 
            // cb_StatusInputInfo
            // 
            this.cb_StatusInputInfo.FormattingEnabled = true;
            this.cb_StatusInputInfo.Items.AddRange(new object[] {
            "Shipping",
            "Received"});
            this.cb_StatusInputInfo.Location = new System.Drawing.Point(473, 151);
            this.cb_StatusInputInfo.Name = "cb_StatusInputInfo";
            this.cb_StatusInputInfo.Size = new System.Drawing.Size(295, 21);
            this.cb_StatusInputInfo.TabIndex = 108;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(410, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "Status";
            // 
            // cb_Suplier
            // 
            this.cb_Suplier.FormattingEnabled = true;
            this.cb_Suplier.Location = new System.Drawing.Point(473, 46);
            this.cb_Suplier.Name = "cb_Suplier";
            this.cb_Suplier.Size = new System.Drawing.Size(295, 21);
            this.cb_Suplier.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(410, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 112;
            this.label14.Text = "Suplier";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(317, 208);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(54, 20);
            this.btn_Upload.TabIndex = 113;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // txt_PathFile
            // 
            this.txt_PathFile.ForeColor = System.Drawing.Color.Red;
            this.txt_PathFile.Location = new System.Drawing.Point(67, 208);
            this.txt_PathFile.Name = "txt_PathFile";
            this.txt_PathFile.Size = new System.Drawing.Size(180, 20);
            this.txt_PathFile.TabIndex = 114;
            // 
            // FrmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddFood";
            this.Text = "FrmAddFood";
            this.Load += new System.EventHandler(this.FrmAddFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Food)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Food;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_namefood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_InputDate;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Button btn_CreateTotalPriceAndInput;
        private System.Windows.Forms.ComboBox cb_StatusInputInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_Suplier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txt_PathFile;
    }
}