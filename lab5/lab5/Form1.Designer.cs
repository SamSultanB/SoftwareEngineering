namespace lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 127);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 162);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(591, 129);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(64, 318);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 2;
            button1.Text = "Add text";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 318);
            button2.Name = "button2";
            button2.Size = new Size(91, 54);
            button2.TabIndex = 3;
            button2.Text = "append";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(313, 318);
            button3.Name = "button3";
            button3.Size = new Size(91, 54);
            button3.TabIndex = 4;
            button3.Text = "setLines";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(560, 318);
            button4.Name = "button4";
            button4.Size = new Size(95, 54);
            button4.TabIndex = 5;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(64, 397);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(272, 144);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(385, 397);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(270, 144);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(441, 318);
            button5.Name = "button5";
            button5.Size = new Size(87, 54);
            button5.TabIndex = 8;
            button5.Text = "clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(64, 574);
            button6.Name = "button6";
            button6.Size = new Size(185, 54);
            button6.TabIndex = 9;
            button6.Text = "addValue";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(266, 574);
            button7.Name = "button7";
            button7.Size = new Size(173, 54);
            button7.TabIndex = 10;
            button7.Text = "showText";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(462, 574);
            button8.Name = "button8";
            button8.Size = new Size(193, 54);
            button8.TabIndex = 11;
            button8.Text = "addTextWithLink";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 663);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}