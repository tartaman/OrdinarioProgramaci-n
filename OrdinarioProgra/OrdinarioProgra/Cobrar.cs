using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinarioProgra
{
    public partial class Cobrar : Form
    {
        bool efectivo = false;
        bool tarjeta = false;
        int ingresado;
        public Cobrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            button4.Enabled = true;
            efectivo = true;
            tarjeta = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (efectivo)
            {
                ingresado = Convert.ToInt32(textBox1.Text);
                if(ingresado >= Caja.suma)
                {
                    MessageBox.Show("Operación completada, vuelva pronto");
                    Caja.suma = 0;
                }
            }
        }
    }
}
