using Challenge_thu_lam_DA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_thu_lam_DA
{
    public partial class frmDashboard : Form
    {
        public frmDashboard(User user)
        {
            InitializeComponent();
            lb_name.Text = user.name;
            lb_email.Text = user.email;
            lb_name.TextAlign = ContentAlignment.MiddleCenter;
            lb_email.TextAlign = ContentAlignment.MiddleCenter;
            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
          //  bunifuFormDock1.SubscribeControlToDragEvents(bunifuPanel2);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(1);
            inlicator.Top = ((Control)sender).Top;

        }

        private void btn_finance_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(2);
            inlicator.Top = ((Control)sender).Top;
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(3);
            inlicator.Top = ((Control)sender).Top;
        }

        private void btn_presciption_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(4);
            inlicator.Top = ((Control)sender).Top;
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(5);
            inlicator.Top = ((Control)sender).Top;
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            inlicator.Show();
            bunifuPages1.SetPage(6);
            inlicator.Top = ((Control)sender).Top;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            inlicator.Hide();
            inlicator.Top = ((Control)sender).Top;
        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }

     
        private void btn_exit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            product add =new product();
            flowLayoutPanel1.Controls.Add(add);

        }
    }
}
