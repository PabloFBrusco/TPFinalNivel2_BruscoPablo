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
using System.Configuration;
using Ayudas;

namespace Presentacion
{
    public partial class frmSetearConexion : Form
    {
        string servidor, basedatos, usuario, pasword;
        AccesoDatos datos;
        Excepcion error = new Excepcion();

        public frmSetearConexion()
        {
            InitializeComponent();
        }
        private void frmSetearConexion_Load(object sender, EventArgs e)
        {
            TxtServidor.Text = ConfigurationManager.AppSettings["server"];
            TxtBase.Text = ConfigurationManager.AppSettings["db"];
            TxtUsuario.Text = ConfigurationManager.AppSettings["user"];
            TxtPass.Text = ConfigurationManager.AppSettings["pass"];
            TxtPass.UseSystemPasswordChar = true;
        }
        public void establecerConexion()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];
            ConfigurationManager.AppSettings.Set("server", TxtServidor.Text);
            datos = new AccesoDatos(servidor, basedatos, usuario, pasword);
        }
        private void BtnTestear_Click(object sender, EventArgs e)
        {
            try
            {
                datos = new AccesoDatos(TxtServidor.Text, TxtBase.Text, TxtUsuario.Text, TxtPass.Text);
                datos.probarConexion();
                MessageBox.Show("La conexión se estableció correctamente", "Probar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.excepcionSqlClient();

            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (btnver.Text == "Ver datos")
            {
                TxtPass.UseSystemPasswordChar = false;
                btnver.Text = "Ocultar";
            }
            else
            {
                TxtPass.UseSystemPasswordChar = true;
                btnver.Text = "Ver datos";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                datos = new AccesoDatos(TxtServidor.Text, TxtBase.Text, TxtUsuario.Text, TxtPass.Text);
                datos.probarConexion();
 
                if (config.AppSettings.Settings.Count < 4)
                {
                    config.AppSettings.Settings.Add("server", TxtServidor.Text);
                    config.AppSettings.Settings.Add("db", TxtBase.Text);
                    config.AppSettings.Settings.Add("user", TxtUsuario.Text);
                    config.AppSettings.Settings.Add("pass", TxtPass.Text);
                }
                else
                {
                    config.AppSettings.Settings["server"].Value = TxtServidor.Text;
                    config.AppSettings.Settings["db"].Value = TxtBase.Text;
                    config.AppSettings.Settings["user"].Value = TxtUsuario.Text;
                    config.AppSettings.Settings["pass"].Value = TxtPass.Text;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Datos grabados exitosamente", "Setear Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                error.excepcionSqlClient();
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
