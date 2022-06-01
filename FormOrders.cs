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
    public partial class FormOrders : Form
    {
        StekloPacketDataSet.OrdersUsersClientDataTable dataOrders;
        public FormOrders()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dataOrders = this.ordersUsersClientTableAdapter1.GetData(ClassTotal.idUser);
            dataGridView1.DataSource = dataOrders.CopyToDataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; 	//Нет дополнительных строк
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Номер заказа";
            dataGridView1.Columns[1].HeaderText = "Сумма заказа";
            dataGridView1.Columns[2].HeaderText = "Скидка";
            dataGridView1.Columns[3].HeaderText = "Дата заказа";
            dataGridView1.Columns[4].HeaderText = "Дата выполнения";
            dataGridView1.Columns[5].HeaderText = "Клиент";
            dataGridView1.Columns[6].HeaderText = "Менеджер";
        }
    }
}
