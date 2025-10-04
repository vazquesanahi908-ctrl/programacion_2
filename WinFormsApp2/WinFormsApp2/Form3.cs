using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnigual2_Click(object sender, EventArgs e)
        {
           while (textBox1.Text == "" || textBox2.Text == "")
           {
                MessageBox.Show("Error, ingrese valores en las cajas de texto");
                return;
            }

            // Validar que los valores sean numéricos
            double numero1, numero2;
            bool esNumero1 = double.TryParse(textBox1.Text, out numero1);
            bool esNumero2 = double.TryParse(textBox2.Text, out numero2);

            if (!esNumero1 || !esNumero2)
            {
                MessageBox.Show("Error, ingrese valores numéricos");
                return;
            }



                    if (radioButton1.Checked)
                    {
                      double texbox1 = Convert.ToDouble(textBox1.Text);
                       double texbox2 = Convert.ToDouble(textBox2.Text);
                      double result = ClassLibrary2.Class1.Sumar(texbox1, texbox2);
                        textBox1.Text = result.ToString();
                        textBox2.Text = "";
                    }
                    else if (radioButton2.Checked)
                    {
                           double texbox1 = Convert.ToDouble(textBox1.Text);
                          double texbox2 = Convert.ToDouble(textBox2.Text);
                          double result = ClassLibrary2.Class1.Restar( texbox1 , texbox2);
                           textBox1.Text = result.ToString();
                            textBox2.Text = "";
                    }
                    if (radioButton4.Checked)
                    {
                       double texbox1 = Convert.ToDouble(textBox1.Text);
                       double texbox2 = Convert.ToDouble(textBox2.Text);
                       double result =ClassLibrary2.Class1.Multiplicar( texbox1 , texbox2);
                       textBox1.Text = result.ToString();
                       textBox2.Text = "";
                    }
                   else if (radioButton3.Checked)
                   {
                if (double.TryParse(textBox2.Text, out double valor) && valor == 0)
                {
                    MessageBox.Show("error no se puede dividir por cero");
                    return;
                }
                double texbox1 = Convert.ToDouble(textBox1.Text);
                       double texbox2 = Convert.ToDouble(textBox2.Text);
                       double result = ClassLibrary2.Class1.Dividir( texbox1 , texbox2);
                       textBox1.Text = result.ToString();
                       textBox2.Text = "";
                   }
               
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
