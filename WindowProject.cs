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
    public partial class WindowProject : Form
    {
        PictureBox pb;
        int x0, y0;
        bool drag = false;
        bool picadd = false;
        int sashCount = 0;
        int idglazingtype = 1;
        int idsill = 1;
        int horizLineCount = 0;
        int vertikLineCount = 0;
        int Width = 500, Height = 500; 
        Point last_pos = new Point();
        
        decimal cost;
        decimal summsquare, squareheight, squarewidth;
        public WindowProject()
        {
            InitializeComponent();
            textBoxHeight.Text = "500";
            textBoxWidth.Text = "500";
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цена любого типа окна расчитывается по площади прямоугольника в большую сторону." + Environment.NewLine + 
                "Чтобы увеличить линию нажмите на нее и прокрутите колесико вверх, а" + Environment.NewLine + "чтобы уменьшить прокрутите колесико вниз." + Environment.NewLine + 
                "Чтобы удалить ручку или линию нажмите на нее быстро два раза.");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_elipse_Click(object sender, EventArgs e)
        {           
            picadd = false;
            try
            {
                
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.elipse;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.elipse;
                
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void Pb_doubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                PictureBox pb = sender as PictureBox;
                
                if ( pb.Width == 20 && sashCount != 0)
                {
                    cost -= 1500;
                    labelCost.Text = "Цена окна: " + Math.Round(cost,2);
                    sashCount--;
                }
                if (pb.Height == 10 && horizLineCount != 0)
                {
                    cost -= 1000;
                    labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                    horizLineCount--;

                }
                if (pb.Width == 10 && vertikLineCount != 0)
                {
                    cost -= 1000;
                    labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                    vertikLineCount--;
                }
                this.pictureBox3.Controls.Remove(pb);
                
                

            }


        }

        private void Pb_MouseMove(object sender, MouseEventArgs e)
        {
            
            PictureBox pb = (PictureBox)sender; 
            if (drag) 
            {

                pb.Left += (e.X - x0); 
                pb.Top += (e.Y - y0);               
            }
        }

        private void Pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                drag = true; 
                x0 = e.X; 
                y0 = e.Y;
                last_pos = e.Location;
            }
        }

        private void Pb_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; 
        }

        private void button_halfelipse_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {                                
                pictureBox3.Controls.Clear();
                sashCount = 0;               
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.halfelipse;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.halfelipse;
                
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_eight_Click(object sender, EventArgs e)
        {           
            picadd = false;
            try
            {
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.eight1;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.eight1;
               
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_triangleravn_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {
                
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.treugravn;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.treugravn;
                
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_trianglepryam_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {                

                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.treugpryam1;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.treugpryam1;
                
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_arc_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {
                
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.arc;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.arc;
                
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_trapezoidarc_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {
                
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.trapezy1;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.trapezy1;
               
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_trapezoid_Click(object sender, EventArgs e)
        {
            
            picadd = false;
            try
            {
                
                pictureBox3.Controls.Clear();
                sashCount = 0;
                vertikLineCount = 0;
                horizLineCount = 0;
                cost = 0;
                WindowCost();
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
                pictureBox3.BackgroundImage = Properties.Resources.trapezypryam1;
                pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox3.SendToBack();
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.trapezypryam1;
               
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_horizline_Click(object sender, EventArgs e)
        {

            try
            {
                pb = new PictureBox();
                pb.Width = 270;
                pb.Height = 10;
                pb.Parent = pictureBox3;
                pb.Image = Properties.Resources.png_line_hor;
                
                pb.Left = 175; 
                pb.Top = 173; 
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.png_line_hor;
                pb.BackColor = Color.Transparent;
                pb.BringToFront();
                
                this.pictureBox3.Controls.Add(pb);
                
                horizLineCount++;
                WindowCost();
                pb.MouseClick += Pb_Horiz_Click;
                pb.MouseDoubleClick += Pb_doubleClick;
                pb.MouseMove += Pb_MouseMove;
                pb.MouseDown += Pb_MouseDown;
                pb.MouseUp += Pb_MouseUp;
                pb.MouseWheel += Pb_Mouse_WheelHoriz;               
                picadd = true;
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        public void WindowCost()
        {
            
                squarewidth = Convert.ToDecimal(Width) / 1000;
                squareheight = Convert.ToDecimal(Height) / 1000;
                summsquare = squareheight * squarewidth;

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
                cost += 1500.00M * sashCount;
                cost += 1000.00M * horizLineCount;
                cost += 1000.00M * vertikLineCount;
                labelCost.Text = "Цена окна: " + Math.Round(cost, 2);
            
            
        }

        private void button_verticline_Click(object sender, EventArgs e)
        {
            try
            {

                pb = new PictureBox();
                pb.Width = 10;
                pb.Height = 270;
                pb.Parent = pictureBox3;
                pb.Image = Properties.Resources.png_line_vert;
                pb.Left = 175; 
                pb.Top = 173; 
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImage = Properties.Resources.png_line_vert;
                pb.BackColor = Color.Transparent;
                pb.BringToFront();
                this.pictureBox3.Controls.Add(pb);
                vertikLineCount ++;
                WindowCost();
                pb.MouseClick += Pb_Vertik_Click;
                pb.MouseDoubleClick += Pb_doubleClick;
                pb.MouseMove += Pb_MouseMove;
                pb.MouseDown += Pb_MouseDown;
                pb.MouseUp += Pb_MouseUp;
                pb.MouseWheel += Pb_Mouse_WheelVertik;
                
                picadd = true;
                
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        private void button_sash_Click(object sender, EventArgs e)
        {
            try
            {
                pb = new PictureBox();
                pb.Width = 20;
                pb.Height = 72;
                pb.Image = Properties.Resources.sash;
                pb.Left = 175; 
                pb.Top = 173; 
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BringToFront();               
                pb.Parent = pictureBox3;
                pictureBox2.BackgroundImage = Properties.Resources.sash;
                pb.BackColor = Color.Transparent;
                this.pictureBox3.Controls.Add(pb);
                sashCount++;
                WindowCost();
                pb.MouseClick += Pb_Click;
                pb.MouseDoubleClick += Pb_doubleClick;
                pb.MouseMove += Pb_MouseMove;
                pb.MouseDown += Pb_MouseDown;
                pb.MouseUp += Pb_MouseUp;
                
                picadd = true;

                
            }
            catch
            {
                MessageBox.Show("Вы не добавили предмет", "Ошибка");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.sash, Point.Empty);
            
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            
            Width = Convert.ToInt32(textBoxWidth.Text);
            WindowCost();
                              
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            Height = Convert.ToInt32(textBoxHeight.Text);
            WindowCost();
                                    
        }

        private void PaintHoriz(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.png_line_hor, new Point(175,173));
        }

        

        private void WindowProject_Load(object sender, EventArgs e)
        {
            textBoxWidth.Text = "500";
            textBoxHeight.Text = "500";

            comboBox_glazingtype.DataSource = glazingTypeTableAdapter1.GetData();
            comboBox_glazingtype.DisplayMember = "Title";
            comboBox_glazingtype.ValueMember = "IDGlazingType";
            comboBox_glazingtype.SelectedIndex = 0;
            idglazingtype = (int)comboBox_glazingtype.SelectedValue;

            comboBox_sill.DataSource = windowSillTableAdapter1.GetData();
            comboBox_sill.DisplayMember = "Title";
            comboBox_sill.ValueMember = "IDWindowSill";
            comboBox_sill.SelectedIndex = 0;
            idsill = (int)comboBox_sill.SelectedValue;
        }

        private void Pb_Click(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {
                PictureBox pb = sender as PictureBox;
                               
                pb.Focus();

            }
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pb = sender as PictureBox;
                
                pb.Focus();
            }



        }
        private void Pb_Horiz_Click(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {
                PictureBox pb = sender as PictureBox;
                
                pb.Focus();

            }
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pb = sender as PictureBox;
                
                pb.Focus();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackgroundImage != null || pictureBox3.Image != null)
            {
                SaveFileDialog pic = new SaveFileDialog();
                pic.Title = "Сохранение картинки";
                pic.OverwritePrompt = true;
                pic.CheckPathExists = true;
                pic.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                pic.ShowHelp = true;

                if (pic.ShowDialog() == DialogResult.OK)
                {
                    try 
                    {
                        int width, height;
                        width = panel3.Width;
                        height = panel3.Height;
                        Bitmap save = new Bitmap(width, height);
                        panel3.DrawToBitmap(save, panel3.ClientRectangle);
                        save.Save(pic.FileName);
                        
                        MessageBox.Show("Изображение сохранено", "Save");
                    }
                    catch 
                    {
                        MessageBox.Show("Не удалось сохранить изшбражение","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
            }
           
        }

        private void comboBox_glazingtype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idglazingtype = (int)comboBox_glazingtype.SelectedValue;
            WindowCost();
        }

        private void comboBox_sill_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idsill = (int)comboBox_sill.SelectedValue;
            WindowCost();
        }

        private void button_addtoBase_Click(object sender, EventArgs e)
        {
            int windowID;
            byte[] photo = null;

            idglazingtype = (int)comboBox_glazingtype.SelectedValue;
            idsill = (int)comboBox_sill.SelectedValue;

            if (customWindowsTableAdapter1.SelectLastID().ToString() == "")
            {
                windowID = 1;
            }
            else
            {
                windowID = (int)(customWindowsTableAdapter1.SelectLastID() + 1);
            }
            if (pictureBox3.Image != null || pictureBox3.BackgroundImage != null)
            {
                
                try
                {
                    MemoryStream stream = new System.IO.MemoryStream(); 
                    

                    int width, height;
                    width = panel3.Width;
                    height = panel3.Height;
                    Bitmap save = new Bitmap(width, height);
                    panel3.DrawToBitmap(save, panel3.ClientRectangle);
                    
                    save.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    photo = stream.ToArray();
                    customWindowsTableAdapter1.Insert(windowID, idsill, idglazingtype, cost ,photo);
                    MessageBox.Show("Окно добавлено в базу");
                }
                catch
                {
                    MessageBox.Show("Не удалось добавить в базу");
                }

            }
            else
            {
                MessageBox.Show("Сначала спроектируйте окно");
                return;
            }
            

        }





        private void Pb_Vertik_Click(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {
                PictureBox pb = sender as PictureBox;
                
                pb.Focus();

            }
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pb = sender as PictureBox;
                
                pb.Focus();
            }
        }

        private void Pb_Mouse_WheelHoriz(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (e.Delta > 0)
                pb.Width += 5;
            else
                pb.Width -= 5;
        }

        private void Pb_Mouse_WheelVertik(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (e.Delta > 0)
                pb.Height += 5;
            else
                pb.Height -= 5;
        }
    }
}
