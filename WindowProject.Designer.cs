namespace Steklo
{
    partial class WindowProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowProject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_addtoBase = new System.Windows.Forms.Button();
            this.comboBox_sill = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_glazingtype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sash = new System.Windows.Forms.Button();
            this.button_verticline = new System.Windows.Forms.Button();
            this.button_horizline = new System.Windows.Forms.Button();
            this.button_trapezoid = new System.Windows.Forms.Button();
            this.button_trapezoidarc = new System.Windows.Forms.Button();
            this.button_arc = new System.Windows.Forms.Button();
            this.button_trianglepryam = new System.Windows.Forms.Button();
            this.button_triangleravn = new System.Windows.Forms.Button();
            this.button_halfelipse = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_elipse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.glazingTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter();
            this.windowSillTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowSillTableAdapter();
            this.customWindowsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.CustomWindowsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 118);
            this.panel1.TabIndex = 1;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exit.Location = new System.Drawing.Point(1051, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(136, 42);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Назад";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(496, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Проектирование окон";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(-9, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 65);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(5, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 596);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(138, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 340);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_addtoBase);
            this.groupBox1.Controls.Add(this.comboBox_sill);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox_glazingtype);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.button_info);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.textBoxWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_sash);
            this.groupBox1.Controls.Add(this.button_verticline);
            this.groupBox1.Controls.Add(this.button_horizline);
            this.groupBox1.Controls.Add(this.button_trapezoid);
            this.groupBox1.Controls.Add(this.button_trapezoidarc);
            this.groupBox1.Controls.Add(this.button_arc);
            this.groupBox1.Controls.Add(this.button_trianglepryam);
            this.groupBox1.Controls.Add(this.button_triangleravn);
            this.groupBox1.Controls.Add(this.button_halfelipse);
            this.groupBox1.Controls.Add(this.button_eight);
            this.groupBox1.Controls.Add(this.button_elipse);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(702, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 596);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // button_addtoBase
            // 
            this.button_addtoBase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addtoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addtoBase.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addtoBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_addtoBase.Location = new System.Drawing.Point(260, 488);
            this.button_addtoBase.Name = "button_addtoBase";
            this.button_addtoBase.Size = new System.Drawing.Size(220, 42);
            this.button_addtoBase.TabIndex = 27;
            this.button_addtoBase.Text = "Добавить в БД";
            this.button_addtoBase.UseVisualStyleBackColor = false;
            this.button_addtoBase.Click += new System.EventHandler(this.button_addtoBase_Click);
            // 
            // comboBox_sill
            // 
            this.comboBox_sill.FormattingEnabled = true;
            this.comboBox_sill.Location = new System.Drawing.Point(317, 418);
            this.comboBox_sill.Name = "comboBox_sill";
            this.comboBox_sill.Size = new System.Drawing.Size(121, 29);
            this.comboBox_sill.TabIndex = 26;
            this.comboBox_sill.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sill_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Подоконник";
            // 
            // comboBox_glazingtype
            // 
            this.comboBox_glazingtype.FormattingEnabled = true;
            this.comboBox_glazingtype.Location = new System.Drawing.Point(301, 357);
            this.comboBox_glazingtype.Name = "comboBox_glazingtype";
            this.comboBox_glazingtype.Size = new System.Drawing.Size(149, 29);
            this.comboBox_glazingtype.TabIndex = 24;
            this.comboBox_glazingtype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_glazingtype_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(313, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Тип стеклопакета";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_save.Location = new System.Drawing.Point(260, 536);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(220, 42);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "Сохранить макет";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_info.Location = new System.Drawing.Point(260, 16);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(220, 42);
            this.button_info.TabIndex = 21;
            this.button_info.Text = "Справка";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(328, 293);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 28);
            this.textBoxHeight.TabIndex = 20;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(328, 238);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 28);
            this.textBoxWidth.TabIndex = 19;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Высота,мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ширина, мм";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Century", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(260, 461);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(112, 21);
            this.labelCost.TabIndex = 16;
            this.labelCost.Text = "Цена окна:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите тип окна:";
            // 
            // button_sash
            // 
            this.button_sash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sash.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_sash.Location = new System.Drawing.Point(6, 536);
            this.button_sash.Name = "button_sash";
            this.button_sash.Size = new System.Drawing.Size(248, 42);
            this.button_sash.TabIndex = 14;
            this.button_sash.Text = "Ручка";
            this.button_sash.UseVisualStyleBackColor = false;
            this.button_sash.Click += new System.EventHandler(this.button_sash_Click);
            // 
            // button_verticline
            // 
            this.button_verticline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_verticline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_verticline.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_verticline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_verticline.Location = new System.Drawing.Point(6, 488);
            this.button_verticline.Name = "button_verticline";
            this.button_verticline.Size = new System.Drawing.Size(248, 42);
            this.button_verticline.TabIndex = 13;
            this.button_verticline.Text = "Вертикальная линия";
            this.button_verticline.UseVisualStyleBackColor = false;
            this.button_verticline.Click += new System.EventHandler(this.button_verticline_Click);
            // 
            // button_horizline
            // 
            this.button_horizline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_horizline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_horizline.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_horizline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_horizline.Location = new System.Drawing.Point(6, 440);
            this.button_horizline.Name = "button_horizline";
            this.button_horizline.Size = new System.Drawing.Size(248, 42);
            this.button_horizline.TabIndex = 12;
            this.button_horizline.Text = "Горизонтальная линия";
            this.button_horizline.UseVisualStyleBackColor = false;
            this.button_horizline.Click += new System.EventHandler(this.button_horizline_Click);
            // 
            // button_trapezoid
            // 
            this.button_trapezoid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_trapezoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trapezoid.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_trapezoid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_trapezoid.Location = new System.Drawing.Point(6, 392);
            this.button_trapezoid.Name = "button_trapezoid";
            this.button_trapezoid.Size = new System.Drawing.Size(248, 42);
            this.button_trapezoid.TabIndex = 11;
            this.button_trapezoid.Text = "Трапецевидный";
            this.button_trapezoid.UseVisualStyleBackColor = false;
            this.button_trapezoid.Click += new System.EventHandler(this.button_trapezoid_Click);
            // 
            // button_trapezoidarc
            // 
            this.button_trapezoidarc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_trapezoidarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trapezoidarc.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_trapezoidarc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_trapezoidarc.Location = new System.Drawing.Point(6, 344);
            this.button_trapezoidarc.Name = "button_trapezoidarc";
            this.button_trapezoidarc.Size = new System.Drawing.Size(248, 42);
            this.button_trapezoidarc.TabIndex = 10;
            this.button_trapezoidarc.Text = "Трапецевидная арка";
            this.button_trapezoidarc.UseVisualStyleBackColor = false;
            this.button_trapezoidarc.Click += new System.EventHandler(this.button_trapezoidarc_Click);
            // 
            // button_arc
            // 
            this.button_arc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_arc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_arc.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_arc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_arc.Location = new System.Drawing.Point(6, 296);
            this.button_arc.Name = "button_arc";
            this.button_arc.Size = new System.Drawing.Size(248, 42);
            this.button_arc.TabIndex = 9;
            this.button_arc.Text = "Арка";
            this.button_arc.UseVisualStyleBackColor = false;
            this.button_arc.Click += new System.EventHandler(this.button_arc_Click);
            // 
            // button_trianglepryam
            // 
            this.button_trianglepryam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_trianglepryam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trianglepryam.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_trianglepryam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_trianglepryam.Location = new System.Drawing.Point(6, 248);
            this.button_trianglepryam.Name = "button_trianglepryam";
            this.button_trianglepryam.Size = new System.Drawing.Size(248, 42);
            this.button_trianglepryam.TabIndex = 8;
            this.button_trianglepryam.Text = "Прямой треугольник";
            this.button_trianglepryam.UseVisualStyleBackColor = false;
            this.button_trianglepryam.Click += new System.EventHandler(this.button_trianglepryam_Click);
            // 
            // button_triangleravn
            // 
            this.button_triangleravn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_triangleravn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_triangleravn.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_triangleravn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_triangleravn.Location = new System.Drawing.Point(6, 200);
            this.button_triangleravn.Name = "button_triangleravn";
            this.button_triangleravn.Size = new System.Drawing.Size(248, 42);
            this.button_triangleravn.TabIndex = 7;
            this.button_triangleravn.Text = "Равносторонний треугольник";
            this.button_triangleravn.UseVisualStyleBackColor = false;
            this.button_triangleravn.Click += new System.EventHandler(this.button_triangleravn_Click);
            // 
            // button_halfelipse
            // 
            this.button_halfelipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_halfelipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_halfelipse.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_halfelipse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_halfelipse.Location = new System.Drawing.Point(6, 104);
            this.button_halfelipse.Name = "button_halfelipse";
            this.button_halfelipse.Size = new System.Drawing.Size(248, 42);
            this.button_halfelipse.TabIndex = 6;
            this.button_halfelipse.Text = "Полукруг";
            this.button_halfelipse.UseVisualStyleBackColor = false;
            this.button_halfelipse.Click += new System.EventHandler(this.button_halfelipse_Click);
            // 
            // button_eight
            // 
            this.button_eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eight.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_eight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_eight.Location = new System.Drawing.Point(6, 152);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(248, 42);
            this.button_eight.TabIndex = 5;
            this.button_eight.Text = "Восьмиугольник";
            this.button_eight.UseVisualStyleBackColor = false;
            this.button_eight.Click += new System.EventHandler(this.button_eight_Click);
            // 
            // button_elipse
            // 
            this.button_elipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_elipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_elipse.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_elipse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_elipse.Location = new System.Drawing.Point(6, 56);
            this.button_elipse.Name = "button_elipse";
            this.button_elipse.Size = new System.Drawing.Size(248, 42);
            this.button_elipse.TabIndex = 4;
            this.button_elipse.Text = "Круг";
            this.button_elipse.UseVisualStyleBackColor = false;
            this.button_elipse.Click += new System.EventHandler(this.button_elipse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(301, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 138);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // glazingTypeTableAdapter1
            // 
            this.glazingTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // windowSillTableAdapter1
            // 
            this.windowSillTableAdapter1.ClearBeforeFill = true;
            // 
            // customWindowsTableAdapter1
            // 
            this.customWindowsTableAdapter1.ClearBeforeFill = true;
            // 
            // WindowProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 790);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowProject";
            this.Text = "Проектирование окон";
            this.Load += new System.EventHandler(this.WindowProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sash;
        private System.Windows.Forms.Button button_verticline;
        private System.Windows.Forms.Button button_horizline;
        private System.Windows.Forms.Button button_trapezoid;
        private System.Windows.Forms.Button button_trapezoidarc;
        private System.Windows.Forms.Button button_arc;
        private System.Windows.Forms.Button button_trianglepryam;
        private System.Windows.Forms.Button button_triangleravn;
        private System.Windows.Forms.Button button_halfelipse;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_elipse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox_glazingtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_sill;
        private System.Windows.Forms.Label label11;
        private StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter glazingTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowSillTableAdapter windowSillTableAdapter1;
        private System.Windows.Forms.Button button_addtoBase;
        private StekloPacketDataSetTableAdapters.CustomWindowsTableAdapter customWindowsTableAdapter1;
    }
}