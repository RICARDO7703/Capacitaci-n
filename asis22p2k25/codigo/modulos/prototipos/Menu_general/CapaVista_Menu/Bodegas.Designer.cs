
namespace CapaVista_Seguridad
{
    partial class Bodegas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Bodegas
            // 
            this.ClientSize = new System.Drawing.Size(448, 74);
            this.Name = "Bodegas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_Actuali;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView Dgv_registros;
    }
}