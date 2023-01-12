using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPAvion;

namespace TPAvionForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PropAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial("Juan", "Pedro", "Sofia", 250, "JetSmart");

            MessageBox.Show(avionComercial.ToString());
        }

        private void btn_DespegaAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial("Juan", "Pedro", "Sofia", 250, "JetSmart");

            MessageBox.Show(avionComercial.Despega());
        }

        private void btn_AterrizaAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial("Juan", "Pedro", "Sofia", 250, "JetSmart");

            MessageBox.Show(avionComercial.Aterriza());
        }

        private void btn_PropAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga = new AvionCarga("Jose", "Martin", "-", 300, "Austral");

            MessageBox.Show (avionCarga.MostrarPropiedades());
        }

        private void btn_DespegaAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga = new AvionCarga("Jose", "Martin", "-", 300, "Austral");

            MessageBox.Show(avionCarga.Despega());
        }

        private void btn_AterrizaAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga = new AvionCarga("Jose", "Martin", "-", 300, "Austral");

            MessageBox.Show(avionCarga.Aterriza());
        }
    }
}
