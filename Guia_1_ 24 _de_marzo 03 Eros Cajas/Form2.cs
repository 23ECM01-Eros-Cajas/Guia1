﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont2 = 1;
            int num1 = int.Parse(textBox1.Text);
            while (cont2 < 11) 
            {
                int multi;
                multi = num1 * cont2;
                dataGridView1.Rows.Add(num1, cont2, multi ); 
                cont2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
