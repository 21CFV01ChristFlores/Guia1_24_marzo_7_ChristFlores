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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = {
                {1,2,3,4 },
                {1,3,4,5},
        };
            int[,] matriz2 = {
                { 5, 6, 7, 8},
                { 4, 2, 8, 5 }
            };

            for (int co = 0; co < 4; co++)
            {
                for (int fi = 0; fi < 2; fi++)
                {
                    int mul = matriz1[fi, co] * matriz2[fi, co];
                    dataGridView1.Rows.Add(matriz1[fi, co], matriz2[fi, co], mul);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
