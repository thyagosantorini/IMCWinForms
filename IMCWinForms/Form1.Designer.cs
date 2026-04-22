namespace IMCWinForms
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
            label2 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblIMC = new Label();
            lblClassificacao = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 54);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "PESO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "ALTURA";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(104, 51);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(119, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(104, 83);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(119, 23);
            txtAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(104, 135);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(113, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular IMC";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(126, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Location = new Point(141, 214);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(29, 15);
            lblIMC.TabIndex = 6;
            lblIMC.Text = "IMC";
            lblIMC.Visible = false;
            // 
            // lblClassificacao
            // 
            lblClassificacao.AutoSize = true;
            lblClassificacao.Location = new Point(92, 245);
            lblClassificacao.Name = "lblClassificacao";
            lblClassificacao.Size = new Size(78, 15);
            lblClassificacao.TabIndex = 7;
            lblClassificacao.Text = "Classificação!";
            lblClassificacao.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 54);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 8;
            label3.Text = "kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 86);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 9;
            label4.Text = "m";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(220, 260);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(68, 23);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 325);
            Controls.Add(btnLimpar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblClassificacao);
            Controls.Add(lblIMC);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblIMC;
        private Label lblClassificacao;
        private Label label3;
        private Label label4;
        private Button btnLimpar;
    }
}
