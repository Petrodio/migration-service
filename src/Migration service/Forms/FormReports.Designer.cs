
namespace Migration_service
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePat = new System.Windows.Forms.TabPage();
            this.патенты_по_месяцамDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.патенты_по_месяцамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.миграционная_службаDataSet = new Migration_service.Migration_serviceDataSet();
            this.tbPatYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRVP = new System.Windows.Forms.TabPage();
            this.рВП_по_месяцамDataGridView = new System.Windows.Forms.DataGridView();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.месяцDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоРВПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рВП_по_месяцамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRVPYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager();
            this.патенты_по_месяцамTableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.Патенты_по_месяцамTableAdapter();
            this.рВП_по_месяцамTableAdapter = new Migration_service.Migration_serviceDataSetTableAdapters.РВП_по_месяцамTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPagePat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.патенты_по_месяцамDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.патенты_по_месяцамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).BeginInit();
            this.tabPageRVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рВП_по_месяцамDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВП_по_месяцамBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePat);
            this.tabControl1.Controls.Add(this.tabPageRVP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePat
            // 
            this.tabPagePat.Controls.Add(this.патенты_по_месяцамDataGridView);
            this.tabPagePat.Controls.Add(this.tbPatYear);
            this.tabPagePat.Controls.Add(this.label1);
            this.tabPagePat.Location = new System.Drawing.Point(4, 22);
            this.tabPagePat.Name = "tabPagePat";
            this.tabPagePat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePat.Size = new System.Drawing.Size(280, 328);
            this.tabPagePat.TabIndex = 0;
            this.tabPagePat.Text = "Патенты по месяцам";
            this.tabPagePat.UseVisualStyleBackColor = true;
            // 
            // патенты_по_месяцамDataGridView
            // 
            this.патенты_по_месяцамDataGridView.AutoGenerateColumns = false;
            this.патенты_по_месяцамDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.патенты_по_месяцамDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.патенты_по_месяцамDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.патенты_по_месяцамDataGridView.DataSource = this.патенты_по_месяцамBindingSource;
            this.патенты_по_месяцамDataGridView.Location = new System.Drawing.Point(6, 28);
            this.патенты_по_месяцамDataGridView.Name = "патенты_по_месяцамDataGridView";
            this.патенты_по_месяцамDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.патенты_по_месяцамDataGridView.Size = new System.Drawing.Size(266, 292);
            this.патенты_по_месяцамDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Год";
            this.dataGridViewTextBoxColumn1.HeaderText = "Год";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Месяц";
            this.dataGridViewTextBoxColumn8.HeaderText = "Месяц";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Кол-во патентов";
            this.dataGridViewTextBoxColumn9.HeaderText = "Кол-во патентов";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // патенты_по_месяцамBindingSource
            // 
            this.патенты_по_месяцамBindingSource.DataMember = "Патенты_по_месяцам";
            this.патенты_по_месяцамBindingSource.DataSource = this.миграционная_службаDataSet;
            // 
            // миграционная_службаDataSet
            // 
            this.миграционная_службаDataSet.DataSetName = "Миграционная_службаDataSet";
            this.миграционная_службаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPatYear
            // 
            this.tbPatYear.Location = new System.Drawing.Point(101, 2);
            this.tbPatYear.Name = "tbPatYear";
            this.tbPatYear.Size = new System.Drawing.Size(100, 20);
            this.tbPatYear.TabIndex = 2;
            this.tbPatYear.TextChanged += new System.EventHandler(this.tbPatYear_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите год:";
            // 
            // tabPageRVP
            // 
            this.tabPageRVP.AutoScroll = true;
            this.tabPageRVP.Controls.Add(this.рВП_по_месяцамDataGridView);
            this.tabPageRVP.Controls.Add(this.tbRVPYear);
            this.tabPageRVP.Controls.Add(this.label2);
            this.tabPageRVP.Location = new System.Drawing.Point(4, 22);
            this.tabPageRVP.Name = "tabPageRVP";
            this.tabPageRVP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRVP.Size = new System.Drawing.Size(280, 328);
            this.tabPageRVP.TabIndex = 1;
            this.tabPageRVP.Text = "РВП по месяцам";
            this.tabPageRVP.UseVisualStyleBackColor = true;
            // 
            // рВП_по_месяцамDataGridView
            // 
            this.рВП_по_месяцамDataGridView.AutoGenerateColumns = false;
            this.рВП_по_месяцамDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.рВП_по_месяцамDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.рВП_по_месяцамDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.годDataGridViewTextBoxColumn,
            this.месяцDataGridViewTextBoxColumn,
            this.колвоРВПDataGridViewTextBoxColumn});
            this.рВП_по_месяцамDataGridView.DataSource = this.рВП_по_месяцамBindingSource;
            this.рВП_по_месяцамDataGridView.Location = new System.Drawing.Point(6, 28);
            this.рВП_по_месяцамDataGridView.Name = "рВП_по_месяцамDataGridView";
            this.рВП_по_месяцамDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.рВП_по_месяцамDataGridView.Size = new System.Drawing.Size(266, 292);
            this.рВП_по_месяцамDataGridView.TabIndex = 4;
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            // 
            // месяцDataGridViewTextBoxColumn
            // 
            this.месяцDataGridViewTextBoxColumn.DataPropertyName = "Месяц";
            this.месяцDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.месяцDataGridViewTextBoxColumn.Name = "месяцDataGridViewTextBoxColumn";
            // 
            // колвоРВПDataGridViewTextBoxColumn
            // 
            this.колвоРВПDataGridViewTextBoxColumn.DataPropertyName = "Кол-во РВП";
            this.колвоРВПDataGridViewTextBoxColumn.HeaderText = "Кол-во РВП";
            this.колвоРВПDataGridViewTextBoxColumn.Name = "колвоРВПDataGridViewTextBoxColumn";
            // 
            // рВП_по_месяцамBindingSource
            // 
            this.рВП_по_месяцамBindingSource.AllowNew = true;
            this.рВП_по_месяцамBindingSource.DataMember = "РВП_по_месяцам";
            this.рВП_по_месяцамBindingSource.DataSource = this.миграционная_службаDataSet;
            // 
            // tbRVPYear
            // 
            this.tbRVPYear.Location = new System.Drawing.Point(101, 2);
            this.tbRVPYear.Name = "tbRVPYear";
            this.tbRVPYear.Size = new System.Drawing.Size(100, 20);
            this.tbRVPYear.TabIndex = 4;
            this.tbRVPYear.TextChanged += new System.EventHandler(this.tbRVPYear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите год:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МигрантTableAdapter = null;
            this.tableAdapterManager.ПатентTableAdapter = null;
            this.tableAdapterManager.ПрофессияTableAdapter = null;
            this.tableAdapterManager.РВПTableAdapter = null;
            this.tableAdapterManager.СтранаTableAdapter = null;
            this.tableAdapterManager.ЦелиTableAdapter = null;
            // 
            // патенты_по_месяцамTableAdapter
            // 
            this.патенты_по_месяцамTableAdapter.ClearBeforeFill = true;
            // 
            // рВП_по_месяцамTableAdapter
            // 
            this.рВП_по_месяцамTableAdapter.ClearBeforeFill = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(288, 354);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReports";
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePat.ResumeLayout(false);
            this.tabPagePat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.патенты_по_месяцамDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.патенты_по_месяцамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.миграционная_службаDataSet)).EndInit();
            this.tabPageRVP.ResumeLayout(false);
            this.tabPageRVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рВП_по_месяцамDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рВП_по_месяцамBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePat;
        private System.Windows.Forms.TabPage tabPageRVP;
        private Migration_service.Migration_serviceDataSet миграционная_службаDataSet;
        private Migration_service.Migration_serviceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox tbPatYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource патенты_по_месяцамBindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.Патенты_по_месяцамTableAdapter патенты_по_месяцамTableAdapter;
        private System.Windows.Forms.DataGridView патенты_по_месяцамDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox tbRVPYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource рВП_по_месяцамBindingSource;
        private Migration_service.Migration_serviceDataSetTableAdapters.РВП_по_месяцамTableAdapter рВП_по_месяцамTableAdapter;
        private System.Windows.Forms.DataGridView рВП_по_месяцамDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn месяцDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоРВПDataGridViewTextBoxColumn;
    }
}