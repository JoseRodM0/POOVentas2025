namespace POOVentas2025
{
    public class Venta
    {
        //Propiedades
        public decimal MontoTotal { get; set; }
        public Pago FormaPago { get; set; }
        public decimal TotalConIntereses { get; set; }

        //Lista del puesto de limonadas
        public List<Limonada> productos { get; set; } = new List<Limonada>();

        //Constructor
        public Venta(Pago pago)
        {
            MontoTotal = 0;
            FormaPago = pago;
            TotalConIntereses = 0;
        }

        //Método total con intereses
        public decimal CalcularTotal()
        {
            decimal total = 0;


            //El foreach es para ver la lista de productos
            foreach (Limonada producto in productos)
            {
                
                total += producto.Precio * producto.Cantidad;
                Console.WriteLine($"{producto.Nombre}:{producto.Cantidad}unidades x${producto.Precio}=${producto.Cantidad * producto.Precio}");


            }

            //Es el monto total y el total con los intereses agregados
            MontoTotal = total;
            TotalConIntereses = total + (total * FormaPago.Interes);
            return TotalConIntereses;

        }
    }
}

