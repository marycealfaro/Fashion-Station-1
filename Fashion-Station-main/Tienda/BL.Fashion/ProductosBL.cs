using System.ComponentModel;
using System.Linq;

namespace BL.Fashion
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Crop top";
            producto1.Precio = 890;
            producto1.Existencia = 10;
            producto1.TipoProducto = "Productos para Damas";
            producto1.Activo = true;

            ListaProductos.Add(producto1);


            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Vestido";
            producto2.Precio = 1000;
            producto2.Existencia = 15;
            producto2.TipoProducto = "Productos para Damas";
            producto2.Activo = true;

            ListaProductos.Add(producto2);


            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Polo Ralph Lauren";
            producto3.Precio = 1500;
            producto3.Existencia = 8;
            producto3.TipoProducto = "Productos para Damas";
            producto3.Activo = true;

            ListaProductos.Add(producto3);


            var producto4 = new Producto();
            producto4.Id = 11;
            producto4.Descripcion = "Polo Ralph Lauren";
            producto4.Precio = 1200;
            producto4.Existencia = 8;
            producto4.TipoProducto = "Productos para Caballeros";
            producto4.Activo = true;

            ListaProductos.Add(producto4);


            var producto5 = new Producto();
            producto5.Id = 12;
            producto5.Descripcion = "Polo Tommy manga larga";
            producto5.Precio = 1500;
            producto5.Existencia = 15;
            producto5.TipoProducto = "Productos para Caballeros";
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.Id = 13;
            producto6.Descripcion = "Jeans Pepe skinny black";
            producto6.Precio = 1000;
            producto6.Existencia = 20;
            producto6.TipoProducto = "Productos para Caballeros";
            producto6.Activo = true;

            ListaProductos.Add(producto6);



            var producto7 = new Producto();
            producto7.Id = 21;
            producto7.Descripcion = "Jeans Pepe";
            producto7.Precio = 890;
            producto7.Existencia = 7;
            producto7.TipoProducto = "Productos para Niños";
            producto7.Activo = true;

            ListaProductos.Add(producto7);

            var producto8 = new Producto();
            producto8.Id = 22;
            producto8.Descripcion = "Polo Nautica";
            producto8.Precio = 700;
            producto8.Existencia = 10;
            producto8.TipoProducto = "Productos para Niños";
            producto8.Activo = true;

            ListaProductos.Add(producto8);

            var producto9 = new Producto();
            producto9.Id = 23;
            producto9.Descripcion = "Short";
            producto9.Precio = 600;
            producto9.Existencia = 13;
            producto9.TipoProducto = "Productos para Niños";
            producto9.Activo = true;

            ListaProductos.Add(producto9);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (producto.Id == 0)
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }
            return false;
        }


        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty (producto.Descripcion) == true)
            {
                resultado.Mensaje = "Debe registrar una 'Descripción'.";
                resultado.Exitoso = false;
            }

            if (producto.Precio <= 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero.";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La Existencia debe ser mayor o igual a cero.";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty (producto.TipoProducto) == true)
            {
                resultado.Mensaje = "Debe registrar un 'Tipo de Producto'.";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public string TipoProducto { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}
