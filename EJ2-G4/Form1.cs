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

        private List<Ingenieria> Ingeniero = new List<Ingenieria>();
        private int index = -1;
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
            btnGuardar.Text = "Modificar";
            DataGridViewRow seleccion = dgvIngenieria.SelectedRows[0];
            index = dgvIngenieria.Rows.IndexOf(seleccion);

            Ingenieria ing = Ingeniero[index];
            txtApellido.Text = ing.Apellido;
            txtCarnet.Text = ing.Carnet;
            txtHorasCompl.Text = ing.Horas_compl.ToString();
            txtHorasT.Text = ing.Total_horas.ToString();
            txtMat1.Text = ing.Materia1;
            txtMat2.Text = ing.Materia2;
            txtMat3.Text = ing.Materia3;
            txtNivel.Text = ing.Nivel;
            txtNombre.Text = ing.Nombre;
            txtNota1.Text = ing.Nota1.ToString();
            txtNota2.Text = ing.Nota2.ToString();
            txtNota3.Text = ing.Nota3.ToString();
            txtProyecto.Text = ing.Proyecto;
            cbmUniversidades.Text = ing.Universidad;
            cmbCarreras.Text = ing.Carrera;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Ingenieria ing = new Ingenieria();
            ing.Apellido = txtApellido.Text;
            ing.Carnet = txtCarnet.Text;
            ing.Horas_compl = int.Parse(txtHorasCompl.Text);
            ing.Total_horas = int.Parse(txtHorasT.Text);
            ing.Materia1 = txtMat1.Text;
            ing.Materia2 = txtMat2.Text;
            ing.Materia3 = txtMat3.Text;
            ing.Nivel = txtNivel.Text;
            ing.Nombre = txtNombre.Text;
            ing.Nota1 = float.Parse(txtNota1.Text);
            ing.Nota2 = float.Parse(txtNota2.Text);
            ing.Nota3 = float.Parse(txtNota3.Text);
            ing.Proyecto = txtProyecto.Text;
            ing.Universidad = cbmUniversidades.Text;
            ing.Carrera = cmbCarreras.Text;
            ///Caculo de cum
            float suma = 0;
            suma = float.Parse(txtNota1.Text) + float.Parse(txtNota2.Text) + float.Parse(txtNota3.Text);
            ing.Cum = suma / 3;
            ////verificacion de indeice
            if (index > -1)
            {
                Ingeniero[index] = ing;
                index = -1;
            }
            else
            {
                Ingeniero.Add(ing);

            }
            btnGuardar.Text = "Guardar";
            Actualizar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                Ingeniero.RemoveAt(index);
                index = -1;
                Actualizar();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void btnEstudientes_Click(object sender, EventArgs e)
        {
            estudiantes();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            promedios();
        }

        public void estudiantes()
        {
            int lon = Ingeniero.Count();
            int udb = 0, UES = 0, UFG = 0, UCA = 0;
            for (int i = 0; i < lon; i++)
            {
                if (Ingeniero[i].Universidad == "UDB")
                {
                    udb++;
                }
                if (Ingeniero[i].Universidad == "UES")
                {
                    UES++;
                }
                if (Ingeniero[i].Universidad == "UFG")
                {
                    UFG++;
                }
                if (Ingeniero[i].Universidad == "UCA")
                {
                    UCA++;
                }
            }
            if (udb > UES)
            {
                if (udb > UFG)
                {
                    if (udb > UCA)
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UDB con " + udb.ToString() + " estudiantes");
                    }
                    else {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UCA con " + UCA.ToString() + " estudiantes");
                    }
                }
                else
                {
                    if (UFG > UCA)
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UFG con " + UFG.ToString() + " estudiantes");
                    }
                    else
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UCA con " + UCA.ToString() + " estudiantes");
                    }
                }
            }
            else
            {
                if (UES > UFG)
                {
                    if (UES > UCA)
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UES con " + UES.ToString() + " estudiantes");
                    }
                    else
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UCA con " + UCA.ToString() + " estudiantes");
                    }
                }
                else
                {
                    if (UFG > UCA)
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UFG con " + UFG.ToString() + " estudiantes");
                    }
                    else
                    {
                        MessageBox.Show("La Universidad con mayor cantidad de estudiantes de ingenieria es la  UCA con " + UCA.ToString() + " estudiantes");
                    }
                }
            }
        }
        public void promedios()
        {
            int lon = Ingeniero.Count();
            float suma1=0,suma2=0,suma3=0, suma4=0;
            float mat = 0, cien = 0, ling = 0, cum=0;
            for (int i = 0; i < lon; i++)
            {
                suma1 = suma1 + Ingeniero[i].Nota1;
                suma2 = suma2 + Ingeniero[i].Nota2;
                suma3 = suma3 + Ingeniero[i].Nota3;
                suma4 = suma4 + Ingeniero[i].Cum;
            }
            mat = suma1 / lon;
            cien = suma2 / lon;
            ling = suma3 / lon;
            cum = suma4 / lon;

            MessageBox.Show("PROMEDIO DE NOTAS\n Matematicas -> "+mat.ToString()+ "\n Ciencias -> " + cien.ToString() + "\n Linguistica -> " + mat.ToString() + "\n CUM -> " +cum.ToString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
