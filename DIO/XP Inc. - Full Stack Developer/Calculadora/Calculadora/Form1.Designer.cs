namespace Calculadora
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            text1 = new TextBox();
            btnCalcular = new Button();
            cboTypeCal = new ComboBox();
            text2 = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            label3 = new Label();
            lblResultado = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._3396202;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(28, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 152);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero 1";
            // 
            // text1
            // 
            text1.Location = new Point(545, 149);
            text1.Name = "text1";
            text1.Size = new Size(125, 27);
            text1.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkViolet;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(461, 343);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 35);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboTypeCal
            // 
            cboTypeCal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeCal.FormattingEnabled = true;
            cboTypeCal.Items.AddRange(new object[] { "Somar", "Subtrair", "Multiplicar", "Dividir" });
            cboTypeCal.Location = new Point(545, 262);
            cboTypeCal.Name = "cboTypeCal";
            cboTypeCal.Size = new Size(125, 28);
            cboTypeCal.TabIndex = 7;
            cboTypeCal.SelectedIndexChanged += cboTypeCal_SelectedIndexChanged;
            // 
            // text2
            // 
            text2.Location = new Point(545, 196);
            text2.Name = "text2";
            text2.Size = new Size(125, 27);
            text2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 203);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Numero 2";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(598, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 265);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 11;
            label3.Text = "Operação:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Moccasin;
            lblResultado.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.InfoText;
            lblResultado.Location = new Point(276, 142);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(31, 32);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "0";
            lblResultado.Click += lblResultado_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Location = new Point(433, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 426);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 39);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(689, 6);
            button1.Name = "button1";
            button1.Size = new Size(45, 29);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 15;
            label4.Text = "Calculadora";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(757, 510);
            Controls.Add(panel2);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(text2);
            Controls.Add(label2);
            Controls.Add(cboTypeCal);
            Controls.Add(btnCalcular);
            Controls.Add(text1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox text1;
        private Button btnCalcular;
        private ComboBox cboTypeCal;
        private TextBox text2;
        private Label label2;
        private Button btnClear;
        private Label label3;
        private Label lblResultado;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Button button1;
    }
}
