
namespace PresentationLayer
{
    partial class FrmFoodManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFoodManagement));
            this.gv_Food = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.txt_idfood = new System.Windows.Forms.TextBox();
            this.txt_namefood = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_idsuplier = new System.Windows.Forms.TextBox();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.list_image = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Food
            // 
            this.gv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Food.Location = new System.Drawing.Point(6, 19);
            this.gv_Food.Name = "gv_Food";
            this.gv_Food.Size = new System.Drawing.Size(726, 488);
            this.gv_Food.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1175, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID Suplier";
            // 
            // pic_avatar
            // 
            this.pic_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pic_avatar.Image")));
            this.pic_avatar.Location = new System.Drawing.Point(87, 18);
            this.pic_avatar.Margin = new System.Windows.Forms.Padding(2);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(318, 164);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avatar.TabIndex = 70;
            this.pic_avatar.TabStop = false;
            // 
            // txt_idfood
            // 
            this.txt_idfood.Location = new System.Drawing.Point(87, 213);
            this.txt_idfood.Name = "txt_idfood";
            this.txt_idfood.Size = new System.Drawing.Size(318, 20);
            this.txt_idfood.TabIndex = 71;
            this.txt_idfood.Validating += new System.ComponentModel.CancelEventHandler(this.txt_idfood_Validating);
            // 
            // txt_namefood
            // 
            this.txt_namefood.Location = new System.Drawing.Point(87, 239);
            this.txt_namefood.Name = "txt_namefood";
            this.txt_namefood.Size = new System.Drawing.Size(318, 20);
            this.txt_namefood.TabIndex = 72;
            this.txt_namefood.Validating += new System.ComponentModel.CancelEventHandler(this.txt_namefood_Validating);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(87, 265);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(318, 20);
            this.txt_quantity.TabIndex = 74;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quantity_Validating);
            // 
            // txt_idsuplier
            // 
            this.txt_idsuplier.Location = new System.Drawing.Point(87, 291);
            this.txt_idsuplier.Name = "txt_idsuplier";
            this.txt_idsuplier.Size = new System.Drawing.Size(318, 20);
            this.txt_idsuplier.TabIndex = 75;
            this.txt_idsuplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idsuplier_KeyPress);
            this.txt_idsuplier.Validating += new System.ComponentModel.CancelEventHandler(this.txt_idsuplier_Validating);
            // 
            // date_start
            // 
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(87, 318);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(318, 20);
            this.date_start.TabIndex = 76;
            // 
            // date_end
            // 
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(87, 344);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(318, 20);
            this.date_end.TabIndex = 77;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_avatar);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.list_image);
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
            this.groupBox1.Location = new System.Drawing.Point(756, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 428);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(330, 377);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 20);
            this.btn_browse.TabIndex = 81;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // list_image
            // 
            this.list_image.HideSelection = false;
            this.list_image.Location = new System.Drawing.Point(87, 377);
            this.list_image.Name = "list_image";
            this.list_image.Size = new System.Drawing.Size(237, 20);
            this.list_image.TabIndex = 80;
            this.list_image.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gv_Food);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 513);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Food";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Location = new System.Drawing.Point(757, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 78);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(275, 29);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(141, 29);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 34);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 29);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(13, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(737, 165);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Suplier Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmFoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmFoodManagement";
            this.Text = "Food Management Warehouse";
            this.Load += new System.EventHandler(this.FrmFoodManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Food;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pic_avatar;
        private System.Windows.Forms.TextBox txt_idfood;
        private System.Windows.Forms.TextBox txt_namefood;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_idsuplier;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.ListView list_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}