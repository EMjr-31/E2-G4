using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ2_G4
{
    public partial class Form1 : Form
    {

        private List<Ingenieria> Ingeniero= new List<Ingenieria>();
        private int index=-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Univeridades
            cbmUniversidades.Items.Clear();
            cbmUniversidades.Items.Add("UDB");
            cbmUniversidades.Items.Add("UES");
            cbmUniversidades.Items.Add("UFG");
            cbmUniversidades.Items.Add("UCA");

            // Carreras de ingenierias
            cmbCarreras.Items.Clear();
            cmbCarreras.Items.Add("Ingeniería Mecánica");
            cmbCarreras.Items.Add("Ingeniería Industrial");
            cmbCarreras.Items.Add("Ingeniería Biomédica");
            cmbCarreras.Items.Add("Ingeniería en Ciencias de la Computación");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería en Telecomunicaciones");
        }
        public void Actualizar()
        {
            dgvIngenieria.DataSource = null;
            dgvIngenieria.DataSource = Ingeniero;
        }
        public void Limpiar()
        {
            txtApellido.Clear();
            txtCarnet.Clear();
            txtHorasCompl.Clear();
            txtHorasT.Clear();
            txtMat1.Clear();
            txtMat2.Clear();
            txtMat3.Clear();
            txtNivel.Clear();
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtProyecto.Clear();
            txtNombre.Focus();
        }

        private void dgvIngenieria_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
