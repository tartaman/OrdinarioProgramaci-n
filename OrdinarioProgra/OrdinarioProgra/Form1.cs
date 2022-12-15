﻿using System;
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
        private string path = @"C:\Users\Usuario\Documents\OrdinarioProgramaci-n\uwu.json"; 
        //private string path = @"C:\Users\Dell\Documents\GitHub\OrdinarioProgramaci-n\uwu.json";
        public static List<Empleadosxd> listaDeEmpleados = new List<Empleadosxd>();
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
                    label2.Text = "SI estas en el sistema wachin pero cuidado no vaya a ser el del oxxo" + listaDeEmpleados.Count;
                    Caja caja = new Caja();
                    caja.Show();
                    entro = true;
                    break;
                } 
                else if (claveIngresada == listaDeEmpleados[i].Clave.ToString() && listaDeEmpleados[i].Gerente == true)
                {
                    label2.Text = "Noma eres gerente";
                    Form2 gerente = new Form2();
                    gerente.Show();
                    entro = true;
                    break;
                }

            }
            if (entro != true)
            {
                label2.Text = "200 pa tu casaaaa";
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
