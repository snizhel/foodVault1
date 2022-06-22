
namespace PresentationLayer
{
    partial class FrmUpdateFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateFood));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idfood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.txt_idsuplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_namefood = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_Food = new System.Windows.Forms.PictureBox();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Food)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Upload);
            this.groupBox1.Controls.Add(this.txt_FilePath);
            this.groupBox1.Controls.Add(this.pic_Food);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_idfood);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_end);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_start);
            this.groupBox1.Controls.Add(this.txt_idsuplier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_namefood);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 441);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(246, 389);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(53, 20);
            this.btn_browse.TabIndex = 81;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Image";
            // 
            // txt_idfood
            // 
            this.txt_idfood.Location = new System.Drawing.Point(87, 232);
            this.txt_idfood.Name = "txt_idfood";
            this.txt_idfood.ReadOnly = true;
            this.txt_idfood.Size = new System.Drawing.Size(268, 20);
            this.txt_idfood.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // date_end
            // 
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(87, 363);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(268, 20);
            this.date_end.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // date_start
            // 
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(87, 337);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(268, 20);
            this.date_start.TabIndex = 76;
            // 
            // txt_idsuplier
            // 
            this.txt_idsuplier.Location = new System.Drawing.Point(87, 310);
            this.txt_idsuplier.Name = "txt_idsuplier";
            this.txt_idsuplier.ReadOnly = true;
            this.txt_idsuplier.Size = new System.Drawing.Size(268, 20);
            this.txt_idsuplier.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(87, 284);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(268, 20);
            this.txt_quantity.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID Suplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start Date";
            // 
            // txt_namefood
            // 
            this.txt_namefood.Location = new System.Drawing.Point(87, 258);
            this.txt_namefood.Name = "txt_namefood";
            this.txt_namefood.Size = new System.Drawing.Size(268, 20);
            this.txt_namefood.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exp Date";
            // 
            // pic_Food
            // 
            this.pic_Food.Image = ((System.Drawing.Image)(resources.GetObject("pic_Food.Image")));
            this.pic_Food.Location = new System.Drawing.Point(18, 18);
            this.pic_Food.Margin = new System.Windows.Forms.Padding(2);
            this.pic_Food.Name = "pic_Food";
            this.pic_Food.Size = new System.Drawing.Size(337, 176);
            this.pic_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Food.TabIndex = 70;
            this.pic_Food.TabStop = false;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.ForeColor = System.Drawing.Color.Red;
            this.txt_FilePath.Location = new System.Drawing.Point(87, 389);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(153, 20);
            this.txt_FilePath.TabIndex = 82;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(302, 389);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(53, 20);
            this.btn_Upload.TabIndex = 83;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(6, 415);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(349, 20);
            this.btn_Save.TabIndex = 84;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 22);
            this.statusStrip1.TabIndex = 82;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmUpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 467);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUpdateFood";
            this.Text = "FrmUpdateFood";
            this.Load += new System.EventHandler(this.FrmUpdateFood_Load);
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
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idfood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.TextBox txt_idsuplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_namefood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}