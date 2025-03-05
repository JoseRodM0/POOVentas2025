using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOVentas2025
{
    public class Limonada
    {
        //Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }


        //Se agrega una constante para que después que se ejecute, no se pueda modificar, en este caso los precios
        public const decimal PrecioLimonadaLimon = 4.00m;
        public const decimal PrecioLimonadaFresa = 2.80m;
        public const decimal PrecioUvola = 7.00m;
        public const decimal InteresUvola = 0.05m;

        //Constructor de Limonada
        public Limonada(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Total = 0;
            Total = Precio * Cantidad;
        }

        public class LimonadaDeLimon : Limonada
        {
            public LimonadaDeLimon() : base("Limonada de Limón", 20.00m) { }
        }

        public class LimonadaDeFresa : Limonada
        {
            public LimonadaDeFresa() : base("Limonada de Fresa", 25.00m) { }
        }

        public class Uvola : Limonada
        {
            public Uvola() : base("Limonada de Uvola", 30.00m) { }
        }


        //Retorna el total
        public decimal CalcularTotal()
        {
            return Total = Precio * Cantidad;
        }
    }


}