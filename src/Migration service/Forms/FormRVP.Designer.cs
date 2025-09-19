
namespace Migration_service
{
    partial class FormRVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRVP));
            this.миграционная_службаDataSet = new Migration_service.Migration_serviceDataSet();
            this.рВПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рВПTableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.РВПTableAdapter();
            this.tableAdapterManager = new Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager();
            this.рВПBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbRVPSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRVPSearch = new System.Windows.Forms.ToolStripButton();
            this.btnRVPRes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRVPAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRVPEdit = new System.Windows.Forms.ToolStripButton();
            this.btnRVPDel = new System.Windows.Forms.ToolStripButton();
            this.рВПDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCloseAddEditPat = new System.Windows.Forms.Button();
            this.buttonOkAddEditPat = new System.Windows.Forms.Button();
            this.cmbID_Mig = new System.Windows.Forms.ComboBox();
            this.мигрант1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateResh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.panelAddEdit = new System.Windows.Forms.Panel();
            this.lblPanel = new System.Windows.Forms.Label();
            this.мигрант1TableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.Мигрант1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВПBindingNavigator)).BeginInit();
            this.рВПBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рВПDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мигрант1BindingSource)).BeginInit();
            this.panelAddEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // миграционная_службаDataSet
            // 
            this.миграционная_службаDataSet.DataSetName = "Миграционная_службаDataSet";
            this.миграционная_службаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рВПBindingSource
            // 
            this.рВПBindingSource.DataMember = "РВП";
            this.рВПBindingSource.DataSource = this.миграционная_службаDataSet;
            // 
            // рВПTableAdapter
            // 
            this.рВПTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МигрантTableAdapter = null;
            this.tableAdapterManager.ПатентTableAdapter = null;
            this.tableAdapterManager.ПрофессияTableAdapter = null;
            this.tableAdapterManager.РВПTableAdapter = this.рВПTableAdapter;
            this.tableAdapterManager.СтранаTableAdapter = null;
            this.tableAdapterManager.ЦелиTableAdapter = null;
            // 
            // рВПBindingNavigator
            // 
            this.рВПBindingNavigator.AddNewItem = null;
            this.рВПBindingNavigator.BindingSource = this.рВПBindingSource;
            this.рВПBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рВПBindingNavigator.DeleteItem = null;
            this.рВПBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tbRVPSearch,
            this.toolStripSeparator1,
            this.btnRVPSearch,
            this.btnRVPRes,
            this.toolStripSeparator2,
            this.btnRVPAdd,
            this.btnRVPEdit,
            this.btnRVPDel});
            this.рВПBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рВПBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рВПBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рВПBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рВПBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рВПBindingNavigator.Name = "рВПBindingNavigator";
            this.рВПBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рВПBindingNavigator.Size = new System.Drawing.Size(841, 25);
            this.рВПBindingNavigator.TabIndex = 0;
            this.рВПBindingNavigator.Text = "bindingNavigator1";
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
            // tbRVPSearch
            // 
            this.tbRVPSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbRVPSearch.Name = "tbRVPSearch";
            this.tbRVPSearch.Size = new System.Drawing.Size(132, 25);
            this.tbRVPSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_control_sep);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRVPSearch
            // 
            this.btnRVPSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRVPSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnRVPSearch.Image")));
            this.btnRVPSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRVPSearch.Name = "btnRVPSearch";
            this.btnRVPSearch.Size = new System.Drawing.Size(23, 22);
            this.btnRVPSearch.Text = "Поиск";
            this.btnRVPSearch.Click += new System.EventHandler(this.btnRVPSearch_Click);
            // 
            // btnRVPRes
            // 
            this.btnRVPRes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRVPRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRVPRes.Image")));
            this.btnRVPRes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRVPRes.Name = "btnRVPRes";
            this.btnRVPRes.Size = new System.Drawing.Size(23, 22);
            this.btnRVPRes.Text = "Сброс";
            this.btnRVPRes.Click += new System.EventHandler(this.btnRVPRes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRVPAdd
            // 
            this.btnRVPAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRVPAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRVPAdd.Image")));
            this.btnRVPAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRVPAdd.Name = "btnRVPAdd";
            this.btnRVPAdd.Size = new System.Drawing.Size(23, 22);
            this.btnRVPAdd.Text = "Добавить";
            this.btnRVPAdd.Click += new System.EventHandler(this.btnRVPAdd_Click);
            // 
            // btnRVPEdit
            // 
            this.btnRVPEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRVPEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnRVPEdit.Image")));
            this.btnRVPEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRVPEdit.Name = "btnRVPEdit";
            this.btnRVPEdit.Size = new System.Drawing.Size(23, 22);
            this.btnRVPEdit.Text = "Редактировать";
            this.btnRVPEdit.Click += new System.EventHandler(this.btnRVPEdit_Click);
            // 
            // btnRVPDel
            // 
            this.btnRVPDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRVPDel.Image = ((System.Drawing.Image)(resources.GetObject("btnRVPDel.Image")));
            this.btnRVPDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRVPDel.Name = "btnRVPDel";
            this.btnRVPDel.Size = new System.Drawing.Size(23, 22);
            this.btnRVPDel.Text = "Удалить";
            this.btnRVPDel.Click += new System.EventHandler(this.btnRVPDel_Click);
            // 
            // рВПDataGridView
            // 
            this.рВПDataGridView.AutoGenerateColumns = false;
            this.рВПDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.рВПDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рВПDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.рВПDataGridView.DataSource = this.рВПBindingSource;
            this.рВПDataGridView.Location = new System.Drawing.Point(4, 28);
            this.рВПDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.рВПDataGridView.Name = "рВПDataGridView";
            this.рВПDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.рВПDataGridView.Size = new System.Drawing.Size(520, 296);
            this.рВПDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_РВП";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_РВП";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_реш";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_реш";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Срок";
            this.dataGridViewTextBoxColumn5.HeaderText = "Срок";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCloseAddEditPat, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonOkAddEditPat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbID_Mig, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateResh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpDateTo, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(531, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Visible = false;
            // 
            // buttonCloseAddEditPat
            // 
            this.buttonCloseAddEditPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseAddEditPat.Location = new System.Drawing.Point(231, 115);
            this.buttonCloseAddEditPat.Name = "buttonCloseAddEditPat";
            this.buttonCloseAddEditPat.Size = new System.Drawing.Size(74, 22);
            this.buttonCloseAddEditPat.TabIndex = 26;
            this.buttonCloseAddEditPat.Text = "Закрыть";
            this.buttonCloseAddEditPat.UseVisualStyleBackColor = true;
            this.buttonCloseAddEditPat.Click += new System.EventHandler(this.buttonCloseAddEditPat_Click);
            // 
            // buttonOkAddEditPat
            // 
            this.buttonOkAddEditPat.Location = new System.Drawing.Point(3, 115);
            this.buttonOkAddEditPat.Name = "buttonOkAddEditPat";
            this.buttonOkAddEditPat.Size = new System.Drawing.Size(66, 22);
            this.buttonOkAddEditPat.TabIndex = 25;
            this.buttonOkAddEditPat.Text = "ОК";
            this.buttonOkAddEditPat.UseVisualStyleBackColor = true;
            this.buttonOkAddEditPat.Click += new System.EventHandler(this.buttonOkAddEditPat_Click);
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
            // tbNumber
            // 
            this.tbNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNumber.Location = new System.Drawing.Point(87, 31);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(218, 23);
            this.tbNumber.TabIndex = 3;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата_реш";
            // 
            // dtpDateResh
            // 
            this.dtpDateResh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDateResh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateResh.Location = new System.Drawing.Point(87, 59);
            this.dtpDateResh.Name = "dtpDateResh";
            this.dtpDateResh.Size = new System.Drawing.Size(218, 23);
            this.dtpDateResh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Срок";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(87, 87);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(218, 23);
            this.dtpDateTo.TabIndex = 7;
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddEdit.Controls.Add(this.lblPanel);
            this.panelAddEdit.Location = new System.Drawing.Point(531, 29);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(308, 22);
            this.panelAddEdit.TabIndex = 3;
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
            // мигрант1TableAdapter
            // 
            this.мигрант1TableAdapter.ClearBeforeFill = true;
            // 
            // FormRVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(841, 329);
            this.Controls.Add(this.panelAddEdit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.рВПDataGridView);
            this.Controls.Add(this.рВПBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRVP";
            this.Text = "Разрешения на временное проживание";
            this.Load += new System.EventHandler(this.FormRVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВПBindingNavigator)).EndInit();
            this.рВПBindingNavigator.ResumeLayout(false);
            this.рВПBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рВПDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мигрант1BindingSource)).EndInit();
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Migration_service.Migration_serviceDataSet миграционная_службаDataSet;
        private System.Windows.Forms.BindingSource рВПBindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.РВПTableAdapter рВПTableAdapter;
        private Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рВПBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView рВПDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripTextBox tbRVPSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRVPSearch;
        private System.Windows.Forms.ToolStripButton btnRVPRes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRVPAdd;
        private System.Windows.Forms.ToolStripButton btnRVPEdit;
        private System.Windows.Forms.ToolStripButton btnRVPDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelAddEdit;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.ComboBox cmbID_Mig;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateResh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.BindingSource мигрант1BindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.Мигрант1TableAdapter мигрант1TableAdapter;
        private System.Windows.Forms.Button buttonOkAddEditPat;
        private System.Windows.Forms.Button buttonCloseAddEditPat;
    }
}