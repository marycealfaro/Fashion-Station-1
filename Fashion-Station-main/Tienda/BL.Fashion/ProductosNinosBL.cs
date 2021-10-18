using System.ComponentModel;

namespace BL.Fashion
{
    public class ProductosNinosBL
    {
        public BindingList<Producto3> ListaProductos { get; set; }

        public ProductosNinosBL()
        {
            ListaProductos = new BindingList<Producto3>();

            var producto1 = new Producto3();
            producto1.Id = 1;
            producto1.Descripcion = "Jeans Pepe";
            producto1.Precio = 890;
            producto1.Existencia = 7;
            producto1.TipoProducto = "Productos para Niños";
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto3();
            producto2.Id = 2;
            producto2.Descripcion = "Polo Nautica";
            producto2.Precio = 700;
            producto2.Existencia = 10;
            producto2.TipoProducto = "Productos para Niños";
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto3();
            producto3.Id = 3;
            producto3.Descripcion = "Short";
            producto3.Precio = 600;
            producto3.Existencia = 13;
            producto3.TipoProducto = "Productos para Niños";
            producto3.Activo = true;

            ListaProductos.Add(producto3);
        }

        public BindingList<Producto3> ObtenerProductos()
        {
            return ListaProductos;
        }
    }
  
    public class Producto3
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public string TipoProducto { get; set; }
        public bool Activo { get; set; }
    }
}
