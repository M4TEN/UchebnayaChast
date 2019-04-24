namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangeDisp
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
            this.LabelZav = new System.Windows.Forms.Label();
            this.ADShifr = new System.Windows.Forms.TextBox();
            this.ADName = new System.Windows.Forms.TextBox();
            this.LabelShifr = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ADCancel = new System.Windows.Forms.Button();
            this.ADAdd = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.ADComboType = new System.Windows.Forms.ComboBox();
            this.ADComboSem = new System.Windows.Forms.ComboBox();
            this.ADNorm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ADLab = new System.Windows.Forms.TextBox();
            this.PanelMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMain.Controls.Add(this.ADLab);
            this.PanelMain.Controls.Add(this.label3);
            this.PanelMain.Controls.Add(this.label2);
            this.PanelMain.Controls.Add(this.label1);
            this.PanelMain.Controls.Add(this.ADNorm);
            this.PanelMain.Controls.Add(this.ADComboSem);
            this.PanelMain.Controls.Add(this.LabelZav);
            this.PanelMain.Controls.Add(this.ADShifr);
            this.PanelMain.Controls.Add(this.ADComboType);
            this.PanelMain.Controls.Add(this.ADName);
            this.PanelMain.Controls.Add(this.LabelShifr);
            this.PanelMain.Controls.Add(this.LabelName);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(510, 230);
            this.PanelMain.TabIndex = 5;
            // 
            // LabelZav
            // 
            this.LabelZav.AutoSize = true;
            this.LabelZav.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZav.Location = new System.Drawing.Point(9, 114);
            this.LabelZav.Name = "LabelZav";
            this.LabelZav.Size = new System.Drawing.Size(93, 18);
            this.LabelZav.TabIndex = 15;
            this.LabelZav.Text = "Кол-во часов";
            // 
            // ADShifr
            // 
            this.ADShifr.Location = new System.Drawing.Point(118, 20);
            this.ADShifr.MaxLength = 3;
            this.ADShifr.Name = "ADShifr";
            this.ADShifr.Size = new System.Drawing.Size(30, 20);
            this.ADShifr.TabIndex = 14;
            this.ADShifr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADShifr_KeyPress);
            // 
            // ADName
            // 
            this.ADName.Location = new System.Drawing.Point(118, 62);
            this.ADName.MaxLength = 50;
            this.ADName.Name = "ADName";
            this.ADName.Size = new System.Drawing.Size(170, 20);
            this.ADName.TabIndex = 12;
            this.ADName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADName_KeyPress);
            // 
            // LabelShifr
            // 
            this.LabelShifr.AutoSize = true;
            this.LabelShifr.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelShifr.Location = new System.Drawing.Point(9, 20);
            this.LabelShifr.Name = "LabelShifr";
            this.LabelShifr.Size = new System.Drawing.Size(46, 18);
            this.LabelShifr.TabIndex = 11;
            this.LabelShifr.Text = "Шифр";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(9, 62);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(87, 36);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Название\r\nдисциплины";
            // 
            // ADCancel
            // 
            this.ADCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ADCancel.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADCancel.Location = new System.Drawing.Point(395, 194);
            this.ADCancel.Name = "ADCancel";
            this.ADCancel.Size = new System.Drawing.Size(97, 28);
            this.ADCancel.TabIndex = 9;
            this.ADCancel.Text = "Отмена";
            this.ADCancel.UseVisualStyleBackColor = true;
            // 
            // ADAdd
            // 
            this.ADAdd.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADAdd.Location = new System.Drawing.Point(12, 194);
            this.ADAdd.Name = "ADAdd";
            this.ADAdd.Size = new System.Drawing.Size(97, 28);
            this.ADAdd.TabIndex = 8;
            this.ADAdd.Text = "Добавить";
            this.ADAdd.UseVisualStyleBackColor = true;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.LabelTop);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(520, 30);
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
            // ADComboType
            // 
            this.ADComboType.FormattingEnabled = true;
            this.ADComboType.Items.AddRange(new object[] {
            "Экзамен",
            "Диференцированный зачёт",
            "Зачёт"});
            this.ADComboType.Location = new System.Drawing.Point(313, 114);
            this.ADComboType.Name = "ADComboType";
            this.ADComboType.Size = new System.Drawing.Size(179, 21);
            this.ADComboType.TabIndex = 13;
            this.ADComboType.Text = "              ";
            // 
            // ADComboSem
            // 
            this.ADComboSem.FormattingEnabled = true;
            this.ADComboSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ADComboSem.Location = new System.Drawing.Point(443, 19);
            this.ADComboSem.Name = "ADComboSem";
            this.ADComboSem.Size = new System.Drawing.Size(49, 21);
            this.ADComboSem.TabIndex = 16;
            this.ADComboSem.Text = "              ";
            // 
            // ADNorm
            // 
            this.ADNorm.Location = new System.Drawing.Point(118, 112);
            this.ADNorm.MaxLength = 3;
            this.ADNorm.Name = "ADNorm";
            this.ADNorm.Size = new System.Drawing.Size(30, 20);
            this.ADNorm.TabIndex = 17;
            this.ADNorm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADNorm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Семестр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Оценивание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Кол-во лаб";
            // 
            // ADLab
            // 
            this.ADLab.Location = new System.Drawing.Point(118, 151);
            this.ADLab.MaxLength = 3;
            this.ADLab.Name = "ADLab";
            this.ADLab.Size = new System.Drawing.Size(30, 20);
            this.ADLab.TabIndex = 21;
            this.ADLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADLab_KeyPress);
            // 
            // FormAddChangeDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddChangeDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelZav;
        private System.Windows.Forms.TextBox ADShifr;
        private System.Windows.Forms.TextBox ADName;
        private System.Windows.Forms.Label LabelShifr;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.ComboBox ADComboType;
        private System.Windows.Forms.TextBox ADNorm;
        private System.Windows.Forms.ComboBox ADComboSem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ADLab;
    }
}