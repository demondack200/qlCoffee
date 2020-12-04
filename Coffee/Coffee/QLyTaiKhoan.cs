using System;
using System.Collections.Generic;
using System.Windows.Forms;
using qlyCoffeeService;


namespace Coffee
{
    public partial class QLyTaiKhoan : Form
    {
        public QLyTaiKhoan()
        {
            InitializeComponent();
            showInfo();
        }

        private void showInfo()
        {
            if(MainForm.account != null)
            {
                USER user = MainForm.account.USER;
                lb_HoTen.Text = user.HOTEN;
                lb_GioiTinh.Text = user.GIOITINH;
                dtp_NgaySinh.Value = (DateTime) user.NGAYSINH;

                string str_vaiTro = "";
                ICollection<ROLE> listVaiTro = user.ROLEs;
                foreach (ROLE vaitro in listVaiTro)
                {
                    str_vaiTro = str_vaiTro + vaitro.ROLENAME;
                }
                lb_VaiTro.Text = str_vaiTro;
            }
        }

        private void btn_DoiMatKhau_Click(object sender, System.EventArgs e)
        {

        }
    }
}
