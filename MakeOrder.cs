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
        List<int> IdWindow = new List<int>();
        List<int> CountWindow = new List<int>();
        Panel panel;
        Label label_windowtype, label_size, label_profiletype, label_glazingtype, label_costwindow, label_count_window;
        Button deleteFrommarket;
        //DateTime dateOrder = new DateTime();
        //DateTime datePerform = new DateTime();
        string dateOrder;
        string datePerform;
        int IDwindow;
        int idwindowinmarket = 0;
        int panelid = 0;
        int montage = 0, demontage = 0;
        int count = 0;
        int idClient;
        int IDOrder;
        string nameClient, surnameClient, patronymicClient, phoneClient, addressClient;
        bool refresh = true;
        bool clientadded = false;
        decimal cost = 0;
        int idhometype = 1, idwindowtype = 1, idprofiletype, idmanufacturer, width = 500, height = 500, idglazingtype, idcolor, idsill, idleftsash, idrightsash, idmediumsash;
        decimal squarewidth = 0.0M;
        decimal squareheight = 0.0M;
        decimal summsquare = 0.0M;
        decimal totalcost = 0.0M;
        decimal sumsale = 0.0M;


        private void MakeOrder_Load(object sender, EventArgs e)
        {
            
            comboBox_client.Enabled = false;
            comboBox_client.Visible = false;
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; //свеху
            this.flowLayoutPanel1.AutoScroll = true;  //Полосы прокрутки
            this.flowLayoutPanel1.WrapContents = false;//Нет перехода на новую строку
            this.flowLayoutPanel1.Font = new Font(FontFamily.GenericMonospace, 12);
            this.flowLayoutPanel1.Controls.Clear();
            checkBox_demontage.Checked = true;
            pictureBox_dvyx.Visible = false;
            pictureBox_trx.Visible = false;
            pictureBox_odn.BackgroundImage = Properties.Resources.odn_glx;
            pictureBox_odn.BackgroundImageLayout  = ImageLayout.Zoom;
            pictureBox_dvyx.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox_trx.BackgroundImageLayout = ImageLayout.Zoom;
            ShowHomeTypes();
            idhometype = (int)comboBox_hometype.SelectedValue;

            comboBox_windowstype.DataSource = windowsTypeTableAdapter1.GetData();
            comboBox_windowstype.DisplayMember = "Title";
            comboBox_windowstype.ValueMember = "IDWindowType";
            idwindowtype = (int)comboBox_windowstype.SelectedValue; 
            //ShowHeightAndWidth();
            
            //textBox_height.Text = "500";
            //ыtextBox_width.Text = "500";

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

            comboBox_centrsash.DataSource = mediumSashTableAdapter1.GetDataByMediumSash();
            comboBox_centrsash.DisplayMember = "Title";
            comboBox_centrsash.ValueMember = "IDMediumSash";
            comboBox_centrsash.Visible = false;

            comboBox_client.DataSource = clientTableAdapter1.GetData();
            comboBox_client.DisplayMember = "FIO";
            comboBox_client.ValueMember = "IDClient";


            label_cost.Text = "Цена окна: " + cost;
            //WindowCost();
        }

        public void WindowCost()
        {
            idhometype = (int)comboBox_hometype.SelectedValue;
            idwindowtype = (int)comboBox_windowstype.SelectedValue;
            idglazingtype = (int)comboBox_glazingtype.SelectedValue;
            idsill = (int)comboBox_sill.SelectedValue;
            idcolor = (int)comboBox_color.SelectedValue;
            idleftsash = (int)comboBox_leftsash.SelectedValue;
            idrightsash = (int)comboBox_rigthsash.SelectedValue;
            idmediumsash = (int)comboBox_centrsash.SelectedValue;
            idprofiletype = (int)comboBox_profiletype.SelectedValue;
            idmanufacturer = (int)comboBox_manufacturer.SelectedValue;

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
                if (checkBox_montage.Checked)
                {
                    montage = 1;
                }
                else
                {
                    montage = 0;
                }
                
                switch (montage)
                {
                    case 0:
                    cost += 0;
                    break;
                    case 1:
                    cost += 2500;
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
            WindowShow();
        }

        private void comboBox_centrsash_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_centrsash_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
            WindowShow();
        }

        private void checkBox_montage_CheckedChanged(object sender, EventArgs e)
        {
            WindowCost();
        }

        private void checkBox_demontage_CheckedChanged(object sender, EventArgs e)
        {
                       
            
        }

        private void checkBox_demontage_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_demontage.Checked == true)
            {
                demontage = 1;
            }
            else if (checkBox_demontage.Checked == false)
            {
                demontage = 0;
            }
            switch (demontage)
            {
                case 0:
                    totalcost -= 9990;
                    label_totalcost.Text = "Цена заказа: " + Math.Round(totalcost, 2);
                    break;
                case 1:
                    totalcost += 9990;
                    label_totalcost.Text = "Цена заказа: " + Math.Round(totalcost,2);
                    break;
            }
        }

        private void numericUpDown_sale_ValueChanged(object sender, EventArgs e)
        {
            
            sumsale = numericUpDown_sale.Value;
                             
            //sumsale = totalcost * numericUpDown_sale.Value / 100;
            //totalcost = totalcost - sumsale;
            //label_totalcost.Text = "Цена заказа: " + Math.Round(totalcost,2);
        }

        private void button_chooseclient_Click(object sender, EventArgs e)
        {
            comboBox_client.Enabled = true;
            comboBox_client.Visible = true;
            button_add_to_base.Enabled = false;
        }

        private void comboBox_client_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idClient = (int)comboBox_client.SelectedValue;
            DataTable dt = new DataTable();
            dt = clientTableAdapter1.GetDataByClient(idClient);
            maskedTextBox_phone.Text = dt.Rows[0][2].ToString();
            textBox_address.Text = dt.Rows[0][3].ToString();
            string fio = dt.Rows[0][1].ToString();
            string[] words = fio.Split(' ');
            //MessageBox.Show(fio);
            textBox_surname.Text = words[0];
            textBox_name.Text = words[1];
            textBox_patron.Text = words[2];
        }

        private void groupBox_window_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox_dvyx_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sumsale = numericUpDown_sale.Value;

            sumsale = totalcost * numericUpDown_sale.Value / 100;
            totalcost = totalcost - sumsale;

            label_totalcost.Text = "Цена заказа: " + Math.Round(totalcost, 2);
            checkBox1.Enabled = false;
        }

        private void comboBox_profiletype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_oform_order_Click(object sender, EventArgs e)
        {
            if (clientadded == true)
            {
                ClassTotal.TotalCost = totalcost;
                if (demontage == 0)
                {
                    ClassTotal.Demontage = false;
                }
                else
                {
                    ClassTotal.Demontage = true;
                }
                if (demontage == 0)
                {
                    ClassTotal.Montage = false;
                }
                else
                {
                    ClassTotal.Montage = true;
                }
                //ClassTotal.Demontage = demontage;

                dateOrder = dateTimePicker_order.Value.ToShortDateString();
                datePerform = dateTimePicker_perform.Value.ToShortDateString();
                ClassTotal.sale = numericUpDown_sale.Value;
                ClassTotal.TotalCost = totalcost;
                

                if (ordersTableAdapter1.SelectLastID().ToString() == "")
                {
                    IDOrder = 1;
                    ClassTotal.idOrder = IDOrder;
                }
                else
                {
                    IDOrder = (int)(ordersTableAdapter1.SelectLastID() + 1);
                    ClassTotal.idOrder = IDOrder;
                }
                try
                {
                    ordersTableAdapter1.InsertOrder(IDOrder, ClassTotal.idClient, ClassTotal.TotalCost, ClassTotal.sale, ClassTotal.Montage, ClassTotal.Demontage, dateOrder.ToString(), datePerform.ToString(), ClassTotal.idUser);
                    MessageBox.Show("Заказа добавлен в базу");
                    this.flowLayoutPanel1.Controls.Clear();
                    IdWindow.Clear();
                    CountWindow.Clear();
                    //cost = 0;
                    //WindowCost();

                    totalcost = 0;
                    label_totalcost.Text = "Цена заказа: ";
                    checkBox1.Enabled = true;

                    textBox_address.Text = "";
                    textBox_name.Text = "";
                    textBox_patron.Text = "";
                    textBox_surname.Text = "";
                    maskedTextBox_phone.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось внести заказ в базу");
                }
                for (int i = 0; i < IdWindow.Count; i++)
                {
                    orderDetailTableAdapter1.InsertOrderDetail(ClassTotal.idOrder, IdWindow[i], CountWindow[i]);
                }
            }
            else
            {
                MessageBox.Show("Сначала добавьте клиента");
                return;
            }

        }

        private void comboBox_rigthsash_SelectionChangeCommitted(object sender, EventArgs e)
        {
            WindowCost();
            WindowShow();
        }

        private void button_delAllinmarket_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            IdWindow.Clear();
            CountWindow.Clear();
            //cost = 0;
            //WindowCost();

            totalcost = 0;
            label_totalcost.Text = "Цена заказа: ";
            checkBox1.Enabled = true;
        }

        private void button_addwindowtoDB_Click(object sender, EventArgs e)
        {
            decimal costadded;
            DataTable dt = windowsTableAdapter1.GetDataByWindow(idcolor,width,height,idwindowtype,idsill,idprofiletype,idhometype,idglazingtype,idleftsash,idrightsash,idmediumsash);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("такого окна нет");
                if (width != 0 && height != 0 && width >= 500 && width <= 2800 && height >= 500 && height <= 2000)
                {
                    costadded = cost;
                    if (montage == 1)
                    {
                        costadded -= 2500;
                    }
                    int windowID;
                    windowID = (int)(windowsTableAdapter1.SelectLastID() + 1);
                    windowsTableAdapter1.InsertWindow(windowID, cost, idcolor, idmanufacturer, width, height, 1, idwindowtype, idsill, idprofiletype, idhometype, idglazingtype, idleftsash, idrightsash, idmediumsash);
                    MessageBox.Show("Окно успешно добавлено в базу");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить в базу");
                }
            }
            else
            {
                MessageBox.Show("Такое окно есть в базе");
                return;
            }
        }

        private void button_addtomarket_Click(object sender, EventArgs e)
        {
            
            
            if (width != 0 && height != 0 && width >= 500 && width <= 2800 && height >= 500 && height <= 2000 && textBox_height.Text != "" && textBox_width.Text != "" && numericUpDown1.Value !=0)
            {
                DataTable dt = windowsTableAdapter1.GetDataByWindow(idcolor, width, height, idwindowtype, idsill, idprofiletype, idhometype, idglazingtype, idleftsash, idrightsash, idmediumsash);
                if (dt.Rows.Count != 0)
                {
                    IDwindow = (int)windowsTableAdapter1.SelectWindowID(idcolor, width, height, idwindowtype, idsill, idprofiletype, idhometype, idglazingtype, idleftsash, idrightsash, idmediumsash);
                    count = 0;
                    count = (int)numericUpDown1.Value;
                    DataTable dat = windowTypeGlazingandProfile1.GetDataMarket(idglazingtype, idprofiletype, idwindowtype);
                    string glazing = dat.Rows[0][2].ToString();
                    string profile = dat.Rows[0][1].ToString();
                    string window = dat.Rows[0][0].ToString();

                    cost = cost * count;
                    totalcost += cost;
                    totalcost = Math.Round(totalcost, 2);
                    label_totalcost.Text = "Цена заказа:" + totalcost;


                    //panels.Add(panel);
                    panel = new Panel();
                    panel.Size = new Size(this.flowLayoutPanel1.Width, 150);
                    label_windowtype = new Label();
                    label_windowtype.Location = new Point(0, 0);
                    label_windowtype.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_windowtype.AutoSize = false;
                    label_windowtype.Text = "Тип окна: " + window;
                    panel.Controls.Add(label_windowtype);

                    label_size = new Label();
                    label_size.Location = new Point(0, 20);
                    label_size.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_size.AutoSize = false;
                    label_size.Text = "Размер: " + width + "X" + height + "мм";
                    panel.Controls.Add(label_size);

                    label_profiletype = new Label();
                    label_profiletype.Location = new Point(0, 40);
                    label_profiletype.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_profiletype.AutoSize = false;
                    label_profiletype.Text = "Тип профиля: " + profile;
                    panel.Controls.Add(label_profiletype);

                    label_glazingtype = new Label();
                    label_glazingtype.Location = new Point(0, 60);
                    label_glazingtype.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_glazingtype.AutoSize = false;
                    label_glazingtype.Text = "Тип стеклопакета: " + glazing;
                    panel.Controls.Add(label_glazingtype);

                    label_count_window = new Label();
                    label_count_window.Location = new Point(0, 80);
                    label_count_window.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_count_window.AutoSize = false;
                    label_count_window.Text = "Количество: " + count;
                    panel.Controls.Add(label_count_window);

                    label_costwindow = new Label();
                    label_costwindow.Location = new Point(0, 100);
                    label_costwindow.Size = new Size(this.flowLayoutPanel1.Width, 20);
                    label_costwindow.AutoSize = false;
                    cost = Math.Round(cost, 2);
                    label_costwindow.Text = "Цена окна: " + cost;
                    panel.Controls.Add(label_costwindow);

                    IdWindow.Add(IDwindow);
                    CountWindow.Add(count);
                    //deleteFrommarket = new Button();
                    //deleteFrommarket.Location = new Point(50, 100);
                    //deleteFrommarket.Size = new Size(150, 30);
                    //deleteFrommarket.AutoSize = false;
                    //deleteFrommarket.Text = "Удалить товар";
                    //deleteFrommarket.FlatStyle = FlatStyle.Flat;
                    //deleteFrommarket.Tag = panelid;
                    //deleteFrommarket.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular);
                    //deleteFrommarket.Click += new EventHandler(this.DeleteFromMarket);
                    //panel.Controls.Add(deleteFrommarket);
                    //panel.Tag = panelid;
                    //panelid++;

                    this.flowLayoutPanel1.Controls.Add(panel);
                    cost = 0;
                    WindowCost();
                }
                else
                {
                    MessageBox.Show("Добавьте окно в базу");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Укажите правильные значения ширины, высоты и количества окон");
                return;
            }
            

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
                label16.Visible = false;
                comboBox_rigthsash.Visible = false;
                comboBox_rigthsash.Enabled = false;
                label17.Visible = false;
            }
            if (idwindowtype == 2)
            {
                comboBox_centrsash.Visible = false;
                comboBox_centrsash.Enabled = false;
                label16.Visible = false;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
                label17.Visible = true;
            }
            if (idwindowtype == 3)
            {
                comboBox_centrsash.Visible = true;
                comboBox_centrsash.Enabled = true;
                label16.Visible = true;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
                label17.Visible = true;
            }         
        }

        public void WindowShow()
        {
            idleftsash = (int)comboBox_leftsash.SelectedValue;
            idrightsash = (int)comboBox_rigthsash.SelectedValue;
            idmediumsash = (int)comboBox_centrsash.SelectedValue;
            idwindowtype = (int)comboBox_windowstype.SelectedValue;
            if (idwindowtype == 1)
            {
                pictureBox_odn.Visible = true;
                pictureBox_dvyx.Visible = false;
                pictureBox_trx.Visible = false;
                switch (idleftsash)
                {
                    case 1:
                        pictureBox_odn.BackgroundImage = Properties.Resources.odn_glx;
                        break;
                    case 2:
                        pictureBox_odn.BackgroundImage = Properties.Resources.odn_pov;
                        break;
                    case 3:
                        pictureBox_odn.BackgroundImage = Properties.Resources.odn_pov_otkd;
                        break;

                }
            }
            if (idwindowtype == 2)
            {
                pictureBox_odn.Visible = false;
                pictureBox_dvyx.Visible = true;
                pictureBox_trx.Visible = false;

                if (idleftsash == 1 && idrightsash == 1)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_glx_glx;
                }
                else if (idleftsash == 1 && idrightsash == 2)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_glx_pov;
                }
                else if (idleftsash == 1 && idrightsash == 3)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_glx_povotkd;
                }
                else if (idleftsash == 2 && idrightsash == 1)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_pox_glx;
                }
                else if (idleftsash == 3 && idrightsash == 1)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_povotkd_glx;
                }
                else if (idleftsash == 2 && idrightsash == 2)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_pov_pov;
                }
                else if (idleftsash == 3 && idrightsash == 3)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_povotkd_povotkd;
                }
                else if (idleftsash == 2 && idrightsash == 3)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_pov_povotkd;
                }
                else if (idleftsash == 3 && idrightsash == 2)
                {
                    pictureBox_dvyx.BackgroundImage = Properties.Resources.dv_povotkd_pov;
                }
            }
            if (idwindowtype == 3)
            {
                pictureBox_odn.Visible = false;
                pictureBox_dvyx.Visible = false;
                pictureBox_trx.Visible = true;

                if (idleftsash == 1 && idrightsash == 1 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_glx_glx;
                }
                else if (idleftsash == 2 && idrightsash == 2 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_pov_pov;
                }
                else if (idleftsash == 3 && idrightsash == 3 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_otkd_otkd;
                }
                else if (idleftsash == 1 && idrightsash == 3 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_otkd_otkd;
                }
                else if (idleftsash == 1 && idrightsash == 2 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_pov_pov;
                }

                else if (idleftsash == 1 && idrightsash == 2 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_glx_pov;
                }
                else if (idleftsash == 1 && idrightsash == 3 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_glx_otkd;
                }
                else if (idleftsash == 2 && idrightsash == 2 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_glx_pov;
                }
                else if (idleftsash == 3 && idrightsash == 3 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_glx_otkd;
                }
                else if (idleftsash == 2 && idrightsash == 3 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_glx_otkd;
                }

                else if (idleftsash == 3 && idrightsash == 2 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_glx_pov;
                }
                else if (idleftsash == 2 && idrightsash == 1 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_pov_glx;
                }
                else if (idleftsash == 3 && idrightsash == 1 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_otkd_glx;
                }
                else if (idleftsash == 1 && idrightsash == 3 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_pov_otkd;
                }
                else if (idleftsash == 2 && idrightsash == 3 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_otkd_otkd;
                }

                else if (idleftsash == 2 && idrightsash == 3 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_pov_otkd;
                }
                else if (idleftsash == 3 && idrightsash == 2 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_otkd_pov;
                }
                else if (idleftsash == 3 && idrightsash == 2 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_pov_pov;
                }
                else if (idleftsash == 3 && idrightsash == 1 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_pov_glx;
                }
                else if (idleftsash == 2 && idrightsash == 2 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_otkd_pov;
                }

                else if (idleftsash == 1 && idrightsash == 1 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_pov_glx;
                }
                else if (idleftsash == 3 && idrightsash == 3 && idmediumsash == 3)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_pov_otkd;
                }
                else if (idleftsash == 3 && idrightsash == 1 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.otkd_glx_glx;
                }
                else if (idleftsash == 2 && idrightsash == 1 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_otkd_glx;
                }
                else if (idleftsash == 2 && idrightsash == 1 && idmediumsash == 2)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.pov_glx_glx;
                }

                else if (idleftsash == 1 && idrightsash == 2 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_otkd_pov;
                }
                else if (idleftsash == 1 && idrightsash == 1 && idmediumsash == 4)
                {
                    pictureBox_trx.BackgroundImage = Properties.Resources.glx_otkd_glx;
                }
            }
            
        }

        private void comboBox_windowstype_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            idwindowtype = (int)comboBox_windowstype.SelectedValue;
            label_widthtype.Text = "";
            label_heighttype.Text = "";
            ShowHeightAndWidth();
            WindowCost();
            WindowShow();


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

        }
        public MakeOrder()
        {
            InitializeComponent();
            //textBox_phone.MaxLength = 12;
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
            phoneClient = maskedTextBox_phone.Text;
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
                    MessageBox.Show("Клиент добавлен в базу");
                    clientadded = true;
                    ClassTotal.idClient = (int)clientTableAdapter1.SelectIDClient(phoneClient,addressClient,FIOClient);
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
