using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steklo
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_make_order_Click(object sender, EventArgs e)
        {
            MakeOrder makeOrder = new MakeOrder();
            this.Hide();
            makeOrder.StartPosition = FormStartPosition.CenterScreen;
            makeOrder.ShowDialog();
            this.Show();
        }

        private void button_toOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            this.Hide();
            formOrders.StartPosition = FormStartPosition.CenterScreen;
            formOrders.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowProject win = new WindowProject();
            this.Hide();
            win.StartPosition = FormStartPosition.CenterScreen;
            win.ShowDialog();
            this.Show();
        }
    }
}
