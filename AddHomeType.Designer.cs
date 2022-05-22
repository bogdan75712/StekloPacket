namespace Steklo
{
    partial class AddHomeType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHomeType));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_name_hometype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_hometype = new System.Windows.Forms.TextBox();
            this.button_addhome = new System.Windows.Forms.Button();
            this.homeTypeTableAdapter1 = new Steklo.StekloPacketDataSetTableAdapters.HomeTypeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 118);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(140, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добавление типа дома";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_close.Location = new System.Drawing.Point(371, 12);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(1, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 81);
            this.panel2.TabIndex = 6;
            // 
            // textBox_name_hometype
            // 
            this.textBox_name_hometype.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_hometype.Location = new System.Drawing.Point(201, 164);
            this.textBox_name_hometype.Name = "textBox_name_hometype";
            this.textBox_name_hometype.Size = new System.Drawing.Size(174, 28);
            this.textBox_name_hometype.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя типа дома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип дома";
            // 
            // textBox_hometype
            // 
            this.textBox_hometype.Font = new System.Drawing.Font("Candara Light", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hometype.Location = new System.Drawing.Point(201, 209);
            this.textBox_hometype.Name = "textBox_hometype";
            this.textBox_hometype.Size = new System.Drawing.Size(174, 28);
            this.textBox_hometype.TabIndex = 10;
            // 
            // button_addhome
            // 
            this.button_addhome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addhome.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addhome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_addhome.Location = new System.Drawing.Point(140, 264);
            this.button_addhome.Name = "button_addhome";
            this.button_addhome.Size = new System.Drawing.Size(235, 42);
            this.button_addhome.TabIndex = 6;
            this.button_addhome.Text = "Добавить";
            this.button_addhome.UseVisualStyleBackColor = false;
            this.button_addhome.Click += new System.EventHandler(this.button_addhome_Click);
            // 
            // homeTypeTableAdapter1
            // 
            this.homeTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // AddHomeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.button_addhome);
            this.Controls.Add(this.textBox_hometype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name_hometype);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddHomeType";
            this.Text = "Добавление типа дома";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_name_hometype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_hometype;
        private System.Windows.Forms.Button button_addhome;
        private StekloPacketDataSetTableAdapters.HomeTypeTableAdapter homeTypeTableAdapter1;
    }
}