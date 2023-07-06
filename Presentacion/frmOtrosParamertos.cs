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
using Negocio;
using System.IO;
using System.Runtime.Remoting.Channels;
using Ayudas;

namespace Presentacion
{
    public partial class frmOtrosParamertos : Form
    {
        private OpenFileDialog archivo = null;
        private FolderBrowserDialog carpeta = null;
        Excepcion error = new Excepcion();
        public frmOtrosParamertos()
        {
            InitializeComponent();
        }

        private void frmOtrosParamertos_Load(object sender, EventArgs e)
        {
            txtLogo.Text = ConfigurationManager.AppSettings["logo"];
            txtImages.Text = ConfigurationManager.AppSettings["images"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {

                if (config.AppSettings.Settings.Count <= 4)
                {
                    config.AppSettings.Settings.Add("logo", txtLogo.Text);
                    config.AppSettings.Settings.Add("images", txtImages.Text);

                }
                else
                {
                    config.AppSettings.Settings["logo"].Value = txtLogo.Text;
                    config.AppSettings.Settings["images"].Value = txtImages.Text;
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                error.excepcionGeneral(ex.ToString());
            }
            finally
            {
                Close();
            }
            

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = archivo.FileName;
                
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                txtImages.Text = carpeta.SelectedPath;
            }
        }
    }
}
