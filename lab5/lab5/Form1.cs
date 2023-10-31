using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll(); // select all text
            textBox1.Cut(); // cut out what was selected
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Lines = new string[] { " Line 1 ", " Line 2 " };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(textBox2.Text); // The function adds text to the end of the line textBox1 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // in this line we assign an empty line.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            // Set indentation in pixels for list items
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 16);
            // Display text that is not affected by the set
            // indentation (SelectionBullet = false)
            richTextBox1.SelectedText = "Below is a list \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            // Next is a list
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MessageBox.Show("Clicked on links");
            System.Diagnostics.Process.Start(e.LinkText); // line for the transition
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int viNom = 0;
            // Text output in one line
            richTextBox1.Text += "Text" + (Convert.ToInt32(viNom)).ToString();
            viNom++;
            //// The first way to display multi-line text
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r \n";
            viNom++;
            richTextBox1.Text += "String" + (Convert.ToInt32(viNom)).ToString() + "\r \n";
            //// The second way to display multi-line text
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r \n");
            viNom++;
            richTextBox1.AppendText("String" + Convert.ToString(viNom) + "\r \n");
            //// the third way to display multi-line text
            // richTextBox1.Lines = new string [] {"Line 1", "Line 2"};
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "My site http: \\ CSarp.kg";
        }
    }
}