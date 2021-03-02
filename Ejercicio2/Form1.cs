using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BuscaDivision()
        {
            double N1 = 0;
            double N2 = 0;
            double cos = 0;
            double res = 0;
            double Residuo = 0;
            string mensaje = string.Empty;
            string Es_O_No = string.Empty;
            try
            {
                N1 = Convert.ToDouble(txtNumero1.Text);
                N2 = Convert.ToDouble(txtNumero2.Text);

                cos = (N1 / N2);
                res = Math.Truncate(cos) * N2;
                Residuo = N1 - res;
                if (Residuo == 0)
                {
                    Es_O_No = "si";
                }
                else
                {
                    Es_O_No = "no";
                }
                mensaje = $"El número {N1} {Es_O_No} es divisible entre el número {N2}";

                lblResultado.Text = cos.ToString();
                lblResiduo.Text = Residuo.ToString();
                lblMensaje.Text = mensaje;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            BuscaDivision();
        }
       

    }
}


