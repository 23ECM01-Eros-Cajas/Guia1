using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
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
            int[] v1 = new int[5];
            int[] v2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                v1[i] = int.Parse(Interaction.InputBox("Ingrese un numero para el vector 1, en el lugar " + (i + 1), "Entrada Vector 1"));
            }
            for (int i = 0; i < 5; i++)
            {
                v2[i] = int.Parse(Interaction.InputBox("Ingrese un numero para el vector 2, en el lugar " + (i + 1), "Entrada Vector 2"));
            }

            dataGridView1.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                int suma = v1[i] + v2[i];

                dataGridView1.Rows.Add(v1[i], v2[i], suma);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form  = new Form5();
            form.ShowDialog();
        }
    }
}
