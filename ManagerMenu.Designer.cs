namespace Steklo
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_make_order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 118);
            this.panel1.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_close.Location = new System.Drawing.Point(330, 3);
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
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Меню Менеджера";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(-1, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 100);
            this.panel2.TabIndex = 2;
            // 
            // button_make_order
            // 
            this.button_make_order.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_make_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_make_order.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_make_order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_make_order.Location = new System.Drawing.Point(113, 171);
            this.button_make_order.Name = "button_make_order";
            this.button_make_order.Size = new System.Drawing.Size(236, 48);
            this.button_make_order.TabIndex = 5;
            this.button_make_order.Text = "Оформление заказа";
            this.button_make_order.UseVisualStyleBackColor = false;
            this.button_make_order.Click += new System.EventHandler(this.button_make_order_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(113, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Статус заказа";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(113, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Проектирование окон";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_make_order);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerMenu";
            this.Text = "Меню менеджера";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_make_order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}