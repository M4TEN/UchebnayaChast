namespace UchebnayaChast.FormAddChange
{
    partial class FormPrintStydentKicked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintStydentKicked));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRepairStydent = new System.Windows.Forms.Button();
            this.LabelKolS = new System.Windows.Forms.Label();
            this.LabelSkolkoStydentov = new System.Windows.Forms.Label();
            this.LabelKolK = new System.Windows.Forms.Label();
            this.LabelSkolkoKon = new System.Windows.Forms.Label();
            this.LabelKolB = new System.Windows.Forms.Label();
            this.LabelSkolkoByud = new System.Windows.Forms.Label();
            this.StydentGrid = new System.Windows.Forms.DataGridView();
            this.BtnScreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_zach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_postyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_opl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_vipisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StydentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.BtnRepairStydent);
            this.panel1.Controls.Add(this.LabelKolS);
            this.panel1.Controls.Add(this.LabelSkolkoStydentov);
            this.panel1.Controls.Add(this.LabelKolK);
            this.panel1.Controls.Add(this.LabelSkolkoKon);
            this.panel1.Controls.Add(this.LabelKolB);
            this.panel1.Controls.Add(this.LabelSkolkoByud);
            this.panel1.Controls.Add(this.StydentGrid);
            this.panel1.Controls.Add(this.BtnScreen);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 450);
            this.panel1.TabIndex = 27;
            // 
            // BtnRepairStydent
            // 
            this.BtnRepairStydent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnRepairStydent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnRepairStydent.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRepairStydent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRepairStydent.Location = new System.Drawing.Point(1021, 270);
            this.BtnRepairStydent.Name = "BtnRepairStydent";
            this.BtnRepairStydent.Size = new System.Drawing.Size(112, 66);
            this.BtnRepairStydent.TabIndex = 55;
            this.BtnRepairStydent.Text = "Восстановить студента";
            this.BtnRepairStydent.UseVisualStyleBackColor = false;
            this.BtnRepairStydent.Click += new System.EventHandler(this.BtnRepairStydent_Click);
            // 
            // LabelKolS
            // 
            this.LabelKolS.AutoSize = true;
            this.LabelKolS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolS.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolS.Location = new System.Drawing.Point(1092, 160);
            this.LabelKolS.Name = "LabelKolS";
            this.LabelKolS.Size = new System.Drawing.Size(17, 20);
            this.LabelKolS.TabIndex = 54;
            this.LabelKolS.Text = "0";
            // 
            // LabelSkolkoStydentov
            // 
            this.LabelSkolkoStydentov.AutoSize = true;
            this.LabelSkolkoStydentov.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoStydentov.Location = new System.Drawing.Point(1031, 160);
            this.LabelSkolkoStydentov.Name = "LabelSkolkoStydentov";
            this.LabelSkolkoStydentov.Size = new System.Drawing.Size(47, 18);
            this.LabelSkolkoStydentov.TabIndex = 53;
            this.LabelSkolkoStydentov.Text = "Всего:";
            // 
            // LabelKolK
            // 
            this.LabelKolK.AutoSize = true;
            this.LabelKolK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolK.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolK.Location = new System.Drawing.Point(1092, 134);
            this.LabelKolK.Name = "LabelKolK";
            this.LabelKolK.Size = new System.Drawing.Size(17, 20);
            this.LabelKolK.TabIndex = 52;
            this.LabelKolK.Text = "0";
            // 
            // LabelSkolkoKon
            // 
            this.LabelSkolkoKon.AutoSize = true;
            this.LabelSkolkoKon.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoKon.Location = new System.Drawing.Point(1073, 136);
            this.LabelSkolkoKon.Name = "LabelSkolkoKon";
            this.LabelSkolkoKon.Size = new System.Drawing.Size(19, 18);
            this.LabelSkolkoKon.TabIndex = 51;
            this.LabelSkolkoKon.Text = "К:";
            // 
            // LabelKolB
            // 
            this.LabelKolB.AutoSize = true;
            this.LabelKolB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolB.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolB.Location = new System.Drawing.Point(1050, 134);
            this.LabelKolB.Name = "LabelKolB";
            this.LabelKolB.Size = new System.Drawing.Size(17, 20);
            this.LabelKolB.TabIndex = 50;
            this.LabelKolB.Text = "0";
            // 
            // LabelSkolkoByud
            // 
            this.LabelSkolkoByud.AutoSize = true;
            this.LabelSkolkoByud.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoByud.Location = new System.Drawing.Point(1031, 118);
            this.LabelSkolkoByud.Name = "LabelSkolkoByud";
            this.LabelSkolkoByud.Size = new System.Drawing.Size(52, 36);
            this.LabelSkolkoByud.TabIndex = 49;
            this.LabelSkolkoByud.Text = "Кол-во\r\nБ:";
            // 
            // StydentGrid
            // 
            this.StydentGrid.AllowUserToAddRows = false;
            this.StydentGrid.AllowUserToDeleteRows = false;
            this.StydentGrid.AllowUserToResizeColumns = false;
            this.StydentGrid.AllowUserToResizeRows = false;
            this.StydentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.StydentGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StydentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StydentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StydentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.G_id,
            this.St_fio,
            this.St_zach,
            this.St_data,
            this.St_town,
            this.St_adres,
            this.St_postyp,
            this.St_nomer,
            this.St_opl,
            this.St_status,
            this.St_vipisk});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StydentGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StydentGrid.EnableHeadersVisualStyles = false;
            this.StydentGrid.Location = new System.Drawing.Point(5, 5);
            this.StydentGrid.Name = "StydentGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StydentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StydentGrid.RowHeadersVisible = false;
            this.StydentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StydentGrid.Size = new System.Drawing.Size(1010, 440);
            this.StydentGrid.TabIndex = 36;
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
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 25;
            // 
            // G_id
            // 
            this.G_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_id.HeaderText = "Группа";
            this.G_id.Name = "G_id";
            this.G_id.ReadOnly = true;
            this.G_id.Width = 80;
            // 
            // St_fio
            // 
            this.St_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_fio.HeaderText = "ФИО";
            this.St_fio.Name = "St_fio";
            this.St_fio.ReadOnly = true;
            this.St_fio.Width = 64;
            // 
            // St_zach
            // 
            this.St_zach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_zach.HeaderText = "№ зачётки";
            this.St_zach.Name = "St_zach";
            this.St_zach.ReadOnly = true;
            this.St_zach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_zach.Width = 88;
            // 
            // St_data
            // 
            this.St_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_data.HeaderText = "Дата р.";
            this.St_data.Name = "St_data";
            this.St_data.ReadOnly = true;
            this.St_data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_data.Width = 66;
            // 
            // St_town
            // 
            this.St_town.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_town.HeaderText = "Город";
            this.St_town.Name = "St_town";
            this.St_town.ReadOnly = true;
            this.St_town.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_town.Width = 54;
            // 
            // St_adres
            // 
            this.St_adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_adres.HeaderText = "Адрес";
            this.St_adres.Name = "St_adres";
            this.St_adres.ReadOnly = true;
            this.St_adres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_adres.Width = 54;
            // 
            // St_postyp
            // 
            this.St_postyp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_postyp.HeaderText = "Дата пост.";
            this.St_postyp.Name = "St_postyp";
            this.St_postyp.ReadOnly = true;
            this.St_postyp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_postyp.Width = 92;
            // 
            // St_nomer
            // 
            this.St_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_nomer.HeaderText = "Телефон";
            this.St_nomer.Name = "St_nomer";
            this.St_nomer.ReadOnly = true;
            this.St_nomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_nomer.Width = 74;
            // 
            // St_opl
            // 
            this.St_opl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_opl.HeaderText = "Б/К";
            this.St_opl.Name = "St_opl";
            this.St_opl.ReadOnly = true;
            this.St_opl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_opl.Width = 35;
            // 
            // St_status
            // 
            this.St_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_status.HeaderText = "СтатусСтудента";
            this.St_status.Name = "St_status";
            this.St_status.ReadOnly = true;
            this.St_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_status.Visible = false;
            this.St_status.Width = 136;
            // 
            // St_vipisk
            // 
            this.St_vipisk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_vipisk.HeaderText = "Статус";
            this.St_vipisk.Name = "St_vipisk";
            this.St_vipisk.ReadOnly = true;
            this.St_vipisk.Width = 86;
            // 
            // FormPrintStydentKicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrintStydentKicked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintStydentKicked";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StydentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelKolS;
        private System.Windows.Forms.Label LabelSkolkoStydentov;
        private System.Windows.Forms.Label LabelKolK;
        private System.Windows.Forms.Label LabelSkolkoKon;
        private System.Windows.Forms.Label LabelKolB;
        private System.Windows.Forms.Label LabelSkolkoByud;
        private System.Windows.Forms.DataGridView StydentGrid;
        private System.Windows.Forms.Button BtnScreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnRepairStydent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_zach;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_town;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_postyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_opl;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_vipisk;
    }
}