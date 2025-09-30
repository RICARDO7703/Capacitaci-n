namespace CapaVista_Seguridad
{
    partial class Bodegas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Btn_Actuali = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Dgv_registros = new System.Windows.Forms.DataGridView();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Estatus = new System.Windows.Forms.TextBox();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Estatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(21, 33);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(163, 40);
            this.Btn_Consultar.TabIndex = 0;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Location = new System.Drawing.Point(217, 33);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(163, 40);
            this.Btn_Insertar.TabIndex = 1;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Btn_Actuali
            // 
            this.Btn_Actuali.Location = new System.Drawing.Point(404, 33);
            this.Btn_Actuali.Name = "Btn_Actuali";
            this.Btn_Actuali.Size = new System.Drawing.Size(163, 40);
            this.Btn_Actuali.TabIndex = 2;
            this.Btn_Actuali.Text = "Actualizar";
            this.Btn_Actuali.UseVisualStyleBackColor = true;
            this.Btn_Actuali.Click += new System.EventHandler(this.Btn_Actuali_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(603, 33);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(163, 40);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Dgv_registros
            // 
            this.Dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_registros.Location = new System.Drawing.Point(42, 200);
            this.Dgv_registros.Name = "Dgv_registros";
            this.Dgv_registros.RowHeadersWidth = 51;
            this.Dgv_registros.RowTemplate.Height = 24;
            this.Dgv_registros.Size = new System.Drawing.Size(724, 220);
            this.Dgv_registros.TabIndex = 4;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(130, 120);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(150, 22);
            this.Txt_Codigo.TabIndex = 5;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(400, 120);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 22);
            this.Txt_Nombre.TabIndex = 6;
            // 
            // Txt_Estatus
            // 
            this.Txt_Estatus.Location = new System.Drawing.Point(676, 120);
            this.Txt_Estatus.Name = "Txt_Estatus";
            this.Txt_Estatus.Size = new System.Drawing.Size(90, 22);
            this.Txt_Estatus.TabIndex = 7;
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(39, 123);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Codigo.TabIndex = 8;
            this.Lbl_Codigo.Text = "Cod. Bodega:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(325, 123);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(57, 16);
            this.Lbl_Nombre.TabIndex = 9;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Lbl_Estatus
            // 
            this.Lbl_Estatus.AutoSize = true;
            this.Lbl_Estatus.Location = new System.Drawing.Point(620, 123);
            this.Lbl_Estatus.Name = "Lbl_Estatus";
            this.Lbl_Estatus.Size = new System.Drawing.Size(54, 16);
            this.Lbl_Estatus.TabIndex = 10;
            this.Lbl_Estatus.Text = "Estatus:";
            // 
            // Bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Estatus);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Txt_Estatus);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Dgv_registros);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actuali);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.Btn_Consultar);
            this.Name = "Bodegas";
            this.Text = "Bodegas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_Actuali;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridView Dgv_registros;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Estatus;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Estatus;
    }
}
