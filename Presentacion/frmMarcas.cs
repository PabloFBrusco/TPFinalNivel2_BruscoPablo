using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ayudas;

namespace Presentacion
{
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;
        MarcaNegocio Negocio = new MarcaNegocio();
        private Marca marca = null;
        Validaciones validar = new Validaciones();
        Excepcion error = new Excepcion();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            estadoCampos(false);
        }
        private void llenarGrilla()
        {
            try
            {
                listaMarcas = Negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
                formatearGrilla();
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }

        }

        private void formatearGrilla()
        {
            dgvMarcas.Columns["Id"].Visible = false;
            dgvMarcas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMarcas.Columns["Descripcion"].Width = 200;
        }

        private void estadoCampos(bool estado)
        {
            dgvMarcas.Enabled = !estado;
            gpbMarca.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoCampos(false);
            llenarGrilla();
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                txtMarca.Text = seleccionado.descripcion;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadoCampos(true);
            txtMarca.Text = "";
            txtMarca.Focus();
            marca = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(dgvMarcas.CurrentCell is null))
            {
                marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                estadoCampos(true);
                txtMarca.Focus();
            }
            else MessageBox.Show("No hay ningún elemento seleccionado", "Modificar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca marca = new Marca();
            if (!((dgvMarcas.CurrentCell is null)))
            {
                try
                {
                    marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    if (negocio.VerificarArticulos(marca.id) > 0)
                    {
                        MessageBox.Show("No se puede eliminar la marca porque está utilizada por artículos", "Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                       DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminar la marca: " + marca.descripcion + "?", "Eliminar Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                       if (respuesta == DialogResult.Yes)
                       {
                        negocio.eliminar(marca.id);
                        llenarGrilla();
                       }
                    }    
                }
                catch (Exception ex)
                {
                    error.excepcionGeneral(ex.ToString());
                }
            }
            else MessageBox.Show("No hay ningún elemento seleccionado", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            if (validar.validarTextoRequerido(txtMarca.Text))
            {
                    MessageBox.Show("La Marca no puede estar vacía", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtMarca.Focus();
            }
            else
            {
                try
                {
                    if (marca == null)
                        marca = new Marca();

                    marca.descripcion = txtMarca.Text;

                    if (marca.id != 0)
                    {
                        negocio.modificar(marca);
                    }
                    else
                    {
                        negocio.agregar(marca);
                    }
                }
                catch (Exception ex)
                {
                    error.excepcionGeneral(ex.ToString());
                }
                finally
                {
                    llenarGrilla();
                    estadoCampos(false);
                }

            }
            
        }
    }
}
