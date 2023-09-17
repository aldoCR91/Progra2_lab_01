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
    public partial class frmCambiarColor : Form
    {
        public frmCambiarColor()
        {
            InitializeComponent();
        }

        private void frmCambiarColor_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Mostrar el diálogo de selección de color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener el color seleccionado por el usuario
                Color colorSeleccionado = colorDialog.Color;

                // Actualiza la configuración del color de fondo.
                Configuracion.ColorFondo = colorSeleccionado;

                // Aplica el color de fondo a todos los formularios abiertos.
                foreach (Form form in Application.OpenForms)
                {
                    form.BackColor = Configuracion.ColorFondo;
                }

            }
        }
    }
}
