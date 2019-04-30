namespace UchebnayaChast.FormAddChange
{
    partial class FormPrintGryp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintGryp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelKolvo = new System.Windows.Forms.Label();
            this.LabelPoiskName = new System.Windows.Forms.Label();
            this.GrypGrid = new System.Windows.Forms.DataGridView();
            this.BtnScreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_kyrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_stydentov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrypGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.LabelKolvo);
            this.panel1.Controls.Add(this.LabelPoiskName);
            this.panel1.Controls.Add(this.GrypGrid);
            this.panel1.Controls.Add(this.BtnScreen);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 450);
            this.panel1.TabIndex = 26;
            // 
            // LabelKolvo
            // 
            this.LabelKolvo.AutoSize = true;
            this.LabelKolvo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvo.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvo.Location = new System.Drawing.Point(1112, 137);
            this.LabelKolvo.Name = "LabelKolvo";
            this.LabelKolvo.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvo.TabIndex = 46;
            this.LabelKolvo.Text = "0";
            // 
            // LabelPoiskName
            // 
            this.LabelPoiskName.AutoSize = true;
            this.LabelPoiskName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskName.Location = new System.Drawing.Point(1021, 121);
            this.LabelPoiskName.Name = "LabelPoiskName";
            this.LabelPoiskName.Size = new System.Drawing.Size(52, 36);
            this.LabelPoiskName.TabIndex = 45;
            this.LabelPoiskName.Text = "Кол-во\r\nгрупп:";
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
            this.G_kyrs,
            this.G_number,
            this.G_born,
            this.P_id,
            this.G_stydentov,
            this.G_b,
            this.G_k,
            this.G_status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrypGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrypGrid.EnableHeadersVisualStyles = false;
            this.GrypGrid.Location = new System.Drawing.Point(5, 5);
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
            this.GrypGrid.Size = new System.Drawing.Size(1010, 440);
            this.GrypGrid.TabIndex = 25;
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
            // Sp_id
            // 
            this.Sp_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sp_id.HeaderText = "Шифр";
            this.Sp_id.Name = "Sp_id";
            this.Sp_id.ReadOnly = true;
            this.Sp_id.Width = 71;
            // 
            // G_kyrs
            // 
            this.G_kyrs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_kyrs.HeaderText = "Курс";
            this.G_kyrs.Name = "G_kyrs";
            this.G_kyrs.ReadOnly = true;
            this.G_kyrs.Width = 63;
            // 
            // G_number
            // 
            this.G_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_number.HeaderText = "№";
            this.G_number.Name = "G_number";
            this.G_number.ReadOnly = true;
            this.G_number.Width = 48;
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
            this.P_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.P_id.HeaderText = "Кл. рук.";
            this.P_id.Name = "P_id";
            this.P_id.ReadOnly = true;
            this.P_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.P_id.Width = 62;
            // 
            // G_stydentov
            // 
            this.G_stydentov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_stydentov.HeaderText = "Ст";
            this.G_stydentov.Name = "G_stydentov";
            this.G_stydentov.ReadOnly = true;
            this.G_stydentov.Width = 53;
            // 
            // G_b
            // 
            this.G_b.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_b.HeaderText = "Б";
            this.G_b.Name = "G_b";
            this.G_b.ReadOnly = true;
            this.G_b.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G_b.Width = 21;
            // 
            // G_k
            // 
            this.G_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_k.HeaderText = "К";
            this.G_k.Name = "G_k";
            this.G_k.ReadOnly = true;
            this.G_k.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G_k.Width = 22;
            // 
            // G_status
            // 
            this.G_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.G_status.HeaderText = "Статус";
            this.G_status.Name = "G_status";
            this.G_status.ReadOnly = true;
            this.G_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.G_status.Visible = false;
            this.G_status.Width = 67;
            // 
            // FormPrintGryp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrintGryp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintGryp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrypGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnScreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView GrypGrid;
        private System.Windows.Forms.Label LabelKolvo;
        private System.Windows.Forms.Label LabelPoiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_kyrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_born;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_stydentov;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_status;
    }
}