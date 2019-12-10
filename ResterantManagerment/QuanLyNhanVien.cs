using ResterantManagerment.Business;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment
{
    
    public partial class QuanLyNhanVien : Form
    {
        EmployeeBusiness EB = new EmployeeBusiness();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            List<Employee> ds = EB.GetListEmployee();
            grvEmployee.Columns.Add("EmployeeId", "Mã NV");
            grvEmployee.Columns.Add("EmployeeName", "Tên NV");
            grvEmployee.Columns.Add("Gender", "Giới Tính");
            grvEmployee.Columns.Add("Adress", "Địa chỉ");
            grvEmployee.Columns.Add("Age", "Tuổi");
            grvEmployee.Columns.Add("Email", "Email");
            grvEmployee.Columns.Add("Phone", "Số Điện Thoại");
            foreach (Employee item in ds)
            {
                object[] row = new object[] { item.EmployeeId, item.EmployeeName,bool.Parse(item.Gender.ToString())?"Nam":"Nữ",
                item.Adress,item.Age,item.Email,item.Phone};
                grvEmployee.Rows.Add(row);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeName = txtTenNV.Text;
            bool gt = false;
            if (rbNam.Checked) gt = true;
            else gt = false;
            employee.Gender = gt;
            employee.Adress = txtDiaChi.Text;
            employee.Age = int.Parse(txtTuoi.Text);
            employee.Email = txtEmail.Text;
            employee.Phone = txtSDT.Text;
            if (EB.AddEmployee(employee))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");
            DisplayData();
            clearText();
        }
        public void clearText()
        {
            txtMaNV.Text = null;
            txtTenNV.Text = null;
            txtDiaChi.Text = null;
            txtTuoi.Text = null;
            txtEmail.Text = null;
            txtSDT.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                Employee employee = new Employee();
                employee.EmployeeId = int.Parse(txtMaNV.Text);
                employee.EmployeeName = txtTenNV.Text;
                bool gt = false;
                if (rbNam.Checked) gt = true;
                else gt = false;
                employee.Gender = gt;
                employee.Adress = txtDiaChi.Text;
                employee.Age = int.Parse(txtTuoi.Text);
                employee.Email = txtEmail.Text;
                employee.Phone = txtSDT.Text;
                if (EB.UpdateEmployee(employee))
                {
                    MessageBox.Show("Sửa Nhân viên thành công !");
                    DisplayData();
                    clearText();
                }
                else
                    MessageBox.Show("Sửa Nhân viên thất bại!");
            }
            else MessageBox.Show("Xin vui lòng chọn nhân viên !");

        }

        private void grvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNV.Text = grvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = grvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                bool gt = grvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("Nam");
                if (gt) rbNam.Checked = true;
                else rbNu.Checked = true;
                txtDiaChi.Text = grvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTuoi.Text = grvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = grvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = grvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception ee)
            {
               // MessageBox.Show(ee.Message); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                int id = int.Parse(txtMaNV.Text);

                if (EB.DeleteEmployee(id))
                {
                    MessageBox.Show("Xóa thành công !");
                    DisplayData();
                    clearText();
                }
                else
                    MessageBox.Show("Xóa thất bại!");
            }
            else MessageBox.Show("Xin vui lòng chọn nhân viên !");
        }
    }
}
