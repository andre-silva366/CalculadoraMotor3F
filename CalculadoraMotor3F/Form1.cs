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

    double valor;
    List<double> valores = [];
    private void buttonCalcular_Click(object sender, EventArgs e)
    {
        try
        {
            //Potência
            ValidaDados(textBoxPotencia.Text, "potência");

            //Tensão
            ValidaDados(textBoxTensao.Text, "tensão");

            //Rendimento
            ValidaDados(textBoxRendimento.Text, "rendimento");

            //Fator de potência
            ValidaDados(textBoxRendimento.Text, "fator de potência");

            if (valores != null && valores.Count == 4)
            {
                Calcular(valores[0], valores[1], valores[2], valores[3]);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Calcular(double potencia, double tensao, double rendimento, double fatorPotencia)
    {
        double raiz3 = Math.Sqrt(3);
        try
        {
            double correnteNominal = potencia / (tensao * raiz3 * rendimento * fatorPotencia);
            MessageBox.Show($"A corrente nominal do motor é de {correnteNominal:n2} A.", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch
        {
            MessageBox.Show("Ocorreu um erro de cálculo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private double ValidaDados(string texto, string campo)
    {
        try
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new Exception($"Preencha o campo {campo} corretamente!");
            }
            else if (!double.TryParse(texto, out valor))
            {
                throw new Exception($"Preencha o campo {campo} corretamente!");
            }
            valores.Add(valor);
            return valor;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
    }

    private void buttonLimparCampos_Click(object sender, EventArgs e)
    {
        textBoxPotencia.Text = string.Empty;
        textBoxTensao.Text = string.Empty;
        textBoxRendimento.Text = string.Empty;
        textBoxFatorPotencia.Text= string.Empty;
    }
}