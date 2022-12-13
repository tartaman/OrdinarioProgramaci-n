using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrdinarioProgra
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Usuario\OneDrive\Escritorio\Empleados\uwu.json";
        private List<Empleadosxd> listaDeEmpleados = new List<Empleadosxd>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Esto lo voy a usar de ejemplo por ahora pero no se tiene que quedar asi si no quieren

            Empleadosxd JsonEmpleado = new Empleadosxd
            {
                Id = 1,
                Nombre = "Victor",
                Edad = 18,
                Clave = 123,
                Gerente = false
            };
            Empleadosxd JsonEmpleado2 = new Empleadosxd
            {
                Id = 2,
                Nombre = "UWU",
                Edad = 21,
                Clave = 12345,
                Gerente = true
            };
            listaDeEmpleados.Add(JsonEmpleado);
            listaDeEmpleados.Add(JsonEmpleado2);
            string jsonString = JsonConvert.SerializeObject(listaDeEmpleados);
            File.WriteAllText(path, jsonString);
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonString = JsonConvert.SerializeObject(listaDeEmpleados);
            jsonString = File.ReadAllText(path);
            listaDeEmpleados = JsonConvert.DeserializeObject<List<Empleadosxd>>(jsonString);

            string claveIngresada = textBox1.Text;
            for (int i = 0; i < listaDeEmpleados.Count; i++)
            {
                if (claveIngresada == listaDeEmpleados[i].Clave.ToString() && listaDeEmpleados[i].Gerente == false)
                {
                    label2.Text = "SI estas enel sistema wachin pero cuidado no vaya a ser el del oxxo" + listaDeEmpleados.Count;
                    break;
                } 
                if (claveIngresada == listaDeEmpleados[i].Clave.ToString() && listaDeEmpleados[i].Gerente == true)
                {
                    label2.Text = "Noma eres gerente";
                    break;
                }
                if (claveIngresada != listaDeEmpleados[i].Clave.ToString())
                {
                    label2.Text = "200 pa tu casaaaa";
                    break;
                }

            }
        }
    }
    public class Empleadosxd
    {

        private int id;
        private string nombre;
        private int edad;
        private int clave;
        private bool gerente;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Clave { get => clave; set => clave = value; }
        public bool Gerente { get => gerente; set => gerente = value; }
    }
}
