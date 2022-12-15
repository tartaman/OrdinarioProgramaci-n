using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinarioProgra
{
    public partial class tablaventas : Form
    {
        public tablaventas()
        {
            InitializeComponent();
        }

        private void tablaventas_Load(object sender, EventArgs e)
        {
            string path = File.ReadAllText(@"C:\Users\Dell\Documents\GitHub\OrdinarioProgramaci-n\COMPRAS.json");
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(path, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }
    }
}
