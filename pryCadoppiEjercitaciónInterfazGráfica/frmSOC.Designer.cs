namespace pryCadoppiEjercitaciónInterfazGráfica
{
    partial class frmSOC
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
            lblCritico = new Label();
            lblAlto = new Label();
            lblMedio = new Label();
            lblBajo = new Label();
            lblResultadoBajo = new Label();
            lblResultadoMedio = new Label();
            lblResultadoAlto = new Label();
            lblResultadoCritico = new Label();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(49, 59);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(52, 15);
            lblCritico.TabIndex = 0;
            lblCritico.Text = "CRITICO";
            lblCritico.Click += lblCritico_Click;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(49, 87);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(35, 15);
            lblAlto.TabIndex = 1;
            lblAlto.Text = "ALTO";
            lblAlto.Click += lblAlto_Click;
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(49, 115);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(44, 15);
            lblMedio.TabIndex = 2;
            lblMedio.Text = "MEDIO";
            lblMedio.Click += lblMedio_Click;
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(49, 143);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(36, 15);
            lblBajo.TabIndex = 3;
            lblBajo.Text = "BAJO";
            lblBajo.Click += lblBajo_Click;
            // 
            // lblResultadoBajo
            // 
            lblResultadoBajo.AutoSize = true;
            lblResultadoBajo.Location = new Point(153, 143);
            lblResultadoBajo.Name = "lblResultadoBajo";
            lblResultadoBajo.Size = new Size(12, 15);
            lblResultadoBajo.TabIndex = 7;
            lblResultadoBajo.Text = "-";
            // 
            // lblResultadoMedio
            // 
            lblResultadoMedio.AutoSize = true;
            lblResultadoMedio.Location = new Point(153, 115);
            lblResultadoMedio.Name = "lblResultadoMedio";
            lblResultadoMedio.Size = new Size(12, 15);
            lblResultadoMedio.TabIndex = 6;
            lblResultadoMedio.Text = "-";
            // 
            // lblResultadoAlto
            // 
            lblResultadoAlto.AutoSize = true;
            lblResultadoAlto.Location = new Point(153, 87);
            lblResultadoAlto.Name = "lblResultadoAlto";
            lblResultadoAlto.Size = new Size(12, 15);
            lblResultadoAlto.TabIndex = 5;
            lblResultadoAlto.Text = "-";
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(153, 59);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 4;
            lblResultadoCritico.Text = "-";
            // 
            // frmSOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 215);
            Controls.Add(lblResultadoBajo);
            Controls.Add(lblResultadoMedio);
            Controls.Add(lblResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSOC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SOC - - INDICENTES";
            Load += frmSOC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label lblResultadoBajo;
        private Label lblResultadoMedio;
        private Label lblResultadoAlto;
        private Label lblResultadoCritico;
    }
}