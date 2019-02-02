namespace Car
{
    partial class FrmMain
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGenge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypLic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmGenge,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmNew,
            this.tsmSave,
            this.tsmSaveAs,
            this.tsmClose,
            this.toolStripMenuItem1,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(48, 20);
            this.tsmFile.Text = "Файл";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(153, 22);
            this.tsmOpen.Text = "Открыть";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmNew
            // 
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(153, 22);
            this.tsmNew.Text = "Новый";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(153, 22);
            this.tsmSave.Text = "Сохранить";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(153, 22);
            this.tsmSaveAs.Text = "Сохранить как";
            this.tsmSaveAs.Click += new System.EventHandler(this.tsmSaveAs_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(153, 22);
            this.tsmClose.Text = "Закрыть";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(153, 22);
            this.tsmExit.Text = "Выход";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmGenge
            // 
            this.tsmGenge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmEdit,
            this.tsmDel});
            this.tsmGenge.Name = "tsmGenge";
            this.tsmGenge.Size = new System.Drawing.Size(59, 20);
            this.tsmGenge.Text = "Правка";
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(128, 22);
            this.tsmAdd.Text = "Добавить";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(128, 22);
            this.tsmEdit.Text = "Изменить";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDel
            // 
            this.tsmDel.Name = "tsmDel";
            this.tsmDel.Size = new System.Drawing.Size(128, 22);
            this.tsmDel.Text = "Удалить";
            this.tsmDel.Click += new System.EventHandler(this.tsmDel_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // dgMain
            // 
            this.dgMain.AllowUserToAddRows = false;
            this.dgMain.AllowUserToDeleteRows = false;
            this.dgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.TypLic,
            this.ModCar,
            this.TypCar,
            this.Number,
            this.DateLic});
            this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMain.Location = new System.Drawing.Point(0, 24);
            this.dgMain.MultiSelect = false;
            this.dgMain.Name = "dgMain";
            this.dgMain.RowHeadersVisible = false;
            this.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMain.Size = new System.Drawing.Size(643, 326);
            this.dgMain.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(493, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(138, 21);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.DataPropertyName = "FullName";
            this.FIO.HeaderText = "ФИО";
            this.FIO.MinimumWidth = 100;
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // TypLic
            // 
            this.TypLic.DataPropertyName = "TypeLicense";
            this.TypLic.HeaderText = "Права";
            this.TypLic.Name = "TypLic";
            this.TypLic.ReadOnly = true;
            this.TypLic.Width = 64;
            // 
            // ModCar
            // 
            this.ModCar.DataPropertyName = "ModelCar";
            this.ModCar.HeaderText = "Модель";
            this.ModCar.Name = "ModCar";
            this.ModCar.ReadOnly = true;
            this.ModCar.Width = 71;
            // 
            // TypCar
            // 
            this.TypCar.DataPropertyName = "TypeCar";
            this.TypCar.HeaderText = "Тип машины";
            this.TypCar.Name = "TypCar";
            this.TypCar.ReadOnly = true;
            this.TypCar.Width = 96;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "CarNumber";
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 66;
            // 
            // DateLic
            // 
            this.DateLic.DataPropertyName = "CarDate";
            this.DateLic.HeaderText = "Дата прав";
            this.DateLic.Name = "DateLic";
            this.DateLic.ReadOnly = true;
            this.DateLic.Width = 85;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 350);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FrmMain";
            this.Text = "Владельцы авто";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmGenge;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypLic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLic;
    }
}

