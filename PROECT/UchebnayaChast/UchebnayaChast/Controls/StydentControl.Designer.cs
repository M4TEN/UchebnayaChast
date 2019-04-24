namespace UchebnayaChast
{
    partial class StydentControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StydentControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFnc = new System.Windows.Forms.Panel();
            this.LabelRight = new System.Windows.Forms.Label();
            this.BtnFncChange = new System.Windows.Forms.Button();
            this.BtnFncAdd = new System.Windows.Forms.Button();
            this.BtnFncDelete = new System.Windows.Forms.Button();
            this.BtnFncDrop = new System.Windows.Forms.Button();
            this.BtnFncSearch = new System.Windows.Forms.Button();
            this.StydentPoiskFio = new System.Windows.Forms.TextBox();
            this.StydentGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_postyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_zach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_opl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPoiskBK = new System.Windows.Forms.Label();
            this.StydentPoiskGryp = new System.Windows.Forms.ComboBox();
            this.StydentPoiskBK = new System.Windows.Forms.ComboBox();
            this.LabelPoiskKyrs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPoiskFio = new System.Windows.Forms.Label();
            this.PanelFnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StydentGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFnc
            // 
            this.PanelFnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.PanelFnc.Controls.Add(this.LabelRight);
            this.PanelFnc.Controls.Add(this.BtnFncChange);
            this.PanelFnc.Controls.Add(this.BtnFncAdd);
            this.PanelFnc.Controls.Add(this.BtnFncDelete);
            this.PanelFnc.Controls.Add(this.BtnFncDrop);
            this.PanelFnc.Controls.Add(this.BtnFncSearch);
            this.PanelFnc.Location = new System.Drawing.Point(715, 0);
            this.PanelFnc.Name = "PanelFnc";
            this.PanelFnc.Size = new System.Drawing.Size(160, 410);
            this.PanelFnc.TabIndex = 12;
            // 
            // LabelRight
            // 
            this.LabelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelRight.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRight.Location = new System.Drawing.Point(0, 5);
            this.LabelRight.Name = "LabelRight";
            this.LabelRight.Size = new System.Drawing.Size(160, 25);
            this.LabelRight.TabIndex = 8;
            this.LabelRight.Text = "Функции";
            this.LabelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFncChange
            // 
            this.BtnFncChange.FlatAppearance.BorderSize = 0;
            this.BtnFncChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFncChange.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFncChange.Image = ((System.Drawing.Image)(resources.GetObject("BtnFncChange.Image")));
            this.BtnFncChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncChange.Location = new System.Drawing.Point(5, 215);
            this.BtnFncChange.Name = "BtnFncChange";
            this.BtnFncChange.Size = new System.Drawing.Size(150, 40);
            this.BtnFncChange.TabIndex = 4;
            this.BtnFncChange.Text = "   Изменить";
            this.BtnFncChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFncChange.UseVisualStyleBackColor = false;
            // 
            // BtnFncAdd
            // 
            this.BtnFncAdd.FlatAppearance.BorderSize = 0;
            this.BtnFncAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFncAdd.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFncAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnFncAdd.Image")));
            this.BtnFncAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncAdd.Location = new System.Drawing.Point(5, 125);
            this.BtnFncAdd.Name = "BtnFncAdd";
            this.BtnFncAdd.Size = new System.Drawing.Size(150, 40);
            this.BtnFncAdd.TabIndex = 3;
            this.BtnFncAdd.Text = "   Добавить";
            this.BtnFncAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFncAdd.UseVisualStyleBackColor = false;
            this.BtnFncAdd.Click += new System.EventHandler(this.BtnFncAdd_Click);
            // 
            // BtnFncDelete
            // 
            this.BtnFncDelete.FlatAppearance.BorderSize = 0;
            this.BtnFncDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFncDelete.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFncDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnFncDelete.Image")));
            this.BtnFncDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncDelete.Location = new System.Drawing.Point(5, 170);
            this.BtnFncDelete.Name = "BtnFncDelete";
            this.BtnFncDelete.Size = new System.Drawing.Size(150, 40);
            this.BtnFncDelete.TabIndex = 2;
            this.BtnFncDelete.Text = "   Удалить";
            this.BtnFncDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFncDelete.UseVisualStyleBackColor = false;
            // 
            // BtnFncDrop
            // 
            this.BtnFncDrop.FlatAppearance.BorderSize = 0;
            this.BtnFncDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFncDrop.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFncDrop.Image = ((System.Drawing.Image)(resources.GetObject("BtnFncDrop.Image")));
            this.BtnFncDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncDrop.Location = new System.Drawing.Point(5, 80);
            this.BtnFncDrop.Name = "BtnFncDrop";
            this.BtnFncDrop.Size = new System.Drawing.Size(150, 40);
            this.BtnFncDrop.TabIndex = 1;
            this.BtnFncDrop.Text = "   Сбросить";
            this.BtnFncDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncDrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFncDrop.UseVisualStyleBackColor = false;
            this.BtnFncDrop.Click += new System.EventHandler(this.BtnFncDrop_Click);
            // 
            // BtnFncSearch
            // 
            this.BtnFncSearch.FlatAppearance.BorderSize = 0;
            this.BtnFncSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFncSearch.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFncSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnFncSearch.Image")));
            this.BtnFncSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncSearch.Location = new System.Drawing.Point(5, 35);
            this.BtnFncSearch.Name = "BtnFncSearch";
            this.BtnFncSearch.Size = new System.Drawing.Size(150, 40);
            this.BtnFncSearch.TabIndex = 0;
            this.BtnFncSearch.Text = "   Найти";
            this.BtnFncSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFncSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFncSearch.UseVisualStyleBackColor = false;
            this.BtnFncSearch.Click += new System.EventHandler(this.BtnFncSearch_Click);
            // 
            // StydentPoiskFio
            // 
            this.StydentPoiskFio.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StydentPoiskFio.Location = new System.Drawing.Point(89, 37);
            this.StydentPoiskFio.Name = "StydentPoiskFio";
            this.StydentPoiskFio.Size = new System.Drawing.Size(113, 21);
            this.StydentPoiskFio.TabIndex = 36;
            this.StydentPoiskFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StydentPoiskFio_KeyPress);
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
            this.St_data,
            this.St_town,
            this.St_adres,
            this.St_postyp,
            this.St_nomer,
            this.St_zach,
            this.St_opl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StydentGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StydentGrid.EnableHeadersVisualStyles = false;
            this.StydentGrid.Location = new System.Drawing.Point(20, 20);
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
            this.StydentGrid.Size = new System.Drawing.Size(450, 370);
            this.StydentGrid.TabIndex = 35;
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
            // St_zach
            // 
            this.St_zach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_zach.HeaderText = "№ зачётки";
            this.St_zach.Name = "St_zach";
            this.St_zach.ReadOnly = true;
            this.St_zach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_zach.Width = 88;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.LabelPoiskBK);
            this.panel1.Controls.Add(this.StydentPoiskGryp);
            this.panel1.Controls.Add(this.StydentPoiskBK);
            this.panel1.Controls.Add(this.LabelPoiskKyrs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StydentPoiskFio);
            this.panel1.Controls.Add(this.LabelPoiskFio);
            this.panel1.Location = new System.Drawing.Point(490, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 410);
            this.panel1.TabIndex = 40;
            // 
            // LabelPoiskBK
            // 
            this.LabelPoiskBK.AutoSize = true;
            this.LabelPoiskBK.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskBK.Location = new System.Drawing.Point(3, 91);
            this.LabelPoiskBK.Name = "LabelPoiskBK";
            this.LabelPoiskBK.Size = new System.Drawing.Size(87, 40);
            this.LabelPoiskBK.TabIndex = 37;
            this.LabelPoiskBK.Text = "Бюджет/\r\nКонтракт";
            // 
            // StydentPoiskGryp
            // 
            this.StydentPoiskGryp.FormattingEnabled = true;
            this.StydentPoiskGryp.Location = new System.Drawing.Point(89, 64);
            this.StydentPoiskGryp.Name = "StydentPoiskGryp";
            this.StydentPoiskGryp.Size = new System.Drawing.Size(113, 21);
            this.StydentPoiskGryp.TabIndex = 33;
            // 
            // StydentPoiskBK
            // 
            this.StydentPoiskBK.FormattingEnabled = true;
            this.StydentPoiskBK.Items.AddRange(new object[] {
            "Бюджет",
            "Контракт"});
            this.StydentPoiskBK.Location = new System.Drawing.Point(89, 91);
            this.StydentPoiskBK.Name = "StydentPoiskBK";
            this.StydentPoiskBK.Size = new System.Drawing.Size(113, 21);
            this.StydentPoiskBK.TabIndex = 32;
            // 
            // LabelPoiskKyrs
            // 
            this.LabelPoiskKyrs.AutoSize = true;
            this.LabelPoiskKyrs.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskKyrs.Location = new System.Drawing.Point(3, 65);
            this.LabelPoiskKyrs.Name = "LabelPoiskKyrs";
            this.LabelPoiskKyrs.Size = new System.Drawing.Size(65, 20);
            this.LabelPoiskKyrs.TabIndex = 30;
            this.LabelPoiskKyrs.Text = "Группа:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.label1.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поиск:";
            // 
            // LabelPoiskFio
            // 
            this.LabelPoiskFio.AutoSize = true;
            this.LabelPoiskFio.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskFio.Location = new System.Drawing.Point(3, 39);
            this.LabelPoiskFio.Name = "LabelPoiskFio";
            this.LabelPoiskFio.Size = new System.Drawing.Size(49, 20);
            this.LabelPoiskFio.TabIndex = 26;
            this.LabelPoiskFio.Text = "ФИО:";
            // 
            // StydentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StydentGrid);
            this.Controls.Add(this.PanelFnc);
            this.Name = "StydentControl";
            this.Size = new System.Drawing.Size(875, 410);
            this.PanelFnc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StydentGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFnc;
        private System.Windows.Forms.Label LabelRight;
        private System.Windows.Forms.Button BtnFncChange;
        private System.Windows.Forms.Button BtnFncAdd;
        private System.Windows.Forms.Button BtnFncDelete;
        private System.Windows.Forms.Button BtnFncDrop;
        private System.Windows.Forms.Button BtnFncSearch;
        private System.Windows.Forms.TextBox StydentPoiskFio;
        private System.Windows.Forms.DataGridView StydentGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox StydentPoiskGryp;
        private System.Windows.Forms.ComboBox StydentPoiskBK;
        private System.Windows.Forms.Label LabelPoiskKyrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPoiskFio;
        private System.Windows.Forms.Label LabelPoiskBK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_town;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_postyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_nomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_zach;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_opl;
    }
}
