using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace VentasDeEmpleado
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            var conn = new OdbcConnection("Dsn=ventasemp");
            try
            {
                conn.Open();
                return conn;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error de conexión ODBC:\n" + ex.Message,
                                "Conexión ODBC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; //no siga con una conexión cerrada
            }
        }

        public void desconexion(OdbcConnection conn)
        {
            try { conn?.Close(); }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cerrar la conexión:\n" + ex.Message,
                                "Conexión ODBC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
