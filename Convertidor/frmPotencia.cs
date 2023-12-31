﻿using Convertidor.ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Convertidor
{
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o enter
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la entrada de caracteres no numéricos
            }
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            // si el valor no es convertible a int /  si la base es menor que 1 / si la base es mayor que 99
            if (!int.TryParse(tbBase.Text, out int base1) || base1 < 1 || base1 > 99)
            {
                MessageBox.Show("La base debe ser un numero entero entre 1 y 99");
                return;
            }
            // si el valor no es convertible a int /  si el exponente es menor que 1 / si la el exponente es mayor que 9
            if (!int.TryParse(tbExponente.Text, out int exponente) || exponente < 0 || exponente > 10)
            {
                MessageBox.Show("El exponente debe ser un numero entero menor o igual a 10");
                return;
            }

            // Actualiza el valor del label lblResultado con el resultado del metodo Potencia.Calcular
            lblResultado.Text = Potencia.Calcular(base1, exponente);

        }

        private void frmPotencia_Load(object sender, EventArgs e)
        {

        }
    }
}
