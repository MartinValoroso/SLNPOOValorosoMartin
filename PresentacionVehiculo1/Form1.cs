using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionVehiculo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion(7530, "2", "Honda", "16", "145")
            {
             Remolque = new Remolque() { remolque = "Este camión tiene remolque"}
            };
           
            MessageBox.Show($"Camion:\n{camion}" + $"Aceleración : {camion.Acelerar()}" + $"Frenar: {camion.Frenar()}" + $"{camion.Remolque.remolque}");
        }

        

        private void QuitarRemolque(object sender, EventArgs e)
        {

            Camion camion = new Camion(7530, "2", "Honda", "16", "145")
            {
                Remolque = new Remolque() { remolque = "Este camión tiene remolque" }
            };
            MessageBox.Show($"Camion: {camion}" + $"\n{camion.QuitarRemolque()}");
        }
    }
}
