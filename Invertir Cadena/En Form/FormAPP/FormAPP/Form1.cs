using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string textoIngresado = txtInput.Text;

            char[] arregloCaracteres = textoIngresado.ToCharArray();
            Array.Reverse(arregloCaracteres);

            string resultadoInversion = new string(arregloCaracteres);

            txtOutput.Text = resultadoInversion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

