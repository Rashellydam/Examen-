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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            var codigo = Codigo.Text;
            var razonSocial = RazonSocial.Text;
            var primerNOmbre = PrimerNombre.Text;
            var segundoNombre = SegundoNombre.Text;
            var primerApellido = PrimerApellido.Text;
            var segundoApellido = SegundoApellido.Text;
            var telefono = Telefono.Text;
            var tipo = Tipo.Text;
            var direccion = Direccion.Text;
            var atencion = Atencion.Text;
            var diasVencimiento = DiasVencimientos.Text;
            var zona = Zona.Text;
            var cobrador = Cobrar.Text;
            var aportes = Aportes.Text;
            var aval = Aval.Text;
            var avalCodigo = CodigoAval.Text;
            var avalDireccion = DireccionAval.Text;
            var avalTelefono = TelefonoAval.Text;

            Tabla.Rows.Add(codigo, razonSocial, primerNOmbre, segundoNombre, primerApellido, segundoApellido, telefono, tipo, direccion, atencion, diasVencimiento, zona, cobrador, aportes, aval, avalCodigo, avalDireccion, avalTelefono);

        }
    }
}
