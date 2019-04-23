namespace UchebnayaChast
{
    partial class YspehControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YspehControl));
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
            this.YspehGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_ball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPoiskDisp = new System.Windows.Forms.Label();
            this.LabelPoiskPrepod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPoiskStydent = new System.Windows.Forms.Label();
            this.YspehPoiskStydent = new System.Windows.Forms.TextBox();
            this.YspehPoiskPrepod = new System.Windows.Forms.TextBox();
            this.YspehPoiskDisp = new System.Windows.Forms.TextBox();
            this.PanelFnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YspehGrid)).BeginInit();
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
            // 
            // YspehGrid
            // 
            this.YspehGrid.AllowUserToAddRows = false;
            this.YspehGrid.AllowUserToDeleteRows = false;
            this.YspehGrid.AllowUserToResizeColumns = false;
            this.YspehGrid.AllowUserToResizeRows = false;
            this.YspehGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.YspehGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YspehGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.YspehGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YspehGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.St_id,
            this.P_id,
            this.D_id,
            this.Y_data,
            this.Y_ball});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YspehGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.YspehGrid.EnableHeadersVisualStyles = false;
            this.YspehGrid.Location = new System.Drawing.Point(20, 20);
            this.YspehGrid.Name = "YspehGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YspehGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.YspehGrid.RowHeadersVisible = false;
            this.YspehGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.YspehGrid.Size = new System.Drawing.Size(450, 370);
            this.YspehGrid.TabIndex = 21;
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
            // St_id
            // 
            this.St_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_id.HeaderText = "Студент";
            this.St_id.Name = "St_id";
            this.St_id.ReadOnly = true;
            this.St_id.Width = 94;
            // 
            // P_id
            // 
            this.P_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_id.HeaderText = "Преподаватель";
            this.P_id.Name = "P_id";
            this.P_id.ReadOnly = true;
            this.P_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_id.Width = 118;
            // 
            // D_id
            // 
            this.D_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_id.HeaderText = "Предмет";
            this.D_id.Name = "D_id";
            this.D_id.ReadOnly = true;
            this.D_id.Width = 94;
            // 
            // Y_data
            // 
            this.Y_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y_data.HeaderText = "Дата";
            this.Y_data.Name = "Y_data";
            this.Y_data.ReadOnly = true;
            this.Y_data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y_data.Width = 51;
            // 
            // Y_ball
            // 
            this.Y_ball.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y_ball.HeaderText = "Оценка";
            this.Y_ball.Name = "Y_ball";
            this.Y_ball.ReadOnly = true;
            this.Y_ball.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y_ball.Width = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.YspehPoiskDisp);
            this.panel1.Controls.Add(this.YspehPoiskPrepod);
            this.panel1.Controls.Add(this.YspehPoiskStydent);
            this.panel1.Controls.Add(this.LabelPoiskDisp);
            this.panel1.Controls.Add(this.LabelPoiskPrepod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelPoiskStydent);
            this.panel1.Location = new System.Drawing.Point(490, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 410);
            this.panel1.TabIndex = 28;
            // 
            // LabelPoiskDisp
            // 
            this.LabelPoiskDisp.AutoSize = true;
            this.LabelPoiskDisp.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskDisp.Location = new System.Drawing.Point(3, 87);
            this.LabelPoiskDisp.Name = "LabelPoiskDisp";
            this.LabelPoiskDisp.Size = new System.Drawing.Size(79, 20);
            this.LabelPoiskDisp.TabIndex = 35;
            this.LabelPoiskDisp.Text = "Предмет";
            // 
            // LabelPoiskPrepod
            // 
            this.LabelPoiskPrepod.AutoSize = true;
            this.LabelPoiskPrepod.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskPrepod.Location = new System.Drawing.Point(3, 60);
            this.LabelPoiskPrepod.Name = "LabelPoiskPrepod";
            this.LabelPoiskPrepod.Size = new System.Drawing.Size(66, 20);
            this.LabelPoiskPrepod.TabIndex = 30;
            this.LabelPoiskPrepod.Text = "Препод:";
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
            // LabelPoiskStydent
            // 
            this.LabelPoiskStydent.AutoSize = true;
            this.LabelPoiskStydent.Font = new System.Drawing.Font("Comfortaa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskStydent.Location = new System.Drawing.Point(3, 37);
            this.LabelPoiskStydent.Name = "LabelPoiskStydent";
            this.LabelPoiskStydent.Size = new System.Drawing.Size(68, 16);
            this.LabelPoiskStydent.TabIndex = 26;
            this.LabelPoiskStydent.Text = "Студент:";
            // 
            // YspehPoiskStydent
            // 
            this.YspehPoiskStydent.Location = new System.Drawing.Point(89, 33);
            this.YspehPoiskStydent.Name = "YspehPoiskStydent";
            this.YspehPoiskStydent.Size = new System.Drawing.Size(113, 20);
            this.YspehPoiskStydent.TabIndex = 36;
            // 
            // YspehPoiskPrepod
            // 
            this.YspehPoiskPrepod.Location = new System.Drawing.Point(89, 59);
            this.YspehPoiskPrepod.Name = "YspehPoiskPrepod";
            this.YspehPoiskPrepod.Size = new System.Drawing.Size(113, 20);
            this.YspehPoiskPrepod.TabIndex = 37;
            // 
            // YspehPoiskDisp
            // 
            this.YspehPoiskDisp.Location = new System.Drawing.Point(89, 85);
            this.YspehPoiskDisp.Name = "YspehPoiskDisp";
            this.YspehPoiskDisp.Size = new System.Drawing.Size(113, 20);
            this.YspehPoiskDisp.TabIndex = 38;
            // 
            // YspehControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YspehGrid);
            this.Controls.Add(this.PanelFnc);
            this.Name = "YspehControl";
            this.Size = new System.Drawing.Size(875, 410);
            this.PanelFnc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YspehGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView YspehGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_ball;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelPoiskDisp;
        private System.Windows.Forms.Label LabelPoiskPrepod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelPoiskStydent;
        private System.Windows.Forms.TextBox YspehPoiskDisp;
        private System.Windows.Forms.TextBox YspehPoiskPrepod;
        private System.Windows.Forms.TextBox YspehPoiskStydent;
    }
}
