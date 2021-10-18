using BL.Fashion;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormProductoC : Form
    {

        ProductosCaballeroBL _productos2;

        public FormProductoC()
        {
            InitializeComponent();

            _productos2 = new ProductosCaballeroBL();
            listaProductosBindingSource.DataSource = _productos2.ObtenerProductos();

        }

        private void Forminventarioh_Load(object sender, EventArgs e)
        {

        }

      
    }
}
