using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace OrdinarioProgra
{
    public partial class Form2 : Form
    {
        string path = @"C:\Users\Usuario\Documents\OrdinarioProgramaci-n\uwu.json";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleadosxd JsonEmpleado = new Empleadosxd
            {
                Id = int.Parse(textBox1.Text),
                Nombre = textBox3.Text,
                Clave = int.Parse(textBox2.Text),
                Gerente = checkBox1.Checked
            };

            Form1.listaDeEmpleados.Add(JsonEmpleado);
            string jsonString = JsonConvert.SerializeObject(Form1.listaDeEmpleados);
            File.WriteAllText(path, jsonString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.listaDeEmpleados.Count; i++)
            {
                string EmpleadoLeña = textBox4.Text;
                if (EmpleadoLeña == Form1.listaDeEmpleados[i].Clave.ToString())
                {
                    Form1.listaDeEmpleados.Remove(Form1.listaDeEmpleados[i]);
                    string jsonString = JsonConvert.SerializeObject(Form1.listaDeEmpleados);
                    File.WriteAllText(path, jsonString);
                    break;
                } else
                {
                    MessageBox.Show("Error","valiobarriga");
                }
            }
        }
    }
}
