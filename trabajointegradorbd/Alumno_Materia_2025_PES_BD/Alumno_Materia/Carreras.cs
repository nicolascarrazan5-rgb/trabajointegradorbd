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
    public partial class Carreras : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True";
        public Carreras()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        private void MostrarCarreras()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM carreras";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader lector;

                comando.CommandText = query;

                DataTable table = new DataTable();

                lector = comando.ExecuteReader();

                table.Load(lector);

                dgvCarreras.DataSource = table;

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btMostrarCarerras_Click(object sender, EventArgs e)
        {
            MostrarCarreras();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            MostrarCarreras();
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btBuscarCarrera_Click(object sender, EventArgs e)
        {
            string txtBuscado = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtBuscado))
            {
                MessageBox.Show("Ingrese un texto para buscar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = @"SELECT * FROM carreras
                                   WHERE sede LIKE @busqueda 
                                   OR nombre LIKE @busqueda";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", "%" + txtBuscado + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCarreras.DataSource = dt;

                        if (dt.Rows.Count == 0)
                            MessageBox.Show("No se encontraron resultados.", "Sin resultados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            int estado = cbestado.Checked ? 1 : 0;

            if (!int.TryParse(txtNewIDcarrera.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID válido para modificar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = @"UPDATE carreras
                                     SET nombre=@nombre, sede=@sede, estado=@estado
                                     WHERE id_carrera=@id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);                   
                    comando.Parameters.AddWithValue("@nombre", txtNewCarreraname.Text.Trim());
                    comando.Parameters.AddWithValue("@sede", txtNewSede.Text.Trim());
                    comando.Parameters.AddWithValue("@estado", estado);
                   

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Carrera modificado correctamente.");
                        btMostrarCarerras_Click(sender, e);
                        
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

        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCarreras.Rows[e.RowIndex];

                txtNewCarreraname.Text = fila.Cells["nombre"].Value?.ToString(); 
                txtNewSede.Text = fila.Cells["sede"].Value?.ToString();
                txtNewIDcarrera.Text = fila.Cells["id_carrera"].Value?.ToString();
                cbestado.Text = fila.Cells["estado"].Value?.ToString();



            }
        }

        private void btID_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Focus();
                MessageBox.Show("Ingrese un ID");
                return;
            }
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un numero");
                return;
            }

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                string query = "SELECT * FROM carreras WHERE  id_carrera= @id";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(lector);

                dgvCarreras.DataSource = table;

                conexion.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Verifica si hay campos vacíos
            if (string.IsNullOrWhiteSpace(txtNewCarreraname.Text) ||
                string.IsNullOrWhiteSpace(txtNewSede.Text))
            {
                MessageBox.Show("Complete todos los campos antes de registrar la carrera.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del formulario
            string nombre = txtNewCarreraname.Text.Trim();
            string sede = txtNewSede.Text.Trim();
            int estado = cbestado.Checked ? 1 : 0;

            //Verifica si la carrera ya existe
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string verificarQuery = @"SELECT COUNT(*) FROM carreras 
                                      WHERE nombre = @nombre AND sede = @sede";

                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.AddWithValue("@nombre", nombre);
                        verificarCmd.Parameters.AddWithValue("@sede", sede);

                        int existe = (int)verificarCmd.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Ya existe una carrera con ese nombre en esa sede.",
                                "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Ingreso de nueva carrera
                    string insertQuery = @"INSERT INTO carreras (nombre, sede, estado)
                                   VALUES (@nombre, @sede, @estado)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conexion))
                    {
                        insertCmd.Parameters.AddWithValue("@nombre", nombre);
                        insertCmd.Parameters.AddWithValue("@sede", sede);
                        insertCmd.Parameters.AddWithValue("@estado", estado);

                        int filas = insertCmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Carrera registrada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            MostrarCarreras(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la carrera.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarDatosCargados()
        {
            txtNewCarreraname.Text = "";
            txtNewSede.Text = "";
            txtIDelete.Text = "";
            txtNewCarreraname.Text = "";
            txtID.Text = "";
            txtNewIDcarrera.Text = "";

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // verifica el id ingresado
            if (string.IsNullOrWhiteSpace(txtIDelete.Text))
            {
                MessageBox.Show("Ingrese o seleccione un ID de carrera para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // el ID debe ser numerico
            if (!int.TryParse(txtIDelete.Text, out int idCarrera))
            {
                MessageBox.Show("El ID ingresado no es válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // confirma la eliminacion
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta carrera?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // Proceso la eliminación
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = "DELETE FROM carreras WHERE id_carrera = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", idCarrera);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Carrera eliminada correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarCarreras(); // refrescar grilla
                           
                        }
                        else//en caso de surgir un error
                        {
                            MessageBox.Show("No se encontró una carrera con ese ID.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            //en caso de encontrar o no se logre la conexion
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarDatosCargados();
        }
    }
}
