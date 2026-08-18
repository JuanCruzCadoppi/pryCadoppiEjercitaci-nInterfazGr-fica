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
            this.lblResultadoBajo = new Label();
            this.lblResultadoMedio = new Label();
            this.lblResultadoAlto = new Label();
            lblResultadoCritico = new Label();
            SuspendLayout();
            // 
            // lblCritico
            // 
            lblCritico.AutoSize = true;
            lblCritico.Location = new Point(34, 42);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(52, 15);
            lblCritico.TabIndex = 1;
            lblCritico.Text = "CRITICO";
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Location = new Point(34, 76);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(35, 15);
            lblAlto.TabIndex = 2;
            lblAlto.Text = "ALTO";
            // 
            // lblMedio
            // 
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(34, 111);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(44, 15);
            lblMedio.TabIndex = 3;
            lblMedio.Text = "MEDIO";
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Location = new Point(34, 144);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(36, 15);
            lblBajo.TabIndex = 4;
            lblBajo.Text = "BAJO";
            lblBajo.Click += lblBajo_Click;
            // 
            // lblResultadoBajo
            // 
            this.lblResultadoBajo.AutoSize = true;
            this.lblResultadoBajo.Location = new Point(132, 144);
            this.lblResultadoBajo.Name = "lblResultadoBajo";
            this.lblResultadoBajo.Size = new Size(12, 15);
            this.lblResultadoBajo.TabIndex = 8;
            this.lblResultadoBajo.Text = "-";
            this.lblResultadoBajo.Click += this.label1_Click_1;
            // 
            // lblResultadoMedio
            // 
            this.lblResultadoMedio.AutoSize = true;
            this.lblResultadoMedio.Location = new Point(132, 111);
            this.lblResultadoMedio.Name = "lblResultadoMedio";
            this.lblResultadoMedio.Size = new Size(12, 15);
            this.lblResultadoMedio.TabIndex = 7;
            this.lblResultadoMedio.Text = "-";
            this.lblResultadoMedio.Click += this.label2_Click;
            // 
            // lblResultadoAlto
            // 
            this.lblResultadoAlto.AutoSize = true;
            this.lblResultadoAlto.Location = new Point(132, 76);
            this.lblResultadoAlto.Name = "lblResultadoAlto";
            this.lblResultadoAlto.Size = new Size(12, 15);
            this.lblResultadoAlto.TabIndex = 6;
            this.lblResultadoAlto.Text = "-";
            this.lblResultadoAlto.Click += this.label3_Click;
            // 
            // lblResultadoCritico
            // 
            lblResultadoCritico.AutoSize = true;
            lblResultadoCritico.Location = new Point(132, 42);
            lblResultadoCritico.Name = "lblResultadoCritico";
            lblResultadoCritico.Size = new Size(12, 15);
            lblResultadoCritico.TabIndex = 5;
            lblResultadoCritico.Text = "-";
            lblResultadoCritico.Click += this.label4_Click;
            // 
            // frmSOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 203);
            Controls.Add(this.lblResultadoBajo);
            Controls.Add(this.lblResultadoMedio);
            Controls.Add(this.lblResultadoAlto);
            Controls.Add(lblResultadoCritico);
            Controls.Add(lblBajo);
            Controls.Add(lblMedio);
            Controls.Add(lblAlto);
            Controls.Add(lblCritico);
            Name = "frmSOC";
            Text = "SOC - - INCIDENTES";
            Load += frmIncidentes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCritico;
        private Label lblAlto;
        private Label lblMedio;
        private Label lblBajo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultadoCritico;
    }
}