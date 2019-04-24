namespace UchebnayaChast
{
    partial class GrypControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrypControl));
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
            this.LabelPoisk = new System.Windows.Forms.Label();
            this.GrypGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_kyrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelPoiskSpecly = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrypPoiskKlRyk = new System.Windows.Forms.TextBox();
            this.LabelPoiskKlRyk = new System.Windows.Forms.Label();
            this.GrypPoiskSpecly = new System.Windows.Forms.ComboBox();
            this.GrypPoiskKyrs = new System.Windows.Forms.ComboBox();
            this.LabelPoiskKyrs = new System.Windows.Forms.Label();
            this.PanelFnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrypGrid)).BeginInit();
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
            this.PanelFnc.TabIndex = 11;
            this.PanelFnc.UseWaitCursor = true;
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
            this.LabelRight.UseWaitCursor = true;
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
            this.BtnFncChange.UseWaitCursor = true;
            this.BtnFncChange.Click += new System.EventHandler(this.BtnFncChange_Click);
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
            this.BtnFncAdd.UseWaitCursor = true;
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
            this.BtnFncDelete.UseWaitCursor = true;
            this.BtnFncDelete.Click += new System.EventHandler(this.BtnFncDelete_Click);
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
            this.BtnFncDrop.UseWaitCursor = true;
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
            this.BtnFncSearch.UseWaitCursor = true;
            this.BtnFncSearch.Click += new System.EventHandler(this.BtnFncSearch_Click);
            // 
            // LabelPoisk
            // 
            this.LabelPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelPoisk.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoisk.Location = new System.Drawing.Point(0, 7);
            this.LabelPoisk.Name = "LabelPoisk";
            this.LabelPoisk.Size = new System.Drawing.Size(205, 23);
            this.LabelPoisk.TabIndex = 23;
            this.LabelPoisk.Text = "Поиск:";
            // 
            // GrypGrid
            // 
            this.GrypGrid.AllowUserToAddRows = false;
            this.GrypGrid.AllowUserToDeleteRows = false;
            this.GrypGrid.AllowUserToResizeColumns = false;
            this.GrypGrid.AllowUserToResizeRows = false;
            this.GrypGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.GrypGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrypGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrypGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrypGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sp_id,
            this.G_number,
            this.G_kyrs,
            this.G_born,
            this.P_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrypGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrypGrid.EnableHeadersVisualStyles = false;
            this.GrypGrid.Location = new System.Drawing.Point(20, 20);
            this.GrypGrid.Name = "GrypGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrypGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrypGrid.RowHeadersVisible = false;
            this.GrypGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrypGrid.Size = new System.Drawing.Size(450, 370);
            this.GrypGrid.TabIndex = 21;
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
            // Sp_id
            // 
            this.Sp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sp_id.HeaderText = "Специальность";
            this.Sp_id.Name = "Sp_id";
            this.Sp_id.ReadOnly = true;
            this.Sp_id.Width = 136;
            // 
            // G_number
            // 
            this.G_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_number.HeaderText = "№";
            this.G_number.Name = "G_number";
            this.G_number.ReadOnly = true;
            this.G_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G_number.Width = 29;
            // 
            // G_kyrs
            // 
            this.G_kyrs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_kyrs.HeaderText = "Курс";
            this.G_kyrs.Name = "G_kyrs";
            this.G_kyrs.ReadOnly = true;
            this.G_kyrs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G_kyrs.Width = 44;
            // 
            // G_born
            // 
            this.G_born.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_born.HeaderText = "Год";
            this.G_born.Name = "G_born";
            this.G_born.ReadOnly = true;
            this.G_born.Width = 57;
            // 
            // P_id
            // 
            this.P_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_id.HeaderText = "Кл. рук.";
            this.P_id.Name = "P_id";
            this.P_id.ReadOnly = true;
            this.P_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_id.Width = 62;
            // 
            // LabelPoiskSpecly
            // 
            this.LabelPoiskSpecly.AutoSize = true;
            this.LabelPoiskSpecly.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskSpecly.Location = new System.Drawing.Point(4, 39);
            this.LabelPoiskSpecly.Name = "LabelPoiskSpecly";
            this.LabelPoiskSpecly.Size = new System.Drawing.Size(130, 20);
            this.LabelPoiskSpecly.TabIndex = 26;
            this.LabelPoiskSpecly.Text = "Специальность:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.GrypPoiskKlRyk);
            this.panel1.Controls.Add(this.LabelPoiskKlRyk);
            this.panel1.Controls.Add(this.GrypPoiskSpecly);
            this.panel1.Controls.Add(this.GrypPoiskKyrs);
            this.panel1.Controls.Add(this.LabelPoiskKyrs);
            this.panel1.Controls.Add(this.LabelPoisk);
            this.panel1.Controls.Add(this.LabelPoiskSpecly);
            this.panel1.Location = new System.Drawing.Point(490, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 410);
            this.panel1.TabIndex = 27;
            // 
            // GrypPoiskKlRyk
            // 
            this.GrypPoiskKlRyk.Location = new System.Drawing.Point(8, 168);
            this.GrypPoiskKlRyk.MaxLength = 50;
            this.GrypPoiskKlRyk.Name = "GrypPoiskKlRyk";
            this.GrypPoiskKlRyk.Size = new System.Drawing.Size(113, 20);
            this.GrypPoiskKlRyk.TabIndex = 36;
            this.GrypPoiskKlRyk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrypPoiskKlRyk_KeyPress);
            // 
            // LabelPoiskKlRyk
            // 
            this.LabelPoiskKlRyk.AutoSize = true;
            this.LabelPoiskKlRyk.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskKlRyk.Location = new System.Drawing.Point(4, 145);
            this.LabelPoiskKlRyk.Name = "LabelPoiskKlRyk";
            this.LabelPoiskKlRyk.Size = new System.Drawing.Size(62, 20);
            this.LabelPoiskKlRyk.TabIndex = 35;
            this.LabelPoiskKlRyk.Text = "Кл. рук:";
            // 
            // GrypPoiskSpecly
            // 
            this.GrypPoiskSpecly.FormattingEnabled = true;
            this.GrypPoiskSpecly.Location = new System.Drawing.Point(7, 62);
            this.GrypPoiskSpecly.Name = "GrypPoiskSpecly";
            this.GrypPoiskSpecly.Size = new System.Drawing.Size(195, 21);
            this.GrypPoiskSpecly.TabIndex = 33;
            // 
            // GrypPoiskKyrs
            // 
            this.GrypPoiskKyrs.FormattingEnabled = true;
            this.GrypPoiskKyrs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.GrypPoiskKyrs.Location = new System.Drawing.Point(8, 113);
            this.GrypPoiskKyrs.Name = "GrypPoiskKyrs";
            this.GrypPoiskKyrs.Size = new System.Drawing.Size(42, 21);
            this.GrypPoiskKyrs.TabIndex = 32;
            // 
            // LabelPoiskKyrs
            // 
            this.LabelPoiskKyrs.AutoSize = true;
            this.LabelPoiskKyrs.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskKyrs.Location = new System.Drawing.Point(4, 90);
            this.LabelPoiskKyrs.Name = "LabelPoiskKyrs";
            this.LabelPoiskKyrs.Size = new System.Drawing.Size(43, 20);
            this.LabelPoiskKyrs.TabIndex = 30;
            this.LabelPoiskKyrs.Text = "Курс\r\n";
            // 
            // GrypControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrypGrid);
            this.Controls.Add(this.PanelFnc);
            this.Name = "GrypControl";
            this.Size = new System.Drawing.Size(875, 410);
            this.PanelFnc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrypGrid)).EndInit();
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
        private System.Windows.Forms.Label LabelPoisk;
        private System.Windows.Forms.DataGridView GrypGrid;
        private System.Windows.Forms.Label LabelPoiskSpecly;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox GrypPoiskKyrs;
        private System.Windows.Forms.Label LabelPoiskKyrs;
        private System.Windows.Forms.ComboBox GrypPoiskSpecly;
        private System.Windows.Forms.Label LabelPoiskKlRyk;
        private System.Windows.Forms.TextBox GrypPoiskKlRyk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_kyrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_born;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_id;
    }
}
