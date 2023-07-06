using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Xml.Linq;
using System.IO;
using Ayudas;


namespace Presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        ArticuloNegocio Negocio = new ArticuloNegocio();
        CategoriaNegocio CatNegocio = new CategoriaNegocio();
        MarcaNegocio MarNegocio = new MarcaNegocio();
        Validaciones validar = new Validaciones();
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        Excepcion error = new Excepcion();
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombo(cboCategoria, "Categoria");
                cargarCombo(cboMarca, "Marca");
                cargarComboFiltro(cboFCategoria);
                cargarComboFiltro(cboFCodigo);
                cargarComboFiltro(cboFDescripcion);
                cargarComboFiltro(cboFMarca);
                cargarComboFiltro(cboFNombre);
                cargarComboFiltro(cboFPrecio);
                estadoFiltros();
                llenarGrilla();
                estadoCampos(false);
                cargarLogo();
                VerRequeridos(false);
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }
        }

        private void VerRequeridos(bool estado)
        {
            LblRCategoria.Visible = estado;
            LblRCodigo.Visible = estado;
            LblRMarca.Visible = estado;
            LblRNombre.Visible = estado;
            LblRPrecio.Visible = estado;
        }

        private void llenarGrilla()
        {
            try
            {
                listaArticulos = Negocio.filtrar(armarCadena());
                dgvArticulos.DataSource = listaArticulos;
                formatearGrilla();
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }

        }

        private void formatearGrilla()
        {
            dgvArticulos.Columns["imagen"].Visible = false;
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArticulos.Columns["Codigo"].Width = 60;
            dgvArticulos.Columns["Nombre"].Width = 200;
            dgvArticulos.Columns["Descripcion"].Width = 200;
            dgvArticulos.Columns["Precio"].Width = 80;
            dgvArticulos.Columns["Categoria"].Width = 80;
            dgvArticulos.Columns["Marca"].Width = 80;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "c";
        }

        private void estadoCampos(bool estado)
        {
            dgvArticulos.Enabled = !estado;
            gpbFiltro.Enabled = !estado;
            gpbArticulos.Enabled = estado;
            btnAgregar.Enabled = !estado;
            btnModificar.Enabled = !estado;
            btnEliminar.Enabled = !estado;
            txtFiltroRapido.Enabled = !estado;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoCampos(false);
            txtFiltroRapido.Text = "";
            llenarGrilla();
            VerRequeridos(false);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                ptbFoto.Load(imagen);
            }
            catch (Exception)
            {
                ptbFoto.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg?w=740");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            LlenarCampos();
                
        }
        private void LlenarCampos()
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.imagen);
                txtCodigo.Text = seleccionado.codigo;
                txtNombre.Text = seleccionado.nombre;
                txtDescripcion.Text = seleccionado.descripcion;
                txtLinkFoto.Text = seleccionado.imagen;
                txtPrecio.Text = seleccionado.precio.ToString();
                cboCategoria.SelectedValue = seleccionado.categoria.id;
                cboMarca.SelectedValue = seleccionado.marca.id;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estadoCampos(true);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtLinkFoto.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            ptbFoto.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg?w=740");
            txtCodigo.Focus();
            articulo = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(dgvArticulos.CurrentCell is null))
            {
                articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                estadoCampos(true);
                txtCodigo.Focus();
            }
            else MessageBox.Show("No hay ningún elemento seleccionado", "Modificar Artículo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ptbLogo_DoubleClick(object sender, EventArgs e)
        {
            frmOtrosParamertos Formulario = new frmOtrosParamertos();
            Formulario.ShowDialog ();
            cargarLogo();
        }

        private void ptbLogo_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.ptbLogo, "Haga Doble Click para Insertar su logo");
        }

        private void cargarLogo()
        {
            try
            {
                ptbLogo.Load(ConfigurationManager.AppSettings["logo"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe elegir una imagen válida para el logo de la empresa","Insertar Logo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                ptbLogo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                
            }
            
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            int elegido;
            if (!(cboCategoria.SelectedValue is null))
            {
                elegido = int.Parse(cboCategoria.SelectedValue.ToString());
            }
            else elegido = 0;
            frmCategorias Formulario = new frmCategorias();
            Formulario.ShowDialog();
            cargarCombo(cboCategoria, "Categoria");
            cboCategoria.SelectedValue = elegido;
        }
        private void cargarCombo(ComboBox combo, string item)
        {
            combo.DataSource = null;
            combo.Items.Clear();
            if (item == "Categoria")
            {
                combo.DataSource = CatNegocio.listar();
            }
            else
            {
                combo.DataSource = MarNegocio.listar();
            }
            
            combo.ValueMember = "Id";
            combo.DisplayMember = "Descripcion";
        }
        private void cargarComboFiltro (ComboBox combo)
        {
            combo.Items.Clear();
            if (combo.Name == "cboFPrecio")
            {
                combo.Items.Add("Mayor a");
                combo.Items.Add("Menor a");
                combo.Items.Add("Igual a");
            }
            else
            {
                combo.Items.Add("Empieza con");
                combo.Items.Add("Termina con");
                combo.Items.Add("Contiene");
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            int elegido;
            if (!(cboMarca.SelectedValue is null))
            {
                elegido = int.Parse(cboMarca.SelectedValue.ToString());
            }
            else elegido = 0;
            
            frmMarcas Formulario = new frmMarcas();
            Formulario.ShowDialog();
            cargarCombo(cboMarca, "Marca");
            cboMarca.SelectedValue = elegido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            int fila = 0;
            bool requeridos = false;

            if (validar.validarTextoRequerido(txtNombre.Text))
            {
                requeridos = true;
                LblRNombre.Visible = true;
            }
            else LblRNombre.Visible = false;
            if (validar.validarTextoRequerido(txtCodigo.Text))
            {
                requeridos = true;
                LblRCodigo.Visible = true;
            }
            else LblRCodigo.Visible = false;

            if (!(validar.validarNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Debe ingresar un dato numérico en el Precio", "Ingresar Precio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LblRPrecio.Visible = true;
                requeridos = true;
            }
            else LblRPrecio.Visible = false;
            if (validar.validarComboRequerido(cboMarca.SelectedIndex.ToString()))
            {
                requeridos = true;
                LblRMarca.Visible = true;
            }
            else LblRMarca.Visible = false;
            if (validar.validarComboRequerido(cboCategoria.SelectedIndex.ToString()))
            {
                requeridos = true;
                LblRCategoria.Visible = true;
            }
            else LblRCategoria.Visible = false;

            if (requeridos)
            {
                MessageBox.Show("Debe completar los campos indicados con '*'", "Completar Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (articulo == null)
                        articulo = new Articulo();

                    articulo.codigo = txtCodigo.Text;
                    articulo.descripcion = txtDescripcion.Text;
                    articulo.nombre = txtNombre.Text;
                    articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                    articulo.marca = (Marca)cboMarca.SelectedItem;
                    articulo.imagen = txtLinkFoto.Text;
                    articulo.precio = float.Parse(txtPrecio.Text);

                    if (articulo.id != 0)
                    {
                        fila = dgvArticulos.CurrentRow.Index;
                        negocio.modificar(articulo);

                    }
                    else
                    {
                        negocio.agregar(articulo);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            Articulo articulo = new Articulo();
            if (!((dgvArticulos.CurrentCell is null)))
            {
                try
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminar el artículo: " + articulo.nombre + "?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminar(articulo.id);
                        llenarGrilla();
                    }
                }
                catch (Exception ex)
                {
                    error.excepcionGeneral(ex.ToString());
                }

            }
            else MessageBox.Show("No hay ningún elemento seleccionado", "Eliminar Artículo", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            //string nombreArchivo;
            string ruta = ConfigurationManager.AppSettings["images"];
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtLinkFoto.Text = archivo.FileName;
            }
            txtLinkFoto.Focus();

        }
        private void txtLinkFoto_Leave(object sender, EventArgs e)
        {
            string nombreArchivo;
            string ruta = ConfigurationManager.AppSettings["images"];
            CargarImagen(txtLinkFoto.Text);
            if (!(ptbFoto.ImageLocation == "https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg?w=740"))
            {
                archivo = new OpenFileDialog();
                archivo.FileName = txtLinkFoto.Text;
                nombreArchivo = archivo.SafeFileName;
                if (!(ruta == ""))
                {
                    if (archivo != null && !(txtLinkFoto).Text.ToUpper().Contains("HTTP"))
                    {
                        DialogResult respuesta = MessageBox.Show("¿Desea guardar una copia del archivo: " + nombreArchivo + " en la carpeta " + ruta + "?", "Guardar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            if (!(File.Exists(ruta + "\\" + nombreArchivo)))
                            {
                                File.Copy(archivo.FileName, ruta + "\\" + nombreArchivo);
                            }
                            txtLinkFoto.Text = ruta + "\\" + nombreArchivo;
                        }
                    }
                }
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro;
            try
            {
                filtro = txtFiltroRapido.Text;
                if (filtro.Length > 0)
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.codigo.ToUpper().Contains(filtro.ToUpper()) || x.nombre.ToUpper().Contains(filtro.ToUpper()) || x.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.marca.descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulos;
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                formatearGrilla();
            }
            catch (Exception ex)
            {

                error.excepcionGeneral(ex.ToString());
            }
            
        }

        private void limpiarFiltros()
        {
            chkCategoria.Checked = false;
            chkCodigo.Checked = false;
            chkDescripcion.Checked = false;
            chkMarca.Checked = false;
            chkNombre.Checked = false;
            chkPrecio.Checked = false;

            txtFCodigo.Text = "";
            txtFCategoria.Text = "";
            txtFDescripcion.Text = "";
            txtFMarca.Text = "";
            txtFNombre.Text = "";
            txtFPrecio.Text = "";

            cboFCategoria.SelectedValue = -1;
            cboFCodigo.SelectedValue = -1;
            cboFDescripcion.SelectedValue = -1;
            cboFMarca.SelectedValue = -1;
            cboFNombre.SelectedValue = -1;
            cboFPrecio.SelectedValue = -1;

        }

        private void estadoFiltros()
        {
            txtFCodigo.Enabled = false;
            txtFCategoria.Enabled = false;
            txtFDescripcion.Enabled = false;
            txtFMarca.Enabled = false;
            txtFNombre.Enabled = false;
            txtFPrecio.Enabled = false;

            cboFCategoria.Enabled = false;
            cboFCodigo.Enabled = false;
            cboFDescripcion.Enabled = false;
            cboFMarca.Enabled = false;
            cboFNombre.Enabled = false;
            cboFPrecio.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            txtFiltroRapido.Text = "";
            llenarGrilla();
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            string cadena;
            bool estado = false;
            if (validar.validarFiltro(cboFCodigo.SelectedIndex.ToString(), chkCodigo.Checked, txtFCodigo.Text))
            {
                estado = true;
            }
            else if (validar.validarFiltro(cboFNombre.SelectedIndex.ToString(), chkNombre.Checked, txtFNombre.Text))
            {
                estado = true;
            }
            else if (validar.validarFiltro(cboFDescripcion.SelectedIndex.ToString(), chkDescripcion.Checked, txtFDescripcion.Text))
            {
                estado = true;
            }
            else if (validar.validarFiltro(cboFCategoria.SelectedIndex.ToString(), chkCategoria.Checked, txtFCategoria.Text))
            {
                estado = true;
            }
            else if (validar.validarFiltro(cboFMarca.SelectedIndex.ToString(), chkMarca.Checked, txtFMarca.Text))
            {
                estado = true;
            }
            if (validar.validarFiltro(cboFPrecio.SelectedIndex.ToString(), chkPrecio.Checked, txtFPrecio.Text))
            {
                estado = true;

            }
            if (chkPrecio.Checked)
            {
                if (!(validar.validarNumeros(txtFPrecio.Text)))
                {
                    MessageBox.Show("Debe ingresar un dato numérico", "Ingresar Precio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtFPrecio.Focus();
                    estado = true;
                }
            }
            
            if (estado)
            {
                    MessageBox.Show("Debe completar criterios y filtros seleccionados", "Filtrar Grilla", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                txtFiltroRapido.Text = "";
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    cadena = armarCadena();
                    llenarGrilla();
                }
                catch (Exception ex)
                {

                    error.excepcionGeneral(ex.ToString());
                }
            }
            
        }
        public string armarCadena()
        {
            string cadena;
            bool filtro = false;
            cadena = "";
            cadena = "Select a.Id, a.Codigo, a.Nombre, a.descripcion, a.IdMarca, a.IdCategoria, a.ImagenUrl, a.precio, c.Descripcion Categoria, m.Descripcion Marca\r\nfrom Articulos a \r\ninner join Categorias C on a.IdCategoria = c.Id \r\ninner join Marcas M on a.IdMarca = m.Id ";
            if (chkCodigo.Checked) 
            {
                filtro = true;
                cadena = cadena + "where a.codigo" + generarCriterio("codigo", cboFCodigo, txtFCodigo);
            } 
            if (chkPrecio.Checked)
            {
                if (filtro)
                {
                    cadena = cadena + " and a.precio" + generarCriterio("precio", cboFPrecio, txtFPrecio);
                }
                else
                {
                    filtro = true;
                    cadena = cadena + " where a.precio" + generarCriterio("precio", cboFPrecio, txtFPrecio);
                }
            }
            if (chkNombre.Checked)
            {
                if (filtro)
                {
                    cadena = cadena + " and a.nombre" + generarCriterio("nombre", cboFNombre, txtFNombre);
                }
                else
                {
                    filtro = true;
                    cadena = cadena + " where a.nombre" + generarCriterio("nombre", cboFNombre, txtFNombre);
                }
            }
            if (chkDescripcion.Checked)
            {
                if (filtro)
                {
                    cadena = cadena + " and a.descripcion" + generarCriterio("descripcion", cboFDescripcion, txtFDescripcion);
                }
                else
                {
                    filtro = true;
                    cadena = cadena + " where a.descripcion" + generarCriterio("descripcion", cboFDescripcion, txtFDescripcion);
                }
            }
            if (chkMarca.Checked)
            {
                if (filtro)
                {
                    cadena = cadena + " and m.descripcion" + generarCriterio("marca", cboFMarca, txtFMarca);
                }
                else
                {
                    filtro = true;
                    cadena = cadena + " where m.descripcion" + generarCriterio("marca", cboFMarca, txtFMarca);
                }
            }
            if (chkCategoria.Checked)
            {
                if (filtro)
                {
                    cadena = cadena + " and c.descripcion" + generarCriterio("categoria", cboFCategoria, txtFCategoria);
                }
                else
                {
                    filtro = true;
                    cadena = cadena + " where c.descripcion" + generarCriterio("categoria", cboFCategoria, txtFCategoria);
                }
            }
            cadena = cadena + " order by a.codigo";

            return cadena;
        }
        private string generarCriterio(string chek, ComboBox combo, TextBox filtro)
        {
            string criterio = "";
            if (chek == "precio")
            {
                if (combo.SelectedItem.ToString() == "Mayor a")
                {
                    criterio = " > " + filtro.Text;
                }
                else if (combo.SelectedItem.ToString() == "Menor a")
                {
                    criterio = " < " + filtro.Text;
                }
                else
                {
                    criterio = " = " + filtro.Text;
                }
            }
            else
            {
                if (combo.SelectedItem.ToString() == "Empieza con")
                {
                    criterio = " like '" + filtro.Text + "%'";
                }
                else if (combo.SelectedItem.ToString() == "Termina con")
                {
                    criterio = " like '%" + filtro.Text + "'";
                }
                else
                {
                    criterio = " like '%" + filtro.Text + "%'";
                }
            }
            return criterio;
        }

        private void cambiarEstadoFiltro (bool estado, ComboBox combo, TextBox filtro)
        {
            if (estado == false)
            {
                filtro.Text = "";
                cargarComboFiltro(combo);
            }
            combo.Enabled = estado;
            filtro.Enabled = estado;

        }

        private void chkCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCodigo.Checked)
               cambiarEstadoFiltro(false, cboFCodigo, txtFCodigo);
            else
                cambiarEstadoFiltro(true, cboFCodigo, txtFCodigo);
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNombre.Checked)
                cambiarEstadoFiltro(false, cboFNombre, txtFNombre);
            else
                cambiarEstadoFiltro(true, cboFNombre, txtFNombre);
        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkDescripcion.Checked)
                cambiarEstadoFiltro(false, cboFDescripcion, txtFDescripcion);
            else
                cambiarEstadoFiltro(true, cboFDescripcion, txtFDescripcion);
        }

        private void chkPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPrecio.Checked)
                cambiarEstadoFiltro(false, cboFPrecio, txtFPrecio);
            else
                cambiarEstadoFiltro(true, cboFPrecio, txtFPrecio);
        }

        private void chkMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMarca.Checked)
                cambiarEstadoFiltro(false, cboFMarca, txtFMarca);
            else
                cambiarEstadoFiltro(true, cboFMarca, txtFMarca);
        }

        private void chkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCategoria.Checked)
                cambiarEstadoFiltro(false, cboFCategoria, txtFCategoria);
            else
                cambiarEstadoFiltro(true, cboFCategoria, txtFCategoria);
        }

    }
}
