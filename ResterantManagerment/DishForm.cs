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
    public partial class DishForm : Form
    {
        OrderBusiness OB = new OrderBusiness();
        DishBusiness DB = new DishBusiness();
        public DishForm()
        {
            InitializeComponent();
            dgvDish.Columns.Add("DishId", "Id");
            dgvDish.Columns.Add("DishName", "Name");
            dgvDish.Columns.Add("Price", "Price");
            dgvDish.Columns.Add("KindOfDishId", "Kind Of Dish");
            DisplayData();
        }
        public void DisplayData()
        {
            dgvDish.Rows.Clear();
            List<Dish> ds = null;
            try
            {
                ds = OB.GetListDish();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            foreach (Dish item in ds)
            {
                object[] row = new object[] { item.DishId, item.DishName, item.Price, item.KindOfDishId };
                dgvDish.Rows.Add(row);
            }
        }
        private void DishForm_Load(object sender, EventArgs e)
        {
            this.kindOfDishTableAdapter.Fill(this.managerResterantDataSet2.KindOfDish);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dish a = new Dish();
            a.DishName = txtName.Text;
            a.Price = int.Parse(txtPrice.Text);
            a.KindOfDishId = Convert.ToInt32(cbbKod.SelectedValue);
            DB.AddDish(a);
            DisplayData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
