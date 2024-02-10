namespace Multiplicar_eje8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Numero.Text, out int numero))
            {
                lst_Tabla.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = numero * i;
                    lst_Tabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lst_Tabla.Items.Clear();
            txt_Numero.Clear();
        }
    }
    }
