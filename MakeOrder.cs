using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Steklo
{
    public partial class MakeOrder : Form
    {
        StekloPacketDataSet.ClientDataTable clients;
        StekloPacketDataSet.HomeTypeDataTable homeType;
        string nameClient, surnameClient, patronymicClient, phoneClient, addressClient;
        bool refresh = true;
        int idhometype, idwindowtype, idprofiletype;


        
        private void MakeOrder_Load(object sender, EventArgs e)
        {
            ShowHomeTypes();

            comboBox_windowstype.DataSource = windowsTypeTableAdapter1.GetData();
            comboBox_windowstype.DisplayMember = "Title";
            comboBox_windowstype.ValueMember = "IDWindowType";
            comboBox_windowstype.SelectedIndex = 0;

            comboBox_profiletype.DataSource = profileTypeTableAdapter1.GetData();
            comboBox_profiletype.DisplayMember = "Title";
            comboBox_profiletype.ValueMember = "IDProfileType";
            comboBox_windowstype.SelectedIndex = 0;
        }

        public void ShowHomeTypes()
        {
            if (refresh == true)
            {
                comboBox_hometype.DataSource = homeTypeTableAdapter1.GetData();
                comboBox_hometype.DisplayMember = "Name";
                comboBox_hometype.ValueMember = "IDHomeType";
                comboBox_hometype.SelectedIndex = 0;
                refresh = false;
            }
        }

        private void button_no_hometype_Click(object sender, EventArgs e)
        {
            refresh = true;
            AddHomeType addHomeType = new AddHomeType();
            this.Hide();
            addHomeType.ShowDialog();
            this.Show();
        }

        private void comboBox_hometype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //idhometype = (int)comboBox_hometype.SelectedValue;
            //
        }

        private void comboBox_hometype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idhometype = (int)comboBox_hometype.SelectedValue;            
        }

        private void comboBox_windowstype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idwindowtype = (int)comboBox_windowstype.SelectedValue;
            textBox_width.Text = windowsTableAdapter1.SelectWidth(idhometype, idwindowtype).ToString();
            textBox_height.Text = windowsTableAdapter1.SelectHeight(idhometype, idwindowtype).ToString();
        }

        private void comboBox_profiletype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idprofiletype = (int)comboBox_profiletype.SelectedValue;
            if (idprofiletype == 1 || idprofiletype == 2)
            {

            }
            else
            { 
                
            }
        }

        private void comboBox_hometype_DropDown(object sender, EventArgs e)
        {
            ShowHomeTypes();
        }

        

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }
        }
        public MakeOrder()
        {
            InitializeComponent();
            textBox_phone.MaxLength = 12;
        }

        

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_to_base_Click(object sender, EventArgs e)
        {
            surnameClient = textBox_surname.Text;
            nameClient = textBox_name.Text;
            patronymicClient = textBox_patron.Text;
            phoneClient = textBox_phone.Text;
            addressClient = textBox_address.Text;
            string FIOClient;

            if (surnameClient == "" || nameClient == "" || patronymicClient == "" || phoneClient == "" || addressClient == "")
            {              
                MessageBox.Show("Вы не ввели одно из значений!!");
                return;
            }
            else
            {
                FIOClient = surnameClient + " " + nameClient + " " + patronymicClient;
                try
                {
                    clientTableAdapter1.InsertClient(FIOClient, phoneClient, addressClient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления клиента в базу");
                    return;
                }
    
            }
        }
    }
}
