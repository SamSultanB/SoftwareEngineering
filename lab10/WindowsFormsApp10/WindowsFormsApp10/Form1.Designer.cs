
namespace WindowsFormsApp10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перваяФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стилиОтображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.втораяФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перваяФормаToolStripMenuItem,
            this.втораяФормаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // перваяФормаToolStripMenuItem
            // 
            this.перваяФормаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стилиОтображенияToolStripMenuItem});
            this.перваяФормаToolStripMenuItem.Name = "перваяФормаToolStripMenuItem";
            this.перваяФормаToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.перваяФормаToolStripMenuItem.Text = "Первая форма";
            // 
            // стилиОтображенияToolStripMenuItem
            // 
            this.стилиОтображенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.стилиОтображенияToolStripMenuItem.Name = "стилиОтображенияToolStripMenuItem";
            this.стилиОтображенияToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.стилиОтображенияToolStripMenuItem.Text = "Стили отображения";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // втораяФормаToolStripMenuItem
            // 
            this.втораяФормаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчётToolStripMenuItem});
            this.втораяФормаToolStripMenuItem.Name = "втораяФормаToolStripMenuItem";
            this.втораяФормаToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.втораяФормаToolStripMenuItem.Text = "Вторая Форма";
            // 
            // расчётToolStripMenuItem
            // 
            this.расчётToolStripMenuItem.Name = "расчётToolStripMenuItem";
            this.расчётToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.расчётToolStripMenuItem.Text = "Расчёт";
            this.расчётToolStripMenuItem.Click += new System.EventHandler(this.расчётToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перваяФормаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стилиОтображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem втораяФормаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётToolStripMenuItem;
    }
}

