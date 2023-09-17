namespace Convertidor
{
    partial class frmAcercaDe
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
            lblUniversidad = new Label();
            lblCarrera = new Label();
            lblCurso = new Label();
            lblTitulo = new Label();
            lblProfesor = new Label();
            lblEstudiante = new Label();
            lblYear = new Label();
            SuspendLayout();
            // 
            // lblUniversidad
            // 
            lblUniversidad.AutoSize = true;
            lblUniversidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUniversidad.Location = new Point(269, 43);
            lblUniversidad.Name = "lblUniversidad";
            lblUniversidad.Size = new Size(303, 25);
            lblUniversidad.TabIndex = 0;
            lblUniversidad.Text = "Colegio Universitario de Cartago";
            lblUniversidad.Click += label1_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrera.Location = new Point(314, 104);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(219, 21);
            lblCarrera.TabIndex = 1;
            lblCarrera.Text = "Tecnologías de la Información ";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurso.Location = new Point(333, 158);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(174, 21);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "TI-131 Programación 2 ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(305, 210);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 21);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = " Trabajo Corto 1 - Investigación ";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesor.Location = new Point(268, 271);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(297, 21);
            lblProfesor.TabIndex = 4;
            lblProfesor.Text = "Profesor: Róger Alberto Rodríguez López ";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstudiante.Location = new Point(329, 326);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(178, 21);
            lblEstudiante.TabIndex = 5;
            lblEstudiante.Text = "Estudiante: Aldo Burgos ";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(378, 384);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(89, 21);
            lblYear.TabIndex = 6;
            lblYear.Text = "Año: 2023 ";
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblYear);
            Controls.Add(lblEstudiante);
            Controls.Add(lblProfesor);
            Controls.Add(lblTitulo);
            Controls.Add(lblCurso);
            Controls.Add(lblCarrera);
            Controls.Add(lblUniversidad);
            Name = "frmAcercaDe";
            Text = "frmAcercaDe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUniversidad;
        private Label lblCarrera;
        private Label lblCurso;
        private Label lblTitulo;
        private Label lblProfesor;
        private Label lblEstudiante;
        private Label lblYear;
    }
}