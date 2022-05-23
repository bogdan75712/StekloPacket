namespace Steklo
{
    partial class MakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_client = new System.Windows.Forms.GroupBox();
            this.button_add_to_base = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_patron = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.groupBox_window = new System.Windows.Forms.GroupBox();
            this.comboBox_rigthsash = new System.Windows.Forms.ComboBox();
            this.comboBox_centrsash = new System.Windows.Forms.ComboBox();
            this.comboBox_leftsash = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_sill = new System.Windows.Forms.ComboBox();
            this.comboBox_glazingtype = new System.Windows.Forms.ComboBox();
            this.comboBox_manufacturer = new System.Windows.Forms.ComboBox();
            this.comboBox_profiletype = new System.Windows.Forms.ComboBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.button_no_hometype = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_windowstype = new System.Windows.Forms.ComboBox();
            this.comboBox_hometype = new System.Windows.Forms.ComboBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ClientTableAdapter();
            this.homeTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.HomeTypeTableAdapter();
            this.windowsTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowsTypeTableAdapter();
            this.windowsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowsTableAdapter();
            this.profileTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ProfileTypeTableAdapter();
            this.manufacturerTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ManufacturerTableAdapter();
            this.glazingTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter();
            this.colorsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ColorsTableAdapter();
            this.windowSillTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowSillTableAdapter();
            this.mediumSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.MediumSashTableAdapter();
            this.leftSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.LeftSashTableAdapter();
            this.rightSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.RightSashTableAdapter();
            this.label_height = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_widthtype = new System.Windows.Forms.Label();
            this.label_heighttype = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_client.SuspendLayout();
            this.groupBox_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 118);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(505, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Оформление заказа";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_close.Location = new System.Drawing.Point(1161, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(136, 42);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Выйти";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 65);
            this.panel2.TabIndex = 3;
            // 
            // groupBox_client
            // 
            this.groupBox_client.Controls.Add(this.button_add_to_base);
            this.groupBox_client.Controls.Add(this.label6);
            this.groupBox_client.Controls.Add(this.label5);
            this.groupBox_client.Controls.Add(this.label4);
            this.groupBox_client.Controls.Add(this.label3);
            this.groupBox_client.Controls.Add(this.label2);
            this.groupBox_client.Controls.Add(this.textBox_address);
            this.groupBox_client.Controls.Add(this.textBox_phone);
            this.groupBox_client.Controls.Add(this.textBox_patron);
            this.groupBox_client.Controls.Add(this.textBox_name);
            this.groupBox_client.Controls.Add(this.textBox_surname);
            this.groupBox_client.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox_client.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_client.Location = new System.Drawing.Point(4, 124);
            this.groupBox_client.Name = "groupBox_client";
            this.groupBox_client.Size = new System.Drawing.Size(284, 489);
            this.groupBox_client.TabIndex = 4;
            this.groupBox_client.TabStop = false;
            this.groupBox_client.Text = "Данные клиента";
            // 
            // button_add_to_base
            // 
            this.button_add_to_base.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add_to_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_to_base.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_to_base.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add_to_base.Location = new System.Drawing.Point(12, 441);
            this.button_add_to_base.Name = "button_add_to_base";
            this.button_add_to_base.Size = new System.Drawing.Size(266, 42);
            this.button_add_to_base.TabIndex = 6;
            this.button_add_to_base.Text = "Добавить клиента в базу";
            this.button_add_to_base.UseVisualStyleBackColor = false;
            this.button_add_to_base.Click += new System.EventHandler(this.button_add_to_base_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(89, 258);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_address.Size = new System.Drawing.Size(189, 170);
            this.textBox_address.TabIndex = 4;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(89, 201);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(189, 28);
            this.textBox_phone.TabIndex = 3;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // textBox_patron
            // 
            this.textBox_patron.Location = new System.Drawing.Point(89, 148);
            this.textBox_patron.Name = "textBox_patron";
            this.textBox_patron.Size = new System.Drawing.Size(189, 28);
            this.textBox_patron.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(89, 96);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(189, 28);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(89, 45);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(189, 28);
            this.textBox_surname.TabIndex = 0;
            // 
            // groupBox_window
            // 
            this.groupBox_window.Controls.Add(this.label_heighttype);
            this.groupBox_window.Controls.Add(this.label_widthtype);
            this.groupBox_window.Controls.Add(this.label_width);
            this.groupBox_window.Controls.Add(this.label_height);
            this.groupBox_window.Controls.Add(this.comboBox_rigthsash);
            this.groupBox_window.Controls.Add(this.comboBox_centrsash);
            this.groupBox_window.Controls.Add(this.comboBox_leftsash);
            this.groupBox_window.Controls.Add(this.comboBox_color);
            this.groupBox_window.Controls.Add(this.comboBox_sill);
            this.groupBox_window.Controls.Add(this.comboBox_glazingtype);
            this.groupBox_window.Controls.Add(this.comboBox_manufacturer);
            this.groupBox_window.Controls.Add(this.comboBox_profiletype);
            this.groupBox_window.Controls.Add(this.textBox_height);
            this.groupBox_window.Controls.Add(this.textBox_width);
            this.groupBox_window.Controls.Add(this.button_no_hometype);
            this.groupBox_window.Controls.Add(this.label19);
            this.groupBox_window.Controls.Add(this.label18);
            this.groupBox_window.Controls.Add(this.label17);
            this.groupBox_window.Controls.Add(this.label16);
            this.groupBox_window.Controls.Add(this.label15);
            this.groupBox_window.Controls.Add(this.label14);
            this.groupBox_window.Controls.Add(this.label13);
            this.groupBox_window.Controls.Add(this.label12);
            this.groupBox_window.Controls.Add(this.label11);
            this.groupBox_window.Controls.Add(this.label10);
            this.groupBox_window.Controls.Add(this.label9);
            this.groupBox_window.Controls.Add(this.label8);
            this.groupBox_window.Controls.Add(this.comboBox_windowstype);
            this.groupBox_window.Controls.Add(this.comboBox_hometype);
            this.groupBox_window.Controls.Add(this.label_cost);
            this.groupBox_window.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_window.Location = new System.Drawing.Point(295, 124);
            this.groupBox_window.Name = "groupBox_window";
            this.groupBox_window.Size = new System.Drawing.Size(700, 489);
            this.groupBox_window.TabIndex = 5;
            this.groupBox_window.TabStop = false;
            this.groupBox_window.Text = "Добавление окна";
            // 
            // comboBox_rigthsash
            // 
            this.comboBox_rigthsash.FormattingEnabled = true;
            this.comboBox_rigthsash.Location = new System.Drawing.Point(177, 453);
            this.comboBox_rigthsash.Name = "comboBox_rigthsash";
            this.comboBox_rigthsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_rigthsash.TabIndex = 25;
            this.comboBox_rigthsash.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rigthsash_SelectionChangeCommitted);
            // 
            // comboBox_centrsash
            // 
            this.comboBox_centrsash.FormattingEnabled = true;
            this.comboBox_centrsash.Location = new System.Drawing.Point(177, 421);
            this.comboBox_centrsash.Name = "comboBox_centrsash";
            this.comboBox_centrsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_centrsash.TabIndex = 24;
            this.comboBox_centrsash.SelectedIndexChanged += new System.EventHandler(this.comboBox_centrsash_SelectedIndexChanged);
            this.comboBox_centrsash.SelectionChangeCommitted += new System.EventHandler(this.comboBox_centrsash_SelectionChangeCommitted);
            // 
            // comboBox_leftsash
            // 
            this.comboBox_leftsash.FormattingEnabled = true;
            this.comboBox_leftsash.Location = new System.Drawing.Point(177, 388);
            this.comboBox_leftsash.Name = "comboBox_leftsash";
            this.comboBox_leftsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_leftsash.TabIndex = 23;
            this.comboBox_leftsash.SelectionChangeCommitted += new System.EventHandler(this.comboBox_leftsash_SelectionChangeCommitted);
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(129, 318);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 29);
            this.comboBox_color.TabIndex = 22;
            this.comboBox_color.SelectionChangeCommitted += new System.EventHandler(this.comboBox_color_SelectionChangeCommitted);
            // 
            // comboBox_sill
            // 
            this.comboBox_sill.FormattingEnabled = true;
            this.comboBox_sill.Location = new System.Drawing.Point(129, 353);
            this.comboBox_sill.Name = "comboBox_sill";
            this.comboBox_sill.Size = new System.Drawing.Size(121, 29);
            this.comboBox_sill.TabIndex = 21;
            this.comboBox_sill.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sill_SelectionChangeCommitted);
            // 
            // comboBox_glazingtype
            // 
            this.comboBox_glazingtype.FormattingEnabled = true;
            this.comboBox_glazingtype.Location = new System.Drawing.Point(162, 283);
            this.comboBox_glazingtype.Name = "comboBox_glazingtype";
            this.comboBox_glazingtype.Size = new System.Drawing.Size(272, 29);
            this.comboBox_glazingtype.TabIndex = 20;
            this.comboBox_glazingtype.SelectedIndexChanged += new System.EventHandler(this.comboBox_glazingtype_SelectedIndexChanged);
            this.comboBox_glazingtype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_glazingtype_SelectionChangeCommitted);
            // 
            // comboBox_manufacturer
            // 
            this.comboBox_manufacturer.FormattingEnabled = true;
            this.comboBox_manufacturer.Location = new System.Drawing.Point(150, 241);
            this.comboBox_manufacturer.Name = "comboBox_manufacturer";
            this.comboBox_manufacturer.Size = new System.Drawing.Size(121, 29);
            this.comboBox_manufacturer.TabIndex = 19;
            // 
            // comboBox_profiletype
            // 
            this.comboBox_profiletype.FormattingEnabled = true;
            this.comboBox_profiletype.Location = new System.Drawing.Point(124, 200);
            this.comboBox_profiletype.Name = "comboBox_profiletype";
            this.comboBox_profiletype.Size = new System.Drawing.Size(121, 29);
            this.comboBox_profiletype.TabIndex = 18;
            this.comboBox_profiletype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_profiletype_SelectionChangeCommitted);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(124, 155);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 28);
            this.textBox_height.TabIndex = 17;
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox_height_TextChanged);
            this.textBox_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_height_KeyPress);
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(124, 118);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 28);
            this.textBox_width.TabIndex = 16;
            this.textBox_width.TextChanged += new System.EventHandler(this.textBox_width_TextChanged);
            this.textBox_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_width_KeyPress);
            // 
            // button_no_hometype
            // 
            this.button_no_hometype.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_no_hometype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no_hometype.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_no_hometype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_no_hometype.Location = new System.Drawing.Point(247, 32);
            this.button_no_hometype.Name = "button_no_hometype";
            this.button_no_hometype.Size = new System.Drawing.Size(134, 29);
            this.button_no_hometype.TabIndex = 6;
            this.button_no_hometype.Text = "Нет типа дома";
            this.button_no_hometype.UseVisualStyleBackColor = false;
            this.button_no_hometype.Click += new System.EventHandler(this.button_no_hometype_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 21);
            this.label19.TabIndex = 14;
            this.label19.Text = "Высота, мм";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Ширина, мм";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 456);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Правая створка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Центральная створка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Левая створка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 21);
            this.label14.TabIndex = 9;
            this.label14.Text = "Тип стеклопакета";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Тип дома";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Тип профиля";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Подоконник";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Тип окна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Производитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Цвет";
            // 
            // comboBox_windowstype
            // 
            this.comboBox_windowstype.FormattingEnabled = true;
            this.comboBox_windowstype.Location = new System.Drawing.Point(103, 67);
            this.comboBox_windowstype.Name = "comboBox_windowstype";
            this.comboBox_windowstype.Size = new System.Drawing.Size(172, 29);
            this.comboBox_windowstype.TabIndex = 2;
            this.comboBox_windowstype.SelectedIndexChanged += new System.EventHandler(this.comboBox_windowstype_SelectedIndexChanged);
            this.comboBox_windowstype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_windowstype_SelectionChangeCommitted);
            // 
            // comboBox_hometype
            // 
            this.comboBox_hometype.FormattingEnabled = true;
            this.comboBox_hometype.Location = new System.Drawing.Point(103, 32);
            this.comboBox_hometype.Name = "comboBox_hometype";
            this.comboBox_hometype.Size = new System.Drawing.Size(138, 29);
            this.comboBox_hometype.TabIndex = 1;
            this.comboBox_hometype.DropDown += new System.EventHandler(this.comboBox_hometype_DropDown);
            this.comboBox_hometype.SelectedIndexChanged += new System.EventHandler(this.comboBox_hometype_SelectedIndexChanged);
            this.comboBox_hometype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_hometype_SelectionChangeCommitted);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Century", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cost.Location = new System.Drawing.Point(478, 451);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(102, 21);
            this.label_cost.TabIndex = 0;
            this.label_cost.Text = "Цена окна:";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // homeTypeTableAdapter1
            // 
            this.homeTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // windowsTypeTableAdapter1
            // 
            this.windowsTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // windowsTableAdapter1
            // 
            this.windowsTableAdapter1.ClearBeforeFill = true;
            // 
            // profileTypeTableAdapter1
            // 
            this.profileTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter1
            // 
            this.manufacturerTableAdapter1.ClearBeforeFill = true;
            // 
            // glazingTypeTableAdapter1
            // 
            this.glazingTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // colorsTableAdapter1
            // 
            this.colorsTableAdapter1.ClearBeforeFill = true;
            // 
            // windowSillTableAdapter1
            // 
            this.windowSillTableAdapter1.ClearBeforeFill = true;
            // 
            // mediumSashTableAdapter1
            // 
            this.mediumSashTableAdapter1.ClearBeforeFill = true;
            // 
            // leftSashTableAdapter1
            // 
            this.leftSashTableAdapter1.ClearBeforeFill = true;
            // 
            // rightSashTableAdapter1
            // 
            this.rightSashTableAdapter1.ClearBeforeFill = true;
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(230, 158);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(0, 21);
            this.label_height.TabIndex = 26;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(230, 121);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(0, 21);
            this.label_width.TabIndex = 27;
            // 
            // label_widthtype
            // 
            this.label_widthtype.AutoSize = true;
            this.label_widthtype.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_widthtype.Location = new System.Drawing.Point(230, 121);
            this.label_widthtype.Name = "label_widthtype";
            this.label_widthtype.Size = new System.Drawing.Size(0, 21);
            this.label_widthtype.TabIndex = 28;
            // 
            // label_heighttype
            // 
            this.label_heighttype.AutoSize = true;
            this.label_heighttype.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_heighttype.Location = new System.Drawing.Point(236, 162);
            this.label_heighttype.Name = "label_heighttype";
            this.label_heighttype.Size = new System.Drawing.Size(0, 21);
            this.label_heighttype.TabIndex = 29;
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 683);
            this.Controls.Add(this.groupBox_window);
            this.Controls.Add(this.groupBox_client);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MakeOrder";
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_client.ResumeLayout(false);
            this.groupBox_client.PerformLayout();
            this.groupBox_window.ResumeLayout(false);
            this.groupBox_window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_patron;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Button button_add_to_base;
        private StekloPacketDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox_window;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.Button button_no_hometype;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_windowstype;
        private System.Windows.Forms.ComboBox comboBox_hometype;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.ComboBox comboBox_rigthsash;
        private System.Windows.Forms.ComboBox comboBox_centrsash;
        private System.Windows.Forms.ComboBox comboBox_leftsash;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_sill;
        private System.Windows.Forms.ComboBox comboBox_glazingtype;
        private System.Windows.Forms.ComboBox comboBox_manufacturer;
        private System.Windows.Forms.ComboBox comboBox_profiletype;
        private StekloPacketDataSetTableAdapters.HomeTypeTableAdapter homeTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowsTypeTableAdapter windowsTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowsTableAdapter windowsTableAdapter1;
        private StekloPacketDataSetTableAdapters.ProfileTypeTableAdapter profileTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter1;
        private StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter glazingTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowSillTableAdapter windowSillTableAdapter1;
        private StekloPacketDataSetTableAdapters.MediumSashTableAdapter mediumSashTableAdapter1;
        private StekloPacketDataSetTableAdapters.LeftSashTableAdapter leftSashTableAdapter1;
        private StekloPacketDataSetTableAdapters.RightSashTableAdapter rightSashTableAdapter1;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_heighttype;
        private System.Windows.Forms.Label label_widthtype;
    }
}