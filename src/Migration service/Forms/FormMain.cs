using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Migration_service.Controller;

namespace Migration_service
{
    public partial class FormMain : Form
    {
        Query controller;
        //OleDbConnection dbConnection;
        public FormMain()
        {
            InitializeComponent();
            //dbConnection = new OleDbConnection(ConnectionString.ConnStr);
            //dbConnection.Open();
            controller = new Query();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Мигрант1". При необходимости она может быть перемещена или удалена.
            this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Цели". При необходимости она может быть перемещена или удалена.
            this.целиTableAdapter.Fill(this.миграционная_службаDataSet.Цели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Профессия". При необходимости она может быть перемещена или удалена.
            this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Страна". При необходимости она может быть перемещена или удалена.
            this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.РВП_Мигранта". При необходимости она может быть перемещена или удалена.
            this.рВП_МигрантаTableAdapter.Fill(this.миграционная_службаDataSet.РВП_Мигранта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Патенты_Мигранта". При необходимости она может быть перемещена или удалена.
            this.патенты_МигрантаTableAdapter.Fill(this.миграционная_службаDataSet.Патенты_Мигранта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Мигрант". При необходимости она может быть перемещена или удалена.
            this.мигрантTableAdapter.Fill(this.миграционная_службаDataSet.Мигрант);
            //мигрант1DataGridView.AutoSize = true; 
            this.Width = 1113;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // выход
        {
            Application.Exit();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) // выбор записи
        {
            if (мигрант1DataGridView.CurrentRow != null)
            {
                string f = $"ID_миг = {мигрант1DataGridView.CurrentRow.Cells[0].Value}";
                патенты_МигрантаBindingSource.Filter = f;
                рВП_МигрантаBindingSource.Filter = f;
            }

        }
        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e) // нажатие кнопки "Справочники"
        {
            FormSprav formSprav = new FormSprav();
            formSprav.Show();
        }
        private void патентыToolStripMenuItem1_Click(object sender, EventArgs e) // нажатие кнопки "Патенты"
        {
            FormPatent formPatent = new FormPatent();
            formPatent.Show();
        }
        private void РВПToolStripMenuItem2_Click(object sender, EventArgs e) // нажатие кнопки "РВП"
        {
            FormRVP formRVP = new FormRVP();
            formRVP.Show();
        }
        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e) // нажатие кнопки "Отчёты"
        {
            FormReports formReports = new FormReports();
            formReports.Show();
        }

        public void letter_control_sep(object sender, KeyPressEventArgs e) // защита полей
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar)
                && e.KeyChar != '-' && e.KeyChar != ',')
                e.Handled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)  // нажатие кнопки "Удалить"
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись '{мигрант1DataGridView.CurrentRow.Cells[1].Value}'?", "Удалить запись", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(мигрант1DataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.Delete("Мигрант", "ID_миг", id);
                    /*string query = $"DELETE FROM Страна WHERE ID_стран = {странаDataGridView.CurrentRow.Cells[0].Value}";
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    // выполняем запрос, n – количество записей, затронутых запросом 
                    command.ExecuteNonQuery();*/
                    MessageBox.Show("Запись удалена.");
                    this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
                }
            }
            catch
            {
                MessageBox.Show("Запись не удалена, так как используется в учёте мигрантов.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // нажатие кнопки "Добавить"
        {
            lblPanel.Text = "Добавление:";
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;

        }

        private void buttonCloseAddEditMig_Click(object sender, EventArgs e) // нажатие кнопки "Закрыть" на панели добавления/редактирования
        {
            panelAddEdit.Visible = false;
            tableLayoutPanel1.Visible = false;
            tbFIO.Text = "";
            dateBirth.Value = DateTime.Today;
            cmbSex.SelectedIndex = 0;
            addCmbState.SelectedIndex = 0;
            tbBirthPl.Text = "";
            tbPasp.Text = "";
            tbNumMig.Text = "";
            addCmbPurp.SelectedIndex = 0;
            tbHost.Text = "";
            addDateFrom.Value = DateTime.Today;
            addDateTo.Value = DateTime.Today;
        }

        private void buttonOkAddEditMig_Click(object sender, EventArgs e) // нажатие кнопки "ОК" на панели добавления/редактирования
        {
            if (tbFIO.Text == "" || cmbSex.Text == "" || tbBirthPl.Text == "" || tbNumMig.Text == "" || addCmbPurp.Text == "" || tbHost.Text == "")
                MessageBox.Show("Заполните все обязательные поля.");
            else
            {
                if (lblPanel.Text == "Добавление:")
                {
                    controller.AddМигрант(tbFIO.Text, dateBirth.Value, cmbSex.SelectedItem.ToString(), addCmbState.SelectedValue.ToString(), tbBirthPl.Text, tbPasp.Text, tbNumMig.Text,
                        addCmbPurp.SelectedValue.ToString(), tbHost.Text, addDateFrom.Value, addDateTo.Value);
                    this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
                    MessageBox.Show("Запись добавлена.");
                }
                else
                {
                    int selR = мигрант1DataGridView.CurrentCell.RowIndex; int selC = мигрант1DataGridView.CurrentCell.ColumnIndex;
                    int id = Int32.Parse(мигрант1DataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.EditМигрант(id, tbFIO.Text, dateBirth.Value.ToShortDateString(), cmbSex.SelectedItem.ToString(), addCmbState.Text, tbBirthPl.Text, tbPasp.Text, tbNumMig.Text,
                        addCmbPurp.Text, tbHost.Text, addDateFrom.Value.ToShortDateString(), addDateTo.Value.ToShortDateString());
                    this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
                    MessageBox.Show("Запись изменена.");
                    мигрант1DataGridView.CurrentCell = мигрант1DataGridView[selC, selR];
                }
                panelAddEdit.Visible = false;
                tableLayoutPanel1.Visible = false;
                tbFIO.Text = "";
                dateBirth.Value = DateTime.Today;
                cmbSex.SelectedIndex = 0;
                addCmbState.SelectedIndex = 0;
                tbBirthPl.Text = "";
                tbPasp.Text = "";
                tbNumMig.Text = "";
                addCmbPurp.SelectedIndex = 0;
                tbHost.Text = "";
                addDateFrom.Value = DateTime.Today;
                addDateTo.Value = DateTime.Today;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) // нажатие кнопки "Редактировать"
        {
            lblPanel.Text = "Редактирование:";
            tbFIO.Text = мигрант1DataGridView.CurrentRow.Cells[1].Value.ToString();
            dateBirth.Value = DateTime.Parse(мигрант1DataGridView.CurrentRow.Cells[2].Value.ToString());
            cmbSex.SelectedItem = мигрант1DataGridView.CurrentRow.Cells[3].Value.ToString();
            addCmbState.Text = мигрант1DataGridView.CurrentRow.Cells[4].Value.ToString();
            tbBirthPl.Text = мигрант1DataGridView.CurrentRow.Cells[5].Value.ToString();
            tbPasp.Text = мигрант1DataGridView.CurrentRow.Cells[6].Value.ToString();
            tbNumMig.Text = мигрант1DataGridView.CurrentRow.Cells[7].Value.ToString();
            addCmbPurp.Text = мигрант1DataGridView.CurrentRow.Cells[8].Value.ToString();
            tbHost.Text = мигрант1DataGridView.CurrentRow.Cells[9].Value.ToString();
            addDateFrom.Value = DateTime.Parse(мигрант1DataGridView.CurrentRow.Cells[10].Value.ToString());
            addDateTo.Value = DateTime.Parse(мигрант1DataGridView.CurrentRow.Cells[11].Value.ToString());
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;
        }

        private void btnSear_Click(object sender, EventArgs e) // нажатие кнопки "Поиск"
        {
            panelSearch.Visible = true;
        }

        private void btnResetMig_Click(object sender, EventArgs e) // нажатие кнопки "Сброс" на панели поиска
        {
            cbFIO.Checked = false; cbState.Checked = false; cbPurpose.Checked = false; cbDateFrom.Checked = false; cbDateTo.Checked = false;
            tbSearFIO.Text = ""; tbSearState.Text = ""; tbSearPurp.Text = ""; dtpSearFrom.Value = DateTime.Today; dtpSearTo.Value = DateTime.Today;
            мигрант1BindingSource.Filter = "";
        }

        private void btnCloseSearchMig_Click(object sender, EventArgs e) // нажатие кнопки "закрыть" на панели поиска
        {
            btnResetMig_Click(sender, e);
            panelSearch.Visible = false;
        }

        private void btnSearMig_Click(object sender, EventArgs e) // нажатие кнопки "Поиск" на панели поиска
        {
            if (cbFIO.Checked == true && tbSearFIO.Text != "")
            {
                мигрант1BindingSource.Filter = $"ФИО Like \'{tbSearFIO.Text}*\'";
                if (cbState.Checked == true && tbSearState.Text != "")
                    мигрант1BindingSource.Filter += $" AND Назв_стран Like \'{tbSearState.Text}*\'";
                if (cbPurpose.Checked == true && tbSearPurp.Text != "")
                    мигрант1BindingSource.Filter += $" AND Цель Like \'{tbSearPurp.Text}*\'";
                if (cbDateFrom.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_с >= '{dtpSearFrom.Value.ToShortDateString()}'";
                if (cbDateTo.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_до <= '{dtpSearTo.Value.ToShortDateString()}'";
            }
            else if (cbState.Checked == true && tbSearState.Text != "")
            {
                мигрант1BindingSource.Filter = $"Назв_стран Like \'{tbSearState.Text}*\'";
                if (cbPurpose.Checked == true && tbSearPurp.Text != "")
                    мигрант1BindingSource.Filter += $" AND Цель Like \'{tbSearPurp.Text}*\'";
                if (cbDateFrom.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_с >= '{dtpSearFrom.Value.ToShortDateString()}'";
                if (cbDateTo.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_до <= '{dtpSearTo.Value.ToShortDateString()}'";
            }
            else if (cbPurpose.Checked == true && tbSearPurp.Text != "")
            {
                мигрант1BindingSource.Filter = $"Цель Like \'{tbSearPurp.Text}*\'";
                string queryD1 = $" AND Срок_с >= '{dtpSearFrom.Value.ToShortDateString()}'";
                //MessageBox.Show(queryD1);
                if (cbDateFrom.Checked == true)
                    мигрант1BindingSource.Filter += queryD1;
                if (cbDateTo.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_до <= '{dtpSearTo.Value.ToShortDateString()}'";
            }
            else if (cbDateFrom.Checked == true)
            {
                мигрант1BindingSource.Filter = $"Срок_с >= '{dtpSearFrom.Value.ToShortDateString()}'";
                if (cbDateTo.Checked == true)
                    мигрант1BindingSource.Filter += $" AND Срок_до <= '{dtpSearTo.Value.ToShortDateString()}'";
            }
            else if (cbDateTo.Checked == true) мигрант1BindingSource.Filter = $"Срок_до <= '{dtpSearTo.Value.ToShortDateString()}'";
            //MessageBox.Show(мигрант1BindingSource.Filter);
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
            this.целиTableAdapter.Fill(this.миграционная_службаDataSet.Цели);
            this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
            this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
            this.рВП_МигрантаTableAdapter.Fill(this.миграционная_службаDataSet.РВП_Мигранта);
            this.патенты_МигрантаTableAdapter.Fill(this.миграционная_службаDataSet.Патенты_Мигранта);
            this.мигрантTableAdapter.Fill(this.миграционная_службаDataSet.Мигрант);
        }

        private void panelAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAddEdit.Visible == true) Width = 1392;
            else Width = 1113;
        }
    }
}
