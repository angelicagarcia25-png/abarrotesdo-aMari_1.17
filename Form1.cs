using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace abarrotesdoñaMari_1._17
{
    public partial class Form1 : Form
    {
        //Lista para guardar los productos en memoria.
        List<Producto> listaProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheeets.Add("Inventario");
                worksheet.Cell(1, 1).Value = "Nombre";
                worksheet.Cell(1, 2).Value = "Precio";
                worksheet.Cell(1, 3).Value = "Existencia";

                for (int i = 0; i < listaProductos.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = listaProductos[i].nombre;
                    worksheet.Cell(i + 2, 2).Value = listaProductos[i].precio;
                    worksheet.Cell(i + 2, 3).Value = listaProductos[i].existencia;
                }

                SaveFileDialog sdf = new SaveFileDialog();
                sdf.Filter = "Excel |*.xlsx";
                sdf.FileName = "InventarioSimilares.xlsx";
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sdf.FileName);
                    MessageBox.Show("Exportado con éxito en excel");
                }
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public class Producto
        {
            public string nombre { get; set; }
            public decimal precio { get; set; }
            public int existencia { get; set; }

            public Producto() { }

            public Producto(string nombre, decimal precio, int existencia)
            {
                this.nombre = nombre;
                this.precio = precio;
                this.existencia = existencia;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        //Evento en el boton "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevo = new Producto()
            {
                nombre = txtNombre.Text,
                precio = decimal.Parse(txtPrecio.Text),
                existencia = int.Parse(txtExistencia.Text)
            };
            listaProductos.Add(nuevo);
            MostrarProductos();
            LimpiarCampos();

            //Te manda a ver la tabla (tabepage2) automaticamente
            TabControl1.SelectedTab = TabTabla;
        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            txtNombre.Focus();
        }

        private void VerificarAgotados()
        {
            foreach (var p in listaProductos)
            {
                if (p.existencia == 0)
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = $"Agotado! {p.nombre}";
                    MessageBox.Show($"{p.nombre} esta agotado", "Aviso");
                    return;
                }
            }

            lblAviso.ForeColor = Color.Green;
            lblAviso.Text = "Producto Registrado Correctamente";
        }

    }
}