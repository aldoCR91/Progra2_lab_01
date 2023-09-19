using Convertidor.ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        // Muestra el formulario frmPotencia
        private void calcularPotenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pantalla = new frmPotencia();
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        // Cierra el programa principal
        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Muestra el formulario frmCambiarColor
        private void mnCambiarColor_Click(object sender, EventArgs e)
        {
            var pantalla = new frmCambiarColor();
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        // Muestra el formulario frmAcercaDe
        private void mnAcercaDe_Click(object sender, EventArgs e)
        {
            var pantalla = new frmAcercaDe();
            pantalla.MdiParent = this;
            pantalla.Show();
        }
    }
}
