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
    public partial class ChangeCostandTovars : Form
    {
        StekloPacketDataSet.WindowsAllDataTable dataWindows;
        int selRowNum = 0;
        int idWindow, idGlazing, idWindowType, idProfile, idManufacturer, idSill, idColor, idLeftSash, idRightSash, idMediumSash;

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {
            if (textBox_cost.Text == "")
            {
                MessageBox.Show("Стоимость не может быть нулевой");
                return;
            }
        }

        private void comboBox_profiletype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idProfile = (int)comboBox_profiletype.SelectedValue;
            //idmanufacturer = (int)profileTypeTableAdapter1.SelectManufacturer(idprofiletype);
            if (idProfile == 1 || idProfile == 2)
            {
                comboBox_manufacturer.SelectedValue = 1;
                comboBox_manufacturer.Enabled = false;
            }
            else
            {
                comboBox_manufacturer.SelectedValue = 2;
                comboBox_manufacturer.Enabled = false;
            }
        }

        private void textBox_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowWindowDetails();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        decimal cost;
        
        public ChangeCostandTovars()
        {
            InitializeComponent();
        }

        private void ChangeCostandTovars_Load(object sender, EventArgs e)
        {
            dataWindows = this.windowsAllTableAdapter1.GetData();
            dataGridView1.DataSource = dataWindows.CopyToDataTable();

            dataGridView1.ReadOnly = true;

            comboBox_windowstype.Enabled = false;
            //comboBox_centrsash.Visible = false;
            //comboBox_centrsash.Enabled = false;
            //label16.Visible = false;

            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Тип окна";
            dataGridView1.Columns[2].HeaderText = "Тип стекла";
            dataGridView1.Columns[3].HeaderText = "Тип профиля";
            dataGridView1.Columns[4].HeaderText = "Производитель";
            dataGridView1.Columns[5].HeaderText = "Подоконник, мм";
            dataGridView1.Columns[6].HeaderText = "Цвет";
            dataGridView1.Columns[7].HeaderText = "Левая створка";
            dataGridView1.Columns[8].HeaderText = "Правая створка";
            dataGridView1.Columns[9].HeaderText = "Центральная створка";
            dataGridView1.Columns[10].HeaderText = "Цена";

            selRowNum = dataGridView1.CurrentCell.RowIndex;

            comboBox_windowstype.DataSource = windowsTypeTableAdapter1.GetData();
            comboBox_windowstype.DisplayMember = "Title";
            comboBox_windowstype.ValueMember = "IDWindowType";

            comboBox_profiletype.DataSource = profileTypeTableAdapter1.GetData();
            comboBox_profiletype.DisplayMember = "Title";
            comboBox_profiletype.ValueMember = "IDProfileType";           
            //idprofiletype = (int)comboBox_profiletype.SelectedValue;

            comboBox_manufacturer.DataSource = manufacturerTableAdapter1.GetData();
            comboBox_manufacturer.DisplayMember = "Title";
            comboBox_manufacturer.ValueMember = "IDManufacturer";           
            comboBox_manufacturer.Enabled = false;
            //idmanufacturer = (int)comboBox_manufacturer.SelectedValue;

            comboBox_glazingtype.DataSource = glazingTypeTableAdapter1.GetData();
            comboBox_glazingtype.DisplayMember = "Title";
            comboBox_glazingtype.ValueMember = "IDGlazingType";
            comboBox_glazingtype.SelectedIndex = 0;
            //idglazingtype = (int)comboBox_glazingtype.SelectedValue;

            comboBox_color.DataSource = colorsTableAdapter1.GetData();
            comboBox_color.DisplayMember = "Title";
            comboBox_color.ValueMember = "IDColor";
            comboBox_color.SelectedIndex = 0;
            //idcolor = (int)comboBox_color.SelectedValue;

            comboBox_sill.DataSource = windowSillTableAdapter1.GetData();
            comboBox_sill.DisplayMember = "Title";
            comboBox_sill.ValueMember = "IDWindowSill";
            comboBox_sill.SelectedIndex = 0;
            //idsill = (int)comboBox_sill.SelectedValue;

            comboBox_leftsash.DataSource = leftSashTableAdapter1.GetData();
            comboBox_leftsash.DisplayMember = "Title";
            comboBox_leftsash.ValueMember = "IDLeftSash";
            //idleftsash = (int)comboBox_leftsash.SelectedValue;

            comboBox_rigthsash.DataSource = rightSashTableAdapter1.GetData();
            comboBox_rigthsash.DisplayMember = "Title";
            comboBox_rigthsash.ValueMember = "IDRightSash";

            comboBox_centrsash.DataSource = mediumSashTableAdapter1.GetDataByMediumSash();
            comboBox_centrsash.DisplayMember = "Title";
            comboBox_centrsash.ValueMember = "IDMediumSash";
            //comboBox_centrsash.Visible = false;

            ShowWindowDetails();
        }

        public void ShowWindowDetails()
        {
            selRowNum = dataGridView1.CurrentCell.RowIndex;

            idWindow = (int)(dataGridView1.Rows[selRowNum].Cells[0].Value);
            idWindowType = (int)windowsTypeTableAdapter1.SelectIDWindowType((dataGridView1.Rows[selRowNum].Cells[1].Value).ToString());
            idGlazing = (int)glazingTypeTableAdapter1.SelectIDGlazing((dataGridView1.Rows[selRowNum].Cells[2].Value).ToString());
            idProfile = (int)profileTypeTableAdapter1.SelectProfileID((dataGridView1.Rows[selRowNum].Cells[3].Value).ToString());
            idManufacturer = (int)profileTypeTableAdapter1.SelectManufacturer(idProfile);
            idSill = (int)windowSillTableAdapter1.SelectIDSill((dataGridView1.Rows[selRowNum].Cells[5].Value).ToString());
            idColor = (int)colorsTableAdapter1.SelectIDColor((dataGridView1.Rows[selRowNum].Cells[6].Value).ToString());
            idLeftSash = (int)leftSashTableAdapter1.SelectIDLeft((dataGridView1.Rows[selRowNum].Cells[7].Value).ToString());
            idRightSash = (int)rightSashTableAdapter1.SelectIDRight((dataGridView1.Rows[selRowNum].Cells[8].Value).ToString());
            idMediumSash = (int)mediumSashTableAdapter1.SelectIDMedium((dataGridView1.Rows[selRowNum].Cells[9].Value).ToString());

            cost = (decimal)(dataGridView1.Rows[selRowNum].Cells[10].Value);

            if (idWindowType == 1)
            {
                comboBox_centrsash.Visible = false;
                comboBox_centrsash.Enabled = false;
                label16.Visible = false;
                comboBox_rigthsash.Visible = false;
                comboBox_rigthsash.Enabled = false;
                label17.Visible = false;
            }
            if (idWindowType == 2)
            {
                comboBox_centrsash.Visible = false;
                comboBox_centrsash.Enabled = false;
                label16.Visible = false;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
                label17.Visible = true;
            }
            if (idWindowType == 3)
            {
                comboBox_centrsash.Visible = true;
                comboBox_centrsash.Enabled = true;
                label16.Visible = true;
                comboBox_rigthsash.Visible = true;
                comboBox_rigthsash.Enabled = true;
                label17.Visible = true;
            }

            
            if (idManufacturer == 1)
            {
                comboBox_manufacturer.SelectedValue = 1;
                comboBox_manufacturer.Enabled = false;
            }
            else
            {
                comboBox_manufacturer.SelectedValue = 2;
                comboBox_manufacturer.Enabled = false;
            }

            comboBox_windowstype.SelectedValue = idWindowType;
            comboBox_profiletype.SelectedValue = idProfile;
            comboBox_sill.SelectedValue = idSill;
            comboBox_color.SelectedValue = idColor;
            comboBox_manufacturer.SelectedValue = idManufacturer;
            comboBox_glazingtype.SelectedValue = idGlazing;
            comboBox_rigthsash.SelectedValue = idRightSash;
            comboBox_leftsash.SelectedValue = idLeftSash;
            comboBox_centrsash.SelectedValue = idMediumSash;
            textBox_cost.Text = cost.ToString();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            idWindow = (int)(dataGridView1.Rows[selRowNum].Cells[0].Value);

            idWindowType = (int)comboBox_windowstype.SelectedValue;
            
            idGlazing = (int)comboBox_glazingtype.SelectedValue;
            idProfile = (int)comboBox_profiletype.SelectedValue;
            idManufacturer = (int)comboBox_manufacturer.SelectedValue;
            idSill = (int)comboBox_sill.SelectedValue;
            idColor = (int)comboBox_color.SelectedValue;
            idLeftSash = (int)comboBox_leftsash.SelectedValue;
            idRightSash = (int)comboBox_rigthsash.SelectedValue;
            idMediumSash = (int)comboBox_centrsash.SelectedValue;

            cost = Convert.ToDecimal(textBox_cost.Text);

            if (idWindowType == 1)
            {
                try
                {
                    windowsTableAdapter1.UpdateWindow(cost, idColor, idManufacturer, idSill, idProfile, idGlazing, idLeftSash, 1, 1, idWindow);
                    MessageBox.Show("Успешно изменено");
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Не удалось обновить данные");
                }
               
            }
            if (idWindowType == 2)
            {
                try
                {
                    windowsTableAdapter1.UpdateWindow(cost, idColor, idManufacturer, idSill, idProfile, idGlazing, idLeftSash, idRightSash, 1, idWindow);
                    MessageBox.Show("Успешно изменено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось обновить данные");
                }
                
            }
            if (idWindowType == 3)
            {
                try
                {
                    windowsTableAdapter1.UpdateWindow(cost, idColor, idManufacturer, idSill, idProfile, idGlazing, idLeftSash, idRightSash, idMediumSash, idWindow);
                    MessageBox.Show("Успешно изменено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось обновить данные");
                }
                
            }

            //windowsTableAdapter1.UpdateWindow();
        }
    }
}
