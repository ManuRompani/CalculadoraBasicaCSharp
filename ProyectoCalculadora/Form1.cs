using System.DirectoryServices;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador; 
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            if (txtResultado.Text == "MATH Error")
            {
                txtResultado.Text = "";
            }
            var buton = ((Button)sender);
            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += buton.Text;
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                num1 = num1 + num2;
                txtResultado.Text = num1.ToString();
            }
            else if (operador == '−')
            {
                num1 = num1 - num2;
                txtResultado.Text = num1.ToString();
            }
            else if (operador == 'X')
            {
                num1 = num1 * num2;
                txtResultado.Text = num1.ToString();
            }
            else if (operador == '∕')
            {
                if (num2 == 0)
                {
                    txtResultado.Text = "MATH Error";
                    num1 = 0;
                    num2 = 0;
                }
                else
                {
                    num1 = num1 / num2;
                    txtResultado.Text = num1.ToString();
                }
            }


        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else txtResultado.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void buttonCambioSigno_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            if (num1 != 0)
            {
                num1 = num1 * -1;
                txtResultado.Text = num1.ToString();
            }
        }

        private void btnCalculo(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);
            if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                txtResultado.Text = num1.ToString();
            }
            else if (operador == '√')
            {
                num1 = Math.Sqrt(num1);
                txtResultado.Text = num1.ToString();
            }
            else txtResultado.Text = "0";
        }


    }

}
