using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ayudas;


namespace Presentacion
{
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;
        CategoriaNegocio Negocio = new CategoriaNegocio();
        private Categoria categoria = null;
        Validaciones validar = new Validaciones();
        Excepcion error = new Excepcion();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadoCampos(true);
            txtCategoria.Text = "";
            txtCategoria.Focus();
            categoria = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(dgvCategorias.CurrentCell is null))
            {
                categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                estadoCampos(true);
                txtCategoria.Focus();
            }
            else MessageBox.Show("No hay ningún elemento seleccionado", "Modificar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoCampos(false);
            llenarGrilla();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            estadoCampos(false);
        }
        private void llenarGrilla()
        {
            try
            {
                listaCategorias = Negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
                formatearGrilla();
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }

        }

        private void formatearGrilla()
        {
            dgvCategorias.Columns["Id"].Visible = false;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategorias.Columns["Descripcion"].Width = 200;
        }

        private void estadoCampos(bool estado)
        {
            dgvCategorias.Enabled = !estado;
            gpbCategoria.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }
        private void LlenarCampos()
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                txtCategoria.Text = seleccionado.descripcion;
            }

        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria categoria = new Categoria();
            if (!((dgvCategorias.CurrentCell is null)))
            {
                try
                {
                    categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    if (negocio.VerificarArticulos(categoria.id) > 0)
                    {
                        MessageBox.Show("No se puede eliminar la categoria porque está utilizada por artículos", "Eliminar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminar la categoría: " + categoria.descripcion + "?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(categoria.id);
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
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (validar.validarTextoRequerido(txtCategoria.Text))
                {
                    MessageBox.Show("La Categoría no puede estar vacía","Categorías",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    txtCategoria.Focus();
                }
                else
                {
                    if (categoria == null)
                        categoria = new Categoria();
                    categoria.descripcion = txtCategoria.Text;

                    if (categoria.id != 0)
                    {
                        negocio.modificar(categoria);

                    }
                    else
                    {
                        negocio.agregar(categoria);

                    }
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
