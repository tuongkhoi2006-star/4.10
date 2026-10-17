namespace WinFormsApp4._10_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.chkReturned = new System.Windows.Forms.CheckBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboEquipment = new System.Windows.Forms.ComboBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOverdue = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.panelTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxList);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.chkReturned);
            this.groupBoxInput.Controls.Add(this.dtpReturn);
            this.groupBoxInput.Controls.Add(this.label9);
            this.groupBoxInput.Controls.Add(this.btnMarkReturned);
            this.groupBoxInput.Controls.Add(this.btnExport);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Controls.Add(this.btnUpdate);
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Controls.Add(this.dtpDue);
            this.groupBoxInput.Controls.Add(this.dtpBorrow);
            this.groupBoxInput.Controls.Add(this.numQuantity);
            this.groupBoxInput.Controls.Add(this.comboEquipment);
            this.groupBoxInput.Controls.Add(this.txtStudentName);
            this.groupBoxInput.Controls.Add(this.txtStudentId);
            this.groupBoxInput.Controls.Add(this.txtId);
            this.groupBoxInput.Controls.Add(this.label8);
            this.groupBoxInput.Controls.Add(this.label7);
            this.groupBoxInput.Controls.Add(this.label6);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(350, 600);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Phiếu mượn";
            // 
            // chkReturned
            // 
            this.chkReturned.AutoSize = true;
            this.chkReturned.Location = new System.Drawing.Point(120, 260);
            this.chkReturned.Name = "chkReturned";
            this.chkReturned.Size = new System.Drawing.Size(70, 19);
            this.chkReturned.TabIndex = 12;
            this.chkReturned.Text = "Đã trả";
            this.chkReturned.UseVisualStyleBackColor = true;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(120, 285);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 23);
            this.dtpReturn.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ngày trả thực:";
            // 
            // btnMarkReturned
            // 
            this.btnMarkReturned.Location = new System.Drawing.Point(20, 330);
            this.btnMarkReturned.Name = "btnMarkReturned";
            this.btnMarkReturned.Size = new System.Drawing.Size(140, 30);
            this.btnMarkReturned.TabIndex = 14;
            this.btnMarkReturned.Text = "Đánh dấu đã trả";
            this.btnMarkReturned.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(180, 330);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(140, 30);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Xuất CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtpDue
            // 
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(120, 220);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(200, 23);
            this.dtpDue.TabIndex = 11;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrow.Location = new System.Drawing.Point(120, 185);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(200, 23);
            this.dtpBorrow.TabIndex = 10;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(120, 145);
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 23);
            this.numQuantity.TabIndex = 9;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboEquipment
            // 
            this.comboEquipment.FormattingEnabled = true;
            this.comboEquipment.Location = new System.Drawing.Point(120, 105);
            this.comboEquipment.Name = "comboEquipment";
            this.comboEquipment.Size = new System.Drawing.Size(200, 23);
            this.comboEquipment.TabIndex = 8;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(120, 70);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 23);
            this.txtStudentName.TabIndex = 7;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(120, 40);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 23);
            this.txtStudentId.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hạn trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày mượn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thiết bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ tên sv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.dgvRecords);
            this.groupBoxList.Controls.Add(this.panelTop);
            this.groupBoxList.Controls.Add(this.statusStrip);
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Location = new System.Drawing.Point(0, 0);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(646, 600);
            this.groupBoxList.TabIndex = 0;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Danh sách";
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(6, 60);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowTemplate.Height = 25;
            this.dgvRecords.Size = new System.Drawing.Size(634, 480);
            this.dgvRecords.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.comboFilter);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 19);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(640, 35);
            this.panelTop.TabIndex = 2;
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(430, 6);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(160, 23);
            this.comboFilter.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lọc:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tìm kiếm:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotal,
            this.toolStripStatusLabelOverdue});
            this.statusStrip.Location = new System.Drawing.Point(3, 575);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(640, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTotal
            // 
            this.toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            this.toolStripStatusLabelTotal.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelTotal.Text = "Tổng: 0";
            // 
            // toolStripStatusLabelOverdue
            // 
            this.toolStripStatusLabelOverdue.Name = "toolStripStatusLabelOverdue";
            this.toolStripStatusLabelOverdue.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabelOverdue.Text = "Quá hạn: 0";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Lab Equipment Checkout";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOverdue;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox comboEquipment;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.CheckBox chkReturned;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label9;
    }
}

