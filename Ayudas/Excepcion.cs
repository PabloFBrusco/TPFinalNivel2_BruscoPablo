using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime;
using System.Windows.Forms;

namespace Ayudas
{
    public class Excepcion
    {
        public void excepcionSqlClient()
        {
                MessageBox.Show("No se pudo conectar a la base. Revise los parámetros", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void excepcionGeneral(string error)
        {
            MessageBox.Show("Se produjo un error en el sistema\n\r Conectese con el administrador\n\r " + error,"Error del sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void excepcionReferenciaNula()
        {
            MessageBox.Show("No hay datos seleccionados", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}