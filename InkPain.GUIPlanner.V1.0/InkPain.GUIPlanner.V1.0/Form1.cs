using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkPain.GUIPlanner.V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plannerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plannerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plannerDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plannerDBDataSet.Planner". При необходимости она может быть перемещена или удалена.
            this.plannerTableAdapter.Fill(this.plannerDBDataSet.Planner);

        }

        private void дата_Создания_записиLabel_Click(object sender, EventArgs e)
        {

        }

        private void дата_Создания_записиDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
