using System.ComponentModel;

namespace BL.Fashion
{
    public class ProductosCaballeroBL
    {
        public BindingList<Producto2> ListaProductos { get; set; }

        public ProductosCaballeroBL ()
        {
            ListaProductos = new  BindingList<Producto2>();

            var producto1 = new Producto2();
            producto1.Id = 1;
            producto1.Descripcion = "Polo Ralph Lauren";
            producto1.Precio = 1200;
            producto1.Existencia = 8;
            producto1.TipoProducto = "Productos para Caballeros";
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto2();
            producto2.Id = 2;
            producto2.Descripcion = "Polo Tommy manga larga";
            producto2.Precio = 1500;
            producto2.Existencia = 15;
            producto2.TipoProducto = "Productos para Caballeros";
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto2();
            producto3.Id = 3;
            producto3.Descripcion = "Jeans Pepe skinny black";
            producto3.Precio = 1000;
            producto3.Existencia = 20;
            producto3.TipoProducto = "Productos para Caballeros";
            producto3.Activo = true;

            ListaProductos.Add(producto3);
        }

        public BindingList<Producto2> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto2
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public string TipoProducto { get; set; }
        public bool Activo { get; set; }
    }
}
