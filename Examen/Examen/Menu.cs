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
    public partial class Menu : Form
    {
        Inventario inventario = new Inventario();
        Proveedor proveedor = new Proveedor();

        public Menu()
        {
            InitializeComponent();
        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventario.ShowDialog();
            this.Show();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            proveedor.ShowDialog();
            this.Show();
        }
    }
}
