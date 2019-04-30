namespace UchebnayaChast.FormAddChange
{
    partial class FormPrintSpecly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintSpecly));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelKolvo = new System.Windows.Forms.Label();
            this.LabelPoiskName = new System.Windows.Forms.Label();
            this.SpeclyGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sp_nazv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sp_stydentov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnScreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeclyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.LabelKolvo);
            this.panel1.Controls.Add(this.LabelPoiskName);
            this.panel1.Controls.Add(this.SpeclyGrid);
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
            this.LabelKolvo.Location = new System.Drawing.Point(1112, 149);
            this.LabelKolvo.Name = "LabelKolvo";
            this.LabelKolvo.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvo.TabIndex = 46;
            this.LabelKolvo.Text = "0";
            // 
            // LabelPoiskName
            // 
            this.LabelPoiskName.AutoSize = true;
            this.LabelPoiskName.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskName.Location = new System.Drawing.Point(1021, 133);
            this.LabelPoiskName.Name = "LabelPoiskName";
            this.LabelPoiskName.Size = new System.Drawing.Size(75, 36);
            this.LabelPoiskName.TabIndex = 45;
            this.LabelPoiskName.Text = "Кол-во\r\nспец-тей:";
            // 
            // SpeclyGrid
            // 
            this.SpeclyGrid.AllowUserToAddRows = false;
            this.SpeclyGrid.AllowUserToDeleteRows = false;
            this.SpeclyGrid.AllowUserToResizeColumns = false;
            this.SpeclyGrid.AllowUserToResizeRows = false;
            this.SpeclyGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(115)))));
            this.SpeclyGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpeclyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SpeclyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpeclyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sp_name,
            this.Sp_nazv,
            this.P_id,
            this.Sp_stydentov});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SpeclyGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SpeclyGrid.EnableHeadersVisualStyles = false;
            this.SpeclyGrid.Location = new System.Drawing.Point(5, 5);
            this.SpeclyGrid.Name = "SpeclyGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpeclyGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SpeclyGrid.RowHeadersVisible = false;
            this.SpeclyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpeclyGrid.Size = new System.Drawing.Size(1010, 440);
            this.SpeclyGrid.TabIndex = 25;
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
            // Sp_name
            // 
            this.Sp_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sp_name.HeaderText = "Название";
            this.Sp_name.Name = "Sp_name";
            this.Sp_name.ReadOnly = true;
            this.Sp_name.Width = 93;
            // 
            // Sp_nazv
            // 
            this.Sp_nazv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sp_nazv.HeaderText = "Шифр";
            this.Sp_nazv.Name = "Sp_nazv";
            this.Sp_nazv.ReadOnly = true;
            this.Sp_nazv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sp_nazv.Width = 52;
            // 
            // P_id
            // 
            this.P_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_id.HeaderText = "Заведующий";
            this.P_id.Name = "P_id";
            this.P_id.ReadOnly = true;
            this.P_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.P_id.Width = 116;
            // 
            // Sp_stydentov
            // 
            this.Sp_stydentov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sp_stydentov.HeaderText = "Студентов";
            this.Sp_stydentov.Name = "Sp_stydentov";
            this.Sp_stydentov.ReadOnly = true;
            this.Sp_stydentov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sp_stydentov.Width = 90;
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
            // FormPrintSpecly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrintSpecly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintSpecly";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeclyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnScreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView SpeclyGrid;
        private System.Windows.Forms.Label LabelKolvo;
        private System.Windows.Forms.Label LabelPoiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sp_nazv;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sp_stydentov;
    }
}