namespace склад
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripTextBox();
            this.ButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullNameColumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGE2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduckt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDSColomun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fulpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scladDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scladDBDataSet = new склад.ScladDBDataSet();
            this.scladDBTableAdapter = new склад.ScladDBDataSetTableAdapters.ScladDBTableAdapter();
            this.SchComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Enabled = false;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.изменитьToolStripMenuItem.Text = "Изменить ";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Enabled = false;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::склад.Properties.Resources.up;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forprogramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // forprogramToolStripMenuItem
            // 
            this.forprogramToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forprogramToolStripMenuItem.Name = "forprogramToolStripMenuItem";
            this.forprogramToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.forprogramToolStripMenuItem.Text = "О программе ";
            this.forprogramToolStripMenuItem.Click += new System.EventHandler(this.forprogramToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1169, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(220, 25);
            this.toolStripStatusLabel1.Text = "Колличество товаров на складе: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(220, 25);
            this.toolStripStatusLabel2.Text = "Общая цена товаров(безНДС)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(241, 25);
            this.toolStripStatusLabel3.Text = "Общая цена товаров(сНДС)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.SchComboBox,
            this.Search,
            this.ButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1169, 38);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 33);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(104, 29);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(119, 29);
            this.toolStripButton3.Text = "Изменить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 34);
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSearch.Image = global::склад.Properties.Resources.icons8_поиск_48;
            this.ButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(34, 29);
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColumm,
            this.AGE2Column,
            this.GenderColum,
            this.AgeColumn,
            this.AVGColumn,
            this.Deduckt,
            this.DepterColumn,
            this.NDSColomun,
            this.noNDS,
            this.Columnid});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 463);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FullNameColumm
            // 
            this.FullNameColumm.DataPropertyName = "name";
            this.FullNameColumm.HeaderText = "Наз. товара";
            this.FullNameColumm.MinimumWidth = 8;
            this.FullNameColumm.Name = "FullNameColumm";
            this.FullNameColumm.ReadOnly = true;
            this.FullNameColumm.Width = 125;
            // 
            // AGE2Column
            // 
            this.AGE2Column.DataPropertyName = "raz";
            dataGridViewCellStyle4.Format = "#,#,#";
            dataGridViewCellStyle4.NullValue = null;
            this.AGE2Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.AGE2Column.HeaderText = "Размер";
            this.AGE2Column.MinimumWidth = 8;
            this.AGE2Column.Name = "AGE2Column";
            this.AGE2Column.ReadOnly = true;
            this.AGE2Column.Width = 80;
            // 
            // GenderColum
            // 
            this.GenderColum.DataPropertyName = "mater";
            this.GenderColum.HeaderText = "Материал";
            this.GenderColum.MinimumWidth = 80;
            this.GenderColum.Name = "GenderColum";
            this.GenderColum.ReadOnly = true;
            this.GenderColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GenderColum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GenderColum.Width = 80;
            // 
            // AgeColumn
            // 
            this.AgeColumn.DataPropertyName = "kol";
            this.AgeColumn.HeaderText = "Кол. на складе";
            this.AgeColumn.MinimumWidth = 8;
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            this.AgeColumn.Width = 120;
            // 
            // AVGColumn
            // 
            this.AVGColumn.DataPropertyName = "min";
            this.AVGColumn.HeaderText = "Мин. передел кол.";
            this.AVGColumn.MinimumWidth = 8;
            this.AVGColumn.Name = "AVGColumn";
            this.AVGColumn.ReadOnly = true;
            this.AVGColumn.Width = 140;
            // 
            // Deduckt
            // 
            this.Deduckt.DataPropertyName = "price";
            this.Deduckt.HeaderText = "Цена(без НДС)";
            this.Deduckt.MinimumWidth = 8;
            this.Deduckt.Name = "Deduckt";
            this.Deduckt.ReadOnly = true;
            this.Deduckt.Width = 130;
            // 
            // DepterColumn
            // 
            this.DepterColumn.DataPropertyName = "price1";
            this.DepterColumn.HeaderText = "Цена (с НДС)";
            this.DepterColumn.MinimumWidth = 8;
            this.DepterColumn.Name = "DepterColumn";
            this.DepterColumn.ReadOnly = true;
            this.DepterColumn.Width = 130;
            // 
            // NDSColomun
            // 
            this.NDSColomun.DataPropertyName = "fulprice";
            this.NDSColomun.HeaderText = "Общая цена (с НДС)";
            this.NDSColomun.MinimumWidth = 8;
            this.NDSColomun.Name = "NDSColomun";
            this.NDSColomun.ReadOnly = true;
            this.NDSColomun.Width = 150;
            // 
            // noNDS
            // 
            this.noNDS.DataPropertyName = "fulprice1";
            this.noNDS.HeaderText = "Общая цена (без НДС)";
            this.noNDS.MinimumWidth = 8;
            this.noNDS.Name = "noNDS";
            this.noNDS.ReadOnly = true;
            this.noNDS.Width = 150;
            // 
            // Columnid
            // 
            this.Columnid.DataPropertyName = "Id";
            this.Columnid.HeaderText = "ID";
            this.Columnid.MinimumWidth = 8;
            this.Columnid.Name = "Columnid";
            this.Columnid.ReadOnly = true;
            this.Columnid.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.razDataGridViewTextBoxColumn,
            this.materDataGridViewTextBoxColumn,
            this.kolDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.fulpriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.scladDBBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1169, 150);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // razDataGridViewTextBoxColumn
            // 
            this.razDataGridViewTextBoxColumn.DataPropertyName = "raz";
            this.razDataGridViewTextBoxColumn.HeaderText = "raz";
            this.razDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.razDataGridViewTextBoxColumn.Name = "razDataGridViewTextBoxColumn";
            this.razDataGridViewTextBoxColumn.ReadOnly = true;
            this.razDataGridViewTextBoxColumn.Width = 150;
            // 
            // materDataGridViewTextBoxColumn
            // 
            this.materDataGridViewTextBoxColumn.DataPropertyName = "mater";
            this.materDataGridViewTextBoxColumn.HeaderText = "mater";
            this.materDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.materDataGridViewTextBoxColumn.Name = "materDataGridViewTextBoxColumn";
            this.materDataGridViewTextBoxColumn.ReadOnly = true;
            this.materDataGridViewTextBoxColumn.Width = 150;
            // 
            // kolDataGridViewTextBoxColumn
            // 
            this.kolDataGridViewTextBoxColumn.DataPropertyName = "kol";
            this.kolDataGridViewTextBoxColumn.HeaderText = "kol";
            this.kolDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kolDataGridViewTextBoxColumn.Name = "kolDataGridViewTextBoxColumn";
            this.kolDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolDataGridViewTextBoxColumn.Width = 150;
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn.HeaderText = "min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            this.minDataGridViewTextBoxColumn.ReadOnly = true;
            this.minDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // fulpriceDataGridViewTextBoxColumn
            // 
            this.fulpriceDataGridViewTextBoxColumn.DataPropertyName = "fulprice";
            this.fulpriceDataGridViewTextBoxColumn.HeaderText = "fulprice";
            this.fulpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fulpriceDataGridViewTextBoxColumn.Name = "fulpriceDataGridViewTextBoxColumn";
            this.fulpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.fulpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // scladDBBindingSource
            // 
            this.scladDBBindingSource.DataMember = "ScladDB";
            this.scladDBBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.scladDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // scladDBDataSet
            // 
            this.scladDBDataSet.DataSetName = "ScladDBDataSet";
            this.scladDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scladDBTableAdapter
            // 
            this.scladDBTableAdapter.ClearBeforeFill = true;
            // 
            // SchComboBox
            // 
            this.SchComboBox.Items.AddRange(new object[] {
            "name",
            "mater",
            "Id",
            "raz"});
            this.SchComboBox.Name = "SchComboBox";
            this.SchComboBox.Size = new System.Drawing.Size(121, 38);
            this.SchComboBox.Text = "name";
            this.SchComboBox.Click += new System.EventHandler(this.SchComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 569);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад гвоздей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forprogramToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduckt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDSColomun;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripTextBox Search;
        private System.Windows.Forms.ToolStripButton ButtonSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ScladDBDataSet scladDBDataSet;
        private System.Windows.Forms.BindingSource scladDBBindingSource;
        private ScladDBDataSetTableAdapters.ScladDBTableAdapter scladDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fulpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SchComboBox;
    }
}

