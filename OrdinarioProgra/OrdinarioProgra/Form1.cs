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
        bool entro;
        //parece que hay que cambiar el path cada que lo use alguien
        //private string path = @"C:\Users\Usuario\Documents\OrdinarioProgramaci-n\uwu.json"; 
        private string path = @"C:\Users\Dell\Documents\GitHub\OrdinarioProgramaci-n\uwu.json";
        public static List<Empleadosxd> listaDeEmpleados = new List<Empleadosxd>();
        public static string empleado;
        public static string clave;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            
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
                    empleado = listaDeEmpleados[i].Nombre.ToString();
                    clave = listaDeEmpleados[i].Clave.ToString();
                    Caja caja = new Caja();
                    caja.Show();
                    entro = true;
                    break;
                } 
                else if (claveIngresada == listaDeEmpleados[i].Clave.ToString() && listaDeEmpleados[i].Gerente == true)
                {
                    
                    Form2 gerente = new Form2();
                    gerente.Show();
                    entro = true;
                    break;
                }

            }
            if (entro != true)
            {
                MessageBox.Show("Esa clave no está registrada, contacte al gerente");
            }
            entro = false;
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
