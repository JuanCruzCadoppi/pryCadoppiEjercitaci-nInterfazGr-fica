using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiEjercitaciónInterfazGráfica
{
    public partial class frmSOC : Form
    {
        public frmSOC()
        {
            InitializeComponent();
        }

        private void frmSOC_Load(object sender, EventArgs e)
        {

        }

        private void lblCritico_Click(object sender, EventArgs e)
        {
            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = "100%";
        }
    }
}
