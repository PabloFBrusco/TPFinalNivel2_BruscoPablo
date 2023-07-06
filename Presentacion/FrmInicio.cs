using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            TmeInicio.Start();
        }

        private void IniciarSistema()
        {
            FrmContenedor Formulario = new FrmContenedor();
            TmeInicio.Stop();
            this.Hide();
            Formulario.ShowDialog();
            this.Close();
            
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {
            IniciarSistema();
        }

        private void TmeInicio_Tick(object sender, EventArgs e)
        {
            IniciarSistema();
        }
    }
}
