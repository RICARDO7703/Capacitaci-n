using System;
using System.Data;
using System.Data.Odbc;              // Necesario para OdbcDataAdapter y DataTable
using System.Windows.Forms;
using CapaControlador_Menu;     // Para usar Cls_Controlador_Bodega

namespace CapaVista_Seguridad
{
    public partial class Bodegas : Form
    {
        Cls_Controlador_Bodega ctrl = new Cls_Controlador_Bodega();

        public Bodegas()
        {
            InitializeComponent();
        }

        // Método para llenar el DataGridView
        private void llenarGrid()
        {
            OdbcDataAdapter da = ctrl.consultarBodegas();
            DataTable dt = new DataTable();
            da.Fill(dt);
            Dgv_registros.DataSource = dt;
        }

        // INSERTAR
        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            ctrl.insertarBodega(Txt_Codigo.Text, Txt_Nombre.Text, Txt_Estatus.Text);
            llenarGrid();
        }

        // CONSULTAR
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        // ACTUALIZAR
        private void Btn_Actuali_Click(object sender, EventArgs e)
        {
            ctrl.actualizarBodega(Txt_Codigo.Text, Txt_Nombre.Text, Txt_Estatus.Text);
            llenarGrid();
        }

        // ELIMINAR
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            ctrl.eliminarBodega(Txt_Codigo.Text);
            llenarGrid();
        }
    }
}
