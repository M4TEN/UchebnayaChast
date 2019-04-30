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
            this.BtnStydKicked = new System.Windows.Forms.Button();
            this.LabelRight = new System.Windows.Forms.Label();
            this.BtnFncChange = new System.Windows.Forms.Button();
            this.BtnFncAdd = new System.Windows.Forms.Button();
            this.BtnFncDelete = new System.Windows.Forms.Button();
            this.BtnFncDrop = new System.Windows.Forms.Button();
            this.BtnFncSearch = new System.Windows.Forms.Button();
            this.StydentPoiskFio = new System.Windows.Forms.TextBox();
            this.StydentGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StydentPoiskZach = new System.Windows.Forms.TextBox();
            this.LabelZach = new System.Windows.Forms.Label();
            this.StydentPoiskGod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelKolS = new System.Windows.Forms.Label();
            this.LabelSkolkoStydentov = new System.Windows.Forms.Label();
            this.LabelKolK = new System.Windows.Forms.Label();
            this.LabelSkolkoKon = new System.Windows.Forms.Label();
            this.LabelKolB = new System.Windows.Forms.Label();
            this.LabelSkolkoByud = new System.Windows.Forms.Label();
            this.BtnPrint2 = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LabelPoiskBK = new System.Windows.Forms.Label();
            this.StydentPoiskGryp = new System.Windows.Forms.ComboBox();
            this.StydentPoiskBK = new System.Windows.Forms.ComboBox();
            this.LabelPoiskKyrs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPoiskFio = new System.Windows.Forms.Label();
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
            this.PanelFnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StydentGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFnc
            // 
            this.PanelFnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.PanelFnc.Controls.Add(this.BtnStydKicked);
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
            // BtnStydKicked
            // 
            this.BtnStydKicked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnStydKicked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnStydKicked.FlatAppearance.BorderSize = 3;
            this.BtnStydKicked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStydKicked.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStydKicked.Location = new System.Drawing.Point(5, 342);
            this.BtnStydKicked.Name = "BtnStydKicked";
            this.BtnStydKicked.Size = new System.Drawing.Size(150, 60);
            this.BtnStydKicked.TabIndex = 43;
            this.BtnStydKicked.Text = "Отчисленные студенты:\r\n";
            this.BtnStydKicked.UseVisualStyleBackColor = false;
            this.BtnStydKicked.Click += new System.EventHandler(this.BtnStydKicked_Click);
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
            this.BtnFncDelete.Text = "   Отчислить";
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
            this.BtnFncDrop.Text = "   Обновить";
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
            this.StydentPoiskFio.MaxLength = 50;
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
            this.St_zach,
            this.St_data,
            this.St_town,
            this.St_adres,
            this.St_postyp,
            this.St_nomer,
            this.St_opl,
            this.St_status});
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
            this.StydentGrid.Size = new System.Drawing.Size(495, 400);
            this.StydentGrid.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.StydentPoiskZach);
            this.panel1.Controls.Add(this.LabelZach);
            this.panel1.Controls.Add(this.StydentPoiskGod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LabelKolS);
            this.panel1.Controls.Add(this.LabelSkolkoStydentov);
            this.panel1.Controls.Add(this.LabelKolK);
            this.panel1.Controls.Add(this.LabelSkolkoKon);
            this.panel1.Controls.Add(this.LabelKolB);
            this.panel1.Controls.Add(this.LabelSkolkoByud);
            this.panel1.Controls.Add(this.BtnPrint2);
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.LabelPoiskBK);
            this.panel1.Controls.Add(this.StydentPoiskGryp);
            this.panel1.Controls.Add(this.StydentPoiskBK);
            this.panel1.Controls.Add(this.LabelPoiskKyrs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StydentPoiskFio);
            this.panel1.Controls.Add(this.LabelPoiskFio);
            this.panel1.Location = new System.Drawing.Point(505, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 410);
            this.panel1.TabIndex = 40;
            // 
            // StydentPoiskZach
            // 
            this.StydentPoiskZach.Location = new System.Drawing.Point(89, 63);
            this.StydentPoiskZach.MaxLength = 7;
            this.StydentPoiskZach.Name = "StydentPoiskZach";
            this.StydentPoiskZach.Size = new System.Drawing.Size(78, 20);
            this.StydentPoiskZach.TabIndex = 51;
            this.StydentPoiskZach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StydentPoiskZach_KeyPress);
            // 
            // LabelZach
            // 
            this.LabelZach.AutoSize = true;
            this.LabelZach.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZach.Location = new System.Drawing.Point(1, 65);
            this.LabelZach.Name = "LabelZach";
            this.LabelZach.Size = new System.Drawing.Size(82, 18);
            this.LabelZach.TabIndex = 52;
            this.LabelZach.Text = "№ зачётки";
            // 
            // StydentPoiskGod
            // 
            this.StydentPoiskGod.FormattingEnabled = true;
            this.StydentPoiskGod.Location = new System.Drawing.Point(89, 155);
            this.StydentPoiskGod.Name = "StydentPoiskGod";
            this.StydentPoiskGod.Size = new System.Drawing.Size(113, 21);
            this.StydentPoiskGod.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Год рожд.";
            // 
            // LabelKolS
            // 
            this.LabelKolS.AutoSize = true;
            this.LabelKolS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolS.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolS.Location = new System.Drawing.Point(143, 253);
            this.LabelKolS.Name = "LabelKolS";
            this.LabelKolS.Size = new System.Drawing.Size(17, 20);
            this.LabelKolS.TabIndex = 48;
            this.LabelKolS.Text = "0";
            // 
            // LabelSkolkoStydentov
            // 
            this.LabelSkolkoStydentov.AutoSize = true;
            this.LabelSkolkoStydentov.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoStydentov.Location = new System.Drawing.Point(3, 253);
            this.LabelSkolkoStydentov.Name = "LabelSkolkoStydentov";
            this.LabelSkolkoStydentov.Size = new System.Drawing.Size(47, 18);
            this.LabelSkolkoStydentov.TabIndex = 47;
            this.LabelSkolkoStydentov.Text = "Всего:";
            // 
            // LabelKolK
            // 
            this.LabelKolK.AutoSize = true;
            this.LabelKolK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolK.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolK.Location = new System.Drawing.Point(143, 230);
            this.LabelKolK.Name = "LabelKolK";
            this.LabelKolK.Size = new System.Drawing.Size(17, 20);
            this.LabelKolK.TabIndex = 46;
            this.LabelKolK.Text = "0";
            // 
            // LabelSkolkoKon
            // 
            this.LabelSkolkoKon.AutoSize = true;
            this.LabelSkolkoKon.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoKon.Location = new System.Drawing.Point(3, 230);
            this.LabelSkolkoKon.Name = "LabelSkolkoKon";
            this.LabelSkolkoKon.Size = new System.Drawing.Size(115, 18);
            this.LabelSkolkoKon.TabIndex = 45;
            this.LabelSkolkoKon.Text = "контрактников:";
            // 
            // LabelKolB
            // 
            this.LabelKolB.AutoSize = true;
            this.LabelKolB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelKolB.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKolB.Location = new System.Drawing.Point(143, 206);
            this.LabelKolB.Name = "LabelKolB";
            this.LabelKolB.Size = new System.Drawing.Size(17, 20);
            this.LabelKolB.TabIndex = 44;
            this.LabelKolB.Text = "0";
            // 
            // LabelSkolkoByud
            // 
            this.LabelSkolkoByud.AutoSize = true;
            this.LabelSkolkoByud.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSkolkoByud.Location = new System.Drawing.Point(3, 190);
            this.LabelSkolkoByud.Name = "LabelSkolkoByud";
            this.LabelSkolkoByud.Size = new System.Drawing.Size(104, 36);
            this.LabelSkolkoByud.TabIndex = 43;
            this.LabelSkolkoByud.Text = "Количество:\r\nбюджетников:";
            // 
            // BtnPrint2
            // 
            this.BtnPrint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnPrint2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnPrint2.FlatAppearance.BorderSize = 3;
            this.BtnPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint2.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrint2.Location = new System.Drawing.Point(5, 276);
            this.BtnPrint2.Name = "BtnPrint2";
            this.BtnPrint2.Size = new System.Drawing.Size(195, 60);
            this.BtnPrint2.TabIndex = 42;
            this.BtnPrint2.Text = "Отобразить выделенные данные таблицы\r\n";
            this.BtnPrint2.UseVisualStyleBackColor = false;
            this.BtnPrint2.Click += new System.EventHandler(this.BtnPrint2_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.BtnPrint.FlatAppearance.BorderSize = 3;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrint.Location = new System.Drawing.Point(5, 342);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(195, 60);
            this.BtnPrint.TabIndex = 41;
            this.BtnPrint.Text = "Отобразить данные таблицы\r\n";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LabelPoiskBK
            // 
            this.LabelPoiskBK.AutoSize = true;
            this.LabelPoiskBK.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskBK.Location = new System.Drawing.Point(3, 116);
            this.LabelPoiskBK.Name = "LabelPoiskBK";
            this.LabelPoiskBK.Size = new System.Drawing.Size(76, 36);
            this.LabelPoiskBK.TabIndex = 37;
            this.LabelPoiskBK.Text = "Бюджет/\r\nКонтракт";
            // 
            // StydentPoiskGryp
            // 
            this.StydentPoiskGryp.FormattingEnabled = true;
            this.StydentPoiskGryp.Location = new System.Drawing.Point(89, 89);
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
            this.StydentPoiskBK.Location = new System.Drawing.Point(89, 116);
            this.StydentPoiskBK.Name = "StydentPoiskBK";
            this.StydentPoiskBK.Size = new System.Drawing.Size(113, 21);
            this.StydentPoiskBK.TabIndex = 32;
            // 
            // LabelPoiskKyrs
            // 
            this.LabelPoiskKyrs.AutoSize = true;
            this.LabelPoiskKyrs.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskKyrs.Location = new System.Drawing.Point(3, 90);
            this.LabelPoiskKyrs.Name = "LabelPoiskKyrs";
            this.LabelPoiskKyrs.Size = new System.Drawing.Size(58, 18);
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
            this.LabelPoiskFio.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPoiskFio.Location = new System.Drawing.Point(3, 39);
            this.LabelPoiskFio.Name = "LabelPoiskFio";
            this.LabelPoiskFio.Size = new System.Drawing.Size(42, 18);
            this.LabelPoiskFio.TabIndex = 26;
            this.LabelPoiskFio.Text = "ФИО:";
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
            this.St_status.HeaderText = "Статус";
            this.St_status.Name = "St_status";
            this.St_status.ReadOnly = true;
            this.St_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.St_status.Visible = false;
            this.St_status.Width = 67;
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
        private System.Windows.Forms.Button BtnPrint2;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label LabelKolK;
        private System.Windows.Forms.Label LabelSkolkoKon;
        private System.Windows.Forms.Label LabelKolB;
        private System.Windows.Forms.Label LabelSkolkoByud;
        private System.Windows.Forms.Label LabelKolS;
        private System.Windows.Forms.Label LabelSkolkoStydentov;
        private System.Windows.Forms.Button BtnStydKicked;
        private System.Windows.Forms.ComboBox StydentPoiskGod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StydentPoiskZach;
        private System.Windows.Forms.Label LabelZach;
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
    }
}
