namespace UchebnayaChast
{
    partial class KafedraControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KafedraControl));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelPoisk = new System.Windows.Forms.Label();
            this.KafedraPoisk = new System.Windows.Forms.TextBox();
            this.KafedraGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelFnc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KafedraGrid)).BeginInit();
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
            this.PanelFnc.TabIndex = 9;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.LabelPoisk);
            this.panel2.Controls.Add(this.KafedraPoisk);
            this.panel2.Controls.Add(this.KafedraGrid);
            this.panel2.Controls.Add(this.PanelFnc);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 410);
            this.panel2.TabIndex = 10;
            // 
            // LabelPoisk
            // 
            this.LabelPoisk.AutoSize = true;
            this.LabelPoisk.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoisk.Location = new System.Drawing.Point(16, 10);
            this.LabelPoisk.Name = "LabelPoisk";
            this.LabelPoisk.Size = new System.Drawing.Size(55, 20);
            this.LabelPoisk.TabIndex = 15;
            this.LabelPoisk.Text = "Поиск:";
            // 
            // KafedraPoisk
            // 
            this.KafedraPoisk.Location = new System.Drawing.Point(90, 10);
            this.KafedraPoisk.Name = "KafedraPoisk";
            this.KafedraPoisk.Size = new System.Drawing.Size(380, 20);
            this.KafedraPoisk.TabIndex = 14;
            // 
            // KafedraGrid
            // 
            this.KafedraGrid.AllowUserToAddRows = false;
            this.KafedraGrid.AllowUserToDeleteRows = false;
            this.KafedraGrid.AllowUserToResizeColumns = false;
            this.KafedraGrid.AllowUserToResizeRows = false;
            this.KafedraGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.KafedraGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KafedraGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.KafedraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KafedraGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.K_name,
            this.K_nomer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KafedraGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.KafedraGrid.EnableHeadersVisualStyles = false;
            this.KafedraGrid.Location = new System.Drawing.Point(20, 37);
            this.KafedraGrid.Name = "KafedraGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KafedraGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.KafedraGrid.RowHeadersVisible = false;
            this.KafedraGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KafedraGrid.Size = new System.Drawing.Size(450, 344);
            this.KafedraGrid.TabIndex = 9;
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
            // K_name
            // 
            this.K_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.K_name.HeaderText = "Название";
            this.K_name.Name = "K_name";
            this.K_name.ReadOnly = true;
            this.K_name.Width = 93;
            // 
            // K_nomer
            // 
            this.K_nomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.K_nomer.HeaderText = "Номер";
            this.K_nomer.Name = "K_nomer";
            this.K_nomer.ReadOnly = true;
            this.K_nomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.K_nomer.Width = 56;
            // 
            // KafedraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "KafedraControl";
            this.Size = new System.Drawing.Size(875, 410);
            this.PanelFnc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KafedraGrid)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView KafedraGrid;
        private System.Windows.Forms.Label LabelPoisk;
        private System.Windows.Forms.TextBox KafedraPoisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_nomer;
    }
}
