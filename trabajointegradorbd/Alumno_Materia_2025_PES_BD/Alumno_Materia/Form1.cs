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
    public partial class Form1 : Form
    {
        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarAlumnos();
            cargarMaterias();
            cargarCursos();

            // Configura todas las columnas para que se ajusten al contenido más ancho (incluida la cabecera)
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos_Materias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void cargarAlumnos()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = "select id_alumno, apellido, nombre, legajo, dni from alumnos";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvAlumnos.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
        private void cargarMaterias()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryMateria = @"select m.id_materia, m.nombre, 
                                        c.nombre as carrera
                                        from materias m
                                        inner join
                                        carreras c on m.id_carrera = c.id_carrera";
                SqlCommand cmd = new SqlCommand(queryMateria, conn);
                cmd.CommandText = queryMateria;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvMaterias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void cargarCursos()
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

                dgvAlumnos_Materias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            txt_id_Alumn.Text = dgvAlumnos.SelectedCells[0].Value.ToString();
            lblAlumno.Text = dgvAlumnos.SelectedCells[1].Value.ToString();

        }

        private void dgvMaterias_DoubleClick(object sender, EventArgs e)
        {
            txt_Id_Materia.Text = dgvMaterias.SelectedCells[0].Value.ToString();
            lblMateria.Text=dgvMaterias.SelectedCells[1].Value.ToString();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            agregarAlumnoMateria();
            limpiarDatosCargados();
        }
        private void agregarAlumnoMateria()
        {
            if (txt_Id_Materia.Text == "" || txt_id_Alumn.Text == " ")
            {
                txt_id_Alumn.Focus();
                MessageBox.Show("completar Campos");
                return;
            }

            int alumno = int.Parse(txt_id_Alumn.Text);
            int materia = int.Parse(txt_Id_Materia.Text);

            string query = @"insert into  alumnos_materias
                            values (@alumno, @materia)";
            try
            {
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@alumno", alumno);
                cmd.Parameters.AddWithValue("@materia",materia);

                cmd.ExecuteNonQuery();

                MessageBox.Show("agregado al curso");

                con.Close();

                cargarCursos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscAlumno_TextChanged(object sender, EventArgs e)
        {
            if (rdbLejajo.Checked)
            {
                filtroAlumno_legajo();
            }
            else
            {
                if (rdbDni.Checked)
                {
                    filtroAlumno_DNI();
                }
                else
                {
                    if (rdbApellido.Checked)
                    {
                        filtroAlumno_Apellido();
                    }
                }
            }
        }
        private void filtroAlumno_legajo()
        {
            try 
            { 
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            string queryAlumno = @"select id_alumno, apellido, nombre, legajo, dni from alumnos
                                   where legajo like '%"+txtBuscAlumno.Text+"%'";
            SqlCommand cmd = new SqlCommand(queryAlumno, conn);
            cmd.CommandText = queryAlumno;
            
            SqlDataReader lector;

            lector = cmd.ExecuteReader();

            DataTable tabla = new DataTable();

            tabla.Load(lector);

            dgvAlumnos.DataSource = tabla;

            conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void filtroAlumno_Apellido()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select id_alumno, apellido, nombre, legajo, dni from alumnos
                                   where apellido like '%" + txtBuscAlumno.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvAlumnos.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void filtroAlumno_DNI()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select id_alumno, apellido, nombre, legajo, dni from alumnos
                                   where dni like '%" + txtBuscAlumno.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvAlumnos.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtBuscMaterias_TextChanged(object sender, EventArgs e)
        {
            if (rbtMateria.Checked)
            {
                filtroMateria_Nombre();
            }
            else
            {
                if (rbtCarrera.Checked)
                {
                    filtroMateria_Carrera();
                }
            }
        }

        private void txtBuscCursos_TextChanged(object sender, EventArgs e)
        {
            if (rbtAlumno.Checked)
            {
                filtroCurso_Legajo();
            }
            else
            {
                if (rbtCurso.Checked)
                {
                    filtroCurso_Materia();
                }
            }

        }
        private void filtroMateria_Nombre()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select
                                        m.id_materia, m.nombre, 
                                        c.nombre as carrera
                                        from materias m
                                        inner join
                                        carreras c on m.id_carrera = c.id_carrera
                                        where m.nombre like '%" + txtBuscMaterias.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvMaterias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void filtroMateria_Carrera()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();

                string queryAlumno = @"select
                                        m.id_materia, m.nombre, 
                                        c.nombre as carrera
                                        from materias m
                                        inner join
                                        carreras c on m.id_carrera = c.id_carrera
                                        where c.nombre like '%" + txtBuscMaterias.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvMaterias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void filtroCurso_Legajo()
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
                                    where a.legajo like '%" + txtBuscCursos.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvAlumnos_Materias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void filtroCurso_Materia()
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
                                    where mt.nombre like '%" + txtBuscCursos.Text + "%'";
                SqlCommand cmd = new SqlCommand(queryAlumno, conn);
                cmd.CommandText = queryAlumno;

                SqlDataReader lector;

                lector = cmd.ExecuteReader();

                DataTable tabla = new DataTable();

                tabla.Load(lector);

                dgvAlumnos_Materias.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void limpiarDatosCargados()
        {
            txt_id_Alumn.Text = "";
            txt_Id_Materia.Text = "";
            lblAlumno.Text = "";
            lblMateria.Text = "";
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            CursoAlumnos cursoAlumnos = new CursoAlumnos();
            cursoAlumnos.ShowDialog();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void txt_id_Alumn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
