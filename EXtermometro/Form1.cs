using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXtermometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ConverterCelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                string entradaTexto = txtCel.Text;

                
                if (double.TryParse(entradaTexto, out double celsius))
                {
                    
                    double fahrenheit = ConverterCelsiusParaFahrenheit(celsius);

                    
                    txtFah.Text = fahrenheit.ToString("F2"); 
                }
                else
                {
                    
                    txtFah.Clear();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCel.Clear();
            txtFah.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
