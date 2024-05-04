using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCuotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = double.Parse(txtMonto.Text);
                double interes = double.Parse(txtInteres.Text);
                double plazo = double.Parse(txtPlazo.Text);

                double cuotaMensual = (monto * interes * Math.Pow(1 + interes, plazo)) / (Math.Pow(1 + interes, plazo) - 1);
                cuotaMensual = Math.Round(cuotaMensual, 2);
                txtResultadoCuotas.Text = cuotaMensual.ToString();

                double totalIntereses = (cuotaMensual * plazo) - monto;
                txtTotalIntereses.Text = totalIntereses.ToString();

                double totalPagar = monto + totalIntereses;
                txtTotalPagar.Text = totalPagar.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular los valores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
