using ResterantManagerment.Business;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ResterantManagerment
{
    public partial class QuanLyKhachHang : DevComponents.DotNetBar.Office2007Form
    {
        CustomerBusiness ub = new CustomerBusiness();

        public QuanLyKhachHang()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            //IEnumerable<Customer> bindingData = new BindingList<Customer>(ub.GetListCustomer());
            List<Customer> customers = ub.GetListCustomer();
           // BindingSource source = new BindingSource(bindingData, null);

            dgvCustomer.DataSource = customers;
            dgvCustomer.Columns["CustomerId"].HeaderText = "ID";
            dgvCustomer.Columns["CustomerName"].HeaderText = "Name";
            dgvCustomer.Columns["PhoneNumber"].HeaderText = "Phone";
            dgvCustomer.Columns["Email"].HeaderText = "Email";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();
            a.CustomerName = txtName.Text;
            a.PhoneNumber = txtPhone.Text;
            a.Email = txtEmail.Text;
            ub.AddCustomer(a);
            DisplayData();
            clearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                Customer a = new Customer();
                a.CustomerId = int.Parse(txtId.Text);
                a.CustomerName = txtName.Text;
                a.PhoneNumber = txtPhone.Text;
                a.Email = txtEmail.Text;
                ub.UpdateCustomer(a);
                DisplayData();
                clearText();
            }
            else
            {
                MessageBox.Show("Xin mời chọn nhân viên cần sửa!");
            }
        }
        public void clearText()
        {
            txtEmail.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                ub.DeleteCustomer(id);
                DisplayData();
                clearText();
            }
            else
            {
                MessageBox.Show("Xin mời chọn nhân viên cần Xóa!");
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
