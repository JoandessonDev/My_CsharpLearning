namespace TesteWindows
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
            btnDesfazerVenda = new PictureBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            toolStripContainer1 = new ToolStripContainer();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)btnDesfazerVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDesfazerVenda
            // 
            btnDesfazerVenda.Cursor = Cursors.Hand;
            btnDesfazerVenda.Image = Properties.Resources.Screenshot_2024_08_24_013008;
            btnDesfazerVenda.Location = new Point(431, 34);
            btnDesfazerVenda.Name = "btnDesfazerVenda";
            btnDesfazerVenda.Size = new Size(166, 45);
            btnDesfazerVenda.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDesfazerVenda.TabIndex = 1;
            btnDesfazerVenda.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(249, 97);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 39);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(649, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(504, 43);
            comboBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_08_24_013634;
            pictureBox1.Location = new Point(1180, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(249, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 461);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 236);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 234, 236);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 234, 236);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(431, 94);
            button1.Name = "button1";
            button1.Size = new Size(166, 45);
            button1.TabIndex = 6;
            button1.Text = "Filtrar Intervalo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.White;
            toolStripContainer1.ContentPanel.Size = new Size(212, 714);
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(-3, -3);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(212, 714);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(24, 144, 255);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 236);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 234, 236);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 234, 236);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(249, 34);
            button2.Name = "button2";
            button2.Size = new Size(166, 45);
            button2.TabIndex = 8;
            button2.Text = "Registrar Venda";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 711);
            Controls.Add(button2);
            Controls.Add(toolStripContainer1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btnDesfazerVenda);
            ForeColor = Color.FromArgb(234, 234, 236);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnDesfazerVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnDesfazerVenda;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private ToolStripContainer toolStripContainer1;
        private Button button2;
    }
}
