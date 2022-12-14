using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinarioProgra
{
    public partial class Cobrar : Form
    {
        bool efectivo = false;
        bool tarjeta = false;
        double ingresado;
        public static double total;
        public static bool terminado;
        public static bool debito;
        public static bool credito;
        public Cobrar()
        {
            InitializeComponent();
            label3.Text = Caja.suma.ToString();
            total = Caja.suma;
            label4.Text = Caja.suma.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Visible = true;
            button4.Enabled = true;
            efectivo = true;
            tarjeta = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (efectivo)
            {
                ingresado = Convert.ToDouble(textBox1.Text);
                if (ingresado >= total)
                {
                    if(ingresado > total)
                    {
                        MessageBox.Show("Operación completada, su cambio es de : $" + (ingresado - total)+" vuelva pronto");
                        terminado = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Operación completada, vuelva pronto");
                        terminado = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el monto correcto por favor");
                }
            }
            else if (tarjeta){
                MessageBox.Show("Operación completada, le quedan $" + Tarjeta.restante);
                terminado = true;
                this.Close();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
            else
            {
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                total = Caja.suma;
                label4.Text = total.ToString();
            }
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            total = Caja.suma + Caja.suma * 0.10;
            label4.Text = total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            total = Caja.suma + Caja.suma * 0.15;
            label4.Text = total.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            total = Caja.suma + Caja.suma * 0.20;
            label4.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Visible = false;
            debito = true;
            credito = false;
            tarjeta = true;
            Tarjeta venta = new Tarjeta();
            venta.Show();
        }

        private void Cobrar_Activated(object sender, EventArgs e)
        {
            if (Tarjeta.aprobado)
            {
                button4.Enabled = true;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Visible = false;
            tarjeta = true;
            debito = false;
            credito = true;
            Tarjeta venta = new Tarjeta();
            venta.Show();
        }

        private void Cobrar_Load(object sender, EventArgs e)
        {

        }
    }
}
