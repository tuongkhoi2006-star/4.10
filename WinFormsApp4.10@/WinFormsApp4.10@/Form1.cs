using System.ComponentModel;
using System.IO;

namespace WinFormsApp4._10_
{
    public partial class Form1 : Form
    {
        private List<CheckoutRecord> masterList = new List<CheckoutRecord>();
        private BindingList<CheckoutRecord> viewList = new BindingList<CheckoutRecord>();
        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            // initialize equipment list
            comboEquipment.Items.AddRange(new string[] { "Laptop", "Projector", "Camera", "Microphone" });
            comboEquipment.SelectedIndex = 0;

            // setup binding
            bs.DataSource = viewList;
            dgvRecords.AutoGenerateColumns = false;
            dgvRecords.DataSource = bs;

            // configure columns (manual so order is stable)
            dgvRecords.Columns.Clear();
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã phiếu" });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã sv" });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ tên" });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Equipment", HeaderText = "Thiết bị" });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số lượng" });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BorrowDate", HeaderText = "Ngày mượn", DefaultCellStyle = new DataGridViewCellStyle { Format = "d" } });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn trả", DefaultCellStyle = new DataGridViewCellStyle { Format = "d" } });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReturnDate", HeaderText = "Ngày trả", DefaultCellStyle = new DataGridViewCellStyle { Format = "d" } });
            dgvRecords.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái" });

            // events
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnMarkReturned.Click += BtnMarkReturned_Click;
            txtSearch.TextChanged += (s, e) => RefreshView();
            comboFilter.SelectedIndexChanged += (s, e) => RefreshView();
            dgvRecords.SelectionChanged += DgvRecords_SelectionChanged;
            btnExport.Click += BtnExport_Click;

            // initialize filter
            comboFilter.Items.AddRange(new string[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            comboFilter.SelectedIndex = 0;

            UpdateStatusStrip();
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV files|*.csv|All files|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var listToExport = viewList.ToList();
                CsvExporter.ExportToCsv(sfd.FileName, listToExport);
                MessageBox.Show("Exported.", "CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvRecords_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow?.DataBoundItem is CheckoutRecord r)
            {
                txtId.Text = r.Id;
                txtStudentId.Text = r.StudentId;
                txtStudentName.Text = r.StudentName;
                comboEquipment.Text = r.Equipment;
                numQuantity.Value = r.Quantity;
                dtpBorrow.Value = r.BorrowDate;
                dtpDue.Value = r.DueDate;
                if (r.ReturnDate.HasValue)
                {
                    dtpReturn.Value = r.ReturnDate.Value;
                    chkReturned.Checked = true;
                }
                else
                {
                    dtpReturn.Value = DateTime.Now;
                    chkReturned.Checked = false;
                }
            }
        }

        private void BtnMarkReturned_Click(object? sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow?.DataBoundItem is CheckoutRecord r)
            {
                r.ReturnDate = DateTime.Now.Date;
                RefreshView();
                bs.ResetBindings(false);
                UpdateStatusStrip();
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow?.DataBoundItem is CheckoutRecord r)
            {
                if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    masterList.Remove(r);
                    RefreshView();
                    UpdateStatusStrip();
                }
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            ClearErrors();
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existing = masterList.FirstOrDefault(x => x.Id == txtId.Text.Trim());
            if (existing == null)
            {
                MessageBox.Show("Không tìm thấy mã phiếu để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            existing.StudentId = txtStudentId.Text.Trim();
            existing.StudentName = txtStudentName.Text.Trim();
            existing.Equipment = comboEquipment.Text;
            existing.Quantity = (int)numQuantity.Value;
            existing.BorrowDate = dtpBorrow.Value.Date;
            existing.DueDate = dtpDue.Value.Date;
            existing.ReturnDate = chkReturned.Checked ? dtpReturn.Value.Date : null;

            RefreshView();
            bs.ResetBindings(false);
            UpdateStatusStrip();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            ClearErrors();
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = txtId.Text.Trim();
            if (masterList.Any(x => x.Id == id))
            {
                errorProvider.SetError(txtId, "Mã phiếu trùng");
                return;
            }

            var rec = new CheckoutRecord
            {
                Id = id,
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                Equipment = comboEquipment.Text,
                Quantity = (int)numQuantity.Value,
                BorrowDate = dtpBorrow.Value.Date,
                DueDate = dtpDue.Value.Date,
                ReturnDate = chkReturned.Checked ? dtpReturn.Value.Date : null
            };

            masterList.Add(rec);
            RefreshView();
            UpdateStatusStrip();
        }

        private void RefreshView()
        {
            var query = masterList.AsEnumerable();
            var search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.StudentId.Contains(search, StringComparison.OrdinalIgnoreCase) || (x.Equipment ?? "").Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            var filter = comboFilter.SelectedItem?.ToString();
            if (filter == "Đang mượn")
            {
                query = query.Where(x => x.ReturnDate == null && x.DueDate >= DateTime.Now.Date);
            }
            else if (filter == "Quá hạn")
            {
                query = query.Where(x => x.ReturnDate == null && x.DueDate < DateTime.Now.Date);
            }
            else if (filter == "Đã trả")
            {
                query = query.Where(x => x.ReturnDate != null);
            }

            var list = query.ToList();
            viewList = new BindingList<CheckoutRecord>(list);
            bs.DataSource = viewList;
            dgvRecords.DataSource = bs;
            bs.ResetBindings(false);
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            toolStripStatusLabelTotal.Text = $"Tổng: {masterList.Count}";
            var overdue = masterList.Count(x => x.ReturnDate == null && x.DueDate < DateTime.Now.Date);
            toolStripStatusLabelOverdue.Text = $"Quá hạn: {overdue}";
        }

        private void ClearErrors()
        {
            errorProvider.SetError(txtId, "");
            errorProvider.SetError(txtStudentId, "");
            errorProvider.SetError(comboEquipment, "");
            errorProvider.SetError(numQuantity, "");
            errorProvider.SetError(dtpDue, "");
            errorProvider.SetError(dtpReturn, "");
        }

        private bool ValidateInputs(out string message)
        {
            message = string.Empty;
            var id = txtId.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                errorProvider.SetError(txtId, "Mã phiếu không được để trống");
                message = "Mã phiếu không được để trống";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider.SetError(txtStudentId, "Mã sinh viên không được để trống");
                message = "Mã sinh viên không được để trống";
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboEquipment.Text))
            {
                errorProvider.SetError(comboEquipment, "Thiết bị không được để trống");
                message = "Thiết bị không được để trống";
                return false;
            }

            if (numQuantity.Value <= 0)
            {
                errorProvider.SetError(numQuantity, "Số lượng phải > 0");
                message = "Số lượng phải > 0";
                return false;
            }

            if (dtpDue.Value.Date < dtpBorrow.Value.Date)
            {
                errorProvider.SetError(dtpDue, "Hạn trả không trước ngày mượn");
                message = "Hạn trả không trước ngày mượn";
                return false;
            }

            if (chkReturned.Checked && dtpReturn.Value.Date < dtpBorrow.Value.Date)
            {
                errorProvider.SetError(dtpReturn, "Ngày trả thực tế không trước ngày mượn");
                message = "Ngày trả thực tế không trước ngày mượn";
                return false;
            }

            return true;
        }
    }
}
