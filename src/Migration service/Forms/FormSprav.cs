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
    public partial class FormSprav : Form
    {
        private readonly List<Panel> resizingPanels = new List<Panel>();
        Query controller;
        OleDbConnection dbConnection;
        public FormSprav()
        {
            InitializeComponent();
            dbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/App_Data/Миграционная_служба.mdb");
            dbConnection.Open();
            controller = new Query();
            this.Width = 523;
            RegisterPanelsForResizing(panelAddState, panelEdState, panelAddProf, panelEdProf);
        }

        private void странаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.странаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.миграционная_службаDataSet);

        }
        
        private void FormSprav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Страна". При необходимости она может быть перемещена или удалена.
            this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Цели". При необходимости она может быть перемещена или удалена.
            this.целиTableAdapter.Fill(this.миграционная_службаDataSet.Цели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Профессия". При необходимости она может быть перемещена или удалена.
            this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
            lblStripState.Text = (странаDataGridView.Rows.Count - 1).ToString();
            //странаDataGridView.AutoSize = true;
            целиDataGridView.Columns[0].Visible = false;
            профессияDataGridView.Columns[0].Visible = false;
        }

        private void tabctrlMain_TabIndexChanged(object sender, EventArgs e) // переключение вкладки
        {
            switch (tabctrlMain.SelectedIndex)
            {
                case 0:
                    lblStripState.Text = (странаDataGridView.Rows.Count - 1).ToString();
                    break;
                case 1:
                    lblStripState.Text = (профессияDataGridView.Rows.Count - 1).ToString();
                    break;
                case 2:
                    lblStripState.Text = (целиDataGridView.Rows.Count - 1).ToString();
                    break;
            }
            this.Width = 523;
            foreach (var panel in resizingPanels) { panel.Visible = false; }
        }

        public void letter_control_sep (object sender, KeyPressEventArgs e) // защита полей
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar)
                && e.KeyChar != '-' && e.KeyChar != ',')
                e.Handled = true;
        }

        private void btnStateSear_Click(object sender, EventArgs e) // нажатие кнопки поиска на вкладке Страны
        {
            странаBindingSource.Filter = $"Назв_стран Like \'{tbSSearch.Text}*\'";
        }

        private void btnStateRes_Click(object sender, EventArgs e) // нажатие кнопки сброса на вкладке Страны
        {
            tbSSearch.Text = "";
            странаBindingSource.Filter = "";
        }
        private void btnProfSear_Click(object sender, EventArgs e) // нажатие кнопки поиска на вкладке Профессии
        {
            профессияBindingSource.Filter = $"Назв_проф Like \'{tbPrSearch.Text}*\'";
        }
        private void btnProfRes_Click(object sender, EventArgs e) // нажатие кнопки сброса на вкладке Профессии
        {
            tbPrSearch.Text = "";
            профессияBindingSource.Filter = "";
        }
        
        private void btnStateAdd_Click(object sender, EventArgs e) // нажатие кнопки добавления на вкладке Страны 
        {
            //Size = new Size(196, 376);
            //странаDataGridView.Size = Size;
            panelAddState.Visible = true;
        }

        private void buttonCloseS_Click(object sender, EventArgs e) // нажатие кнопки Закрыть на панели добавления страны
        {
            //Size = new Size(424, 376);
            //странаDataGridView.Size = Size;
            tbAddState.Text = "";
            panelAddState.Visible = false;
        }

        private void buttonOkS_Click(object sender, EventArgs e) // нажатие кнопки ОК на панели добавления страны
        {
            if (tbAddState.Text == "")
                MessageBox.Show("Введите название страны.");
            else
            {
                string query = $"INSERT INTO Страна (Назв_стран) VALUES ('{tbAddState.Text}')";
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                // выполняем запрос
                command.ExecuteNonQuery();
                MessageBox.Show("Страна добавлена.");
                tbAddState.Text = "";
                panelAddState.Visible = false;
                //Size = new Size(424, 376);
               // странаDataGridView.Size = Size;
                this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
                //странаDataGridView.CurrentCell = странаDataGridView.Rows.Cells ;
            }
        }
                
        private void btnStateEdit_Click(object sender, EventArgs e) // нажатие кнопки редактирования на вкладке Страны
        {
            panelEdState.Visible = true;
            tbEdState.Text = странаDataGridView.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnOkEdState_Click(object sender, EventArgs e) // нажатие кнопки ОК на панели редактирования страны
        {
            if (tbEdState.Text == "")
                MessageBox.Show("Введите название страны.");
            else
            {
                int selR = странаDataGridView.CurrentCell.RowIndex; int selC = странаDataGridView.CurrentCell.ColumnIndex;
                string query = $"UPDATE Страна SET Назв_стран = '{tbEdState.Text}' WHERE ID_стран = {странаDataGridView.CurrentRow.Cells[0].Value}";
                OleDbCommand command = new OleDbCommand(query, dbConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Название изменено.");
                panelEdState.Visible = false;
                //Size = new Size(424, 376);
                // странаDataGridView.Size = Size;
                this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
                странаDataGridView.CurrentCell = странаDataGridView[selC, selR];
            }
        }

        private void btnCloseEdState_Click(object sender, EventArgs e) // нажатие кнопки Закрыть на панели редактирования страны
        {
            tbEdState.Text = "";
            panelEdState.Visible = false;
        }

        private void btnStateDel_Click(object sender, EventArgs e) // нажатие кнопки удаления на вкладке Страны
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись '{странаDataGridView.CurrentRow.Cells[1].Value}'?", "Удалить запись", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Страна WHERE ID_стран = {странаDataGridView.CurrentRow.Cells[0].Value}";
                    OleDbCommand command = new OleDbCommand(query, dbConnection);
                    // выполняем запрос, n – количество записей, затронутых запросом 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена.");
                    this.странаTableAdapter.Fill(this.миграционная_службаDataSet.Страна);
                }
            }
            catch
            {
                MessageBox.Show("Запись не удалена, так как используется в учёте мигрантов.");
            }
        }

        private void btnProfAdd_Click(object sender, EventArgs e) // нажатие кнопки добавления профессии
        {
            panelAddProf.Visible = true;
        }
                
        private void btnOkAddProf_Click(object sender, EventArgs e) // нажатие кнопки ОК при добавлении профессии
        {
            if (tbAddProf.Text == "")
                MessageBox.Show("Введите название профессии.");
            else
            {
                controller.AddSprav("Профессия", "Назв_проф", $"{tbAddProf.Text}");
                MessageBox.Show("Профессия добавлена.");
                tbAddProf.Text = "";
                panelAddProf.Visible = false;
                //Size = new Size(424, 376);
                //странаDataGridView.Size = Size;
                this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
                //странаDataGridView.CurrentCell = странаDataGridView.Rows.Cells ;
            }
        }

        private void btnCloseAddProf_Click(object sender, EventArgs e) // нажатие кнопки Закрыть при добавлении профессии
        {
            tbAddProf.Text = "";
            panelAddProf.Visible = false;
        }
                
        private void btnProfEdit_Click(object sender, EventArgs e) // нажатие кнопки редактирования профессии
        {
            panelEdProf.Visible = true;
            tbEdProf.Text = профессияDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnOkEdProf_Click(object sender, EventArgs e) // нажатие кнопки ОК при редактировании профессии
        {
            if (tbEdProf.Text == "")
                MessageBox.Show("Введите название профессии.");
            else
            {
                int selR = профессияDataGridView.CurrentCell.RowIndex; int selC = профессияDataGridView.CurrentCell.ColumnIndex;
                int id = Int32.Parse(профессияDataGridView.CurrentRow.Cells[0].Value.ToString());
                controller.EditSprav("Профессия", "Назв_проф", $"{tbEdProf.Text}", "ID_проф", id);
                MessageBox.Show("Название изменено.");
                panelEdProf.Visible = false;
                //Size = new Size(424, 376);
                // странаDataGridView.Size = Size;
                this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
                профессияDataGridView.CurrentCell = профессияDataGridView[selC, selR];
            }
        }

        private void btnCloseEdProf_Click(object sender, EventArgs e) // нажатие кнопки Закрыть при редактировании профессии
        {
            tbEdProf.Text = "";
            panelEdProf.Visible = false;
        }

        private void btnProfDel_Click(object sender, EventArgs e) // нажатие кнопки удаления профессии
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить запись '{профессияDataGridView.CurrentRow.Cells[1].Value}'?", "Удалить запись", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(профессияDataGridView.CurrentRow.Cells[0].Value.ToString());
                    controller.Delete("Профессия", "ID_проф", id);
                    MessageBox.Show("Запись удалена.");
                    this.профессияTableAdapter.Fill(this.миграционная_службаDataSet.Профессия);
                }
            }
            catch
            {
                MessageBox.Show("Запись не удалена, так как используется в учёте мигрантов.");
            }
        }

        private void RegisterPanelsForResizing(params Panel[] panels)
        {
            foreach (var panel in panels)
            {
                resizingPanels.Add(panel);
                panel.VisibleChanged += Panel_VisibleChanged;
            }
        }

        private void Panel_VisibleChanged(object sender, EventArgs e)
        {
            foreach (var panel in resizingPanels)
            {
                if (panel.Visible == true) { this.Width = 848; break;}
                else this.Width = 523;
            }
        }
    }
}
