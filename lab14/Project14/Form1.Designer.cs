namespace Project14
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(333, 236);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(410, 12);
            button1.Name = "button1";
            button1.Size = new Size(334, 42);
            button1.TabIndex = 1;
            button1.Text = "Вывод тектса";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(410, 76);
            button2.Name = "button2";
            button2.Size = new Size(334, 42);
            button2.TabIndex = 1;
            button2.Text = "Ссылка в тексте";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(410, 124);
            button3.Name = "button3";
            button3.Size = new Size(334, 42);
            button3.TabIndex = 1;
            button3.Text = "Используем шрифты";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(410, 172);
            button4.Name = "button4";
            button4.Size = new Size(334, 42);
            button4.TabIndex = 1;
            button4.Text = "Сохраняем и загружаем";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}