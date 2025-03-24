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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont3 = 2;
            int num1 = int.Parse(textBox1.Text);
            do
            {
                int multi;
                multi = num1 * cont3;
                dataGridView1.Rows.Add(num1, cont3, multi);
                cont3++;
            }
            while (cont3 < 11);

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
    }
}
