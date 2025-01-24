namespace CalculadoraMotor3F;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        string tensao = string.Empty;
        string potencia = string.Empty;
        string rendimento = string.Empty;
        string fatorPotencia = string.Empty;
    }

    private void buttonCalcular_Click(object sender, EventArgs e)
    {
        try
        {
            //Pot�ncia
            if (string.IsNullOrEmpty(textBoxPotencia.Text))
            {
                throw new Exception("Preencha o campo pot�ncia corretamente!");
            }
            double potencia1;
            if (!double.TryParse(textBoxPotencia.Text, out potencia1))
            {
                throw new Exception("Preencha o campo pot�ncia corretamente!");
            }

            //Tens�o
            if (string.IsNullOrEmpty(textBoxTensao.Text))
            {
                throw new Exception("Preencha o campo tens�o corretamente!");
            }
            double tensao1;
            if (!double.TryParse(textBoxTensao.Text, out tensao1))
            {
                throw new Exception("Preencha o campo tens�o corretamente!");
            }

            //Rendimento
            if (string.IsNullOrEmpty(textBoxRendimento.Text))
            {
                throw new Exception("Preencha o campo rendimento corretamente!");
            }
            double rendimento1;
            if (!double.TryParse(textBoxRendimento.Text, out rendimento1))
            {
                throw new Exception("Preencha o campo rendimento corretamente!");
            }

            //Fator de pot�ncia
            if (string.IsNullOrEmpty(textBoxFatorPotencia.Text))
            {
                throw new Exception("Preencha o campo fator de pot�ncia corretamente!");
            }
            double fatorPotencia1;
            if (!double.TryParse(textBoxFatorPotencia.Text, out fatorPotencia1))
            {
                throw new Exception("Preencha o campo fator de pot�ncia corretamente!");
            }
            Calcular(potencia1,tensao1,rendimento1,fatorPotencia1);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Calcular(double potencia, double tensao,  double rendimento, double fatorPotencia)
    {
        double raiz3 = Math.Sqrt(3);
        try
        {
            double correnteNominal = potencia / (tensao * raiz3 * rendimento * fatorPotencia);
            MessageBox.Show($"A corrente nominal do motor � de {correnteNominal:n2} A.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro de c�lculo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}