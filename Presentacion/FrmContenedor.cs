using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Presentacion
{
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
        }

        private void conexiónBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmSetearConexion))
                    return;
            }

            frmSetearConexion Formulario = new frmSetearConexion();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmArticulos))
                    return;
            }

            frmArticulos Formulario = new frmArticulos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void otrosParámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmOtrosParamertos))
                    return;
            }

            frmOtrosParamertos Formulario = new frmOtrosParamertos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Count < 4)
            {
                frmSetearConexion Formulario = new frmSetearConexion();

                Formulario.ShowDialog();
            }
            
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMarcas))
                    return;
            }

            frmMarcas Formulario = new frmMarcas();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmCategorias))
                    return;
            }

            frmCategorias Formulario = new frmCategorias();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

    }
}
