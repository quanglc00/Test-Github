using Constant;
using ResterantManagerment.Business;
using System;
using System.Windows.Forms;
namespace ResterantManagerment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UserBusiness ub = new UserBusiness();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" && txtPassword.Text != "")
            {
                int result = ub.Login(txtUserName.Text, txtPassword.Text);
                if (result == 1)
                {
                    this.Hide();
                    SessionUser.USER_NAME = txtUserName.Text;
                    QuanLyKhachHang qlnv = new QuanLyKhachHang();
                    //qlnv.Show();
                    new OrderForm().Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập xin mời nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống!");
            }
        }
    }
}
