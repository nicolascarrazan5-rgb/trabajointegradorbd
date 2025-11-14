using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno_Materia
{
    public partial class MateriaProfesores : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True ";
        public MateriaProfesores()
        {
            InitializeComponent();
                        this.StartPosition = FormStartPosition.CenterScreen;
            cargarMaterias();
            cargarProfesores();
        }
        private void cargarMaterias()
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            string queryMateria = "select id_materia, nombre, id_profesor, id_carrera, estado from materias";
            SqlCommand cmd = new SqlCommand(queryMateria, conn);
            cmd.CommandText = queryMateria;

            SqlDataReader lector;

            lector = cmd.ExecuteReader();

            DataTable tabla = new DataTable();

            tabla.Load(lector);

            dgv_materias.DataSource = tabla;

            conn.Close();
        }

        private void cargarProfesores()
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            string queryProfesores = "SELECT * FROM profesores";
            SqlCommand cmd = new SqlCommand(queryProfesores, conn);
            cmd.CommandText = queryProfesores;

            SqlDataReader lector;

            lector = cmd.ExecuteReader();

            DataTable tabla = new DataTable();

            tabla.Load(lector);

            dgv_profesores.DataSource = tabla;

            conn.Close();
        }

        private void AsignarProfesor()
        {

            int idMateria = int.Parse(idmateria.Text);
            int idProfesor = int.Parse(idprofesor.Text);

            string query = "UPDATE materias SET id_profesor = @idProfesor WHERE id_materia = @idMateria";

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idProfesor", idProfesor);
                        cmd.Parameters.AddWithValue("@idMateria", idMateria);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Profesor asignado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la materia o no se actualizó nada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar profesor: " + ex.Message);
                }
            }
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            AsignarProfesor();
            cargarMaterias();
            cargarProfesores();
        }

        private void idmateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void idprofesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_materias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // ignora el encabezado
            {
                idmateria.Text = dgv_materias.Rows[e.RowIndex].Cells["id_materia"].Value.ToString();
            }
        }

        private void dgv_profesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idprofesor.Text = dgv_profesores.Rows[e.RowIndex].Cells["id_profesor"].Value.ToString();
            }
    }
    }
}
