namespace FirstProject
{
    partial class Form1
    {
        private const int V = 28;

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
            btnClickThis = new Button();
            label1 = new Label();
            btnClickThis2 = new Button();
            buttonTest = new Button();

            SuspendLayout();

            // buttonTeste

            buttonTest.Location(321, V);
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(303, 100);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(167, 71);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click This";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 195);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "lblhelloworld";
            label1.Click += label1_Click;
            // 
            // btnClickThis2
            // 
            btnClickThis2.Location = new Point(569, 98);
            btnClickThis2.Name = "btnClickThis2";
            btnClickThis2.Size = new Size(116, 73);
            btnClickThis2.TabIndex = 2;
            btnClickThis2.Text = "Click This2";
            btnClickThis2.UseVisualStyleBackColor = true;
            btnClickThis2.Click += btnClickThis2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickThis2);
            Controls.Add(label1);
            Controls.Add(btnClickThis);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label label1;
        private Button btnClickThis2;
        private Button buttonTest;
    }
}
