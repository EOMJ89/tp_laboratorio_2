using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesCalculadora;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperator.ResetText();
            this.lblResultado.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            retorno += Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperator.Text);

            this.lblResultado.Text = retorno;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            resultado = Calculadora.Operar(numeroUno, numeroDos, operador);
            return resultado;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
        }
    }
}
