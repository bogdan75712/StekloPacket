using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Steklo
{
    public partial class ManagersCheck : Form
    {
        StekloPacketDataSet.OrdersManagersDataTable ordersManagers;
        StekloPacketDataSet.UsersDataTable dataUsers;
        int idManager;
        decimal summ;
        public ManagersCheck()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagersCheck_Load(object sender, EventArgs e)
        {
            dataUsers = this.usersTableAdapter1.GetData();
            comboBox_manager.DataSource = dataUsers.Where(x => x.IDRole > 1).CopyToDataTable();
            //omboBox_manager.DataSource = usersTableAdapter1.GetData();
            comboBox_manager.DisplayMember = "Login";
            comboBox_manager.ValueMember = "IDUser";
            comboBox_manager.SelectedIndex = 0;
            idManager = (int)comboBox_manager.SelectedValue;

            comboBox_period.SelectedIndex = 0;

            ordersManagers = this.ordersManagersTableAdapter1.GetData(idManager);
            dataGridView1.DataSource = ordersManagers.CopyToDataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; 	//Нет дополнительных строк
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "Менеджер";
            dataGridView1.Columns[1].HeaderText = "Номер заказа";
            dataGridView1.Columns[2].HeaderText = "Сумма";
            dataGridView1.Columns[3].HeaderText = "Дата заказа";

            summ = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                summ += (decimal)dataGridView1.Rows[i].Cells[2].Value;
            }
            
            label_summ.Text = "Сумма продаж: " + summ;
        }

        private void comboBox_manager_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idManager = (int)comboBox_manager.SelectedValue;
            ordersManagers = this.ordersManagersTableAdapter1.GetData(idManager);
            dataGridView1.DataSource = ordersManagers.CopyToDataTable();
            summ = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                summ += (decimal)dataGridView1.Rows[i].Cells[2].Value;
            }

            label_summ.Text = "Сумма продаж: " + summ;
        }

        private void comboBox_period_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            
            var endDate = startDate.AddMonths(1).AddDays(-1);

            if (comboBox_period.SelectedIndex == 0)
            {
                idManager = (int)comboBox_manager.SelectedValue;
                ordersManagers = this.ordersManagersTableAdapter1.GetData(idManager);
                dataGridView1.DataSource = ordersManagers.CopyToDataTable();
                summ = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    summ += (decimal)dataGridView1.Rows[i].Cells[2].Value;
                }

                label_summ.Text = "Сумма продаж: " + summ;
            }
            if (comboBox_period.SelectedIndex == 1)
            {
                idManager = (int)comboBox_manager.SelectedValue;
                //MessageBox.Show(startDate.ToString("yyyy-MM-dd"));
                ordersManagers = this.ordersManagersTableAdapter1.GetDataByMonth(startDate.ToString("yyyy-dd-MM"), idManager);
                dataGridView1.DataSource = ordersManagers.CopyToDataTable();
                summ = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    summ += (decimal)dataGridView1.Rows[i].Cells[2].Value;
                }

                label_summ.Text = "Сумма продаж: " + summ;

                
            }

        }
    }
}
