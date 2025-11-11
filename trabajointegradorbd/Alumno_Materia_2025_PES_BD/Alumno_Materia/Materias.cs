using System;
using System.Collections;
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
    public partial class Materias : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True ";
        public Materias()
        {
            InitializeComponent();
            cargarMaterias();
            dgv_materias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            string queryBuscarMateria = "select id_materia, nombre, id_profesor, id_carrera, estado from materias where nombre like '%' + @nombre + '%'";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryBuscarMateria, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txt_buscar.Text);

                    SqlDataReader lector = cmd.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(lector);

                    dgv_materias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la materia: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarMateria()
        {
            int estadobd = cb_estado.Checked ? 1 : 0;

            string query = "INSERT INTO materias (nombre, estado) VALUES (@nombre, @estado)";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_materia.Text.Trim());
                        cmd.Parameters.AddWithValue("@estado", estadobd);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Materia agregada correctamente ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la materia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM materias WHERE id_materia = @id";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", txt_borrar.Text.Trim());

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Materia borrada correctamente ✅");
                        else
                            MessageBox.Show("No se encontró la materia con ese ID ❌");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la materia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarMaterias();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int estado = cb_estadoM.Checked ? 1 : 0;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();

                    string query = "UPDATE materias SET nombre = @nombre, estado = @estado WHERE id_materia = @id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_nombreM.Text.Trim());
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id.Text));

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Materia actualizada correctamente ✅");
                        else
                            MessageBox.Show("No se encontró la materia con ese ID ❌");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarMaterias();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            agregarMateria();
            cargarMaterias();
        }

        private void txt_materia_Enter(object sender, EventArgs e)
        {
            if (txt_materia.Text == "Ingrese el nombre...")
            {
                txt_materia.Text = "";
                txt_materia.ForeColor = Color.Black;
            }
        }

        private void txt_materia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_materia.Text))
            {
                txt_materia.Text = "Ingrese el nombre...";
                txt_materia.ForeColor = Color.Gray;
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            txt_materia.Text = "Ingrese el nombre...";
            txt_materia.ForeColor = Color.Gray;
            txt_nombreM.Text = "Ingrese el nombre...";
            txt_nombreM.ForeColor = Color.Gray;
            txt_id.Text = "Ingrese el id...";
            txt_id.ForeColor = Color.Gray;
            txt_borrar.Text = "Ingrese el id...";
            txt_borrar.ForeColor = Color.Gray;
        }

        private void txt_borrar_Enter(object sender, EventArgs e)
        {
            if (txt_borrar.Text == "Ingrese el id...")
            {
                txt_borrar.Text = "";
                txt_borrar.ForeColor = Color.Black;
            }
        }

        private void txt_borrar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_borrar.Text))
            {
                txt_borrar.Text = "Ingrese el id...";
                txt_borrar.ForeColor = Color.Gray;
            }
        }

        private void txt_id_Enter(object sender, EventArgs e)
        {
            if (txt_id.Text == "Ingrese el id...")
            {
                txt_id.Text = "";
                txt_id.ForeColor = Color.Black;
            }
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id.Text))
            {
                txt_id.Text = "Ingrese el id...";
                txt_id.ForeColor = Color.Gray;
            }
        }

        private void txt_nombreM_Enter(object sender, EventArgs e)
        {
            if (txt_nombreM.Text == "Ingrese el nombre...")
            {
                txt_nombreM.Text = "";
                txt_nombreM.ForeColor = Color.Black;
            }
        }

        private void txt_nombreM_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombreM.Text))
            {
                txt_nombreM.Text = "Ingrese el nombre...";
                txt_nombreM.ForeColor = Color.Gray;
            }
        }
    }
}
