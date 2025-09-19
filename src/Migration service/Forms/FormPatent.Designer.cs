
namespace Migration_service
{
    partial class FormPatent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatent));
            this.миграционная_службаDataSet = new Migration_service.Migration_serviceDataSet();
            this.патентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.патентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbPatentSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPatentSear = new System.Windows.Forms.ToolStripButton();
            this.btnPatentRes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPatentAdd = new System.Windows.Forms.ToolStripButton();
            this.btnPatentEdit = new System.Windows.Forms.ToolStripButton();
            this.btnPatentDel = new System.Windows.Forms.ToolStripButton();
            this.патентTableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.ПатентTableAdapter();
            this.патентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAddEdit = new System.Windows.Forms.Panel();
            this.lblPanel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.cmbID_Mig = new System.Windows.Forms.ComboBox();
            this.мигрант1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSeria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOkAddEditPat = new System.Windows.Forms.Button();
            this.buttonCloseAddEditPat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateVyd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.профессияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мигрант1TableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.Мигрант1TableAdapter();
            this.профессияTableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.ПрофессияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.патентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.патентBindingNavigator)).BeginInit();
            this.патентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.патентDataGridView)).BeginInit();
            this.panelAddEdit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мигрант1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // миграционная_службаDataSet
            // 
            this.миграционная_службаDataSet.DataSetName = "Migration_serviceDataSet";
            this.миграционная_службаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // патентBindingSource
            // 
            this.патентBindingSource.DataMember = "Патент";
            this.патентBindingSource.DataSource = this.миграционная_службаDataSet;
            // 
            // патентBindingNavigator
            // 
            this.патентBindingNavigator.AddNewItem = null;
            this.патентBindingNavigator.BindingSource = this.патентBindingSource;
            this.патентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.патентBindingNavigator.DeleteItem = null;
            this.патентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tbPatentSearch,
            this.toolStripSeparator1,
            this.btnPatentSear,
            this.btnPatentRes,
            this.toolStripSeparator2,
            this.btnPatentAdd,
            this.btnPatentEdit,
            this.btnPatentDel});
            this.патентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.патентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.патентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.патентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.патентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.патентBindingNavigator.Name = "патентBindingNavigator";
            this.патентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.патентBindingNavigator.Size = new System.Drawing.Size(953, 25);
            this.патентBindingNavigator.TabIndex = 0;
            this.патентBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbPatentSearch
            // 
            this.tbPatentSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPatentSearch.Name = "tbPatentSearch";
            this.tbPatentSearch.Size = new System.Drawing.Size(132, 25);
            this.tbPatentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_control);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPatentSear
            // 
            this.btnPatentSear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPatentSear.Image = ((System.Drawing.Image)(resources.GetObject("btnPatentSear.Image")));
            this.btnPatentSear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatentSear.Name = "btnPatentSear";
            this.btnPatentSear.Size = new System.Drawing.Size(23, 22);
            this.btnPatentSear.Text = "Поиск";
            this.btnPatentSear.Click += new System.EventHandler(this.btnPatentSear_Click);
            // 
            // btnPatentRes
            // 
            this.btnPatentRes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPatentRes.Image = ((System.Drawing.Image)(resources.GetObject("btnPatentRes.Image")));
            this.btnPatentRes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatentRes.Name = "btnPatentRes";
            this.btnPatentRes.Size = new System.Drawing.Size(23, 22);
            this.btnPatentRes.Text = "Сброс";
            this.btnPatentRes.Click += new System.EventHandler(this.btnPatentRes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPatentAdd
            // 
            this.btnPatentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPatentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnPatentAdd.Image")));
            this.btnPatentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatentAdd.Name = "btnPatentAdd";
            this.btnPatentAdd.Size = new System.Drawing.Size(23, 22);
            this.btnPatentAdd.Text = "Добавить";
            this.btnPatentAdd.Click += new System.EventHandler(this.btnPatentAdd_Click);
            // 
            // btnPatentEdit
            // 
            this.btnPatentEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPatentEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnPatentEdit.Image")));
            this.btnPatentEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatentEdit.Name = "btnPatentEdit";
            this.btnPatentEdit.Size = new System.Drawing.Size(23, 22);
            this.btnPatentEdit.Text = "Редактировать";
            this.btnPatentEdit.Click += new System.EventHandler(this.btnPatentEdit_Click);
            // 
            // btnPatentDel
            // 
            this.btnPatentDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPatentDel.Image = ((System.Drawing.Image)(resources.GetObject("btnPatentDel.Image")));
            this.btnPatentDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatentDel.Name = "btnPatentDel";
            this.btnPatentDel.Size = new System.Drawing.Size(23, 22);
            this.btnPatentDel.Text = "Удалить";
            this.btnPatentDel.Click += new System.EventHandler(this.btnPatentDel_Click);
            // 
            // патентTableAdapter
            // 
            this.патентTableAdapter.ClearBeforeFill = true;
            // 
            // патентDataGridView
            // 
            this.патентDataGridView.AutoGenerateColumns = false;
            this.патентDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.патентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.патентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.патентDataGridView.DataSource = this.патентBindingSource;
            this.патентDataGridView.Location = new System.Drawing.Point(4, 28);
            this.патентDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.патентDataGridView.Name = "патентDataGridView";
            this.патентDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.патентDataGridView.Size = new System.Drawing.Size(632, 271);
            this.патентDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_пат";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_пат";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_миг";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_миг";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Серия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Серия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Проф";
            this.dataGridViewTextBoxColumn5.HeaderText = "Проф";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата_выд";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата_выд";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddEdit.Controls.Add(this.lblPanel);
            this.panelAddEdit.Location = new System.Drawing.Point(643, 28);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(308, 22);
            this.panelAddEdit.TabIndex = 5;
            this.panelAddEdit.Visible = false;
            this.panelAddEdit.VisibleChanged += new System.EventHandler(this.panelAddEdit_VisibleChanged);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Location = new System.Drawing.Point(3, 3);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(66, 17);
            this.lblPanel.TabIndex = 0;
            this.lblPanel.Text = "lblPanel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.tbNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbID_Mig, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSeria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonOkAddEditPat, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonCloseAddEditPat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateVyd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbProf, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(643, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 168);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Visible = false;
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNumber.Location = new System.Drawing.Point(87, 59);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(218, 23);
            this.tbNumber.TabIndex = 28;
            // 
            // cmbID_Mig
            // 
            this.cmbID_Mig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbID_Mig.DataSource = this.мигрант1BindingSource;
            this.cmbID_Mig.DisplayMember = "ФИО";
            this.cmbID_Mig.FormattingEnabled = true;
            this.cmbID_Mig.Location = new System.Drawing.Point(87, 3);
            this.cmbID_Mig.Name = "cmbID_Mig";
            this.cmbID_Mig.Size = new System.Drawing.Size(218, 24);
            this.cmbID_Mig.TabIndex = 1;
            this.cmbID_Mig.ValueMember = "ID_миг";
            // 
            // мигрант1BindingSource
            // 
            this.мигрант1BindingSource.DataMember = "Мигрант1";
            this.мигрант1BindingSource.DataSource = this.миграционная_службаDataSet;
            this.мигрант1BindingSource.Sort = "ФИО";
            // 
            // tbSeria
            // 
            this.tbSeria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSeria.Location = new System.Drawing.Point(87, 31);
            this.tbSeria.Name = "tbSeria";
            this.tbSeria.Size = new System.Drawing.Size(218, 23);
            this.tbSeria.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_миг";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Проф";
            // 
            // buttonOkAddEditPat
            // 
            this.buttonOkAddEditPat.Location = new System.Drawing.Point(3, 143);
            this.buttonOkAddEditPat.Name = "buttonOkAddEditPat";
            this.buttonOkAddEditPat.Size = new System.Drawing.Size(66, 22);
            this.buttonOkAddEditPat.TabIndex = 25;
            this.buttonOkAddEditPat.Text = "ОК";
            this.buttonOkAddEditPat.UseVisualStyleBackColor = true;
            this.buttonOkAddEditPat.Click += new System.EventHandler(this.buttonOkAddEditPat_Click);
            // 
            // buttonCloseAddEditPat
            // 
            this.buttonCloseAddEditPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseAddEditPat.Location = new System.Drawing.Point(231, 143);
            this.buttonCloseAddEditPat.Name = "buttonCloseAddEditPat";
            this.buttonCloseAddEditPat.Size = new System.Drawing.Size(74, 22);
            this.buttonCloseAddEditPat.TabIndex = 26;
            this.buttonCloseAddEditPat.Text = "Закрыть";
            this.buttonCloseAddEditPat.UseVisualStyleBackColor = true;
            this.buttonCloseAddEditPat.Click += new System.EventHandler(this.buttonCloseAddEditPat_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата_выд";
            // 
            // dtpDateVyd
            // 
            this.dtpDateVyd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDateVyd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVyd.Location = new System.Drawing.Point(87, 115);
            this.dtpDateVyd.Name = "dtpDateVyd";
            this.dtpDateVyd.Size = new System.Drawing.Size(218, 23);
            this.dtpDateVyd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Серия";
            // 
            // cmbProf
            // 
            this.cmbProf.DataSource = this.профессияBindingSource;
            this.cmbProf.DisplayMember = "Назв_проф";
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(87, 87);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(218, 24);
            this.cmbProf.TabIndex = 29;
            this.cmbProf.ValueMember = "ID_проф";
            // 
            // профессияBindingSource
            // 
            this.профессияBindingSource.DataMember = "Профессия";
            this.профессияBindingSource.DataSource = this.миграционная_службаDataSet;
            this.профессияBindingSource.Sort = "Назв_проф";
            // 
            // мигрант1TableAdapter
            // 
            this.мигрант1TableAdapter.ClearBeforeFill = true;
            // 
            // профессияTableAdapter
            // 
            this.профессияTableAdapter.ClearBeforeFill = true;
            // 
            // FormPatent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(953, 304);
            this.Controls.Add(this.panelAddEdit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.патентDataGridView);
            this.Controls.Add(this.патентBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPatent";
            this.Text = "Патенты на работу";
            this.Load += new System.EventHandler(this.FormPatent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.патентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.патентBindingNavigator)).EndInit();
            this.патентBindingNavigator.ResumeLayout(false);
            this.патентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.патентDataGridView)).EndInit();
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мигрант1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Migration_service.Migration_serviceDataSet миграционная_службаDataSet;
        private System.Windows.Forms.BindingSource патентBindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.ПатентTableAdapter патентTableAdapter;
        private Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator патентBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView патентDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripTextBox tbPatentSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPatentSear;
        private System.Windows.Forms.ToolStripButton btnPatentRes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPatentAdd;
        private System.Windows.Forms.ToolStripButton btnPatentEdit;
        private System.Windows.Forms.ToolStripButton btnPatentDel;
        private System.Windows.Forms.Panel panelAddEdit;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbID_Mig;
        private System.Windows.Forms.TextBox tbSeria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOkAddEditPat;
        private System.Windows.Forms.Button buttonCloseAddEditPat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateVyd;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.BindingSource профессияBindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.ПрофессияTableAdapter профессияTableAdapter;
        private System.Windows.Forms.BindingSource мигрант1BindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.Мигрант1TableAdapter мигрант1TableAdapter;
    }
}