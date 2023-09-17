namespace Convertidor
{
    partial class frmPotencia
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
            lblBase = new Label();
            tbBase = new TextBox();
            lblExponente = new Label();
            tbExponente = new TextBox();
            btnElevar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(44, 55);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(31, 15);
            lblBase.TabIndex = 0;
            lblBase.Text = "Base";
            // 
            // tbBase
            // 
            tbBase.Location = new Point(81, 47);
            tbBase.Name = "tbBase";
            tbBase.Size = new Size(130, 23);
            tbBase.TabIndex = 1;
            tbBase.TextAlign = HorizontalAlignment.Right;
            // 
            // lblExponente
            // 
            lblExponente.AutoSize = true;
            lblExponente.Location = new Point(240, 55);
            lblExponente.Name = "lblExponente";
            lblExponente.Size = new Size(63, 15);
            lblExponente.TabIndex = 2;
            lblExponente.Text = "Exponente";
            // 
            // tbExponente
            // 
            tbExponente.Location = new Point(309, 47);
            tbExponente.Name = "tbExponente";
            tbExponente.Size = new Size(130, 23);
            tbExponente.TabIndex = 3;
            tbExponente.TextAlign = HorizontalAlignment.Right;
            // 
            // btnElevar
            // 
            btnElevar.Location = new Point(44, 98);
            btnElevar.Name = "btnElevar";
            btnElevar.Size = new Size(75, 23);
            btnElevar.TabIndex = 4;
            btnElevar.Text = "Elevar";
            btnElevar.UseVisualStyleBackColor = true;
            btnElevar.Click += btnElevar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(153, 102);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // frmPotencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnElevar);
            Controls.Add(tbExponente);
            Controls.Add(lblExponente);
            Controls.Add(tbBase);
            Controls.Add(lblBase);
            Name = "frmPotencia";
            Text = "frmPotencia";
            Load += frmPotencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBase;
        private TextBox tbBase;
        private Label lblExponente;
        private TextBox tbExponente;
        private Button btnElevar;
        private Label lblResultado;
    }
}