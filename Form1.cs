using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_progra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumero1.Text, out int num1))
            {
                if (int.TryParse(txtnumero2.Text, out int num2))
                {

                    if (num1 > num2)
                    {
                        MessageBox.Show($"El número {num1} es mayor que {num2}");
                    }
                    else if (num1 < num2)
                    {
                        MessageBox.Show($"El número {num2} es mayor que {num1}");
                    }
                    else
                    {
                        MessageBox.Show("Ambos números son iguales.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido en el segundo campo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido en el primer campo.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (int.TryParse(txtnumero1.Text, out int num1))
            {
                if (int.TryParse(txtnumero2.Text, out int num2))
                {

                    if (num1 > num2)
                    {
                        MessageBox.Show($"El número {num1} es mayor que {num2}");
                    }
                    else if (num1 < num2)
                    {
                        MessageBox.Show($"El número {num2} es mayor que {num1}");
                    }
                    else
                    {
                        MessageBox.Show("Ambos números son iguales.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido en el segundo campo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido en el primer campo.");
            }
        }
    }
}