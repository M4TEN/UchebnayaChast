namespace UchebnayaChast
{
    partial class DispControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelFnc = new System.Windows.Forms.Panel();
            this.LabelRight = new System.Windows.Forms.Label();
            this.BtnFncChange = new System.Windows.Forms.Button();
            this.BtnFncAdd = new System.Windows.Forms.Button();
            this.BtnFncDelete = new System.Windows.Forms.Button();
            this.BtnFncDrop = new System.Windows.Forms.Button();
            this.BtnFncSearch = new System.Windows.Forms.Button();
            this.DispGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_shifr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPoiskType = new System.Windows.Forms.Label();
            this.DispPoiskType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DispPoiskName = new System.Windows.Forms.TextBox();
            this.LabelPoiskName = new System.Windows.Forms.Label();
            this.DispPoiskSem = new System.Windows.Forms.ComboBox();
            this.LabelSem = new System.Windows.Forms.Label();
            this.PanelFnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispGrid)).BeginInit();
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
            this.PanelFnc.TabIndex = 10;
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
            // DispGrid
            // 
            this.DispGrid.AllowUserToAddRows = false;
            this.DispGrid.AllowUserToDeleteRows = false;
            this.DispGrid.AllowUserToResizeColumns = false;
            this.DispGrid.AllowUserToResizeRows = false;
            this.DispGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.DispGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DispGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DispGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.D_shifr,
            this.D_name,
            this.D_norm,
            this.D_lab,
            this.D_sem,
            this.D_type});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DispGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DispGrid.EnableHeadersVisualStyles = false;
            this.DispGrid.Location = new System.Drawing.Point(20, 20);
            this.DispGrid.Name = "DispGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DispGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DispGrid.RowHeadersVisible = false;
            this.DispGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DispGrid.Size = new System.Drawing.Size(450, 370);
            this.DispGrid.TabIndex = 30;
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
            // D_shifr
            // 
            this.D_shifr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_shifr.HeaderText = "Шифр";
            this.D_shifr.Name = "D_shifr";
            this.D_shifr.ReadOnly = true;
            this.D_shifr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_shifr.Width = 52;
            // 
            // D_name
            // 
            this.D_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_name.HeaderText = "Название";
            this.D_name.Name = "D_name";
            this.D_name.ReadOnly = true;
            this.D_name.Width = 93;
            // 
            // D_norm
            // 
            this.D_norm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_norm.HeaderText = "Часов";
            this.D_norm.Name = "D_norm";
            this.D_norm.ReadOnly = true;
            this.D_norm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_norm.Width = 52;
            // 
            // D_lab
            // 
            this.D_lab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_lab.HeaderText = "Л/р";
            this.D_lab.Name = "D_lab";
            this.D_lab.ReadOnly = true;
            this.D_lab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_lab.Width = 37;
            // 
            // D_sem
            // 
            this.D_sem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_sem.HeaderText = "Сем";
            this.D_sem.Name = "D_sem";
            this.D_sem.ReadOnly = true;
            this.D_sem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_sem.Width = 41;
            // 
            // D_type
            // 
            this.D_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_type.HeaderText = "Оценивание";
            this.D_type.Name = "D_type";
            this.D_type.ReadOnly = true;
            this.D_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.D_type.Width = 95;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.LabelSem);
            this.panel1.Controls.Add(this.DispPoiskSem);
            this.panel1.Controls.Add(this.LabelPoiskType);
            this.panel1.Controls.Add(this.DispPoiskType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DispPoiskName);
            this.panel1.Controls.Add(this.LabelPoiskName);
            this.panel1.Location = new System.Drawing.Point(490, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 410);
            this.panel1.TabIndex = 41;
            // 
            // LabelPoiskType
            // 
            this.LabelPoiskType.AutoSize = true;
            this.LabelPoiskType.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskType.Location = new System.Drawing.Point(15, 102);
            this.LabelPoiskType.Name = "LabelPoiskType";
            this.LabelPoiskType.Size = new System.Drawing.Size(104, 20);
            this.LabelPoiskType.TabIndex = 37;
            this.LabelPoiskType.Text = "Оценивание:";
            // 
            // DispPoiskType
            // 
            this.DispPoiskType.FormattingEnabled = true;
            this.DispPoiskType.Items.AddRange(new object[] {
            "Экзамен",
            "Диференцированный зачёт",
            "Зачёт"});
            this.DispPoiskType.Location = new System.Drawing.Point(19, 125);
            this.DispPoiskType.Name = "DispPoiskType";
            this.DispPoiskType.Size = new System.Drawing.Size(167, 21);
            this.DispPoiskType.TabIndex = 33;
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
            // DispPoiskName
            // 
            this.DispPoiskName.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DispPoiskName.Location = new System.Drawing.Point(19, 62);
            this.DispPoiskName.MaxLength = 40;
            this.DispPoiskName.Name = "DispPoiskName";
            this.DispPoiskName.Size = new System.Drawing.Size(167, 21);
            this.DispPoiskName.TabIndex = 36;
            this.DispPoiskName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DispPoiskName_KeyPress);
            // 
            // LabelPoiskName
            // 
            this.LabelPoiskName.AutoSize = true;
            this.LabelPoiskName.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskName.Location = new System.Drawing.Point(15, 39);
            this.LabelPoiskName.Name = "LabelPoiskName";
            this.LabelPoiskName.Size = new System.Drawing.Size(80, 20);
            this.LabelPoiskName.TabIndex = 26;
            this.LabelPoiskName.Text = "Название:";
            // 
            // DispPoiskSem
            // 
            this.DispPoiskSem.FormattingEnabled = true;
            this.DispPoiskSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.DispPoiskSem.Location = new System.Drawing.Point(19, 195);
            this.DispPoiskSem.Name = "DispPoiskSem";
            this.DispPoiskSem.Size = new System.Drawing.Size(53, 21);
            this.DispPoiskSem.TabIndex = 38;
            // 
            // LabelSem
            // 
            this.LabelSem.AutoSize = true;
            this.LabelSem.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSem.Location = new System.Drawing.Point(15, 170);
            this.LabelSem.Name = "LabelSem";
            this.LabelSem.Size = new System.Drawing.Size(83, 20);
            this.LabelSem.TabIndex = 39;
            this.LabelSem.Text = "Семестр:";
            // 
            // DispControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DispGrid);
            this.Controls.Add(this.PanelFnc);
            this.Name = "DispControl";
            this.Size = new System.Drawing.Size(875, 410);
            this.PanelFnc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DispGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView DispGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_shifr;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_lab;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelPoiskType;
        private System.Windows.Forms.ComboBox DispPoiskType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DispPoiskName;
        private System.Windows.Forms.Label LabelPoiskName;
        private System.Windows.Forms.Label LabelSem;
        private System.Windows.Forms.ComboBox DispPoiskSem;
    }
}
