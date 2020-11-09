using System;
using System.Windows.Forms;

namespace Coffee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_taiKhoan_Click(object sender, EventArgs e)
        {
            this.p_Container.Controls.Clear();
            TaiKhoan taiKhoanform = new TaiKhoan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            taiKhoanform.FormBorderStyle = FormBorderStyle.None;
            this.p_Container.Controls.Add(taiKhoanform);
            taiKhoanform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.p_Container.Controls.Clear();
            QLyNhanVien qlyNhanVienform = new QLyNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            qlyNhanVienform.FormBorderStyle = FormBorderStyle.None;
            this.p_Container.Controls.Add(qlyNhanVienform);
            qlyNhanVienform.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.p_Container.Controls.Clear();
            ThongKe thongKeForm = new ThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongKeForm.FormBorderStyle = FormBorderStyle.None;
            this.p_Container.Controls.Add(thongKeForm);
            thongKeForm.Show();
        }
    }
}
