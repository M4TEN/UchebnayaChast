namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangeStydent
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
            this.ADTown = new System.Windows.Forms.TextBox();
            this.ADFio = new System.Windows.Forms.TextBox();
            this.LabelFio = new System.Windows.Forms.Label();
            this.LabelGryp = new System.Windows.Forms.Label();
            this.ADCancel = new System.Windows.Forms.Button();
            this.ADAdd = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.ADComboGryp = new System.Windows.Forms.ComboBox();
            this.CnrData = new System.Windows.Forms.MonthCalendar();
            this.LabelData = new System.Windows.Forms.Label();
            this.CnrPostyp = new System.Windows.Forms.MonthCalendar();
            this.LabelPostyp = new System.Windows.Forms.Label();
            this.LabelTown = new System.Windows.Forms.Label();
            this.LabelAdres = new System.Windows.Forms.Label();
            this.ADAdres = new System.Windows.Forms.TextBox();
            this.ADNomer = new System.Windows.Forms.TextBox();
            this.LabelNomer = new System.Windows.Forms.Label();
            this.LabelZach = new System.Windows.Forms.Label();
            this.ADZach = new System.Windows.Forms.TextBox();
            this.ADComboBK = new System.Windows.Forms.ComboBox();
            this.LabelBK = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMain.Controls.Add(this.LabelBK);
            this.PanelMain.Controls.Add(this.ADComboBK);
            this.PanelMain.Controls.Add(this.ADZach);
            this.PanelMain.Controls.Add(this.LabelZach);
            this.PanelMain.Controls.Add(this.LabelNomer);
            this.PanelMain.Controls.Add(this.ADNomer);
            this.PanelMain.Controls.Add(this.ADAdres);
            this.PanelMain.Controls.Add(this.LabelAdres);
            this.PanelMain.Controls.Add(this.LabelTown);
            this.PanelMain.Controls.Add(this.LabelPostyp);
            this.PanelMain.Controls.Add(this.CnrPostyp);
            this.PanelMain.Controls.Add(this.LabelData);
            this.PanelMain.Controls.Add(this.CnrData);
            this.PanelMain.Controls.Add(this.ADComboGryp);
            this.PanelMain.Controls.Add(this.ADTown);
            this.PanelMain.Controls.Add(this.ADFio);
            this.PanelMain.Controls.Add(this.LabelFio);
            this.PanelMain.Controls.Add(this.LabelGryp);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(640, 275);
            this.PanelMain.TabIndex = 3;
            // 
            // ADTown
            // 
            this.ADTown.Location = new System.Drawing.Point(97, 69);
            this.ADTown.MaxLength = 10;
            this.ADTown.Name = "ADTown";
            this.ADTown.Size = new System.Drawing.Size(155, 20);
            this.ADTown.TabIndex = 14;
            // 
            // ADFio
            // 
            this.ADFio.Location = new System.Drawing.Point(97, 43);
            this.ADFio.MaxLength = 100;
            this.ADFio.Name = "ADFio";
            this.ADFio.Size = new System.Drawing.Size(155, 20);
            this.ADFio.TabIndex = 2;
            // 
            // LabelFio
            // 
            this.LabelFio.AutoSize = true;
            this.LabelFio.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFio.Location = new System.Drawing.Point(9, 45);
            this.LabelFio.Name = "LabelFio";
            this.LabelFio.Size = new System.Drawing.Size(39, 18);
            this.LabelFio.TabIndex = 11;
            this.LabelFio.Text = "ФИО";
            // 
            // LabelGryp
            // 
            this.LabelGryp.AutoSize = true;
            this.LabelGryp.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGryp.Location = new System.Drawing.Point(9, 19);
            this.LabelGryp.Name = "LabelGryp";
            this.LabelGryp.Size = new System.Drawing.Size(55, 18);
            this.LabelGryp.TabIndex = 10;
            this.LabelGryp.Text = "Группа";
            // 
            // ADCancel
            // 
            this.ADCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ADCancel.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADCancel.Location = new System.Drawing.Point(525, 228);
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
            this.ADAdd.Location = new System.Drawing.Point(37, 228);
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
            this.PanelTop.Size = new System.Drawing.Size(650, 30);
            this.PanelTop.TabIndex = 2;
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
            // ADComboGryp
            // 
            this.ADComboGryp.FormattingEnabled = true;
            this.ADComboGryp.Location = new System.Drawing.Point(97, 16);
            this.ADComboGryp.Name = "ADComboGryp";
            this.ADComboGryp.Size = new System.Drawing.Size(80, 21);
            this.ADComboGryp.TabIndex = 1;
            // 
            // CnrData
            // 
            this.CnrData.Location = new System.Drawing.Point(276, 43);
            this.CnrData.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.CnrData.MaxSelectionCount = 1;
            this.CnrData.MinDate = new System.DateTime(1990, 12, 1, 0, 0, 0, 0);
            this.CnrData.Name = "CnrData";
            this.CnrData.ShowToday = false;
            this.CnrData.TabIndex = 15;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelData.Location = new System.Drawing.Point(273, 16);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(113, 18);
            this.LabelData.TabIndex = 16;
            this.LabelData.Text = "Дата рождения";
            // 
            // CnrPostyp
            // 
            this.CnrPostyp.Location = new System.Drawing.Point(458, 43);
            this.CnrPostyp.MaxDate = new System.DateTime(2019, 4, 24, 0, 0, 0, 0);
            this.CnrPostyp.MaxSelectionCount = 1;
            this.CnrPostyp.MinDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.CnrPostyp.Name = "CnrPostyp";
            this.CnrPostyp.ShowToday = false;
            this.CnrPostyp.TabIndex = 17;
            // 
            // LabelPostyp
            // 
            this.LabelPostyp.AutoSize = true;
            this.LabelPostyp.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPostyp.Location = new System.Drawing.Point(455, 16);
            this.LabelPostyp.Name = "LabelPostyp";
            this.LabelPostyp.Size = new System.Drawing.Size(135, 18);
            this.LabelPostyp.TabIndex = 18;
            this.LabelPostyp.Text = "Дата поступления";
            // 
            // LabelTown
            // 
            this.LabelTown.AutoSize = true;
            this.LabelTown.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTown.Location = new System.Drawing.Point(9, 71);
            this.LabelTown.Name = "LabelTown";
            this.LabelTown.Size = new System.Drawing.Size(48, 18);
            this.LabelTown.TabIndex = 19;
            this.LabelTown.Text = "Город";
            // 
            // LabelAdres
            // 
            this.LabelAdres.AutoSize = true;
            this.LabelAdres.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdres.Location = new System.Drawing.Point(9, 95);
            this.LabelAdres.Name = "LabelAdres";
            this.LabelAdres.Size = new System.Drawing.Size(48, 18);
            this.LabelAdres.TabIndex = 20;
            this.LabelAdres.Text = "Адрес";
            // 
            // ADAdres
            // 
            this.ADAdres.Location = new System.Drawing.Point(97, 95);
            this.ADAdres.MaxLength = 10;
            this.ADAdres.Name = "ADAdres";
            this.ADAdres.Size = new System.Drawing.Size(155, 20);
            this.ADAdres.TabIndex = 21;
            // 
            // ADNomer
            // 
            this.ADNomer.Location = new System.Drawing.Point(97, 121);
            this.ADNomer.MaxLength = 10;
            this.ADNomer.Name = "ADNomer";
            this.ADNomer.Size = new System.Drawing.Size(80, 20);
            this.ADNomer.TabIndex = 22;
            // 
            // LabelNomer
            // 
            this.LabelNomer.AutoSize = true;
            this.LabelNomer.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNomer.Location = new System.Drawing.Point(9, 123);
            this.LabelNomer.Name = "LabelNomer";
            this.LabelNomer.Size = new System.Drawing.Size(68, 18);
            this.LabelNomer.TabIndex = 23;
            this.LabelNomer.Text = "Телефон";
            // 
            // LabelZach
            // 
            this.LabelZach.AutoSize = true;
            this.LabelZach.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZach.Location = new System.Drawing.Point(9, 149);
            this.LabelZach.Name = "LabelZach";
            this.LabelZach.Size = new System.Drawing.Size(82, 18);
            this.LabelZach.TabIndex = 24;
            this.LabelZach.Text = "№ зачётки";
            // 
            // ADZach
            // 
            this.ADZach.Location = new System.Drawing.Point(97, 147);
            this.ADZach.MaxLength = 7;
            this.ADZach.Name = "ADZach";
            this.ADZach.Size = new System.Drawing.Size(80, 20);
            this.ADZach.TabIndex = 25;
            // 
            // ADComboBK
            // 
            this.ADComboBK.FormattingEnabled = true;
            this.ADComboBK.Items.AddRange(new object[] {
            "Бюджет",
            "Контракт"});
            this.ADComboBK.Location = new System.Drawing.Point(97, 173);
            this.ADComboBK.Name = "ADComboBK";
            this.ADComboBK.Size = new System.Drawing.Size(80, 21);
            this.ADComboBK.TabIndex = 26;
            // 
            // LabelBK
            // 
            this.LabelBK.AutoSize = true;
            this.LabelBK.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBK.Location = new System.Drawing.Point(9, 173);
            this.LabelBK.Name = "LabelBK";
            this.LabelBK.Size = new System.Drawing.Size(76, 36);
            this.LabelBK.TabIndex = 27;
            this.LabelBK.Text = "Бюджет\\\r\nКонтракт\r\n";
            // 
            // FormAddChangeStydent
            // 
            this.AcceptButton = this.ADAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.CancelButton = this.ADCancel;
            this.ClientSize = new System.Drawing.Size(650, 315);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddChangeStydent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddChangeStydent";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TextBox ADTown;
        private System.Windows.Forms.TextBox ADFio;
        private System.Windows.Forms.Label LabelFio;
        private System.Windows.Forms.Label LabelGryp;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.ComboBox ADComboGryp;
        private System.Windows.Forms.MonthCalendar CnrData;
        private System.Windows.Forms.Label LabelPostyp;
        private System.Windows.Forms.MonthCalendar CnrPostyp;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.TextBox ADNomer;
        private System.Windows.Forms.TextBox ADAdres;
        private System.Windows.Forms.Label LabelAdres;
        private System.Windows.Forms.Label LabelTown;
        private System.Windows.Forms.Label LabelNomer;
        private System.Windows.Forms.TextBox ADZach;
        private System.Windows.Forms.Label LabelZach;
        private System.Windows.Forms.Label LabelBK;
        private System.Windows.Forms.ComboBox ADComboBK;
    }
}