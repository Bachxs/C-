namespace projeto
{
    partial class FrmProdutocs
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(17, 228);
            label3.Name = "label3";
            label3.Size = new Size(205, 38);
            label3.TabIndex = 3;
            label3.Text = "Valor em Real:";
            // 
            // button1
            // 
            button1.Location = new Point(17, 280);
            button1.Name = "button1";
            button1.Size = new Size(113, 60);
            button1.TabIndex = 9;
            button1.Text = "Dólar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(136, 280);
            button2.Name = "button2";
            button2.Size = new Size(113, 60);
            button2.TabIndex = 10;
            button2.Text = "Libra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(259, 280);
            button3.Name = "button3";
            button3.Size = new Size(113, 60);
            button3.TabIndex = 11;
            button3.Text = "Euro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(378, 280);
            button4.Name = "button4";
            button4.Size = new Size(113, 60);
            button4.TabIndex = 12;
            button4.Text = "Outra";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, -7);
            label1.Name = "label1";
            label1.Size = new Size(468, 50);
            label1.TabIndex = 1;
            label1.Text = "Chico Moedas Loja Oficial";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(17, 175);
            label2.Name = "label2";
            label2.Size = new Size(286, 38);
            label2.TabIndex = 14;
            label2.Text = "Endereço do Cliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(17, 137);
            label4.Name = "label4";
            label4.Size = new Size(246, 38);
            label4.TabIndex = 16;
            label4.Text = "Nome do Cliente:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // FrmProdutocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.moedas;
            ClientSize = new Size(504, 352);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmProdutocs";
            Text = "FrmProdutocs";
            Load += FrmProdutocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}