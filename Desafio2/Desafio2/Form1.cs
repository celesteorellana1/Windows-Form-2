using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(TxtMontoP.Text);
            double interes = double.Parse(TxtInteresP.Text);
            double periodo = double.Parse(TxtPeriodoP.Text);
            double interesMensual = double.Parse(TxtMensual.Text);

            double Cuota = (monto * interes) / (1 - Math.Pow(1 + interesMensual, -periodo * 12));

            LblResultado.Text = $" La cuota es de: {Cuota} ";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtInteresP.Clear();
            TxtMontoP.Clear();
            TxtPeriodoP.Clear();
            LblResultado.Text = string.Empty;
        }
    }
}
