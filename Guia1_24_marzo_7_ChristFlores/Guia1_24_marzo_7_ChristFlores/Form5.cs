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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] V1 = { 1, 2, 3, 4 };
            int[] V2 = { 5, 6, 7, 8 };

            for (int i = 0; i < 4; i++)
            {
                int suma = V1[i] + V2[i];
                dataGridView1.Rows.Add(V1[i], V2[i], suma);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }
    }
}
