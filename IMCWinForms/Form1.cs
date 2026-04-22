namespace IMCWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza o cálculo do IMC e exibe a classificação baseada nos dados inseridos.
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //TryParse para evitar que o programa trave com entradas inválidas
            bool pesoValido = double.TryParse(txtPeso.Text, out double peso);
            bool alturaValida = double.TryParse(txtAltura.Text, out double altura);


            if (pesoValido && alturaValida && altura > 0)
            {
                // Fórmula do IMC: peso / altura²
                double imc = peso / (altura * altura);

                // Exibição do resultado formatado com 2 casas decimais
                lblIMC.Text = imc.ToString("F2");
                lblIMC.Visible = true;

                string classificacao = "";

                // Tabela de classificação baseada nos padrões de saúde
                if (imc < 16.9)
                    classificacao = "Muito abaixo do peso!";
                else if (imc < 18.5)
                    classificacao = "Você esta Abaixo do peso!";
                else if (imc < 25)
                    classificacao = "Você esta com peso normal!";
                else if (imc < 30)
                    classificacao = "Você esta acima do peso!";
                else if (imc < 35)
                    classificacao = "Obesidade grau I!";
                else if (imc < 40)
                    classificacao = "Obesidade grau II!";
                else
                    classificacao = "Obesidade grau III!";

                lblClassificacao.Text = classificacao;
                lblClassificacao.Visible = true;
            }
            else
            {   
                // Feedback para o usuário em caso de erro de digitação
                MessageBox.Show("Por favor, insira valores numéricos válidos para Peso e Altura.",
                        "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            lblIMC.Text = "";
            lblClassificacao.Text = "";
            lblIMC.Visible = false;
            lblClassificacao.Visible = false;
            txtPeso.Focus(); // Coloca o cursor de volta no peso
        }
    }
}
