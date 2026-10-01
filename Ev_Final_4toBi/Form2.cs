using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        private void Producto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int producto = Num1 * Num2;

            MessageBox.Show("El Resultado es producto " + producto);
        }
         private void Productö_Click(object sender, EventArgs e)
         {
            int Num1 = int.Parse(TextVar1.Text);
        int Num2 = int.Parse(TextVar2.Text);
        int suma = Num1 + Num2;

        MessageBox.Show("El Resultado de la Suma es " + suma);
         }

        private void Potencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar2.Text);
            int n3 = 1;
            int potencia = 1;

            while (n3 != n2)
            {
                potencia = potencia * n1;
                n3 = n3 + 1;
            }

            MessageBox.Show("El Resultado de la potencia es " + potencia);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);

            if (Num2 > 0)
            {
                float division = Num1 / Num2;

                MessageBox.Show("El resultado es " + division);
            }
            else
            {
                MessageBox.Show("La Division es Indefinida");
            }
        }

    }
}

