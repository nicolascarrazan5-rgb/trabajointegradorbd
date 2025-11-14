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
    public partial class FrmAlumnos : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True";
        public FrmAlumnos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void MostrarAlumnos()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM alumnos";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader lector;

                comando.CommandText = query;

                DataTable table = new DataTable();

                lector = comando.ExecuteReader();

                table.Load(lector);

                dgvAlumnos.DataSource = table;

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) //textbox de Buscar Por nombre
        {
            
        }

        private void btBuscarNombre_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Focus();
                MessageBox.Show("completar Campos");
                return;
            }
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM alumnos WHERE nombre LIKE @nombre";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", "%" + richTextBox1.Text.Trim() + "%");
                SqlDataReader lector = comando.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(lector);

                dgvAlumnos.DataSource = table;

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            limpiar();
            
        }
        

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richtextEliminarAlumno.Text))
            {
                MessageBox.Show("Ingrese el ID del alumno a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(richtextEliminarAlumno.Text.Trim(), out int idAlumno))
            {
                MessageBox.Show("Ingrese un ID numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmación del usuario
            DialogResult confirmar = MessageBox.Show(
                "¿Está seguro de eliminar este alumno?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.No)
                return;

            //Conexión a base de datos y eliminación
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    SqlTransaction transaccion = conexion.BeginTransaction();

                    try
                    {
                        //se quita con las relación en las materias
                        string actualizarAlumnos_Materias =
                        "DELETE FROM alumnos_materias WHERE id_alumno = @idAlumno";
                        SqlCommand cmdUpdate = new SqlCommand(actualizarAlumnos_Materias, conexion, transaccion);
                        cmdUpdate.Parameters.AddWithValue("@idAlumno", idAlumno);
                        cmdUpdate.ExecuteNonQuery();

                        //se elimina el alumno
                        string eliminarAlumno = "DELETE FROM alumnos WHERE id_alumno = @idAlumno";
                        SqlCommand cmdDelete = new SqlCommand(eliminarAlumno, conexion, transaccion);
                        cmdDelete.Parameters.AddWithValue("@idAlumno", idAlumno);

                        int filasEliminadas = cmdDelete.ExecuteNonQuery();

                        if (filasEliminadas > 0)
                        {
                            transaccion.Commit();
                            MessageBox.Show("Alumno eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarAlumnos();
                        }
                        else
                        {
                            transaccion.Rollback();
                            MessageBox.Show("No se encontró un alumno con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exSQL)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error durante la eliminación: " + exSQL.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
            MostrarAlumnos();

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            int estadobd = checkBoxEstado.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(richTextNombre.Text) ||
            string.IsNullOrWhiteSpace(richTextApellido.Text) ||
            string.IsNullOrWhiteSpace(richTextEmail.Text) ||
            string.IsNullOrWhiteSpace(richTextTelefono.Text) ||
            string.IsNullOrWhiteSpace(checkBoxEstado.Text))
            {
                MessageBox.Show("Complete todos los campos antes de registrar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar dni solo numeros
            if (!long.TryParse(richTextEmail.Text.Trim(), out _))
            {
                MessageBox.Show("El DNI solo debe contener numeros.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar Legajo solo numeros
            if (!long.TryParse(richTextTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("El legajo debe contener solo números.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexión y registro
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    // 1️⃣ Verificar si ya existe un profesor con el mismo correo o nombre y apellido
                    string verificarQuery = @"SELECT COUNT(*) FROM alumnos 
                                  WHERE dni = @dni OR legajo = @legajo OR
                                        (nombre = @nombre AND apellido = @apellido)";

                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.AddWithValue("@dni", richTextEmail.Text.Trim());
                        verificarCmd.Parameters.AddWithValue("@legajo", richTextTelefono.Text.Trim());
                        verificarCmd.Parameters.AddWithValue("@nombre", richTextNombre.Text.Trim());
                        verificarCmd.Parameters.AddWithValue("@apellido", richTextApellido.Text.Trim());

                        int existe = (int)verificarCmd.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe un alumno con los mismos datos.",
                                "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene la ejecución del método
                        }
                    }

                    // 2️⃣ Si no existe, recién ahí inserta
                    string insertQuery = @"INSERT INTO alumnos (nombre, apellido, dni, legajo, estado)
                               VALUES (@nombre, @apellido, @dni, @legajo, @estado)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conexion))
                    {
                        insertCmd.Parameters.AddWithValue("@nombre", richTextNombre.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@apellido", richTextApellido.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@dni", richTextEmail.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@legajo", richTextTelefono.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@estado", checkBoxEstado.Checked ? 1 : 0);

                        int filas = insertCmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Alumno registrado Correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpiar();
                            MostrarAlumnos();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
            MostrarAlumnos();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int estado = checkBoxEstado.Checked ? 1 : 0;

            if (!int.TryParse(richText_ID.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID válido para modificar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"UPDATE alumnos 
                                     SET nombre=@nombre, apellido=@apellido, dni=@dni, 
                                     legajo=@legajo, estado=@estado
                                     WHERE id_alumno=@id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", richTextNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@apellido", richTextApellido.Text.Trim());
                    comando.Parameters.AddWithValue("@dni", richTextEmail.Text.Trim());
                    comando.Parameters.AddWithValue("@legajo", richTextTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@estado", estado);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Alumno actualizado correctamente.");
                        limpiar();
                        MostrarAlumnos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
        private void limpiar()
        {
            richTextBox1.Text = "";
            richText_ID.Text = "";
            richTextNombre.Text = "";
            richTextApellido.Text = "";
            richTextEmail.Text = "";
            richTextTelefono.Text = "";
            richtextEliminarAlumno.Text = "";

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRefrescar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
            limpiar();
        }
    }
}
