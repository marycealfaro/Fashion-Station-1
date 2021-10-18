using BL.Fashion;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormProductoN : Form
    {

        ProductosNinosBL _productos3;

        public FormProductoN()
        {
            InitializeComponent();

            _productos3 = new ProductosNinosBL();
            listaProductosBindingSource.DataSource = _productos3.ObtenerProductos();
        }
    }
}
