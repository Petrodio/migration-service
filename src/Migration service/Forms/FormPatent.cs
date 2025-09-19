using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Migration_service.Controller;

namespace Migration_service
{
    public partial class FormPatent : Form
    {
        Query controller;
        public FormPatent()
        {
            InitializeComponent();
            controller = new Query();
        }

        private void FormPatent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Мигрант1". При необходимости она может быть перемещена или удалена.
            this.мигрант1TableAdapter.Fill(this.миграционная_службаDataSet.Мигрант1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Профессия". При необходимости она может быть перемещена или удалена.
            this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Патент". При необходимости она может быть перемещена или удалена.
            this.патентTableAdapter.Fill(this.миграционная_службаDataSet.Патент);
            Width = 656;
        }

        public void num_control(object sender, KeyPressEventArgs e) // защита полей
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnPatentSear_Click(object sender, EventArgs e)
        {
            патентBindingSource.Filter = $"Номер Like \'{tbPatentSearch.Text}*\'";
        }

        private void btnPatentRes_Click(object sender, EventArgs e)
        {
            tbPatentSearch.Text = "";
            патентBindingSource.Filter = "";
        }

        private void btnPatentDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись '{патентDataGridView.CurrentRow.Cells[0].Value}'?", "Удалить запись", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(патентDataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.Delete("Патент", "ID_пат", id);
                    MessageBox.Show("Запись удалена.");
                    this.патентTableAdapter.Fill(this.миграционная_службаDataSet.Патент);
                }
            }
            catch
            {
                MessageBox.Show("Запись не удалена, так как используется в учёте мигрантов.");
            }
        }

        private void btnPatentAdd_Click(object sender, EventArgs e)
        {
            lblPanel.Text = "Добавление:";
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;
        }

        private void buttonCloseAddEditPat_Click(object sender, EventArgs e)
        {
            cmbID_Mig.SelectedIndex = 0;
            tbSeria.Text = "";
            tbNumber.Text = "";
            cmbProf.SelectedIndex = 0;
            dtpDateVyd.Value = DateTime.Today;
            tableLayoutPanel1.Visible = false;
            panelAddEdit.Visible = false;
        }

        private void buttonOkAddEditPat_Click(object sender, EventArgs e)
        {
            if (cmbID_Mig.Text == "" || tbSeria.Text == "" || tbNumber.Text == "" || cmbProf.Text == "")
                MessageBox.Show("Заполните все поля.");
            else
            {
                if (lblPanel.Text == "Добавление:")
                {
                    controller.AddPatent(Int32.Parse(cmbID_Mig.SelectedValue.ToString()), tbSeria.Text, tbNumber.Text, Int32.Parse(cmbProf.SelectedValue.ToString()), dtpDateVyd.Value);
                    this.патентTableAdapter.Fill(this.миграционная_службаDataSet.Патент);
                    MessageBox.Show("Запись добавлена.");
                }
                else
                {
                    int selR = патентDataGridView.CurrentCell.RowIndex; int selC = патентDataGridView.CurrentCell.ColumnIndex;
                    int id = Int32.Parse(патентDataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.EditPatent(id, Int32.Parse(cmbID_Mig.Text), tbSeria.Text, tbNumber.Text, Int32.Parse(cmbProf.SelectedValue.ToString()), dtpDateVyd.Value);
                    this.патентTableAdapter.Fill(this.миграционная_службаDataSet.Патент);
                    MessageBox.Show("Запись изменена.");
                    патентDataGridView.CurrentCell = патентDataGridView[selC, selR];
                }
                cmbID_Mig.SelectedIndex = 0;
                tbSeria.Text = "";
                tbNumber.Text = "";
                cmbProf.SelectedIndex = 0;
                dtpDateVyd.Value = DateTime.Today;
                tableLayoutPanel1.Visible = false;
                panelAddEdit.Visible = false;
            }
        }

        private void btnPatentEdit_Click(object sender, EventArgs e)
        {
            lblPanel.Text = "Редактирование:";
            panelAddEdit.Visible = true;
            tableLayoutPanel1.Visible = true;
            cmbID_Mig.Text = патентDataGridView.CurrentRow.Cells[1].Value.ToString();
            tbSeria.Text = патентDataGridView.CurrentRow.Cells[2].Value.ToString();
            tbNumber.Text = патентDataGridView.CurrentRow.Cells[3].Value.ToString();
            cmbProf.Text = патентDataGridView.CurrentRow.Cells[4].Value.ToString();
            dtpDateVyd.Value = DateTime.Parse(патентDataGridView.CurrentRow.Cells[5].Value.ToString());
        }

        private void panelAddEdit_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAddEdit.Visible == true) Width = 969;
            else Width = 656;
        }
    }
}
