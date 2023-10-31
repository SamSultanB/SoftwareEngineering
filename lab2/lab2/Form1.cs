namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1(object sender, EventArgs e)
        {
            int k = Convert.ToInt32((sender as Button).Tag);
            string s = "You pressed the button";
            switch (k)
            {
                case 1:
                    s += "number 1";
                    break;
                case 2:
                    s += "number 2";
                    break;
                default:
                    s = "you couldn't get here";
                    break;
            }
            MessageBox.Show(this, s, "Which button?");
        }
    }
}