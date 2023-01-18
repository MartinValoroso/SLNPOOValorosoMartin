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
            Camion camion = new Camion(7530, "2", "Honda", "16", "145");
            MessageBox.Show($"Camion:\n{camion}" + $"Aceleración : {camion.Acelerar()}" + $"Frenar: {camion.Frenar()}");
        }

        private void btnQuitarRemolque_Click(object sender, EventArgs e)
        {
            Camion camion2 = new Camion(5430, "1", "mercedes", "16", "170");
            MessageBox.Show($"Camion: {camion2}" + $"\n{camion2.QuitarRemolque()}");
        }
    }
}
