using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 editForm = new Form2();
            if (editForm.ShowDialog()!= DialogResult.OK)
                return;

            ListViewItem newItem = listView1.Items.Add(editForm.textBox1_TextChanged);
            newItem.SubItems.Add(editForm.textBox2_TextChanged);
            newItem.SubItems.Add(editForm.numericUpDown1_ValueChanged.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];

            Form2 editForm = new Form2();

            editForm.textBox1_TextChanged = item.Text;
            editForm.textBox2_TextChanged = item.SubItems[1].Text;
            editForm.numericUpDown1_ValueChanged = Convert.ToInt32(item.SubItems[2].Text);

            if (editForm.ShowDialog()!= DialogResult.OK)
                return;

            item.Text = editForm.textBox1_TextChanged;
            item.SubItems[1].Text = editForm.textBox2_TextChanged;
            item.SubItems[2].Text = editForm.numericUpDown1_ValueChanged.ToString();

        }

    }
}
