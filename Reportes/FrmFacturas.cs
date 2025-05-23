using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace Reportes
{
    public partial class FrmFacturas : Form
    {
        Connec con = new Connec();
        int idSeleccionado = -1;

        public FrmFacturas()
        {
            InitializeComponent();
            CargarFacturas();
        }
        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtCategoria.Clear();
            numCantidad.Value = 1;
            txtPrecioUnitario.Clear();
            txtItebis.Clear();
            txtDescuento.Clear();
            idSeleccionado = -1;
        }

        private void CargarFacturas()
        {
            using (SqlConnection conn = con.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Facturas", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFacturas.DataSource = dt;
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = con.Conectar())
            {
                string query = "INSERT INTO Facturas (Descripcion, Categoria, Cantidad, Precio_Unitario, Itebis, Descuento) " +
                               "VALUES (@desc, @cat, @cant, @pu, @itb, @descue)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@cant", Convert.ToInt32(numCantidad.Value));
                cmd.Parameters.AddWithValue("@pu", Convert.ToDecimal(txtPrecioUnitario.Text));
                cmd.Parameters.AddWithValue("@itb", Convert.ToDecimal(txtItebis.Text));
                cmd.Parameters.AddWithValue("@descue", Convert.ToDecimal(txtDescuento.Text));
                cmd.ExecuteNonQuery();
            }
            CargarFacturas();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == -1) return;

            using (SqlConnection conn = con.Conectar())
            {
                string query = "UPDATE Facturas SET Descripcion=@desc, Categoria=@cat, Cantidad=@cant, " +
                               "Precio_Unitario=@pu, Itebis=@itb, Descuento=@descue WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@cant", Convert.ToInt32(numCantidad.Value));
                cmd.Parameters.AddWithValue("@pu", Convert.ToDecimal(txtPrecioUnitario.Text));
                cmd.Parameters.AddWithValue("@itb", Convert.ToDecimal(txtItebis.Text));
                cmd.Parameters.AddWithValue("@descue", Convert.ToDecimal(txtDescuento.Text));
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
            }
            CargarFacturas();
            Limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (idSeleccionado == -1) return;

            using (SqlConnection conn = con.Conectar())
            {
                string query = "DELETE FROM Facturas WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
            }
            CargarFacturas();
            Limpiar();
        }


        private void GenerarPDF(SqlDataReader reader, string path)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            Font fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Font fontBody = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            doc.Add(new Paragraph("FACTURA", fontTitle));
            doc.Add(new Paragraph(" ")); // espacio

            doc.Add(new Paragraph($"ID: {reader["ID"]}", fontBody));
            doc.Add(new Paragraph($"Descripción: {reader["Descripcion"]}", fontBody));
            doc.Add(new Paragraph($"Categoría: {reader["Categoria"]}", fontBody));
            doc.Add(new Paragraph($"Cantidad: {reader["Cantidad"]}", fontBody));
            doc.Add(new Paragraph($"Precio Unitario: {reader["Precio_Unitario"]}", fontBody));
            doc.Add(new Paragraph($"ITBIS: {reader["Itebis"]}", fontBody));
            doc.Add(new Paragraph($"Descuento: {reader["Descuento"]}", fontBody));

            decimal cantidad = Convert.ToDecimal(reader["Cantidad"]);
            decimal precio = Convert.ToDecimal(reader["Precio_Unitario"]);
            decimal itbis = Convert.ToDecimal(reader["Itebis"]);
            decimal descuento = Convert.ToDecimal(reader["Descuento"]);
            decimal total = (cantidad * precio + itbis) - descuento;

            doc.Add(new Paragraph($"Total: {total:C}", fontBody));

            doc.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona una factura primero.");
                return;
            }

            using (SqlConnection conn = con.Conectar())
            {
                // No hagas conn.Open() aquí porque ya está abierta
                SqlCommand cmd = new SqlCommand("SELECT * FROM Facturas WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "PDF file|*.pdf";
                        saveFileDialog.Title = "Guardar factura como PDF";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string path = saveFileDialog.FileName;
                            GenerarPDF(reader, path);
                            MessageBox.Show("Factura generada correctamente.");
                        }
                    }
                }
            }
        }


        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFacturas.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["ID"].Value);
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                numCantidad.Value = Convert.ToInt32(row.Cells["Cantidad"].Value);
                txtPrecioUnitario.Text = row.Cells["Precio_Unitario"].Value.ToString();
                txtItebis.Text = row.Cells["Itebis"].Value.ToString();
                txtDescuento.Text = row.Cells["Descuento"].Value.ToString();
            }
        }
    }
}
