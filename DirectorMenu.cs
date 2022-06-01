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
    public partial class DirectorMenu : Form
    {
        public DirectorMenu()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_manageradd_Click(object sender, EventArgs e)
        {
            ManagerAdd managerAdd = new ManagerAdd();
            this.Hide();
            managerAdd.StartPosition = FormStartPosition.CenterScreen;
            managerAdd.ShowDialog();
            this.Show();
        }

        private void button_otchetManager_Click(object sender, EventArgs e)
        {
            ManagersCheck managersCheck = new ManagersCheck();
            this.Hide();
            managersCheck.StartPosition = FormStartPosition.CenterScreen;
            managersCheck.ShowDialog();
            this.Show();
        }

        private void button_otchetSum_Click(object sender, EventArgs e)
        {
            CompanyCheck companyCheck = new CompanyCheck();
            this.Hide();
            companyCheck.StartPosition = FormStartPosition.CenterScreen;
            companyCheck.ShowDialog();
            this.Show();
        }

        private void button_redakt_Click(object sender, EventArgs e)
        {
            ChangeCostandTovars changeCostand = new ChangeCostandTovars();
            this.Hide();
            changeCostand.StartPosition = FormStartPosition.CenterScreen;
            changeCostand.ShowDialog();
            this.Show();
        }
    }
}
