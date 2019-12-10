using Constant;
using ResterantManagerment.Business;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment
{
    public partial class OrderForm : Form
    {
        OrderBusiness OB = new OrderBusiness();
        Dish dish = new Dish();
        public OrderForm()
        {
            InitializeComponent();
            dgvOrder.Columns.Add("DishId", "Id");
            dgvOrder.Columns.Add("DishName", "Name");
            dgvOrder.Columns.Add("Price", "Price");
            dgvOrder.Columns.Add("KindOfDishId", "Kind Of Dish");
            dgvOrder.Columns.Add("OrderTime", "Time Order");
            DisplayData();
            lbEmp.Text += " " + SessionUser.USER_NAME;
        }
        public void DisplayData()
        {
            List<Dish> ds = null;
            try
            {
                ds = OB.GetListDish();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dgvListDish.Columns.Add("DishId", "Id");
            dgvListDish.Columns.Add("DishName", "Name");
            dgvListDish.Columns.Add("Price", "Price");
            dgvListDish.Columns.Add("KindOfDishId", "Kind Of Dish");
            foreach (Dish item in ds)
            {
                object[] row = new object[] { item.DishId , item.DishName, item.Price, item.KindOfDishId};
                dgvListDish.Rows.Add(row);
            }
        }

        private void dgvListDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dish.DishId = Int32.Parse(dgvListDish.Rows[e.RowIndex].Cells[0].Value.ToString());
            dish.DishName = dgvListDish.Rows[e.RowIndex].Cells[1].Value.ToString();
            dish.Price = decimal.Parse(dgvListDish.Rows[e.RowIndex].Cells[2].Value.ToString());
            dish.KindOfDishId = Int32.Parse(dgvListDish.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dish != null)
            {
                object[] row = new object[] { dish.DishId, dish.DishName, dish.Price, dish.KindOfDishId, DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") };
                dgvOrder.Rows.Add(row);
                totalPrice.Text = CaclTotalPrice().ToString() + " VNĐ";
            }
            else
            {
                MessageBox.Show("Xin mời chọn món ăn để đặt !");
            }
        }
        private decimal CaclTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgvOrder.Rows)
            {
                int val = 0;
                if (item.Cells[2].Value != null) // cell[3] equals to the price cell, change it if necessary
                    Int32.TryParse(item.Cells[2].Value.ToString(), out val);
                total += val;
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvOrder.SelectedCells)
            {
                if (oneCell.Selected)
                    dgvOrder.Rows.RemoveAt(oneCell.RowIndex);
                totalPrice.Text = CaclTotalPrice().ToString() + " VNĐ";
            }
        }

        private void btnInHd_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=.\\SQLEXPRESS;Initial Catalog=Shop_VPP;Integrated Security=True";
            SqlConnection scon = new SqlConnection(mycon);
            scon.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (dgvOrder != null)
                {
                    
                    cmd.Connection = scon;
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd = new SqlCommand();
                    String queryGetOrderId = "select top 1 OrderId from [dbo].[Order] Order by OrderId DESC";
                    cmd.CommandText = queryGetOrderId;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int orderId = Convert.ToInt32(ds.Tables[0].Rows[0]["OrderId"].ToString());
                    DataTable dt = new DataTable();
                    dt = (DataTable)Session["buyitems"];
                    List<DataRow> list = dt.AsEnumerable().ToList();
                    foreach (var entry in list)
                    {
                        cmd.CommandText = "INSERT INTO [dbo].[OrderLine] VALUES(" + entry.ItemArray[1] + "," + orderId + "," + entry.ItemArray[7] + ")";
                        cmd.ExecuteNonQuery();
                    }
                    Session["buyitems"] = null;
                    GridView1.DataSource = null;
                    totalPrice.Text = "";
                    Label1.Text = "";
                    Label a = (Label)Master.FindControl("countProInCart");
                    a.Text = "0";
                    GridView1.DataBind();
                    notification.Text = "Mua thành công!";
                    scon.Close();

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            catch (SqlException ex)
            {
                notification.Text = ex.Message;
            }
        }
    }
}
