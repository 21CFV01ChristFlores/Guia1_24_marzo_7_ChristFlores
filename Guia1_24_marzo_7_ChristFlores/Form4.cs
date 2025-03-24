using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_7_ChristFlores
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
            int cont = 1;

            do
            {
                int multi;
                multi = num1 * cont;
                dataGridView1.Rows.Add(num1, cont, multi);
                cont++;
            } while (cont < 11);
        }
    }
}
