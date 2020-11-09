namespace Coffee
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.p_Container = new System.Windows.Forms.Panel();
            this.btn_taiKhoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Container
            // 
            this.p_Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Container.Location = new System.Drawing.Point(0, 0);
            this.p_Container.Name = "p_Container";
            this.p_Container.Size = new System.Drawing.Size(676, 614);
            this.p_Container.TabIndex = 0;
            // 
            // btn_taiKhoan
            // 
            this.btn_taiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_taiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_taiKhoan.Image")));
            this.btn_taiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_taiKhoan.Location = new System.Drawing.Point(24, 152);
            this.btn_taiKhoan.Name = "btn_taiKhoan";
            this.btn_taiKhoan.Size = new System.Drawing.Size(97, 71);
            this.btn_taiKhoan.TabIndex = 4;
            this.btn_taiKhoan.Text = "Tài khoản";
            this.btn_taiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_taiKhoan.UseVisualStyleBackColor = true;
            this.btn_taiKhoan.Click += new System.EventHandler(this.btn_taiKhoan_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(24, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quản lý nhân viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ThongKe.Location = new System.Drawing.Point(24, 309);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(97, 74);
            this.btn_ThongKe.TabIndex = 6;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.btn_taiKhoan);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 614);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.p_Container);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 614);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Container;
        private System.Windows.Forms.Button btn_taiKhoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}