using System.Data.Odbc;
using CapaModelo_Seguridad;

namespace CapaControlador_Seguridad
{
    public class Cls_Controlador_Bodega
    {
        Cls_Sentencias_Bodega modelo = new Cls_Sentencias_Bodega();

        public OdbcDataAdapter consultarBodegas()
        {
            return modelo.consultarBodegas();
        }

        public void insertarBodega(string codigo, string nombre, string estatus)
        {
            modelo.insertarBodega(codigo, nombre, estatus);
        }

        public void actualizarBodega(string codigo, string nombre, string estatus)
        {
            modelo.actualizarBodega(codigo, nombre, estatus);
        }

        public void eliminarBodega(string codigo)
        {
            modelo.eliminarBodega(codigo);
        }
    }
}
