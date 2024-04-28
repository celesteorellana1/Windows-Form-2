using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(TxtMonto.Text);
            double tasa = double.Parse(TxtTasa.Text);
            double Periodo = double.Parse(TxtPeriodo.Text);

            double CapitalFinal = monto * Math.Pow(1 + (tasa / 100), Periodo);

            LblResultado.Text = $"Elcapital final de la inversion es de: {CapitalFinal}";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtMonto.Clear();
            TxtTasa.Clear();
            TxtPeriodo.Clear ();    
            LblResultado.Text = string.Empty;
        }
    }
}
