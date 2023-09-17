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
    public partial class frmPrincipal : FormularioPersonalizado
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void calcularPotenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pantalla = new frmPotencia();
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnCambiarColor_Click(object sender, EventArgs e)
        {
            var pantalla = new frmCambiarColor();
            pantalla.MdiParent = this;
            pantalla.Show();
        }
    }
}
