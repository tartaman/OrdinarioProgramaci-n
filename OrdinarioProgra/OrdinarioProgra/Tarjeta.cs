using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdinarioProgra
{
    public partial class Tarjeta : Form
    {
        string ingresado = "";
        private string path = @"C:\Users\Dell\Documents\GitHub\OrdinarioProgramaci-n\TARJETAS.json";
        private List<Tarjetas> listaDeTarjetas = new List<Tarjetas>();
        bool aprobado = false;

        public Tarjeta()
        {
            InitializeComponent();
        }
        private void escribir()
        {
            label2.Text = ingresado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresado += "1";
            escribir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingresado += "2";
            escribir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingresado += "3";
            escribir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingresado += "4";
            escribir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ingresado += "5";
            escribir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ingresado += "6";
            escribir();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ingresado += "7";
            escribir();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ingresado += "8";
            escribir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ingresado += "9";
            escribir();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ingresado += "0";
            escribir();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string jsonString = JsonConvert.SerializeObject(listaDeTarjetas);
            jsonString = File.ReadAllText(path);
            listaDeTarjetas= JsonConvert.DeserializeObject<List<Tarjetas>>(jsonString);
            if (Cobrar.debito)
            {
               
                    for(int i = 0; i < listaDeTarjetas.Count; i++)
                    {
                        if (listaDeTarjetas[i].Tipo == "Debito" && listaDeTarjetas[i].Nip == ingresado)
                        {
                            MessageBox.Show("FUNCIONO");
                            aprobado = true;

                        }
                        else
                        {
                            ingresado = "";
                            escribir();
                    

                        }
                    }
              
                
                
            }
        }
    }
    public class Tarjetas
    {
        private string tipo;
        private string nip;
        private double dinero;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nip { get => nip; set => nip = value; }
        public double Dinero { get => dinero; set => dinero = value; }
    }
}


