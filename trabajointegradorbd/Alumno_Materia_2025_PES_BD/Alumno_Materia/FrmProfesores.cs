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
    public partial class FrmProfesores : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True";
        public FrmProfesores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {
            MostrarProfesores();
            dgvProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      

        }
        private void MostrarProfesores()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM profesores";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader lector;

                comando.CommandText = query;

                DataTable table = new DataTable();

                lector = comando.ExecuteReader();

                table.Load(lector);

                dgvProfesores.DataSource = table;

                conexion.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void btBuscarApellido_Click(object sender, EventArgs e)
        {
            if (txbBuscarApe.Text == "")
            {
              txbBuscarApe.Focus();
                MessageBox.Show("completar Campos");
                return;
            }
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM profesores WHERE apellido LIKE @apellido";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@apellido", "%" + txbBuscarApe.Text.Trim() + "%");
                SqlDataReader lector = comando.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(lector);

                dgvProfesores.DataSource = table;

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            limpiarDatosCargados();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btBuscarID_Click(object sender, EventArgs e)
        {
            if (txbBuscarID.Text == "")
            {
                txbBuscarID.Focus();
                MessageBox.Show("Ingrese un ID");
                return;
            }
            if (!int.TryParse(txbBuscarID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un numero");
                    return;
            }

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM profesores WHERE  id_profesor= @id";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(lector);

                dgvProfesores.DataSource = table;

                conexion.Close();
             limpiarDatosCargados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbEliminar.Text))
            {
                MessageBox.Show("Ingrese el ID del profesor a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txbEliminar.Text.Trim(), out int idProfesor))
            {
                MessageBox.Show("Ingrese un ID numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Confirmación del usuario
            DialogResult confirmar = MessageBox.Show(
                "¿Está seguro de eliminar este profesor? Las materias quedarán sin asignar.",
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
                        string actualizarMaterias = "UPDATE materias SET id_profesor = NULL WHERE id_profesor = @idProfesor";
                        SqlCommand cmdUpdate = new SqlCommand(actualizarMaterias, conexion, transaccion);
                        cmdUpdate.Parameters.AddWithValue("@idProfesor", idProfesor);
                        cmdUpdate.ExecuteNonQuery();

                        //se elimina el profesor
                        string eliminarProfesor = "DELETE FROM profesores WHERE id_profesor = @idProfesor";
                        SqlCommand cmdDelete = new SqlCommand(eliminarProfesor, conexion, transaccion);
                        cmdDelete.Parameters.AddWithValue("@idProfesor", idProfesor);

                        int filasEliminadas = cmdDelete.ExecuteNonQuery();

                        if (filasEliminadas > 0)
                        {
                            transaccion.Commit();
                            MessageBox.Show("Profesor eliminado correctamente.\nLas materias quedaron sin asignar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarProfesores();
                        }
                        else
                        {
                            transaccion.Rollback();
                            MessageBox.Show("No se encontró un profesor con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            int estado = cbestado.Checked ? 1 : 0;

            if (!int.TryParse(txtNewID.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID válido para modificar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"UPDATE profesores 
                                     SET nombre=@nombre, apellido=@apellido, email=@correo, 
                                     telefono=@telefono, estado=@estado
                                     WHERE id_profesor=@id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", txtNewname.Text.Trim());
                    comando.Parameters.AddWithValue("@apellido", txtNewapell.Text.Trim());
                    comando.Parameters.AddWithValue("@correo", txtNewemail.Text.Trim());
                    comando.Parameters.AddWithValue("@telefono", txtNewtel.Text.Trim());
                    comando.Parameters.AddWithValue("@estado", estado);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Profesor modificado correctamente.");
                        btnActualizar_Click(sender, e);
                        limpiarDatosCargados();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el ID especificado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }
        private void lbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarProfesores();
        }
        private void limpiarDatosCargados()
        {
            txbBuscarApe.Text = "";
            txbBuscarID.Text = "";
            txbEliminar.Text = "";
            txtNewname.Text = "";
            txtNewapell.Text = "";
            txtNewemail.Text = "";
            txtNewID.Text = "";
            txtNewtel.Text = "";
          
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProfesores.Rows[e.RowIndex];

                txtNewID.Text = fila.Cells["id_profesor"].Value?.ToString();
                txtNewname.Text = fila.Cells["nombre"].Value?.ToString();
                txtNewapell.Text = fila.Cells["apellido"].Value?.ToString();
                txtNewemail.Text = fila.Cells["email"].Value?.ToString();
                txtNewtel.Text = fila.Cells["telefono"].Value?.ToString();
                cbestado.Text = fila.Cells["estado"].Value?.ToString();
                


            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            int estadobd = cbestado.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(txtNewname.Text) ||
            string.IsNullOrWhiteSpace(txtNewapell.Text) ||
            string.IsNullOrWhiteSpace(txtNewemail.Text) ||
            string.IsNullOrWhiteSpace(txtNewtel.Text) ||
            string.IsNullOrWhiteSpace(cbestado.Text))
            {
                MessageBox.Show("Complete todos los campos antes de registrar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar formato de email
            if (!txtNewemail.Text.Contains("@") || !txtNewemail.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validar teléfono solo números
            if (!long.TryParse(txtNewtel.Text.Trim(), out _))
            {
                MessageBox.Show("El teléfono debe contener solo números.",
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
                    string verificarQuery = @"SELECT COUNT(*) FROM profesores 
                                  WHERE email = @correo OR 
                                        (nombre = @nombre AND apellido = @apellido)";

                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.AddWithValue("@correo", txtNewemail.Text.Trim());
                        verificarCmd.Parameters.AddWithValue("@nombre", txtNewname.Text.Trim());
                        verificarCmd.Parameters.AddWithValue("@apellido", txtNewapell.Text.Trim());

                        int existe = (int)verificarCmd.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe un profesor con los mismos datos.",
                                "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Detiene la ejecución del método
                        }
                    }

                    // 2️⃣ Si no existe, recién ahí inserta
                    string insertQuery = @"INSERT INTO profesores (nombre, apellido, email, telefono, estado)
                               VALUES (@nombre, @apellido, @correo, @telefono, @estado)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conexion))
                    {
                        insertCmd.Parameters.AddWithValue("@nombre", txtNewname.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@apellido", txtNewapell.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@correo", txtNewemail.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@telefono", txtNewtel.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@estado", cbestado.Checked ? 1 : 0);

                        int filas = insertCmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Profesor registrado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarDatosCargados();
                            MostrarProfesores();
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
          }

        private void btClear_Click(object sender, EventArgs e)
        {
            limpiarDatosCargados();
        }
    }
    }
