using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad
{
    public class Cls_Sentencias_Bodega
    {
        Conexion con = new Conexion();

        // CONSULTAR → llenar DataGrid con bodegas
        public OdbcDataAdapter consultarBodegas()
        {
            string sql = "SELECT * FROM bodegas;";
            OdbcDataAdapter da = new OdbcDataAdapter(sql, con.conexion());
            return da;
        }

        // INSERTAR
        public void insertarBodega(string codigo, string nombre, string estatus)
        {
            string sql = $"INSERT INTO bodegas (codigo_bodega, nombre_bodega, estatus_bodega) " +
                         $"VALUES ('{codigo}', '{nombre}', '{estatus}');";
            ejecutarComando(sql);
        }

        // ACTUALIZAR
        public void actualizarBodega(string codigo, string nombre, string estatus)
        {
            string sql = $"UPDATE bodegas SET nombre_bodega='{nombre}', estatus_bodega='{estatus}' " +
                         $"WHERE codigo_bodega='{codigo}';";
            ejecutarComando(sql);
        }

        // ELIMINAR
        public void eliminarBodega(string codigo)
        {
            string sql = $"DELETE FROM bodegas WHERE codigo_bodega='{codigo}';";
            ejecutarComando(sql);
        }

        // Método genérico para ejecutar comandos (INSERT, UPDATE, DELETE)
        private void ejecutarComando(string sql)
        {
            using (OdbcCommand cmd = new OdbcCommand(sql, con.conexion()))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
