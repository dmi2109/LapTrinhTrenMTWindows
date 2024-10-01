using BaiTapBuoi5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi5
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {

            bool valid = true;
            err.Clear();
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAverageScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (txtStudentID.Text.Length != 10 || !txtStudentID.Text.All(char.IsDigit))
            {
                err.SetError(txtStudentID, "Mã số sinh viên không hợp lệ.");
                valid = false;
            }

            if (!decimal.TryParse(txtAverageScore.Text, out decimal avgScore) || avgScore < 0 || avgScore > 10)
            {
                err.SetError(txtAverageScore, "Điểm trung bình sinh viên không hợp lệ.");
                valid = false;
            }

            if (txtFullName.Text.Length < 3 || txtFullName.Text.Length > 100 ||
                !txtFullName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtFullName, "Tên sinh viên không hợp lệ.");
                valid = false;
            }

            return valid;
        }

        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }
        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculty.ToList(); //lấy các khoa
                List<Student> listStudent = context.Student.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetInputFields()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            cmbFaculty.SelectedItem = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            // Check if the student already exists
            bool exists = dgvStudent.Rows.Cast<DataGridViewRow>()
                                          .Any(r => r.Cells[0].Value.ToString() == txtStudentID.Text);

            if (!exists)
            {
                try
                {
                    StudentContextDB context = new StudentContextDB();

                    // Create new student object
                    Student newStudent = new Student
                    {
                        StudentID = txtStudentID.Text, 
                        FullName = txtFullName.Text,
                        FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                        AverageScore = double.Parse(txtAverageScore.Text)
                    };

                    // Add new student to the database
                    context.Student.Add(newStudent);
                    context.SaveChanges();

                    // Add new student to DataGridView
                    dgvStudent.Rows.Add(newStudent.StudentID, newStudent.FullName,
                                        cmbFaculty.Text, newStudent.AverageScore);

                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại.");
            }

            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                StudentContextDB context = new StudentContextDB();
                var student = context.Student.FirstOrDefault(s => s.StudentID == txtStudentID.Text);

                if (student != null)
                {
                    // Update student info
                    student.FullName = txtFullName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtAverageScore.Text);

                    context.SaveChanges();

                    // Update DataGridView
                    var row = dgvStudent.Rows.Cast<DataGridViewRow>()
                                             .FirstOrDefault(r => r.Cells[0].Value.ToString() == student.StudentID);
                    if (row != null)
                    {
                        row.Cells[1].Value = student.FullName;
                        row.Cells[2].Value = cmbFaculty.Text;
                        row.Cells[3].Value = student.AverageScore;
                    }

                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetInputFields();

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Load data from DataGridView to input fields
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
                txtAverageScore.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                        "Xác nhận xóa",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    StudentContextDB context = new StudentContextDB();
                    var student = context.Student.FirstOrDefault(s => s.StudentID == txtStudentID.Text);

                    if (student != null)
                    {
                        context.Student.Remove(student);
                        context.SaveChanges();

                        // Remove from DataGridView
                        var row = dgvStudent.Rows.Cast<DataGridViewRow>()
                                                 .FirstOrDefault(r => r.Cells[0].Value.ToString() == student.StudentID);
                        if (row != null)
                        {
                            dgvStudent.Rows.Remove(row);
                        }

                        MessageBox.Show("Xóa dữ liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ResetInputFields();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                         "Xác nhận thoát",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
