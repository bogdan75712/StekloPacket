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
    public partial class Form_Auth : Form
    {
        StekloPacketDataSet.UsersDataTable dataUsers;
        bool visible_pass = false;
        int error_input;
        public Form_Auth()
        {
            InitializeComponent();
            dataUsers = this.usersTableAdapter1.GetData();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = this.textBox_pass.Text;
            log = this.textBox_login.Text;			
            dataUsers = this.usersTableAdapter1.GetData();           		                 
            var filter = dataUsers.Where(rec => rec.Login == log && rec.Password == pas);
            if (filter.Count() == 0)    //Нет записей – совпадение логина+пароля не найдено
            {
                MessageBox.Show("Таких данных нет.");                
                error_input++;
            
                switch (error_input)
                {
                    case 3:
                        MessageBox.Show("Вы 3 раза подряд ввели неправильные данные для входа. Система заблокирована на 15 секунд");
                        button_enter.Enabled = false;
                        timer1.Tick += new EventHandler(timer1_Tick);
                        timer1.Interval = 15000;
                        timer1.Start();
                        break;
                    case 4:
                        MessageBox.Show("Вы 4 раза подряд ввели неправильные данные для входа. Система заблокирована на 20 секунд");
                        button_enter.Enabled = false;
                        timer1.Tick += new EventHandler(timer1_Tick);
                        timer1.Interval = 20000;
                        timer1.Start();
                        break;
                    case 5:
                        MessageBox.Show("Вы 5 раз подряд ввели неправильные данные для входа. Система автоматически закроется");
                        Application.Exit();
                        break;

                }
            }
            else				
               
                
                ClassTotal.idUser = filter.ElementAt(0).IDUser;
                ClassTotal.idRole = filter.ElementAt(0).IDRole;
                ClassTotal.login = filter.ElementAt(0).Login;
                //Переход к формам в зависимости от роли
                switch (ClassTotal.idRole)
                {
                    case 2:
                        MessageBox.Show("Вы успешно авторизовались как менеджер.");
                        ManagerMenu managerMenu = new ManagerMenu();
                        this.Hide();
                        managerMenu.ShowDialog();
                        this.Show();
                        break;
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались как директор.");
                        DirectorMenu directorMenu = new DirectorMenu();
                        this.Hide();
                        directorMenu.ShowDialog();
                        this.Show();
                        break;                 
                
            }
            }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_pass_Click(object sender, EventArgs e)
        {
            if (visible_pass == false)
            {
                this.textBox_pass.PasswordChar = '\0';
                visible_pass = true;
            }
            else
            {
                this.textBox_pass.PasswordChar = '@';
                visible_pass = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button_enter.Enabled = true;
        }
    }
}
