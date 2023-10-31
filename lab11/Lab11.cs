using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyLab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Moloko", 2, 3, 2 * 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells[3].Value = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value));
        }
    }
}
