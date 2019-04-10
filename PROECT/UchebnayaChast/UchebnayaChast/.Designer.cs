namespace UchebnayaChast
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.LabelLeftOkna = new System.Windows.Forms.Label();
            this.BtnMainSpecly = new System.Windows.Forms.Button();
            this.BtnMainKafedra = new System.Windows.Forms.Button();
            this.BtnMainPrepod = new System.Windows.Forms.Button();
            this.BtnMainGryp = new System.Windows.Forms.Button();
            this.BtnMainYspeh = new System.Windows.Forms.Button();
            this.BtnMainDisp = new System.Windows.Forms.Button();
            this.BtnMainStydent = new System.Windows.Forms.Button();
            this.BtnMainHome = new System.Windows.Forms.Button();
            this.PanelControlPrepod = new UchebnayaChast.PrepodControl();
            this.PanelControlGryp = new UchebnayaChast.GrypControl();
            this.PanelControlYspeh = new UchebnayaChast.YspehControl();
            this.PanelControlDisp = new UchebnayaChast.DispControl();
            this.PanelControlMainMenu = new UchebnayaChast.MainMenuControl();
            this.PanelControlKafedra = new UchebnayaChast.KafedraControl();
            this.PanelControlSpecly = new UchebnayaChast.SpeclyControl();
            this.PanelControlStydent = new UchebnayaChast.StydentControl();
            this.PanelTop.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.BtnExit);
            this.PanelTop.Controls.Add(this.LabelName);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1080, 40);
            this.PanelTop.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1038, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(36, 36);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LabelName
            // 
            this.LabelName.Font = new System.Drawing.Font("Comfortaa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(12, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(369, 40);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Учебная часть. Студенты";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(152)))), ((int)(((byte)(150)))));
            this.PanelLeft.Controls.Add(this.PanelScroll);
            this.PanelLeft.Controls.Add(this.LabelLeftOkna);
            this.PanelLeft.Controls.Add(this.BtnMainSpecly);
            this.PanelLeft.Controls.Add(this.BtnMainKafedra);
            this.PanelLeft.Controls.Add(this.BtnMainPrepod);
            this.PanelLeft.Controls.Add(this.BtnMainGryp);
            this.PanelLeft.Controls.Add(this.BtnMainYspeh);
            this.PanelLeft.Controls.Add(this.BtnMainDisp);
            this.PanelLeft.Controls.Add(this.BtnMainStydent);
            this.PanelLeft.Controls.Add(this.BtnMainHome);
            this.PanelLeft.Location = new System.Drawing.Point(0, 45);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(200, 410);
            this.PanelLeft.TabIndex = 1;
            // 
            // PanelScroll
            // 
            this.PanelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.PanelScroll.Location = new System.Drawing.Point(0, 35);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(12, 40);
            this.PanelScroll.TabIndex = 8;
            // 
            // LabelLeftOkna
            // 
            this.LabelLeftOkna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(142)))), ((int)(((byte)(140)))));
            this.LabelLeftOkna.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLeftOkna.Location = new System.Drawing.Point(0, 5);
            this.LabelLeftOkna.Name = "LabelLeftOkna";
            this.LabelLeftOkna.Size = new System.Drawing.Size(200, 25);
            this.LabelLeftOkna.TabIndex = 0;
            this.LabelLeftOkna.Text = "Окна";
            this.LabelLeftOkna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMainSpecly
            // 
            this.BtnMainSpecly.FlatAppearance.BorderSize = 0;
            this.BtnMainSpecly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainSpecly.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainSpecly.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainSpecly.Image")));
            this.BtnMainSpecly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainSpecly.Location = new System.Drawing.Point(12, 350);
            this.BtnMainSpecly.Name = "BtnMainSpecly";
            this.BtnMainSpecly.Size = new System.Drawing.Size(188, 40);
            this.BtnMainSpecly.TabIndex = 7;
            this.BtnMainSpecly.Text = "   Специальности";
            this.BtnMainSpecly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainSpecly.UseVisualStyleBackColor = false;
            this.BtnMainSpecly.Click += new System.EventHandler(this.BtnMainSpecly_Click);
            // 
            // BtnMainKafedra
            // 
            this.BtnMainKafedra.FlatAppearance.BorderSize = 0;
            this.BtnMainKafedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainKafedra.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainKafedra.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainKafedra.Image")));
            this.BtnMainKafedra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainKafedra.Location = new System.Drawing.Point(12, 305);
            this.BtnMainKafedra.Name = "BtnMainKafedra";
            this.BtnMainKafedra.Size = new System.Drawing.Size(188, 40);
            this.BtnMainKafedra.TabIndex = 6;
            this.BtnMainKafedra.Text = "   Кафедры";
            this.BtnMainKafedra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainKafedra.UseVisualStyleBackColor = false;
            this.BtnMainKafedra.Click += new System.EventHandler(this.BtnMainKafedra_Click);
            // 
            // BtnMainPrepod
            // 
            this.BtnMainPrepod.FlatAppearance.BorderSize = 0;
            this.BtnMainPrepod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainPrepod.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainPrepod.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainPrepod.Image")));
            this.BtnMainPrepod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainPrepod.Location = new System.Drawing.Point(12, 260);
            this.BtnMainPrepod.Name = "BtnMainPrepod";
            this.BtnMainPrepod.Size = new System.Drawing.Size(188, 40);
            this.BtnMainPrepod.TabIndex = 5;
            this.BtnMainPrepod.Text = "   Преподаватели";
            this.BtnMainPrepod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainPrepod.UseVisualStyleBackColor = false;
            this.BtnMainPrepod.Click += new System.EventHandler(this.BtnMainPrepod_Click);
            // 
            // BtnMainGryp
            // 
            this.BtnMainGryp.FlatAppearance.BorderSize = 0;
            this.BtnMainGryp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainGryp.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainGryp.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainGryp.Image")));
            this.BtnMainGryp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainGryp.Location = new System.Drawing.Point(12, 215);
            this.BtnMainGryp.Name = "BtnMainGryp";
            this.BtnMainGryp.Size = new System.Drawing.Size(188, 40);
            this.BtnMainGryp.TabIndex = 4;
            this.BtnMainGryp.Text = "   Группы";
            this.BtnMainGryp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainGryp.UseVisualStyleBackColor = false;
            this.BtnMainGryp.Click += new System.EventHandler(this.BtnMainGryp_Click);
            // 
            // BtnMainYspeh
            // 
            this.BtnMainYspeh.FlatAppearance.BorderSize = 0;
            this.BtnMainYspeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainYspeh.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainYspeh.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainYspeh.Image")));
            this.BtnMainYspeh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainYspeh.Location = new System.Drawing.Point(12, 170);
            this.BtnMainYspeh.Name = "BtnMainYspeh";
            this.BtnMainYspeh.Size = new System.Drawing.Size(188, 40);
            this.BtnMainYspeh.TabIndex = 3;
            this.BtnMainYspeh.Text = "   Успеваемость";
            this.BtnMainYspeh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainYspeh.UseVisualStyleBackColor = false;
            this.BtnMainYspeh.Click += new System.EventHandler(this.BtnMainYspeh_Click);
            // 
            // BtnMainDisp
            // 
            this.BtnMainDisp.FlatAppearance.BorderSize = 0;
            this.BtnMainDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainDisp.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainDisp.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainDisp.Image")));
            this.BtnMainDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainDisp.Location = new System.Drawing.Point(12, 125);
            this.BtnMainDisp.Name = "BtnMainDisp";
            this.BtnMainDisp.Size = new System.Drawing.Size(188, 40);
            this.BtnMainDisp.TabIndex = 2;
            this.BtnMainDisp.Text = "   Дисциплины";
            this.BtnMainDisp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainDisp.UseVisualStyleBackColor = false;
            this.BtnMainDisp.Click += new System.EventHandler(this.BtnMainDisp_Click);
            // 
            // BtnMainStydent
            // 
            this.BtnMainStydent.FlatAppearance.BorderSize = 0;
            this.BtnMainStydent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainStydent.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainStydent.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainStydent.Image")));
            this.BtnMainStydent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainStydent.Location = new System.Drawing.Point(12, 80);
            this.BtnMainStydent.Name = "BtnMainStydent";
            this.BtnMainStydent.Size = new System.Drawing.Size(188, 40);
            this.BtnMainStydent.TabIndex = 1;
            this.BtnMainStydent.Text = "   Студенты";
            this.BtnMainStydent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainStydent.UseVisualStyleBackColor = false;
            this.BtnMainStydent.Click += new System.EventHandler(this.BtnMainStydent_Click);
            // 
            // BtnMainHome
            // 
            this.BtnMainHome.FlatAppearance.BorderSize = 0;
            this.BtnMainHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainHome.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMainHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainHome.Image")));
            this.BtnMainHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainHome.Location = new System.Drawing.Point(12, 35);
            this.BtnMainHome.Name = "BtnMainHome";
            this.BtnMainHome.Size = new System.Drawing.Size(188, 40);
            this.BtnMainHome.TabIndex = 0;
            this.BtnMainHome.Text = "   Главная";
            this.BtnMainHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainHome.UseVisualStyleBackColor = false;
            this.BtnMainHome.Click += new System.EventHandler(this.BtnMainHome_Click);
            // 
            // PanelControlPrepod
            // 
            this.PanelControlPrepod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlPrepod.Location = new System.Drawing.Point(205, 45);
            this.PanelControlPrepod.Name = "PanelControlPrepod";
            this.PanelControlPrepod.Size = new System.Drawing.Size(875, 410);
            this.PanelControlPrepod.TabIndex = 15;
            // 
            // PanelControlGryp
            // 
            this.PanelControlGryp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlGryp.Location = new System.Drawing.Point(205, 45);
            this.PanelControlGryp.Name = "PanelControlGryp";
            this.PanelControlGryp.Size = new System.Drawing.Size(875, 410);
            this.PanelControlGryp.TabIndex = 14;
            // 
            // PanelControlYspeh
            // 
            this.PanelControlYspeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlYspeh.Location = new System.Drawing.Point(205, 45);
            this.PanelControlYspeh.Name = "PanelControlYspeh";
            this.PanelControlYspeh.Size = new System.Drawing.Size(875, 410);
            this.PanelControlYspeh.TabIndex = 13;
            // 
            // PanelControlDisp
            // 
            this.PanelControlDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlDisp.Location = new System.Drawing.Point(205, 45);
            this.PanelControlDisp.Name = "PanelControlDisp";
            this.PanelControlDisp.Size = new System.Drawing.Size(875, 410);
            this.PanelControlDisp.TabIndex = 12;
            // 
            // PanelControlMainMenu
            // 
            this.PanelControlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlMainMenu.Location = new System.Drawing.Point(205, 45);
            this.PanelControlMainMenu.Name = "PanelControlMainMenu";
            this.PanelControlMainMenu.Size = new System.Drawing.Size(875, 410);
            this.PanelControlMainMenu.TabIndex = 11;
            // 
            // PanelControlKafedra
            // 
            this.PanelControlKafedra.Location = new System.Drawing.Point(205, 45);
            this.PanelControlKafedra.Name = "PanelControlKafedra";
            this.PanelControlKafedra.Size = new System.Drawing.Size(875, 410);
            this.PanelControlKafedra.TabIndex = 10;
            // 
            // PanelControlSpecly
            // 
            this.PanelControlSpecly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlSpecly.Location = new System.Drawing.Point(205, 45);
            this.PanelControlSpecly.Name = "PanelControlSpecly";
            this.PanelControlSpecly.Size = new System.Drawing.Size(875, 410);
            this.PanelControlSpecly.TabIndex = 16;
            // 
            // PanelControlStydent
            // 
            this.PanelControlStydent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelControlStydent.Location = new System.Drawing.Point(205, 45);
            this.PanelControlStydent.Name = "PanelControlStydent";
            this.PanelControlStydent.Size = new System.Drawing.Size(875, 410);
            this.PanelControlStydent.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1080, 460);
            this.Controls.Add(this.PanelControlStydent);
            this.Controls.Add(this.PanelControlSpecly);
            this.Controls.Add(this.PanelControlPrepod);
            this.Controls.Add(this.PanelControlGryp);
            this.Controls.Add(this.PanelControlYspeh);
            this.Controls.Add(this.PanelControlDisp);
            this.Controls.Add(this.PanelControlMainMenu);
            this.Controls.Add(this.PanelControlKafedra);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTop.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button BtnMainHome;
        private System.Windows.Forms.Button BtnMainStydent;
        private System.Windows.Forms.Button BtnMainSpecly;
        private System.Windows.Forms.Button BtnMainKafedra;
        private System.Windows.Forms.Button BtnMainPrepod;
        private System.Windows.Forms.Button BtnMainGryp;
        private System.Windows.Forms.Button BtnMainYspeh;
        private System.Windows.Forms.Button BtnMainDisp;
        private System.Windows.Forms.Label LabelLeftOkna;
        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button BtnExit;
        private KafedraControl PanelControlKafedra;
        private MainMenuControl PanelControlMainMenu;
        private DispControl PanelControlDisp;
        private YspehControl PanelControlYspeh;
        private GrypControl PanelControlGryp;
        private PrepodControl PanelControlPrepod;
        private SpeclyControl PanelControlSpecly;
        private StydentControl PanelControlStydent;
    }
}

