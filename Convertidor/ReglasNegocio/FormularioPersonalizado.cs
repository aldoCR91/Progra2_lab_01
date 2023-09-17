using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor.ReglasNegocio
{
    public class FormularioPersonalizado : Form
    {
        public static Color backgroundColor = Color.Blue;

        public static Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        public void FormBase()
        {
            this.BackColor = backgroundColor;
        }

        private void InitializeComponent()
        {

        }

        private void FormularioPersonalizado_Load(object sender, EventArgs e)
        {
        }
    }
}
