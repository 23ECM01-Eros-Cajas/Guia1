using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1__24__de_marzo_03_Eros_Cajas
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            for (int cont = 0; cont < 10; cont++)
            {
                int suma;
                suma = num1 + num2 + cont;

                dataGridView1.Rows.Add(num1, num2,cont, suma);
                cont++;
            }
        }
    }
}
