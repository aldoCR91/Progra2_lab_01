using Convertidor.ReglasNegocio;

namespace Convertidor
{
    partial class frmCambiarColor : FormularioPersonalizado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCambiarColor = new Label();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // lblCambiarColor
            // 
            lblCambiarColor.AutoSize = true;
            lblCambiarColor.Location = new Point(40, 33);
            lblCambiarColor.Name = "lblCambiarColor";
            lblCambiarColor.Size = new Size(273, 15);
            lblCambiarColor.TabIndex = 0;
            lblCambiarColor.Text = "Seleccione nuevo color de fondo para las pantallas";
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(40, 64);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(203, 23);
            btnCambiarColor.TabIndex = 1;
            btnCambiarColor.Text = "Cambiar color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // frmCambiarColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(lblCambiarColor);
            Name = "frmCambiarColor";
            Text = "Cambiar color";
            Load += frmCambiarColor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCambiarColor;
        private Button btnCambiarColor;
    }
}