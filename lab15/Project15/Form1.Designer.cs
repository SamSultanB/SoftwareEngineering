namespace Project15
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
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 31);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Изменить цвет TextBox";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(464, 31);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(192, 24);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Добавить текст TextBox";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(25, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменить цвет метки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 138);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Цвет";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(91, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Зеленый";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Синий";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Красный";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(335, 90);
            button1.Name = "button1";
            button1.Size = new Size(222, 38);
            button1.TabIndex = 3;
            button1.Text = "Добавить список фруктов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(335, 143);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(222, 120);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(893, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(136, 26);
            toolStripMenuItem1.Text = "Выход";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(25, 286);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 144);
            listBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(286, 286);
            button2.Name = "button2";
            button2.Size = new Size(176, 34);
            button2.TabIndex = 3;
            button2.Text = "Добавить список";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(286, 344);
            button3.Name = "button3";
            button3.Size = new Size(176, 34);
            button3.TabIndex = 3;
            button3.Text = "Сортировка списка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(286, 396);
            button4.Name = "button4";
            button4.Size = new Size(176, 34);
            button4.TabIndex = 3;
            button4.Text = "Удалить строку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(681, 282);
            button5.Name = "button5";
            button5.Size = new Size(200, 34);
            button5.TabIndex = 3;
            button5.Text = "Добавить поле выбора";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(681, 344);
            button6.Name = "button6";
            button6.Size = new Size(200, 34);
            button6.TabIndex = 3;
            button6.Text = "Удалить поле выбора";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 450);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
    }
}