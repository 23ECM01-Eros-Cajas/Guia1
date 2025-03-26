using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Guia_1__24__de_marzo_03_Eros_Cajas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];

            // Ingreso de valores para la matriz A
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Introduce el valor para la matriz A, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz A");

                    if (!int.TryParse(entrada, out matrizA[i, j]))
                    {
                        MessageBox.Show("Debes ingresar un número válido para la matriz A.");
                        return;
                    }
                }
            }

            // Ingreso de valores para la matriz B
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Introduce el valor para la matriz B, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz B");

                    if (!int.TryParse(entrada, out matrizB[i, j]))
                    {
                        MessageBox.Show("Debes ingresar un número válido para la matriz B.");
                        return;
                    }
                }
            }

            // Limpiar el DataGridView antes de agregar nuevos datos
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ValorA", "Valor A");
            dataGridView1.Columns.Add("ValorB", "Valor B");
            dataGridView1.Columns.Add("Multiplicación", "Multiplicación");

            // Multiplicación de las matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int resultadoMultiplicacion = matrizA[i, j] * matrizB[i, j];
                    dataGridView1.Rows.Add(matrizA[i, j], matrizB[i, j], resultadoMultiplicacion);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Introduce el valor para la matriz A, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz A");

                    if (!int.TryParse(entrada, out matrizA[i, j]))
                    {
                        MessageBox.Show("Debes ingresar un número válido.");
                        return;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Introduce el valor para la matriz B, posición ({i + 1},{j + 1}):",
                        "Entrada Matriz B");

                    if (!int.TryParse(entrada, out matrizB[i, j]))
                    {
                        MessageBox.Show("Debes ingresar un número válido.");
                        return;
                    }
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ValorA", "Valor A");
            dataGridView1.Columns.Add("ValorB", "Valor B");
            dataGridView1.Columns.Add("División", "División");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (matrizB[i, j] != 0)
                    {
                        float resultadoDivision = (float)matrizA[i, j] / matrizB[i, j];
                        dataGridView1.Rows.Add(matrizA[i, j], matrizB[i, j], resultadoDivision);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(matrizA[i, j], matrizB[i, j], "Error (División por 0)");
                    }
                }
            }
        }
    }
}
