using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Alumno_Materia
{
    public partial class CursoAlumnos : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True ";

        int contador;

        public CursoAlumnos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CursoAlumnos_Load(object sender, EventArgs e)
        {
            contador = 0;
            cargar_combo_carrera();
            cargar_alumno_materia();
            cargar_combo_alumnos();
            dgv_alumnos_materias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        
        private void cargar_combo_carrera()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select 
                                        id_carrera,
                                        nombre
                                        from carreras";
                SqlCommand cmdAlumno = new SqlCommand(queryAlumno, conn);
                cmdAlumno.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmdAlumno.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                cboCarrera.DataSource = tabla;
                cboCarrera.DisplayMember = "nombre";
                cboCarrera.ValueMember = "id_carrera";


                conn.Close();

                cargar_materias_porId((int)cboCarrera.SelectedValue);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cargar_materias_porId(int carrera)
        {
           
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryMateria = @"select
                                        m.id_materia as id,
                                        m.nombre as nomb 
                                        from materias m
                                        where m.id_carrera = "+carrera+"";
                SqlCommand cmd = new SqlCommand(queryMateria, conn);
                cmd.CommandText = queryMateria;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                cbxMaterias.DataSource = tabla;
                cbxMaterias.DisplayMember = "nomb";
                cbxMaterias.ValueMember = "id";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                contador++;
                if (contador < 3)
                {
                    //MessageBox.Show($"hola, {contador}");
                    cargar_materias_porId(1);
                }
                else
                {
                    cargar_materias_porId((int)cboCarrera.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargar_alumno_materia()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select 
                                    a.legajo, concat(a.apellido,', ',a.nombre) as Nomb_Alumno,
                                    mt.nombre as MATERIA ,
                                    pf.apellido as Profesor,
                                    c.nombre as CARRERA 
                                    from alumnos_materias am
                                    inner join 
                                    alumnos a on a.id_alumno = am.id_alumno
                                    inner join 
                                    materias mt on mt.id_materia = am.id_materia
                                    inner join 
                                    Profesores pf on pf.id_profesor = mt.id_profesor
                                    inner join carreras c on c.id_carrera = mt.id_carrera
                                    ";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgv_alumnos_materias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cargar_combo_alumnos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select id_alumno,
                                       apellido, nombre, legajo, dni,
                                       concat(apellido, ' - ', nombre ,' - ',legajo) as titulo
                                       from alumnos
                                       order by titulo";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                cbxAlumnos.DataSource = tabla;
                cbxAlumnos.DisplayMember = "titulo";
                cbxAlumnos.ValueMember = "id_alumno";

                conn.Close();
            }
            catch (Exception ex)
            {   
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarCurso_Click(object sender, EventArgs e)
        {
            if (cbxAlumnos.Text!=string.Empty && cbxMaterias.Text!=string.Empty)
            {
                int alumno = (int)cbxAlumnos.SelectedValue;
                txtAlumno.Text = alumno.ToString();
                lbl_alumno.Text = cbxAlumnos.Text;
                int materia = (int)cbxMaterias.SelectedValue;
                txtMateria.Text = materia.ToString();
                lbl_materia.Text = cbxMaterias.Text;
            }
            else
            {
                MessageBox.Show("seleccione desde desplegables");
            }
            
        }
        private void Agregar_alumno_curso()
        {
            int alumno = (int)cbxAlumnos.SelectedValue;
            int materia = (int)cbxMaterias.SelectedValue;
            string alum = lbl_alumno.Text;
            string mat = lbl_materia.Text;

            if (txtAlumno.Text =="" || txtMateria.Text == "")
            {
                MessageBox.Show("seleccione alumno y Carrera desde los desplegables");
                return;
            }
            string query = @"insert into  alumnos_materias
                            values (@alumno, @materia)";
            try
            {
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@alumno", alumno);
                cmd.Parameters.AddWithValue("@materia", materia);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"agregado el alumno {alum} al curso {mat}");

                con.Close();

                cargar_alumno_materia();

                cbxAlumnos.Text = string.Empty;
                cbxMaterias.Text = string.Empty;
                cboCarrera.Text = string.Empty;

                txtAlumno.Text = string.Empty;
                txtMateria.Text = string.Empty;

                lbl_alumno.Text = string.Empty;
                lbl_materia.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void bntGrabar_Click(object sender, EventArgs e)
        {
            Agregar_alumno_curso();
        }

        private void dgv_alumnos_materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
