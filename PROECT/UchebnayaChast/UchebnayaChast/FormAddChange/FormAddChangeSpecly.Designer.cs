namespace UchebnayaChast.FormAddChange
{
    partial class FormAddChangeSpecly
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTop = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.LabelZav = new System.Windows.Forms.Label();
            this.ADShifr = new System.Windows.Forms.TextBox();
            this.ADCombo = new System.Windows.Forms.ComboBox();
            this.ADName = new System.Windows.Forms.TextBox();
            this.LabelShifr = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ADCancel = new System.Windows.Forms.Button();
            this.ADAdd = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
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
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMain.Controls.Add(this.LabelZav);
            this.PanelMain.Controls.Add(this.ADShifr);
            this.PanelMain.Controls.Add(this.ADCombo);
            this.PanelMain.Controls.Add(this.ADName);
            this.PanelMain.Controls.Add(this.LabelShifr);
            this.PanelMain.Controls.Add(this.LabelName);
            this.PanelMain.Controls.Add(this.ADCancel);
            this.PanelMain.Controls.Add(this.ADAdd);
            this.PanelMain.Location = new System.Drawing.Point(5, 35);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(363, 226);
            this.PanelMain.TabIndex = 3;
            // 
            // LabelZav
            // 
            this.LabelZav.AutoSize = true;
            this.LabelZav.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZav.Location = new System.Drawing.Point(33, 130);
            this.LabelZav.Name = "LabelZav";
            this.LabelZav.Size = new System.Drawing.Size(91, 18);
            this.LabelZav.TabIndex = 15;
            this.LabelZav.Text = "Заведующий";
            // 
            // ADShifr
            // 
            this.ADShifr.Location = new System.Drawing.Point(183, 94);
            this.ADShifr.MaxLength = 2;
            this.ADShifr.Name = "ADShifr";
            this.ADShifr.Size = new System.Drawing.Size(30, 20);
            this.ADShifr.TabIndex = 14;
            this.ADShifr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADShifr_KeyPress);
            // 
            // ADCombo
            // 
            this.ADCombo.FormattingEnabled = true;
            this.ADCombo.Location = new System.Drawing.Point(183, 127);
            this.ADCombo.Name = "ADCombo";
            this.ADCombo.Size = new System.Drawing.Size(155, 21);
            this.ADCombo.TabIndex = 13;
            this.ADCombo.Text = "              ";
            // 
            // ADName
            // 
            this.ADName.Location = new System.Drawing.Point(183, 62);
            this.ADName.MaxLength = 50;
            this.ADName.Name = "ADName";
            this.ADName.Size = new System.Drawing.Size(155, 20);
            this.ADName.TabIndex = 12;
            this.ADName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADName_KeyPress);
            // 
            // LabelShifr
            // 
            this.LabelShifr.AutoSize = true;
            this.LabelShifr.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelShifr.Location = new System.Drawing.Point(33, 96);
            this.LabelShifr.Name = "LabelShifr";
            this.LabelShifr.Size = new System.Drawing.Size(46, 18);
            this.LabelShifr.TabIndex = 11;
            this.LabelShifr.Text = "Шифр";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(33, 46);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(111, 36);
            this.LabelName.TabIndex = 10;
            this.LabelName.Text = "Название \r\nспециальности";
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
            // FormAddChangeSpecly
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
            this.Name = "FormAddChangeSpecly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddChangeSpecly";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TextBox ADShifr;
        private System.Windows.Forms.ComboBox ADCombo;
        private System.Windows.Forms.TextBox ADName;
        private System.Windows.Forms.Label LabelShifr;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ADCancel;
        private System.Windows.Forms.Button ADAdd;
        private System.Windows.Forms.Label LabelZav;
    }
}