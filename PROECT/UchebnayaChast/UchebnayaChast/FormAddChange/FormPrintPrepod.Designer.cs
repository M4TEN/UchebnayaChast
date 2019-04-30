namespace UchebnayaChast.FormAddChange
{
    partial class FormPrintPrepod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintPrepod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelKolvoVsego = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelKolvo3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelKolvo2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelKolvo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrepodGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_kategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnScreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrepodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LabelKolvoVsego);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LabelKolvo3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LabelKolvo2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelKolvo1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PrepodGrid);
            this.panel1.Controls.Add(this.BtnScreen);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 450);
            this.panel1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1032, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Всего:";
            // 
            // LabelKolvoVsego
            // 
            this.LabelKolvoVsego.AutoSize = true;
            this.LabelKolvoVsego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvoVsego.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvoVsego.Location = new System.Drawing.Point(1108, 249);
            this.LabelKolvoVsego.Name = "LabelKolvoVsego";
            this.LabelKolvoVsego.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvoVsego.TabIndex = 77;
            this.LabelKolvoVsego.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1021, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "3-й кат:";
            // 
            // LabelKolvo3
            // 
            this.LabelKolvo3.AutoSize = true;
            this.LabelKolvo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvo3.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvo3.Location = new System.Drawing.Point(1108, 215);
            this.LabelKolvo3.Name = "LabelKolvo3";
            this.LabelKolvo3.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvo3.TabIndex = 75;
            this.LabelKolvo3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1021, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "2-й кат:";
            // 
            // LabelKolvo2
            // 
            this.LabelKolvo2.AutoSize = true;
            this.LabelKolvo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvo2.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvo2.Location = new System.Drawing.Point(1108, 183);
            this.LabelKolvo2.Name = "LabelKolvo2";
            this.LabelKolvo2.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvo2.TabIndex = 73;
            this.LabelKolvo2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1021, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "1-й кат:";
            // 
            // LabelKolvo1
            // 
            this.LabelKolvo1.AutoSize = true;
            this.LabelKolvo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvo1.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvo1.Location = new System.Drawing.Point(1108, 152);
            this.LabelKolvo1.Name = "LabelKolvo1";
            this.LabelKolvo1.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvo1.TabIndex = 71;
            this.LabelKolvo1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1021, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 70;
            this.label2.Text = "Кол-во\r\nпреподов:";
            // 
            // PrepodGrid
            // 
            this.PrepodGrid.AllowUserToAddRows = false;
            this.PrepodGrid.AllowUserToDeleteRows = false;
            this.PrepodGrid.AllowUserToResizeColumns = false;
            this.PrepodGrid.AllowUserToResizeRows = false;
            this.PrepodGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.PrepodGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrepodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PrepodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrepodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.P_fio,
            this.P_kategory,
            this.K_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PrepodGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrepodGrid.EnableHeadersVisualStyles = false;
            this.PrepodGrid.Location = new System.Drawing.Point(5, 5);
            this.PrepodGrid.Name = "PrepodGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PrepodGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PrepodGrid.RowHeadersVisible = false;
            this.PrepodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrepodGrid.Size = new System.Drawing.Size(1010, 440);
            this.PrepodGrid.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // P_fio
            // 
            this.P_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_fio.HeaderText = "ФИО";
            this.P_fio.Name = "P_fio";
            this.P_fio.ReadOnly = true;
            this.P_fio.Width = 64;
            // 
            // P_kategory
            // 
            this.P_kategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_kategory.HeaderText = "Категория";
            this.P_kategory.Name = "P_kategory";
            this.P_kategory.ReadOnly = true;
            this.P_kategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_kategory.Width = 85;
            // 
            // K_id
            // 
            this.K_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.K_id.HeaderText = "Кафедра";
            this.K_id.Name = "K_id";
            this.K_id.ReadOnly = true;
            this.K_id.Width = 93;
            // 
            // BtnScreen
            // 
            this.BtnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnScreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnScreen.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnScreen.Location = new System.Drawing.Point(1021, 5);
            this.BtnScreen.Name = "BtnScreen";
            this.BtnScreen.Size = new System.Drawing.Size(112, 103);
            this.BtnScreen.TabIndex = 23;
            this.BtnScreen.Text = "Скриншот на рабочий стол";
            this.BtnScreen.UseVisualStyleBackColor = false;
            this.BtnScreen.Click += new System.EventHandler(this.BtnScreen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnClose.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(1021, 342);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 103);
            this.BtnClose.TabIndex = 24;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormPrintPrepod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrintPrepod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintPrepod";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrepodGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnScreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView PrepodGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_kategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelKolvoVsego;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelKolvo3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelKolvo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelKolvo1;
        private System.Windows.Forms.Label label2;
    }
}