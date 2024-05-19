using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var fechaEntrada = FechaEntrada.Text;
            var fechaFacrtura = FechaFactura.Text;
            var follo = FolloFactura.Text;
            var nombreProveedor = NombreProveedor.Text;
            var articulo = Articulo.Text;
            var cantidad = Cantidad.Text;
            var precio = Precio.Text;

            tabla.Rows.Add(fechaEntrada, fechaFacrtura, follo, nombreProveedor, articulo, cantidad, precio);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
