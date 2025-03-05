using static POOVentas2025.Limonada;

namespace POOVentas2025
{

        public partial class Form1 : Form
        {
        private object txtCliente;
        private object comboBoxLimonada;
        private object radioCredito;

        public Form1()
            {
                InitializeComponent();
            }

            // Evento que se dispara cuando el formulario se carga
            private void Form1_Load(object sender, EventArgs e)
            {
                // Cargar las opciones de limonada en el ComboBox
                comboBoxLimonada.Items.Add(new LimonadaDeLimon());
                comboBoxLimonada.Items.Add(new LimonadaDeFresa());
                comboBoxLimonada.Items.Add(new Uvola());  // Cambiar LimonadaDeUvola por Uvola
                comboBoxLimonada.DisplayMember = "Nombre";  // Mostrar el nombre de la limonada
            }

            // Evento que se dispara al hacer clic en el botón Calcular
            private void btnCalcular_Click(object sender, EventArgs e)
            {
                // Validar que el nombre del cliente no esté vacío
                if (string.IsNullOrEmpty((string?)txtCliente))
                {
                    MessageBox.Show("Por favor ingrese el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que se haya seleccionado una limonada
                if ((string)comboBoxLimonada == null)
                {
                    MessageBox.Show("Por favor seleccione una limonada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener la información del cliente
                string cliente = (string)txtCliente;

                // Obtener la limonada seleccionada
                Limonada limonadaSeleccionada = comboBoxLimonada.SelectedItem as Limonada;

            // Verificar si es crédito o contado
            bool esCredito = radioCredito.Checked;

                // Crear la venta
                Venta venta = new(cliente, limonadaSeleccionada, esCredito);

            // Mostrar los resultados
            lblTotal.Text = $"Total: {venta.Total:C}";

            // Crear el objeto Pago para calcular el total a pagar
            Pago pago = new Pago(venta.Total, esCredito);
            lblTotalPago.Text = $"Total de Pago: {pago.TotalPago:C}";

            // Mostrar los detalles del pago en un MessageBox (opcional)
            MessageBox.Show(pago.ObtenerDetallePago(), "Detalles del Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


