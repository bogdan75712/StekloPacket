namespace Steklo
{
    partial class ViewCustomWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomWindows));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customWindowsTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.CustomWindowsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_sill = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_glazingtype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customWindowsGlazingSillTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.CustomWindowsGlazingSillTableAdapter();
            this.glazingTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter();
            this.windowSillTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.WindowSillTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 118);
            this.panel1.TabIndex = 2;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_close.Location = new System.Drawing.Point(978, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(136, 42);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Назад";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Просмотр нестандартных окон";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(-2, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 87);
            this.panel2.TabIndex = 5;
            // 
            // customWindowsTableAdapter1
            // 
            this.customWindowsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.Size = new System.Drawing.Size(519, 311);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(145, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список спроектированных окон";
            // 
            // comboBox_sill
            // 
            this.comboBox_sill.FormattingEnabled = true;
            this.comboBox_sill.Location = new System.Drawing.Point(583, 302);
            this.comboBox_sill.Name = "comboBox_sill";
            this.comboBox_sill.Size = new System.Drawing.Size(121, 29);
            this.comboBox_sill.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(590, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Подоконник";
            // 
            // comboBox_glazingtype
            // 
            this.comboBox_glazingtype.FormattingEnabled = true;
            this.comboBox_glazingtype.Location = new System.Drawing.Point(567, 200);
            this.comboBox_glazingtype.Name = "comboBox_glazingtype";
            this.comboBox_glazingtype.Size = new System.Drawing.Size(149, 29);
            this.comboBox_glazingtype.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(579, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 21);
            this.label14.TabIndex = 27;
            this.label14.Text = "Тип стеклопакета";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Century", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cost.Location = new System.Drawing.Point(563, 424);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(56, 21);
            this.label_cost.TabIndex = 31;
            this.label_cost.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(770, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 270);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // customWindowsGlazingSillTableAdapter1
            // 
            this.customWindowsGlazingSillTableAdapter1.ClearBeforeFill = true;
            // 
            // glazingTypeTableAdapter1
            // 
            this.glazingTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // windowSillTableAdapter1
            // 
            this.windowSillTableAdapter1.ClearBeforeFill = true;
            // 
            // ViewCustomWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 578);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.comboBox_sill);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_glazingtype);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewCustomWindows";
            this.Text = "Просмотр нестандартных окон";
            this.Load += new System.EventHandler(this.ViewCustomWindows_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private StekloPacketDataSetTableAdapters.CustomWindowsTableAdapter customWindowsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_sill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_glazingtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private StekloPacketDataSetTableAdapters.CustomWindowsGlazingSillTableAdapter customWindowsGlazingSillTableAdapter1;
        private StekloPacketDataSetTableAdapters.GlazingTypeTableAdapter glazingTypeTableAdapter1;
        private StekloPacketDataSetTableAdapters.WindowSillTableAdapter windowSillTableAdapter1;
    }
}