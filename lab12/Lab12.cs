using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab12

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Isaev", "Ruslan", 12);
            dataGridView1.Rows.Add("SS", "B", 32);
            dataGridView1.Rows.Add("Ibraev", "Someone", 22);


        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            dataGridView1.Rows[viNomRow].DefaultCellStyle.BlackColor = Color.White;
            for(int i = 0; dataGridView1.RowCount; i++)
            {
                if (dataGridView1[1, i].FormattedValue.ToString().Trim().ToLower().Contains(toolStrip1.Text.Trim().ToLower()))
                {
                    dataGridView1.CurrentCell = dataGridView1[1, i];
                    enteredviNomRow = i;
                    dataGridView1.Rows[viNomRow].DefaultCellStyle.BlackColor = Color.Aqua;
                    return; 
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
