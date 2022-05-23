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
        decimal cost = 0;
        int idhometype = 1, idwindowtype = 1, idprofiletype, idmanufacturer, width = 500, height = 500, idglazingtype, idcolor, idsill, idleftsash, idrightsash, idmediumsash;
        decimal squarewidth = 0.0M;
        decimal squareheight = 0.0M;
        decimal summsquare = 0.0M;

        
        private void MakeOrder_Load(object sender, EventArgs e)
        {
            ShowHomeTypes();
            idhometype = (int)comboBox_hometype.SelectedValue;

            comboBox_windowstype.DataSource = windowsTypeTableAdapter1.GetData();
            comboBox_windowstype.DisplayMember = "Title";
            comboBox_windowstype.ValueMember = "IDWindowType";
            idwindowtype = (int)comboBox_windowstype.SelectedValue; 
            //ShowHeightAndWidth();
            
            //textBox_height.Text = "500";
            //textBox_width.Text = "500";

            comboBox_profiletype.DataSource = profileTypeTableAdapter1.GetData();
            comboBox_profiletype.DisplayMember = "Title";
            comboBox_profiletype.ValueMember = "IDProfileType";
            comboBox_windowstype.SelectedIndex = 0;
            idprofiletype = (int)comboBox_profiletype.SelectedValue;

            comboBox_manufacturer.DataSource = manufacturerTableAdapter1.GetData();
            comboBox_manufacturer.DisplayMember = "Title";
            comboBox_manufacturer.ValueMember = "IDManufacturer";
            comboBox_windowstype.SelectedIndex = 0;
            comboBox_manufacturer.Enabled = false;
            idmanufacturer = (int)comboBox_manufacturer.SelectedValue;

            comboBox_glazingtype.DataSource = glazingTypeTableAdapter1.GetData();
            comboBox_glazingtype.DisplayMember = "Title";
            comboBox_glazingtype.ValueMember = "IDGlazingType";
            comboBox_glazingtype.SelectedIndex = 0;
            idglazingtype = (int)comboBox_glazingtype.SelectedValue;

            comboBox_color.DataSource = colorsTableAdapter1.GetData();
            comboBox_color.DisplayMember = "Title";
            comboBox_color.ValueMember = "IDColor";
            comboBox_color.SelectedIndex = 0;
            idcolor = (int)comboBox_color.SelectedValue;

            comboBox_sill.DataSource = windowSillTableAdapter1.GetData();
            comboBox_sill.DisplayMember = "Title";
            comboBox_sill.ValueMember = "IDWindowSill";
            comboBox_sill.SelectedIndex = 0;
            idsill = (int)comboBox_sill.SelectedValue;

            comboBox_leftsash.DataSource = leftSashTableAdapter1.GetData();
            comboBox_leftsash.DisplayMember = "Title";
            comboBox_leftsash.ValueMember = "IDLeftSash";
            idleftsash = (int)comboBox_leftsash.SelectedValue;  

            comboBox_rigthsash.DataSource = rightSashTableAdapter1.GetData();
            comboBox_rigthsash.DisplayMember = "Title";
            comboBox_rigthsash.ValueMember = "IDRightSash";

            comboBox_centrsash.DataSource = mediumSashTableAdapter1.GetData();
            comboBox_centrsash.DisplayMember = "Title";
            comboBox_centrsash.ValueMember = "IDMediumSash";
            comboBox_centrsash.Visible = false;

            label_cost.Text = "Цена окна: " + cost;
            //WindowCost();
        }

        public void WindowCost()
        {
            idglazingtype = (int)comboBox_glazingtype.SelectedValue;
            idsill = (int)comboBox_sill.SelectedValue;
            idcolor = (int)comboBox_color.SelectedValue;
            idleftsash = (int)comboBox_leftsash.SelectedValue;
            idrightsash = (int)comboBox_rigthsash.SelectedValue;
            idmediumsash = (int)comboBox_centrsash.SelectedValue;
            idprofiletype = (int)comboBox_profiletype.SelectedValue;

            //cost = Convert.ToDecimal(windowsTableAdapter1.SelectWindowCost(idcolor,width,height,idwindowtype,idsill,idprofiletype,idhometype,idglazingtype,idleftsash,idrightsash,idmediumsash));
            //if (cost != 0)
            //{
            //    label_cost.Text = "Цена окна: " + Math.Round(cost, 2).ToString();
            //}
            //else 
            //{
                //width = textBox_width.Text;
                squarewidth = Convert.ToDecimal(width) / 1000;
                squareheight = Convert.ToDecimal(height) / 1000;
                summsquare = squareheight * squarewidth;
                if (idwindowtype == 1)
                {
                    idrightsash = 1;
                    idmediumsash = 1;
                }
                if (summsquare <= 1)
                {
                    switch (idglazingtype)
                    {
                        case 1:
                            cost = 1 * 5800.50M;
                            break;
                        case 2:
                            cost = 1 * 6800.70M;
                            break;
                        case 3:
                            cost = 1 * 8100.10M;
                            break;
                    }
                }
                else
                {
                    switch (idglazingtype)
                    {
                        case 1:
                            cost = summsquare * 5800.50M;
                            break;
                        case 2:
                            cost = summsquare * 6800.70M;
                            break;
                        case 3:
                            cost = summsquare * 8100.10M;
                            break;
                    }
                }

                switch (idsill)
                {
                    case 1:
                        cost += 500;
                        break;
                    case 2:
                        cost += 650;
                        break;
                    case 3:
                        cost += 750;
                        break;
                    case 4:
                        cost += 900;
                        break;
                    case 5:
                        cost += 1000;
                        break;
                    case 6:
                        cost += 1150;
                        break;
                }

                switch (idcolor)
                {
                    case 1:
                        cost += 0;
                        break;
                    case 2:
                        cost += 250;
                        break;
                    case 3:
                        cost += 500;
                        break;
                    case 4:
                        cost += 1000;
                        break;
                    case 5:
                        cost += 1000;
                        break;

                }

                switch (idleftsash)
                {
                    case 1:
                        cost += 0;
                        break;
                    case 2:
                        cost += 1500;
                        break;
                    case 3:
                        cost += 2000;
                        break;
                }

                switch (idrightsash)
                {
                    case 1:
                        cost += 0;
                        break;
                    case 2:
                        cost += 1500;
                        break;
                    case 3:
                        cost += 2000;
                        break;
                }
                switch (idmediumsash)
                {
                    case 1:
                        cost += 0;
                        break;
                    case 2:
                        cost += 200;
                        break;
                    case 3:
                        cost += 1500;
                        break;
                    case 4:
                        cost += 2000;
                        break;
                }

                switch (idprofiletype)
                {
                    case 1:
                        cost += 1400;
                        break;
                    case 2:
                        cost += 2000;
                        break;
                    case 3:
                        cost += 500;
                        break;
                    case 4:
                        cost += 1000;
                        break;
                }
                label_cost.Text = "Цена окна: " + Math.Round(cost, 2).ToString();

            //}
            
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

        private void comboBox_glazingtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //WindowCost();
        }

        private void comboBox_glazingtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            WindowCost();
        }

        private void comboBox_sill_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void comboBox_color_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void comboBox_leftsash_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void comboBox_centrsash_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_centrsash_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void comboBox_rigthsash_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void comboBox_hometype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_hometype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idhometype = (int)comboBox_hometype.SelectedValue;
            textBox_height.Text = "";
            height = 500;
            textBox_width.Text = "";
            width = 500;
            ShowHeightAndWidth();
        }

        private void textBox_width_TextChanged(object sender, EventArgs e)
        {
            if (textBox_width.Text != "")
            {
                width = Convert.ToInt32(textBox_width.Text);
            }
            
            if (width < 500)
            {
                label_widthtype.Text = "";
                label_width.Text = "Значение ширины не может быть меньше 500";
                label_width.ForeColor = Color.Red;
            }
            if (width >= 500)
            {
                label_width.Text = "";
            }
            if (width > 2800)
            {
                label_widthtype.Text = "";
                label_width.Text = "Значение ширины не может быть больше 2800";
                label_width.ForeColor = Color.Red;
            }
            if (width <= 2800 && width >= 500)
            {
                label_width.Text = "";
            }
            WindowCost();
        }

        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
            if (textBox_height.Text != "")
            {
                height = Convert.ToInt32(textBox_height.Text);
            }
            
            if (height < 500)
            {
                label_heighttype.Text = "";
                label_height.Text = "Значение высоты не может быть меньше 500";
                label_height.ForeColor = Color.Red;
            }
            if (height >= 500)
            {
                label_height.Text = "";
            }

            if (height > 2000)
            {
                label_heighttype.Text = "";
                label_height.Text = "Значение высоты не может быть больше 2000";
                label_height.ForeColor = Color.Red;
            }
            if (height <= 2000 && height >= 500)
            {
                label_height.Text = "";
            }
            WindowCost();
        }

        private void textBox_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox_windowstype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idwindowtype == 1)
            {
                comboBox_centrsash.Visible = false;
                comboBox_centrsash.Enabled = false;
                comboBox_rigthsash.Visible = false;
                comboBox_rigthsash.Enabled = false;
                
            }
            if (idwindowtype == 2)
            {
                comboBox_centrsash.Visible = false;
                comboBox_centrsash.Enabled = false;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
            }
            if (idwindowtype == 3)
            {
                comboBox_centrsash.Visible = true;
                comboBox_centrsash.Enabled = true;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
            }         
        }

        private void comboBox_windowstype_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            idwindowtype = (int)comboBox_windowstype.SelectedValue;
            label_widthtype.Text = "";
            label_heighttype.Text = "";
            ShowHeightAndWidth();
            WindowCost();
        }

        public void ShowHeightAndWidth()
        {
            string str_height;
            string str_width;
            str_width = windowsTableAdapter1.SelectWidth(idhometype, idwindowtype).ToString();
            str_height = windowsTableAdapter1.SelectHeight(idhometype, idwindowtype).ToString();
            if (str_width != "")
            {
                textBox_width.Text = str_width;
                label_widthtype.Text = "это типовой размер";
            }
            if (str_height != "")
            {
                textBox_height.Text = str_height;
                label_heighttype.Text = "это типовой размер";
            }
            //textBox_width.Text = windowsTableAdapter1.SelectWidth(idhometype, idwindowtype).ToString();
            
            //textBox_height.Text = windowsTableAdapter1.SelectHeight(idhometype, idwindowtype).ToString();
            
        }

        private void comboBox_profiletype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idprofiletype = (int)comboBox_profiletype.SelectedValue;
            idmanufacturer =  (int)profileTypeTableAdapter1.SelectManufacturer(idprofiletype);
            if (idmanufacturer == 1)
            {
                comboBox_manufacturer.SelectedValue = 1;
                comboBox_manufacturer.Enabled = false;
            }
            else
            {
                comboBox_manufacturer.SelectedValue = 2;
                comboBox_manufacturer.Enabled = false;
            }
            WindowCost();
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
