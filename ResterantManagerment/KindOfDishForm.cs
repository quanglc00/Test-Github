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
    public partial class KindOfDishForm : Form
    {
        KindOfDishBusiness kind = new KindOfDishBusiness();
        public KindOfDishForm()
        {
            InitializeComponent();
            UploadData();
        }

        public void UploadData()
        {
            List<KindOfDish> ds = kind.getList();
            grv.DataSource = ds;
            grv.Columns["KindOfDishId"].HeaderText = "Mã ID";
            grv.Columns["Name"].HeaderText = "Tên";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            KindOfDish dish = new KindOfDish();
            dish.Name = txtName.Text;
            kind.AddKind(dish);
            UploadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = grv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = grv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtid.Text != "")
                {
                    KindOfDish dish = new KindOfDish();
                    dish.KindOfDishId = int.Parse(txtid.Text);
                    dish.Name = txtName.Text;
                    if (kind.UpdateKind(dish))
                    {
                        MessageBox.Show("Sửa Thành công");
                        UploadData();
                    }
                    else
                        MessageBox.Show("Sửa Thất Bại ");
                }
                else
                {
                    MessageBox.Show("Chọn Loại cần sửa");
                }
            }
            catch (Exception ev)
            {

                MessageBox.Show("Lỗi " + ev.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text != "")
                {
                    
                    int Id = int.Parse(txtid.Text);
                    if (kind.DeleteKind(Id))
                    {
                        MessageBox.Show("Xóa Thành công");
                        UploadData();
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
                else
                {
                    MessageBox.Show("Chọn Loại cần Xóa");
                }
            }
            catch (Exception ev)
            {

                MessageBox.Show("Lỗi " + ev.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtName.Text = "";
        }
    }
}
