namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangeGryp
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
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelSpecly = new System.Windows.Forms.Label();
            this.ADCancel = new System.Windows.Forms.Button();
            this.ADAdd = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.ADComboSpecly = new System.Windows.Forms.ComboBox();
            this.ADComboNumber = new System.Windows.Forms.ComboBox();
            this.ADComboKyrs = new System.Windows.Forms.ComboBox();
            this.ADComboBorn = new System.Windows.Forms.ComboBox();
            this.LabelKyrs = new System.Windows.Forms.Label();
            this.LabelBorn = new System.Windows.Forms.Label();
            this.LabelKlRyk = new System.Windows.Forms.Label();
            this.ADComboKlRyk = new System.Windows.Forms.ComboBox();
            this.PanelMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMain.Controls.Add(this.ADComboKlRyk);
            this.PanelMain.Controls.Add(this.LabelKlRyk);
            this.PanelMain.Controls.Add(this.LabelBorn);
            this.PanelMain.Controls.Add(this.LabelKyrs);
            this.PanelMain.Controls.Add(this.ADComboBorn);
            this.PanelMain.Controls.Add(this.ADComboKyrs);
            this.PanelMain.Controls.Add(this.ADComboNumber);
            this.PanelMain.Controls.Add(this.ADComboSpecly);
            this.PanelMain.Controls.Add(this.LabelNumber);
            this.PanelMain.Controls.Add(this.LabelSpecly);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 38);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(363, 226);
            this.PanelMain.TabIndex = 3;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumber.Location = new System.Drawing.Point(7, 59);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(23, 18);
            this.LabelNumber.TabIndex = 11;
            this.LabelNumber.Text = "№";
            // 
            // LabelSpecly
            // 
            this.LabelSpecly.AutoSize = true;
            this.LabelSpecly.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpecly.Location = new System.Drawing.Point(9, 29);
            this.LabelSpecly.Name = "LabelSpecly";
            this.LabelSpecly.Size = new System.Drawing.Size(111, 18);
            this.LabelSpecly.TabIndex = 10;
            this.LabelSpecly.Text = "Специальность";
            // 
            // ADCancel
            // 
            this.ADCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ADCancel.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADCancel.Location = new System.Drawing.Point(183, 188);
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
            this.ADAdd.Location = new System.Drawing.Point(36, 188);
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
            // ADComboSpecly
            // 
            this.ADComboSpecly.FormattingEnabled = true;
            this.ADComboSpecly.Location = new System.Drawing.Point(126, 29);
            this.ADComboSpecly.Name = "ADComboSpecly";
            this.ADComboSpecly.Size = new System.Drawing.Size(220, 21);
            this.ADComboSpecly.TabIndex = 33;
            // 
            // ADComboNumber
            // 
            this.ADComboNumber.FormattingEnabled = true;
            this.ADComboNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ADComboNumber.Location = new System.Drawing.Point(126, 56);
            this.ADComboNumber.Name = "ADComboNumber";
            this.ADComboNumber.Size = new System.Drawing.Size(39, 21);
            this.ADComboNumber.TabIndex = 34;
            // 
            // ADComboKyrs
            // 
            this.ADComboKyrs.FormattingEnabled = true;
            this.ADComboKyrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ADComboKyrs.Location = new System.Drawing.Point(126, 83);
            this.ADComboKyrs.Name = "ADComboKyrs";
            this.ADComboKyrs.Size = new System.Drawing.Size(39, 21);
            this.ADComboKyrs.TabIndex = 35;
            // 
            // ADComboBorn
            // 
            this.ADComboBorn.FormattingEnabled = true;
            this.ADComboBorn.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ADComboBorn.Location = new System.Drawing.Point(126, 108);
            this.ADComboBorn.Name = "ADComboBorn";
            this.ADComboBorn.Size = new System.Drawing.Size(39, 21);
            this.ADComboBorn.TabIndex = 36;
            // 
            // LabelKyrs
            // 
            this.LabelKyrs.AutoSize = true;
            this.LabelKyrs.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKyrs.Location = new System.Drawing.Point(9, 86);
            this.LabelKyrs.Name = "LabelKyrs";
            this.LabelKyrs.Size = new System.Drawing.Size(38, 18);
            this.LabelKyrs.TabIndex = 37;
            this.LabelKyrs.Text = "Курс";
            // 
            // LabelBorn
            // 
            this.LabelBorn.AutoSize = true;
            this.LabelBorn.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBorn.Location = new System.Drawing.Point(9, 110);
            this.LabelBorn.Name = "LabelBorn";
            this.LabelBorn.Size = new System.Drawing.Size(32, 18);
            this.LabelBorn.TabIndex = 38;
            this.LabelBorn.Text = "Год";
            // 
            // LabelKlRyk
            // 
            this.LabelKlRyk.AutoSize = true;
            this.LabelKlRyk.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKlRyk.Location = new System.Drawing.Point(9, 138);
            this.LabelKlRyk.Name = "LabelKlRyk";
            this.LabelKlRyk.Size = new System.Drawing.Size(56, 18);
            this.LabelKlRyk.TabIndex = 39;
            this.LabelKlRyk.Text = "Кл. рук.";
            // 
            // ADComboKlRyk
            // 
            this.ADComboKlRyk.FormattingEnabled = true;
            this.ADComboKlRyk.Location = new System.Drawing.Point(126, 135);
            this.ADComboKlRyk.Name = "ADComboKlRyk";
            this.ADComboKlRyk.Size = new System.Drawing.Size(220, 21);
            this.ADComboKlRyk.TabIndex = 40;
            // 
            // FormAddChangeGryp
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
            this.Name = "FormAddChangeGryp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelSpecly;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.ComboBox ADComboSpecly;
        private System.Windows.Forms.ComboBox ADComboBorn;
        private System.Windows.Forms.ComboBox ADComboKyrs;
        private System.Windows.Forms.ComboBox ADComboNumber;
        private System.Windows.Forms.ComboBox ADComboKlRyk;
        private System.Windows.Forms.Label LabelKlRyk;
        private System.Windows.Forms.Label LabelBorn;
        private System.Windows.Forms.Label LabelKyrs;
    }
}