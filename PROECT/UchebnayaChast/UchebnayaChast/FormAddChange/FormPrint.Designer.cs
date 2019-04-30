namespace UchebnayaChast.FormAddChange
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.BtnScreen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YspehGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_zach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_ball = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelB5 = new System.Windows.Forms.Label();
            this.LabelB4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelKolvoSrBall = new System.Windows.Forms.Label();
            this.LabelB3 = new System.Windows.Forms.Label();
            this.LabelB2 = new System.Windows.Forms.Label();
            this.LabelB1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YspehGrid)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.YspehGrid);
            this.panel1.Controls.Add(this.LabelB5);
            this.panel1.Controls.Add(this.LabelB4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LabelKolvoSrBall);
            this.panel1.Controls.Add(this.LabelB3);
            this.panel1.Controls.Add(this.LabelB2);
            this.panel1.Controls.Add(this.LabelB1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnScreen);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 450);
            this.panel1.TabIndex = 25;
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
            this.Y_zach,
            this.P_id,
            this.D_id,
            this.D_sem,
            this.Y_data,
            this.Y_ball,
            this.Y_status,
            this.Y_type});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YspehGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.YspehGrid.EnableHeadersVisualStyles = false;
            this.YspehGrid.Location = new System.Drawing.Point(5, 5);
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
            this.YspehGrid.Size = new System.Drawing.Size(1010, 440);
            this.YspehGrid.TabIndex = 86;
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
            // St_id
            // 
            this.St_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.St_id.HeaderText = "Студент";
            this.St_id.Name = "St_id";
            this.St_id.ReadOnly = true;
            this.St_id.Width = 94;
            // 
            // Y_zach
            // 
            this.Y_zach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y_zach.HeaderText = "Зачётка";
            this.Y_zach.Name = "Y_zach";
            this.Y_zach.ReadOnly = true;
            this.Y_zach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y_zach.Width = 70;
            // 
            // P_id
            // 
            this.P_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_id.HeaderText = "Преподаватель";
            this.P_id.Name = "P_id";
            this.P_id.ReadOnly = true;
            this.P_id.Width = 137;
            // 
            // D_id
            // 
            this.D_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_id.HeaderText = "Предмет";
            this.D_id.Name = "D_id";
            this.D_id.ReadOnly = true;
            this.D_id.Width = 94;
            // 
            // D_sem
            // 
            this.D_sem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D_sem.HeaderText = "Семестр";
            this.D_sem.Name = "D_sem";
            this.D_sem.ReadOnly = true;
            this.D_sem.Width = 94;
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
            this.Y_ball.Width = 83;
            // 
            // Y_status
            // 
            this.Y_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y_status.HeaderText = "Статус";
            this.Y_status.Name = "Y_status";
            this.Y_status.ReadOnly = true;
            this.Y_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y_status.Visible = false;
            // 
            // Y_type
            // 
            this.Y_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y_type.HeaderText = "Тип";
            this.Y_type.Name = "Y_type";
            this.Y_type.ReadOnly = true;
            this.Y_type.Width = 58;
            // 
            // LabelB5
            // 
            this.LabelB5.AutoSize = true;
            this.LabelB5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelB5.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB5.Location = new System.Drawing.Point(1109, 264);
            this.LabelB5.Name = "LabelB5";
            this.LabelB5.Size = new System.Drawing.Size(17, 20);
            this.LabelB5.TabIndex = 84;
            this.LabelB5.Text = "0";
            // 
            // LabelB4
            // 
            this.LabelB4.AutoSize = true;
            this.LabelB4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelB4.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB4.Location = new System.Drawing.Point(1109, 229);
            this.LabelB4.Name = "LabelB4";
            this.LabelB4.Size = new System.Drawing.Size(17, 20);
            this.LabelB4.TabIndex = 83;
            this.LabelB4.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1075, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 18);
            this.label8.TabIndex = 82;
            this.label8.Text = "5:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1075, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 81;
            this.label7.Text = "4:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1032, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Ср. балл:";
            // 
            // LabelKolvoSrBall
            // 
            this.LabelKolvoSrBall.AutoSize = true;
            this.LabelKolvoSrBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolvoSrBall.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolvoSrBall.Location = new System.Drawing.Point(1100, 295);
            this.LabelKolvoSrBall.Name = "LabelKolvoSrBall";
            this.LabelKolvoSrBall.Size = new System.Drawing.Size(17, 20);
            this.LabelKolvoSrBall.TabIndex = 79;
            this.LabelKolvoSrBall.Text = "0";
            // 
            // LabelB3
            // 
            this.LabelB3.AutoSize = true;
            this.LabelB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelB3.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB3.Location = new System.Drawing.Point(1109, 197);
            this.LabelB3.Name = "LabelB3";
            this.LabelB3.Size = new System.Drawing.Size(17, 20);
            this.LabelB3.TabIndex = 78;
            this.LabelB3.Text = "0";
            // 
            // LabelB2
            // 
            this.LabelB2.AutoSize = true;
            this.LabelB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelB2.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB2.Location = new System.Drawing.Point(1109, 165);
            this.LabelB2.Name = "LabelB2";
            this.LabelB2.Size = new System.Drawing.Size(17, 20);
            this.LabelB2.TabIndex = 77;
            this.LabelB2.Text = "0";
            // 
            // LabelB1
            // 
            this.LabelB1.AutoSize = true;
            this.LabelB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelB1.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelB1.Location = new System.Drawing.Point(1109, 132);
            this.LabelB1.Name = "LabelB1";
            this.LabelB1.Size = new System.Drawing.Size(17, 20);
            this.LabelB1.TabIndex = 76;
            this.LabelB1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1075, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1075, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1075, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1021, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Оценки:";
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YspehGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnScreen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelB3;
        private System.Windows.Forms.Label LabelB2;
        private System.Windows.Forms.Label LabelB1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelB5;
        private System.Windows.Forms.Label LabelB4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelKolvoSrBall;
        private System.Windows.Forms.DataGridView YspehGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_zach;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_sem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_ball;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_type;
    }
}