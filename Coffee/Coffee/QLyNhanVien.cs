using System.Windows.Forms;
using System.Collections.Generic;
using qlyCoffeeService;
using System.Diagnostics;

namespace Coffee
{
    public partial class QLyNhanVien : Form
    {
        public QLyNhanVien()
        {
            InitializeComponent();
        }

        private void QLyNhanVien_Load(object sender, System.EventArgs e)
        {
            UserService us = new UserService();
            List<USER> listOfUser = us.getAllUser();
            dgv_dsNhanVien.DataSource = listOfUser;
            dgv_dsNhanVien.Columns["ACCOUNT"].Visible = false;
            dgv_dsNhanVien.Columns["ACCOUNTs"].Visible = false;
            dgv_dsNhanVien.Columns["ROLEs"].Visible = false;

            ACCOUNT acc = listOfUser[1].ACCOUNT;
            Debug.WriteLine(acc.USERNAME);
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {

        }
    }
}
