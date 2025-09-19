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
    public partial class FormRVP : Form
    {
        Query controller;
        public FormRVP()
        {
            InitializeComponent();
            controller = new Query();
        }

        private void FormRVP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Мигрант1". При необходимости она может быть перемещена или удалена.
            this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.РВП". При необходимости она может быть перемещена или удалена.
            this.рВПTableAdapter.Fill(this.миграционная_службаDataSet.РВП);
            Width = 544;
        }

        public void num_control_sep(object sender, KeyPressEventArgs e) // защита полей
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar)
                && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnRVPSearch_Click(object sender, EventArgs e)
        {
            рВПBindingSource.Filter = $"Дата_реш Like \'{tbRVPSearch.Text}*\'";
        }

        private void btnRVPRes_Click(object sender, EventArgs e)
        {
            tbRVPSearch.Text = "";
            рВПBindingSource.Filter = "";
        }

        private void btnRVPDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись '{рВПDataGridView.CurrentRow.Cells[0].Value}'?", "Удалить запись", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(рВПDataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.Delete("РВП", "ID_РВП", id);
                    MessageBox.Show("Запись удалена.");
                    this.рВПTableAdapter.Fill(this.миграционная_службаDataSet.РВП);
                }
            }
            catch
            {
                MessageBox.Show("Запись не удалена, так как используется в учёте мигрантов.");
            }
        }

        private void btnRVPAdd_Click(object sender, EventArgs e)
        {
            lblPanel.Text = "Добавление:";
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;
        }

        private void buttonCloseAddEditPat_Click(object sender, EventArgs e)
        {
            cmbID_Mig.SelectedIndex = 0;
            tbNumber.Text = "";
            dtpDateResh.Value = DateTime.Today;
            dtpDateTo.Value = DateTime.Today;
            tableLayoutPanel1.Visible = false;
            panelAddEdit.Visible = false;
        }

        private void buttonOkAddEditPat_Click(object sender, EventArgs e)
        {
            if (cmbID_Mig.Text == "" || tbNumber.Text == "")
                MessageBox.Show("Заполните все поля.");
            else
            {
                if (lblPanel.Text == "Добавление:")
                {
                    controller.AddRVP(Int32.Parse(cmbID_Mig.SelectedValue.ToString()), tbNumber.Text, dtpDateResh.Value, dtpDateTo.Value);
                    this.рВПTableAdapter.Fill(this.миграционная_службаDataSet.РВП);
                    MessageBox.Show("Запись добавлена.");
                }
                else
                {
                    int selR = рВПDataGridView.CurrentCell.RowIndex; int selC = рВПDataGridView.CurrentCell.ColumnIndex;
                    int id = Int32.Parse(рВПDataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.EditRVP(id, Int32.Parse(cmbID_Mig.Text), tbNumber.Text, dtpDateResh.Value, dtpDateTo.Value);
                    this.рВПTableAdapter.Fill(this.миграционная_службаDataSet.РВП);
                    MessageBox.Show("Запись изменена.");
                    рВПDataGridView.CurrentCell = рВПDataGridView[selC, selR];
                }
                cmbID_Mig.SelectedIndex = 0;
                tbNumber.Text = "";
                dtpDateResh.Value = DateTime.Today;
                dtpDateTo.Value = DateTime.Today;
                tableLayoutPanel1.Visible = false;
                panelAddEdit.Visible = false;
            }
        }

        private void btnRVPEdit_Click(object sender, EventArgs e)
        {
            lblPanel.Text = "Редактирование:";
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;
            cmbID_Mig.Text =рВПDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbNumber.Text = рВПDataGridView.CurrentRow.Cells[2].Value.ToString();
            dtpDateResh.Value = DateTime.Parse(рВПDataGridView.CurrentRow.Cells[3].Value.ToString());
            dtpDateTo.Value = DateTime.Parse(рВПDataGridView.CurrentRow.Cells[4].Value.ToString());
        }

        private void panelAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAddEdit.Visible == true) Width = 857;
            else Width = 544;
        }
    }
}
