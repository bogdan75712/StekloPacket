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
    public partial class AddHomeType : Form
    {
        public AddHomeType()
        {
            InitializeComponent();
        }

        private void button_addhome_Click(object sender, EventArgs e)
        {
            string namehometype, hometype;
            hometype = textBox_hometype.Text;
            namehometype = textBox_name_hometype.Text;

            if (hometype == "" || namehometype == "")
            {
                MessageBox.Show("Введите все значения");
            }
            else 
            {
                homeTypeTableAdapter1.InsertHomeType(namehometype, hometype);
                MessageBox.Show("Успешно добавлено");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
