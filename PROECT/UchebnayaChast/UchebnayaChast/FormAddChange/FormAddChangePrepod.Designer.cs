namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangePrepod
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ADComboKategory = new System.Windows.Forms.ComboBox();
            this.LabelKafedra = new System.Windows.Forms.Label();
            this.ADComboKafedra = new System.Windows.Forms.ComboBox();
            this.ADFio = new System.Windows.Forms.TextBox();
            this.LabelKategory = new System.Windows.Forms.Label();
            this.LabelFio = new System.Windows.Forms.Label();
            this.ADCancel = new System.Windows.Forms.Button();
            this.ADAdd = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMain.Controls.Add(this.ADComboKategory);
            this.PanelMain.Controls.Add(this.LabelKafedra);
            this.PanelMain.Controls.Add(this.ADComboKafedra);
            this.PanelMain.Controls.Add(this.ADFio);
            this.PanelMain.Controls.Add(this.LabelKategory);
            this.PanelMain.Controls.Add(this.LabelFio);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(363, 226);
            this.PanelMain.TabIndex = 5;
            // 
            // ADComboKategory
            // 
            this.ADComboKategory.FormattingEnabled = true;
            this.ADComboKategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ADComboKategory.Location = new System.Drawing.Point(183, 83);
            this.ADComboKategory.Name = "ADComboKategory";
            this.ADComboKategory.Size = new System.Drawing.Size(44, 21);
            this.ADComboKategory.TabIndex = 16;
            // 
            // LabelKafedra
            // 
            this.LabelKafedra.AutoSize = true;
            this.LabelKafedra.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKafedra.Location = new System.Drawing.Point(33, 117);
            this.LabelKafedra.Name = "LabelKafedra";
            this.LabelKafedra.Size = new System.Drawing.Size(68, 18);
            this.LabelKafedra.TabIndex = 15;
            this.LabelKafedra.Text = "Кафедра";
            // 
            // ADComboKafedra
            // 
            this.ADComboKafedra.FormattingEnabled = true;
            this.ADComboKafedra.Location = new System.Drawing.Point(183, 117);
            this.ADComboKafedra.Name = "ADComboKafedra";
            this.ADComboKafedra.Size = new System.Drawing.Size(155, 21);
            this.ADComboKafedra.TabIndex = 13;
            this.ADComboKafedra.Text = "              ";
            // 
            // ADFio
            // 
            this.ADFio.Location = new System.Drawing.Point(183, 46);
            this.ADFio.Name = "ADFio";
            this.ADFio.Size = new System.Drawing.Size(155, 20);
            this.ADFio.TabIndex = 12;
            this.ADFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADFio_KeyPress);
            // 
            // LabelKategory
            // 
            this.LabelKategory.AutoSize = true;
            this.LabelKategory.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKategory.Location = new System.Drawing.Point(33, 83);
            this.LabelKategory.Name = "LabelKategory";
            this.LabelKategory.Size = new System.Drawing.Size(79, 18);
            this.LabelKategory.TabIndex = 11;
            this.LabelKategory.Text = "Категория";
            // 
            // LabelFio
            // 
            this.LabelFio.AutoSize = true;
            this.LabelFio.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFio.Location = new System.Drawing.Point(33, 46);
            this.LabelFio.Name = "LabelFio";
            this.LabelFio.Size = new System.Drawing.Size(39, 18);
            this.LabelFio.TabIndex = 10;
            this.LabelFio.Text = "ФИО\r\n";
            // 
            // ADCancel
            // 
            this.ADCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ADCancel.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADCancel.Location = new System.Drawing.Point(183, 175);
            this.ADCancel.Name = "ADCancel";
            this.ADCancel.Size = new System.Drawing.Size(97, 28);
            this.ADCancel.TabIndex = 9;
            this.ADCancel.Text = "Отмена";
            this.ADCancel.UseVisualStyleBackColor = true;
            this.ADCancel.Click += new System.EventHandler(this.ADCancel_Click);
            // 
            // ADAdd
            // 
            this.ADAdd.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADAdd.Location = new System.Drawing.Point(36, 175);
            this.ADAdd.Name = "ADAdd";
            this.ADAdd.Size = new System.Drawing.Size(97, 28);
            this.ADAdd.TabIndex = 8;
            this.ADAdd.Text = "Добавить";
            this.ADAdd.UseVisualStyleBackColor = true;
            this.ADAdd.Click += new System.EventHandler(this.ADAdd_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.LabelTop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(373, 30);
            this.PanelTop.TabIndex = 4;
            // 
            // LabelTop
            // 
            this.LabelTop.AutoSize = true;
            this.LabelTop.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTop.Location = new System.Drawing.Point(13, 4);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(244, 20);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.Text = "Добавление/Изменение данных";
            // 
            // FormAddChangePrepod
            // 
            this.AcceptButton = this.ADAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.CancelButton = this.ADCancel;
            this.ClientSize = new System.Drawing.Size(373, 266);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddChangePrepod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddChangePrepod";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelKafedra;
        private System.Windows.Forms.ComboBox ADComboKafedra;
        private System.Windows.Forms.TextBox ADFio;
        private System.Windows.Forms.Label LabelKategory;
        private System.Windows.Forms.Label LabelFio;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.ComboBox ADComboKategory;
    }
}