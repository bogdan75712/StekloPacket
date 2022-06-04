namespace Steklo
{
    partial class ChangeCostandTovars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCostandTovars));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_windowstype = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_rigthsash = new System.Windows.Forms.ComboBox();
            this.comboBox_centrsash = new System.Windows.Forms.ComboBox();
            this.comboBox_leftsash = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_sill = new System.Windows.Forms.ComboBox();
            this.comboBox_glazingtype = new System.Windows.Forms.ComboBox();
            this.comboBox_manufacturer = new System.Windows.Forms.ComboBox();
            this.comboBox_profiletype = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.profileTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ProfileTypeTableAdapter();
            this.manufacturerTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ManufacturerTableAdapter();
            this.glazingTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter();
            this.colorsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.ColorsTableAdapter();
            this.windowSillTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowSillTableAdapter();
            this.leftSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.LeftSashTableAdapter();
            this.rightSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.RightSashTableAdapter();
            this.mediumSashTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.MediumSashTableAdapter();
            this.windowsAllTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowsAllTableAdapter();
            this.windowsTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowsTypeTableAdapter();
            this.windowsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 118);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изменение цен и товаров";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exit.Location = new System.Drawing.Point(1188, 12);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 75);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.Size = new System.Drawing.Size(944, 442);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox_windowstype);
            this.groupBox1.Controls.Add(this.button_update);
            this.groupBox1.Controls.Add(this.textBox_cost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_rigthsash);
            this.groupBox1.Controls.Add(this.comboBox_centrsash);
            this.groupBox1.Controls.Add(this.comboBox_leftsash);
            this.groupBox1.Controls.Add(this.comboBox_color);
            this.groupBox1.Controls.Add(this.comboBox_sill);
            this.groupBox1.Controls.Add(this.comboBox_glazingtype);
            this.groupBox1.Controls.Add(this.comboBox_manufacturer);
            this.groupBox1.Controls.Add(this.comboBox_profiletype);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(954, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 474);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение характеристик товара";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 68;
            this.label10.Text = "Тип окна";
            // 
            // comboBox_windowstype
            // 
            this.comboBox_windowstype.FormattingEnabled = true;
            this.comboBox_windowstype.Location = new System.Drawing.Point(180, 27);
            this.comboBox_windowstype.Name = "comboBox_windowstype";
            this.comboBox_windowstype.Size = new System.Drawing.Size(172, 29);
            this.comboBox_windowstype.TabIndex = 67;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.Location = new System.Drawing.Point(94, 426);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(223, 42);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Внести изменения";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Century", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cost.Location = new System.Drawing.Point(180, 386);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(121, 28);
            this.textBox_cost.TabIndex = 66;
            this.textBox_cost.TextChanged += new System.EventHandler(this.textBox_cost_TextChanged);
            this.textBox_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cost_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "Цена окна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "Цвет";
            // 
            // comboBox_rigthsash
            // 
            this.comboBox_rigthsash.FormattingEnabled = true;
            this.comboBox_rigthsash.Location = new System.Drawing.Point(180, 327);
            this.comboBox_rigthsash.Name = "comboBox_rigthsash";
            this.comboBox_rigthsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_rigthsash.TabIndex = 59;
            // 
            // comboBox_centrsash
            // 
            this.comboBox_centrsash.FormattingEnabled = true;
            this.comboBox_centrsash.Location = new System.Drawing.Point(180, 283);
            this.comboBox_centrsash.Name = "comboBox_centrsash";
            this.comboBox_centrsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_centrsash.TabIndex = 58;
            // 
            // comboBox_leftsash
            // 
            this.comboBox_leftsash.FormattingEnabled = true;
            this.comboBox_leftsash.Location = new System.Drawing.Point(180, 239);
            this.comboBox_leftsash.Name = "comboBox_leftsash";
            this.comboBox_leftsash.Size = new System.Drawing.Size(196, 29);
            this.comboBox_leftsash.TabIndex = 57;
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(179, 167);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 29);
            this.comboBox_color.TabIndex = 56;
            // 
            // comboBox_sill
            // 
            this.comboBox_sill.FormattingEnabled = true;
            this.comboBox_sill.Location = new System.Drawing.Point(180, 199);
            this.comboBox_sill.Name = "comboBox_sill";
            this.comboBox_sill.Size = new System.Drawing.Size(121, 29);
            this.comboBox_sill.TabIndex = 55;
            // 
            // comboBox_glazingtype
            // 
            this.comboBox_glazingtype.FormattingEnabled = true;
            this.comboBox_glazingtype.Location = new System.Drawing.Point(179, 132);
            this.comboBox_glazingtype.Name = "comboBox_glazingtype";
            this.comboBox_glazingtype.Size = new System.Drawing.Size(149, 29);
            this.comboBox_glazingtype.TabIndex = 54;
            // 
            // comboBox_manufacturer
            // 
            this.comboBox_manufacturer.FormattingEnabled = true;
            this.comboBox_manufacturer.Location = new System.Drawing.Point(179, 97);
            this.comboBox_manufacturer.Name = "comboBox_manufacturer";
            this.comboBox_manufacturer.Size = new System.Drawing.Size(121, 29);
            this.comboBox_manufacturer.TabIndex = 53;
            // 
            // comboBox_profiletype
            // 
            this.comboBox_profiletype.FormattingEnabled = true;
            this.comboBox_profiletype.Location = new System.Drawing.Point(179, 62);
            this.comboBox_profiletype.Name = "comboBox_profiletype";
            this.comboBox_profiletype.Size = new System.Drawing.Size(121, 29);
            this.comboBox_profiletype.TabIndex = 52;
            this.comboBox_profiletype.SelectionChangeCommitted += new System.EventHandler(this.comboBox_profiletype_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 21);
            this.label17.TabIndex = 47;
            this.label17.Text = "Правая створка";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 21);
            this.label16.TabIndex = 46;
            this.label16.Text = "Центральная створка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 21);
            this.label15.TabIndex = 45;
            this.label15.Text = "Левая створка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "Тип стеклопакета";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 21);
            this.label12.TabIndex = 43;
            this.label12.Text = "Тип профиля";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Подоконник";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "Производитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-48, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Цвет";
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
            // leftSashTableAdapter1
            // 
            this.leftSashTableAdapter1.ClearBeforeFill = true;
            // 
            // rightSashTableAdapter1
            // 
            this.rightSashTableAdapter1.ClearBeforeFill = true;
            // 
            // mediumSashTableAdapter1
            // 
            this.mediumSashTableAdapter1.ClearBeforeFill = true;
            // 
            // windowsAllTableAdapter1
            // 
            this.windowsAllTableAdapter1.ClearBeforeFill = true;
            // 
            // windowsTypeTableAdapter1
            // 
            this.windowsTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // windowsTableAdapter1
            // 
            this.windowsTableAdapter1.ClearBeforeFill = true;
            // 
            // ChangeCostandTovars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1336, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeCostandTovars";
            this.Text = "Изменение цен и товаров";
            this.Load += new System.EventHandler(this.ChangeCostandTovars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_rigthsash;
        private System.Windows.Forms.ComboBox comboBox_centrsash;
        private System.Windows.Forms.ComboBox comboBox_leftsash;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_sill;
        private System.Windows.Forms.ComboBox comboBox_glazingtype;
        private System.Windows.Forms.ComboBox comboBox_manufacturer;
        private System.Windows.Forms.ComboBox comboBox_profiletype;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private StekloPacketDataSetTableAdapters.ProfileTypeTableAdapter profileTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter1;
        private StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter glazingTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.ColorsTableAdapter colorsTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowSillTableAdapter windowSillTableAdapter1;
        private StekloPacketDataSetTableAdapters.LeftSashTableAdapter leftSashTableAdapter1;
        private StekloPacketDataSetTableAdapters.RightSashTableAdapter rightSashTableAdapter1;
        private StekloPacketDataSetTableAdapters.MediumSashTableAdapter mediumSashTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowsAllTableAdapter windowsAllTableAdapter1;
        private System.Windows.Forms.Button button_update;
        private StekloPacketDataSetTableAdapters.WindowsTypeTableAdapter windowsTypeTableAdapter1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_windowstype;
        private StekloPacketDataSetTableAdapters.WindowsTableAdapter windowsTableAdapter1;
    }
}