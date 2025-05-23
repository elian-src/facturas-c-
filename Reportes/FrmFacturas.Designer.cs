namespace Reportes
{
    partial class FrmFacturas
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtItebis = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.bD_FacturacionPruebasDataSet = new Reportes.BD_FacturacionPruebasDataSet();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FacturacionPruebasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(630, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(630, 40);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(158, 22);
            this.txtCategoria.TabIndex = 0;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(630, 96);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(158, 22);
            this.txtPrecioUnitario.TabIndex = 0;
            // 
            // txtItebis
            // 
            this.txtItebis.Location = new System.Drawing.Point(630, 124);
            this.txtItebis.Name = "txtItebis";
            this.txtItebis.Size = new System.Drawing.Size(158, 22);
            this.txtItebis.TabIndex = 0;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(630, 152);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(158, 22);
            this.txtDescuento.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(694, 68);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(94, 22);
            this.numCantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(627, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(648, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(648, 259);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 50);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(648, 315);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(648, 371);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 50);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(-2, -1);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersWidth = 51;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(623, 507);
            this.dgvFacturas.TabIndex = 4;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellClick);
            // 
            // bD_FacturacionPruebasDataSet
            // 
            this.bD_FacturacionPruebasDataSet.DataSetName = "BD_FacturacionPruebasDataSet";
            this.bD_FacturacionPruebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(648, 427);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(122, 50);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(795, 503);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtItebis);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "FrmFacturas";
            this.Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FacturacionPruebasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtItebis;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private BD_FacturacionPruebasDataSet bD_FacturacionPruebasDataSet;
        private System.Windows.Forms.Button btnImprimir;
    }
}

