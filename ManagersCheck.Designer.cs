namespace Steklo
{
    partial class ManagersCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagersCheck));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_manager = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_period = new System.Windows.Forms.ComboBox();
            this.label_summ = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.UsersTableAdapter();
            this.ordersManagersTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.OrdersManagersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(693, 118);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(154, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отчетность по менеджерам";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exit.Location = new System.Drawing.Point(523, 12);
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
            this.panel2.Location = new System.Drawing.Point(0, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 72);
            this.panel2.TabIndex = 5;
            // 
            // comboBox_manager
            // 
            this.comboBox_manager.FormattingEnabled = true;
            this.comboBox_manager.Location = new System.Drawing.Point(21, 162);
            this.comboBox_manager.Name = "comboBox_manager";
            this.comboBox_manager.Size = new System.Drawing.Size(184, 29);
            this.comboBox_manager.TabIndex = 6;
            this.comboBox_manager.SelectionChangeCommitted += new System.EventHandler(this.comboBox_manager_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите менеджера";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 44;
            this.dataGridView1.Size = new System.Drawing.Size(581, 319);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите период";
            // 
            // comboBox_period
            // 
            this.comboBox_period.FormattingEnabled = true;
            this.comboBox_period.Items.AddRange(new object[] {
            "За все время",
            "За месяц"});
            this.comboBox_period.Location = new System.Drawing.Point(293, 162);
            this.comboBox_period.Name = "comboBox_period";
            this.comboBox_period.Size = new System.Drawing.Size(184, 29);
            this.comboBox_period.TabIndex = 9;
            this.comboBox_period.SelectionChangeCommitted += new System.EventHandler(this.comboBox_period_SelectionChangeCommitted);
            // 
            // label_summ
            // 
            this.label_summ.AutoSize = true;
            this.label_summ.Location = new System.Drawing.Point(17, 543);
            this.label_summ.Name = "label_summ";
            this.label_summ.Size = new System.Drawing.Size(126, 21);
            this.label_summ.TabIndex = 12;
            this.label_summ.Text = "Сумма продаж: ";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersManagersTableAdapter1
            // 
            this.ordersManagersTableAdapter1.ClearBeforeFill = true;
            // 
            // ManagersCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(687, 641);
            this.Controls.Add(this.label_summ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_period);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_manager);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagersCheck";
            this.Text = "Отчетность по менеджерам";
            this.Load += new System.EventHandler(this.ManagersCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_manager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_period;
        private System.Windows.Forms.Label label_summ;
        private StekloPacketDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private StekloPacketDataSetTableAdapters.OrdersManagersTableAdapter ordersManagersTableAdapter1;
    }
}