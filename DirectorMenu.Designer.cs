namespace Steklo
{
    partial class DirectorMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_redakt = new System.Windows.Forms.Button();
            this.button_otchetManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_otchetSum = new System.Windows.Forms.Button();
            this.button_manageradd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 118);
            this.panel1.TabIndex = 2;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(330, 3);
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
            // button_redakt
            // 
            this.button_redakt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_redakt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_redakt.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_redakt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_redakt.Location = new System.Drawing.Point(112, 246);
            this.button_redakt.Name = "button_redakt";
            this.button_redakt.Size = new System.Drawing.Size(236, 48);
            this.button_redakt.TabIndex = 10;
            this.button_redakt.Text = "Изменение цен/товаров";
            this.button_redakt.UseVisualStyleBackColor = false;
            this.button_redakt.Click += new System.EventHandler(this.button_redakt_Click);
            // 
            // button_otchetManager
            // 
            this.button_otchetManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_otchetManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_otchetManager.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_otchetManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_otchetManager.Location = new System.Drawing.Point(112, 183);
            this.button_otchetManager.Name = "button_otchetManager";
            this.button_otchetManager.Size = new System.Drawing.Size(236, 48);
            this.button_otchetManager.TabIndex = 9;
            this.button_otchetManager.Text = "Отчетность по менеджерам";
            this.button_otchetManager.UseVisualStyleBackColor = false;
            this.button_otchetManager.Click += new System.EventHandler(this.button_otchetManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.92308F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Меню Директора";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(1, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 65);
            this.panel2.TabIndex = 12;
            // 
            // button_otchetSum
            // 
            this.button_otchetSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_otchetSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_otchetSum.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_otchetSum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_otchetSum.Location = new System.Drawing.Point(112, 309);
            this.button_otchetSum.Name = "button_otchetSum";
            this.button_otchetSum.Size = new System.Drawing.Size(236, 48);
            this.button_otchetSum.TabIndex = 13;
            this.button_otchetSum.Text = "Отчетность по доходам";
            this.button_otchetSum.UseVisualStyleBackColor = false;
            this.button_otchetSum.Click += new System.EventHandler(this.button_otchetSum_Click);
            // 
            // button_manageradd
            // 
            this.button_manageradd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_manageradd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_manageradd.Font = new System.Drawing.Font("Candara", 11.76923F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_manageradd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_manageradd.Location = new System.Drawing.Point(112, 376);
            this.button_manageradd.Name = "button_manageradd";
            this.button_manageradd.Size = new System.Drawing.Size(236, 48);
            this.button_manageradd.TabIndex = 14;
            this.button_manageradd.Text = "Добавление менеджера";
            this.button_manageradd.UseVisualStyleBackColor = false;
            this.button_manageradd.Click += new System.EventHandler(this.button_manageradd_Click);
            // 
            // DirectorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(473, 523);
            this.Controls.Add(this.button_manageradd);
            this.Controls.Add(this.button_otchetSum);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_redakt);
            this.Controls.Add(this.button_otchetManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectorMenu";
            this.Text = "Меню директора";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_redakt;
        private System.Windows.Forms.Button button_otchetManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_otchetSum;
        private System.Windows.Forms.Button button_manageradd;
    }
}