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
    public partial class ManagerAdd : Form
    {
        StekloPacketDataSet.UsersDataTable dataUsers;
        public ManagerAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass;
            string login;
            if (textBox_login.Text != "" || textBox_password.Text != "")
            {
                login = textBox_login.Text;
                pass = textBox_password.Text;
                DataTable dt = usersTableAdapter1.GetDataByManager(login,pass);
                if (dt.Rows.Count == 0)
                {
                    int idmanager = (int)(usersTableAdapter1.SelectLastID() + 1);
                    try
                    {
                        usersTableAdapter1.InsertManager(idmanager, login, pass, 2);
                        MessageBox.Show("Менеджер добавлен в систему");
                        dataUsers = this.usersTableAdapter1.GetData();
                        dataGridView1.DataSource = dataUsers.Where(x => x.IDRole > 1).CopyToDataTable();
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show("Не удалось добавить пользователя");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Менеджер с такими данными уже есть");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
        }

        private void ManagerAdd_Load(object sender, EventArgs e)
        {
            dataUsers = this.usersTableAdapter1.GetData();
            dataGridView1.DataSource = dataUsers.Where(x => x.IDRole > 1).CopyToDataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false; 	//Нет дополнительных строк
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].Visible = false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
