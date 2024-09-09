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
            label1 = new Label();
            btnCE = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnSoma = new Button();
            input1 = new TextBox();
            input2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Número 01";
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.Location = new Point(715, 129);
            btnCE.Margin = new Padding(4, 4, 4, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(165, 45);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivisao.Location = new Point(543, 129);
            btnDivisao.Margin = new Padding(4, 4, 4, 4);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(165, 45);
            btnDivisao.TabIndex = 2;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(371, 129);
            btnMultiplicacao.Margin = new Padding(4, 4, 4, 4);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(165, 45);
            btnMultiplicacao.TabIndex = 3;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(199, 129);
            btnSubtracao.Margin = new Padding(4, 4, 4, 4);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(165, 45);
            btnSubtracao.TabIndex = 4;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoma.Location = new Point(26, 129);
            btnSoma.Margin = new Padding(4, 4, 4, 4);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(165, 45);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += button4_Click;
            // 
            // input1
            // 
            input1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input1.Location = new Point(26, 68);
            input1.Margin = new Padding(4, 4, 4, 4);
            input1.Name = "input1";
            input1.Size = new Size(424, 29);
            input1.TabIndex = 6;
            input1.TextChanged += textBox1_TextChanged;
            // 
            // input2
            // 
            input2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input2.Location = new Point(460, 68);
            input2.Margin = new Padding(4, 4, 4, 4);
            input2.Name = "input2";
            input2.Size = new Size(419, 29);
            input2.TabIndex = 7;
            input2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(460, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 8;
            label2.Text = "Número 02";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 204);
            Controls.Add(label2);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnCE);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCE;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnSoma;
        private TextBox input1;
        private TextBox input2;
        private Label label2;
    }
}