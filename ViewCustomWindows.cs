using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steklo
{
    public partial class ViewCustomWindows : Form
    {
        StekloPacketDataSet.CustomWindowsGlazingSillDataTable dataWindows;
        int selRowNum = 0;
        int idSill, idGlazing, idWindow;
        decimal cost;
        public ViewCustomWindows()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowWindowDetails();
        }

        private void ViewCustomWindows_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox_glazingtype.Enabled = false;
            comboBox_sill.Enabled = false;
            dataWindows = this.customWindowsGlazingSillTableAdapter1.GetData();
            dataGridView1.DataSource = dataWindows.CopyToDataTable();

            dataGridView1.ReadOnly = true;



            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Тип стекла";
            dataGridView1.Columns[2].HeaderText = "Подоконник, мм";
            dataGridView1.Columns[3].HeaderText = "Цена";


            selRowNum = dataGridView1.CurrentCell.RowIndex;

            comboBox_glazingtype.DataSource = glazingTypeTableAdapter1.GetData();
            comboBox_glazingtype.DisplayMember = "Title";
            comboBox_glazingtype.ValueMember = "IDGlazingType";

            comboBox_sill.DataSource = windowSillTableAdapter1.GetData();
            comboBox_sill.DisplayMember = "Title";
            comboBox_sill.ValueMember = "IDWindowSill";

            ShowWindowDetails();
        }

        public void ShowWindowDetails()
        {
            selRowNum = dataGridView1.CurrentCell.RowIndex;
            idWindow = (int)dataGridView1.Rows[selRowNum].Cells[0].Value;
            idGlazing = (int)glazingTypeTableAdapter1.SelectIDGlazing((dataGridView1.Rows[selRowNum].Cells[1].Value).ToString());
            idSill = (int)windowSillTableAdapter1.SelectIDSill((dataGridView1.Rows[selRowNum].Cells[2].Value).ToString());

            cost = (decimal)(dataGridView1.Rows[selRowNum].Cells[3].Value);

            comboBox_sill.SelectedValue = idSill;
            comboBox_glazingtype.SelectedValue = idGlazing;


            byte[] photo = customWindowsTableAdapter1.SelectPhoto(idWindow);
            MemoryStream stream = new MemoryStream(photo);
            Image bit = Image.FromStream(stream);
            pictureBox2.BackgroundImage = bit;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            label_cost.Text = "Цена окна: " + cost;
        }
    }
}
