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
    public partial class FormReports : Form
    {
        Query controller;
        public FormReports()
        {
            InitializeComponent();
            controller = new Query();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.РВП_по_месяцам". При необходимости она может быть перемещена или удалена.
            this.рВП_по_месяцамTableAdapter.Fill(this.миграционная_службаDataSet.РВП_по_месяцам);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "миграционная_службаDataSet.Патенты_по_месяцам". При необходимости она может быть перемещена или удалена.
            this.патенты_по_месяцамTableAdapter.Fill(this.миграционная_службаDataSet.Патенты_по_месяцам);
            tbPatYear.Text = DateTime.Now.Year.ToString();
            tbRVPYear.Text = DateTime.Now.Year.ToString();
            патенты_по_месяцамBindingSource.Filter = $"Год = {tbPatYear.Text}";
            рВП_по_месяцамBindingSource.Filter = $"Год = {tbRVPYear.Text}";
        }

        private void tbPatYear_TextChanged(object sender, EventArgs e)
        {
            патенты_по_месяцамBindingSource.Filter = $"Год = {tbPatYear.Text}";
        }

        private void tbRVPYear_TextChanged(object sender, EventArgs e)
        {
            рВП_по_месяцамBindingSource.Filter = $"Год = {tbRVPYear.Text}";
        }
    }
}
