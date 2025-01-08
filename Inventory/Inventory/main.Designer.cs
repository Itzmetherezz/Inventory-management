namespace Inventory
{
    partial class main
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
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.Font = new Font("Sitka Text", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(1, 34);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1309, 68);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Inventory management";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 678);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Sitka Text", 20F);
            button5.ForeColor = SystemColors.ActiveCaption;
            button5.Location = new Point(11, 331);
            button5.Name = "button5";
            button5.Size = new Size(186, 68);
            button5.TabIndex = 8;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Sitka Text", 20F);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(11, 109);
            button4.Name = "button4";
            button4.Size = new Size(186, 68);
            button4.TabIndex = 7;
            button4.Text = "Products";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Sitka Text", 20F);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(11, 183);
            button3.Name = "button3";
            button3.Size = new Size(186, 68);
            button3.TabIndex = 6;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Sitka Text", 20F);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(11, 257);
            button2.Name = "button2";
            button2.Size = new Size(186, 68);
            button2.TabIndex = 5;
            button2.Text = "Inventory";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sitka Text", 20F);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(11, 35);
            button1.Name = "button1";
            button1.Size = new Size(186, 68);
            button1.TabIndex = 4;
            button1.Text = "Orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, dashboardToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1309, 37);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            userToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 192);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(73, 33);
            userToolStripMenuItem.Text = "User";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardToolStripMenuItem.ForeColor = Color.FromArgb(0, 0, 192);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(133, 33);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1309, 778);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            Name = "main";
            Text = "Inventory Management";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private Button button5;
    }
}