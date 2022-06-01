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
    public partial class CompanyCheck : Form
    {
        public CompanyCheck()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyCheck_Load(object sender, EventArgs e)
        {
            comboBox_period.SelectedIndex = 0;
            label_kolvoorders.Text = "Общее количество заказов за все время: " + ordersCompanyTableAdapter1.SelectAllOrders();
            label_kolvo_windows.Text = "Общее число реализованной продукции за все время: " + ordersCompanyTableAdapter1.SelectAllCount();
            label_summ.Text = "Общая сумма заказов за все время: " + ordersCompanyTableAdapter1.SelectAllSum();
        }

        private void comboBox_period_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_period.SelectedIndex == 0)
            {
                label_kolvoorders.Text = "Общее количество заказов за все время: " + ordersCompanyTableAdapter1.SelectAllOrders();
                label_kolvo_windows.Text = "Общее число реализованной продукции за все время: " + ordersCompanyTableAdapter1.SelectAllCount();
                label_summ.Text = "Общая сумма заказов за все время: " + ordersCompanyTableAdapter1.SelectAllSum();
            }

            if (comboBox_period.SelectedIndex == 1)
            {
                DateTime now = DateTime.Now;
                var startDate = new DateTime(now.Year, now.Month, 1);

                label_kolvoorders.Text = "Общее количество заказов за месяц: " + ordersCompanyTableAdapter1.SelectMonthOrders(startDate.ToString("yyyy-dd-MM"));
                label_kolvo_windows.Text = "Общее число реализованной продукции за месяц: " + ordersCompanyTableAdapter1.SelectAllCount();
                label_summ.Text = "Общая сумма заказов за месяц: " + ordersCompanyTableAdapter1.SelectMonthSum(startDate.ToString("yyyy-dd-MM"));


            }
        }
    }
}
