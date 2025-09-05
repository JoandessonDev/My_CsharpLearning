namespace FIrstCrudWindowsForms
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
            marcaTexBox = new TextBox();
            marcaTitulo = new Label();
            categoriaTitulo = new Label();
            categoriaTexBox = new TextBox();
            quantidadeTitulo = new Label();
            quantidadeTexBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            nomeTitulo = new Label();
            nomeTexBox = new TextBox();
            SuspendLayout();
            // 
            // marcaTexBox
            // 
            marcaTexBox.Location = new Point(341, 167);
            marcaTexBox.Name = "marcaTexBox";
            marcaTexBox.Size = new Size(125, 27);
            marcaTexBox.TabIndex = 0;
            // 
            // marcaTitulo
            // 
            marcaTitulo.AutoSize = true;
            marcaTitulo.Location = new Point(234, 170);
            marcaTitulo.Name = "marcaTitulo";
            marcaTitulo.Size = new Size(53, 20);
            marcaTitulo.TabIndex = 1;
            marcaTitulo.Text = "Marca:";
            // 
            // categoriaTitulo
            // 
            categoriaTitulo.AutoSize = true;
            categoriaTitulo.Location = new Point(234, 222);
            categoriaTitulo.Name = "categoriaTitulo";
            categoriaTitulo.Size = new Size(77, 20);
            categoriaTitulo.TabIndex = 3;
            categoriaTitulo.Text = "Categoria:";
            // 
            // categoriaTexBox
            // 
            categoriaTexBox.Location = new Point(341, 222);
            categoriaTexBox.Name = "categoriaTexBox";
            categoriaTexBox.Size = new Size(125, 27);
            categoriaTexBox.TabIndex = 2;
            // 
            // quantidadeTitulo
            // 
            quantidadeTitulo.AutoSize = true;
            quantidadeTitulo.Location = new Point(234, 284);
            quantidadeTitulo.Name = "quantidadeTitulo";
            quantidadeTitulo.Size = new Size(90, 20);
            quantidadeTitulo.TabIndex = 5;
            quantidadeTitulo.Text = "Quantidade:";
            // 
            // quantidadeTexBox
            // 
            quantidadeTexBox.Location = new Point(341, 281);
            quantidadeTexBox.Name = "quantidadeTexBox";
            quantidadeTexBox.Size = new Size(125, 27);
            quantidadeTexBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 65);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 6;
            label1.Text = "Cadastrar Produtos";
            // 
            // button1
            // 
            button1.Location = new Point(341, 353);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            nomeTitulo.AutoSize = true;
            nomeTitulo.Location = new Point(234, 123);
            nomeTitulo.Name = "label2";
            nomeTitulo.Size = new Size(53, 20);
            nomeTitulo.TabIndex = 9;
            nomeTitulo.Text = "Nome:";

            // 
            // textBox1
            // 
            nomeTexBox.Location = new Point(341, 120);
            nomeTexBox.Name = "nameTexBox";
            nomeTexBox.Size = new Size(125, 27);
            nomeTexBox.TabIndex = 8;
            nomeTexBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 415);
            Controls.Add(nomeTitulo);
            Controls.Add(nomeTexBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(marcaTitulo);
            Controls.Add(marcaTexBox);
            Controls.Add(categoriaTitulo);
            Controls.Add(categoriaTexBox);
            Controls.Add(quantidadeTitulo);
            Controls.Add(quantidadeTexBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox marcaTexBox;
        private Label marcaTitulo;
        private Label categoriaTitulo;
        private TextBox categoriaTexBox;
        private Label quantidadeTitulo;
        private TextBox quantidadeTexBox;
        private Label label1;
        private Button button1;
        private Label nomeTitulo;
        private TextBox nomeTexBox;
    }
}
