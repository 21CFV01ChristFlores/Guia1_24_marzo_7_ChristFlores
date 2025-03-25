namespace Guia1_24_marzo_7_ChristFlores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                //Agregar los datos en el DatagridView
                dataGridView1.Rows.Add(num1, cont, multi);
            }

            //int cont2 = 1;
            //while (cont2 < 11)
            {
                {
                    //int multi;
                    // multi = num1 * cont2;
                    //dataGridView1.Rows.Add(num1, cont2, multi);
                    //cont2++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
