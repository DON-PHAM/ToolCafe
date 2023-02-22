
namespace ToolCafe
{
    partial class frmAdmin
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
            this.tcBill = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpkEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmPriceFood = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tcBill.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBill
            // 
            this.tcBill.Controls.Add(this.tabPage1);
            this.tcBill.Controls.Add(this.tabPage2);
            this.tcBill.Controls.Add(this.tabPage3);
            this.tcBill.Controls.Add(this.tabPage4);
            this.tcBill.Controls.Add(this.tabPage5);
            this.tcBill.Location = new System.Drawing.Point(10, 12);
            this.tcBill.Name = "tcBill";
            this.tcBill.SelectedIndex = 0;
            this.tcBill.Size = new System.Drawing.Size(776, 426);
            this.tcBill.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dtpkEndTime);
            this.panel2.Controls.Add(this.dtpkStart);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 33);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpkEndTime
            // 
            this.dtpkEndTime.Location = new System.Drawing.Point(553, 3);
            this.dtpkEndTime.Name = "dtpkEndTime";
            this.dtpkEndTime.Size = new System.Drawing.Size(200, 23);
            this.dtpkEndTime.TabIndex = 1;
            // 
            // dtpkStart
            // 
            this.dtpkStart.Location = new System.Drawing.Point(3, 3);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(200, 23);
            this.dtpkStart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(6, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 347);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(750, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thức ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchFood);
            this.panel6.Controls.Add(this.btnSearchFood);
            this.panel6.Location = new System.Drawing.Point(485, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 59);
            this.panel6.TabIndex = 2;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(3, 19);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(190, 23);
            this.txtSearchFood.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(199, 3);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(75, 53);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Controls.Add(this.nmPriceFood);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtNameFood);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtIdFood);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(485, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 321);
            this.panel5.TabIndex = 1;
            // 
            // nmPriceFood
            // 
            this.nmPriceFood.Location = new System.Drawing.Point(68, 134);
            this.nmPriceFood.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPriceFood.Name = "nmPriceFood";
            this.nmPriceFood.Size = new System.Drawing.Size(189, 23);
            this.nmPriceFood.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh mục";
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(68, 55);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(189, 23);
            this.txtNameFood.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên món";
            // 
            // txtIdFood
            // 
            this.txtIdFood.Location = new System.Drawing.Point(68, 14);
            this.txtIdFood.Name = "txtIdFood";
            this.txtIdFood.Size = new System.Drawing.Size(189, 23);
            this.txtIdFood.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnViewFood);
            this.panel4.Controls.Add(this.btnUpdateFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 59);
            this.panel4.TabIndex = 1;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Location = new System.Drawing.Point(361, 3);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(75, 53);
            this.btnViewFood.TabIndex = 3;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(236, 3);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(75, 53);
            this.btnUpdateFood.TabIndex = 2;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(119, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(75, 53);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 53);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(6, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 321);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(467, 315);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh mục";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bàn ăn";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tài khoản";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(68, 95);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(189, 23);
            this.cbCategory.TabIndex = 8;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcBill);
            this.Name = "frmAdmin";
            this.Text = "Quản trị viên";
            this.tcBill.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBill;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpkEndTime;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nmPriceFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}