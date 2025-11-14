using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno_Materia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlumnos alumnos = new FrmAlumnos();
            alumnos.Show();
            this.Hide();
        }

        private void btn_carreras_Click(object sender, EventArgs e)
        {
            Carreras carreras = new Carreras();
            carreras.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Hide();
        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.Show();
            this.Hide();
        }

        private void btn_curso_Click(object sender, EventArgs e)
        {
            Form1 curso = new Form1();
            curso.Show();
            this.Hide();
        }

        private void btn_profesores_Click(object sender, EventArgs e)
        {
            FrmProfesores profesores = new FrmProfesores();
            profesores.Show();
            this.Hide();
        }
    }
}
