namespace Tabla_de_Amortizacion_practica__2023_1828
{
    public partial class Form1 : Form
    {
        DateTime fecha_actual = new DateTime();
        //agregar fecha actual
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpagocuotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //declarar variables
            double tasainteresmensual;
            double tasainteresanual;
            int tiempo;
            double montoprestamo;
            double cuotas;
            double calculo;

            //asignacion a las variables de las cajas de texto y sus converciones
            tasainteresanual = Convert.ToDouble(txtinteresanual.Text);
            tiempo = Convert.ToInt32(txttiempo.Text);
            montoprestamo = Convert.ToDouble(txtmontoprestamo.Text);

            //calculo de interes mensual
            tasainteresmensual = (tasainteresanual / 12) / 100;
            //asignar a la caja de texto y su conversion
            txtinteresmensual.Text = tasainteresmensual.ToString();
            //calculo de las cuotas
            calculo = (1 - Math.Pow(1 + tasainteresmensual, tiempo * -1)) / tasainteresmensual;

            //calculo de cuotas
            cuotas = montoprestamo / calculo;
            //asignar a la caja de texto de cuotas
            txtpagocuotas.Text = cuotas.ToString();

            //declarar variables
            double interes = 0;
            double tineres = 0;
            double tcuotas = 0;
            double saldoinicial = 0;
            double saldofinal = 0;
            double abonocapital = 0;

            //crear un bucle for para un recorrido y asignar cuotas y los interes generados
            //al pago del prestamo
            for (int i = 1; i < tiempo + 1; i++)
            {
                //calculo de los intereses aplicados al mes
                interes = Math.Round(saldofinal * tasainteresmensual, 2);
                //acumulacion de los intereses
                tineres += interes;
                //saldoinicial igual al saldofinal
                saldoinicial += saldofinal;
                saldofinal = montoprestamo;
                //calcular capital a pagar
                montoprestamo = Math.Round(cuotas - interes, 2);
                abonocapital += montoprestamo;
                saldofinal -= montoprestamo;
                tcuotas += cuotas;

                //declarar variable fecha
                DateTime ffecha;
                ffecha = Convert.ToDateTime(dtfecha.Value.ToString());
                fecha_actual = Convert.ToDateTime(ffecha.ToString());

                //para contar en el mismo mes
                fecha_actual.AddMonths(i - 1).ToShortDateString();

                //agregar datos al datagridview
                dataGridView1.Rows.Add(i.ToString(), fecha_actual.AddMonths(i - 1).ToShortDateString(), Math.Round(cuotas, 2), Math.Round(interes, 2), Math.Round(saldoinicial, 2), Math.Round(saldofinal, 2), Math.Round(montoprestamo, 2));
            }
        }

        private void btmlimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtinteresanual.Clear();
            txtmontoprestamo.Clear();
            txttiempo.Clear();
            txtinteresmensual.Clear();
            txtpagocuotas.Clear();
            txtmontoprestamo.Focus();
        }
    }
}
