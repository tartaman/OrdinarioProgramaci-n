using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinarioProgra
{
    
    public partial class Caja : Form
    {
        int[] precios = { 239, 234, 314, 329, 189, 339, 124, 114, 139, 49, 46, 54};
        string[] nombres = { "Lasaña horneada", "Spagetti con salsa pomodoro", "Trio italiano", "Arrachera", "Bacon cheese burguer", "Pizza de peperoni grande", "Ensalada césar", "Brownie", "Cheesecake", "Coca cola", "Tecate", "Piñada" };
        public static int suma = 0;
        public Caja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar(0);
            total();
        }

        public static int n;
        private void agregar(int selec)
        {
            n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = n + 1;
            dataGridView1.Rows[n].Cells[1].Value = nombres[selec];
            dataGridView1.Rows[n].Cells[2].Value = precios[selec];
        }
        private void total()
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label26.Text = "$" + suma.ToString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            agregar(1);
            total();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregar(2);
            total();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            agregar(3);
            total();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agregar(4);
            total();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            agregar(5);
            total();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            agregar(6);
            total();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            agregar(7);
            total();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            agregar(8);
            total();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agregar(9);
            total();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agregar(10);
            total();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agregar(11);
            total();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
              
               dataGridView1.Rows.RemoveAt(Convert.ToInt32(textBox1.Text) - 1);
               textBox1.BackColor = Color.White;
               textBox1.ForeColor = Color.Black;
                total();
                for(int i = 0; i < n; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i+1;
                }
                n--;

            }
            catch
            {
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.White;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(n);
            n--;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cobrar cobrar = new Cobrar();
            cobrar.Show();
        }
    }
}
