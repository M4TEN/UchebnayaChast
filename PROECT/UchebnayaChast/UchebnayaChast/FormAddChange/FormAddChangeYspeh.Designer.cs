namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangeYspeh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddChangeYspeh));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ADZach = new System.Windows.Forms.TextBox();
            this.LabelZach = new System.Windows.Forms.Label();
            this.LabelSem = new System.Windows.Forms.Label();
            this.ADSem = new System.Windows.Forms.ComboBox();
            this.ADBall = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ADDisp = new System.Windows.Forms.TextBox();
            this.ADPrepod = new System.Windows.Forms.TextBox();
            this.CnrData = new System.Windows.Forms.MonthCalendar();
            this.ADFio = new System.Windows.Forms.TextBox();
            this.LabelNomer = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
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
            this.PanelMain.Controls.Add(this.ADZach);
            this.PanelMain.Controls.Add(this.LabelZach);
            this.PanelMain.Controls.Add(this.LabelSem);
            this.PanelMain.Controls.Add(this.ADSem);
            this.PanelMain.Controls.Add(this.ADBall);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.ADDisp);
            this.PanelMain.Controls.Add(this.ADPrepod);
            this.PanelMain.Controls.Add(this.CnrData);
            this.PanelMain.Controls.Add(this.ADFio);
            this.PanelMain.Controls.Add(this.LabelNomer);
            this.PanelMain.Controls.Add(this.LabelName);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(325, 315);
            this.PanelMain.TabIndex = 3;
            // 
            // ADZach
            // 
            this.ADZach.Location = new System.Drawing.Point(13, 154);
            this.ADZach.MaxLength = 7;
            this.ADZach.Name = "ADZach";
            this.ADZach.Size = new System.Drawing.Size(85, 20);
            this.ADZach.TabIndex = 46;
            this.ADZach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADZach_KeyPress);
            // 
            // LabelZach
            // 
            this.LabelZach.AutoSize = true;
            this.LabelZach.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZach.Location = new System.Drawing.Point(10, 134);
            this.LabelZach.Name = "LabelZach";
            this.LabelZach.Size = new System.Drawing.Size(64, 18);
            this.LabelZach.TabIndex = 45;
            this.LabelZach.Text = "Зачётка";
            // 
            // LabelSem
            // 
            this.LabelSem.AutoSize = true;
            this.LabelSem.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSem.Location = new System.Drawing.Point(8, 222);
            this.LabelSem.Name = "LabelSem";
            this.LabelSem.Size = new System.Drawing.Size(72, 18);
            this.LabelSem.TabIndex = 44;
            this.LabelSem.Text = "Семестр:";
            // 
            // ADSem
            // 
            this.ADSem.FormattingEnabled = true;
            this.ADSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ADSem.Location = new System.Drawing.Point(13, 245);
            this.ADSem.Name = "ADSem";
            this.ADSem.Size = new System.Drawing.Size(53, 21);
            this.ADSem.TabIndex = 5;
            // 
            // ADBall
            // 
            this.ADBall.FormattingEnabled = true;
            this.ADBall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ADBall.Location = new System.Drawing.Point(13, 198);
            this.ADBall.Name = "ADBall";
            this.ADBall.Size = new System.Drawing.Size(35, 21);
            this.ADBall.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Балл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Дата оценивания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Дисциплина";
            // 
            // ADDisp
            // 
            this.ADDisp.Location = new System.Drawing.Point(142, 72);
            this.ADDisp.MaxLength = 40;
            this.ADDisp.Name = "ADDisp";
            this.ADDisp.Size = new System.Drawing.Size(164, 20);
            this.ADDisp.TabIndex = 2;
            this.ADDisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADDisp_KeyPress);
            // 
            // ADPrepod
            // 
            this.ADPrepod.Location = new System.Drawing.Point(142, 46);
            this.ADPrepod.MaxLength = 50;
            this.ADPrepod.Name = "ADPrepod";
            this.ADPrepod.Size = new System.Drawing.Size(164, 20);
            this.ADPrepod.TabIndex = 1;
            this.ADPrepod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADPrepod_KeyPress);
            // 
            // CnrData
            // 
            this.CnrData.Location = new System.Drawing.Point(142, 104);
            this.CnrData.MaxDate = new System.DateTime(2019, 4, 25, 0, 0, 0, 0);
            this.CnrData.MaxSelectionCount = 1;
            this.CnrData.MinDate = new System.DateTime(2018, 12, 1, 0, 0, 0, 0);
            this.CnrData.Name = "CnrData";
            this.CnrData.TabIndex = 3;
            // 
            // ADFio
            // 
            this.ADFio.Location = new System.Drawing.Point(142, 20);
            this.ADFio.MaxLength = 50;
            this.ADFio.Name = "ADFio";
            this.ADFio.Size = new System.Drawing.Size(164, 20);
            this.ADFio.TabIndex = 0;
            this.ADFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADFio_KeyPress);
            // 
            // LabelNomer
            // 
            this.LabelNomer.AutoSize = true;
            this.LabelNomer.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNomer.Location = new System.Drawing.Point(9, 48);
            this.LabelNomer.Name = "LabelNomer";
            this.LabelNomer.Size = new System.Drawing.Size(112, 18);
            this.LabelNomer.TabIndex = 11;
            this.LabelNomer.Text = "Преподаватель";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(9, 22);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(69, 18);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Студент";
            // 
            // ADCancel
            // 
            this.ADCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ADCancel.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADCancel.Location = new System.Drawing.Point(209, 278);
            this.ADCancel.Name = "ADCancel";
            this.ADCancel.Size = new System.Drawing.Size(97, 28);
            this.ADCancel.TabIndex = 7;
            this.ADCancel.Text = "Отмена";
            this.ADCancel.UseVisualStyleBackColor = true;
            this.ADCancel.Click += new System.EventHandler(this.ADCancel_Click);
            // 
            // ADAdd
            // 
            this.ADAdd.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADAdd.Location = new System.Drawing.Point(12, 278);
            this.ADAdd.Name = "ADAdd";
            this.ADAdd.Size = new System.Drawing.Size(97, 28);
            this.ADAdd.TabIndex = 6;
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
            this.PanelTop.Size = new System.Drawing.Size(335, 30);
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
            // FormAddChangeYspeh
            // 
            this.AcceptButton = this.ADAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ADCancel;
            this.ClientSize = new System.Drawing.Size(335, 355);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddChangeYspeh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddChangeYspeh";
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelNomer;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.TextBox ADFio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ADDisp;
        private System.Windows.Forms.TextBox ADPrepod;
        private System.Windows.Forms.ComboBox ADBall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar CnrData;
        private System.Windows.Forms.Label LabelSem;
        private System.Windows.Forms.ComboBox ADSem;
        private System.Windows.Forms.TextBox ADZach;
        private System.Windows.Forms.Label LabelZach;
    }
}