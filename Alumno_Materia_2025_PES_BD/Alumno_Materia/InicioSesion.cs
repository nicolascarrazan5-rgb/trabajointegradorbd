using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class InicioSesion : Form
    {

        string cadena = "Server =localhost\\SQLEXPRESS; Database=GestionAcademica; Trusted_Connection=True ";



        public InicioSesion()
        {
            InitializeComponent();
        }

        private void iniciosesion()
        {
            string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @user AND clave = @pass";

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user", txt_usuario.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_contraseña.Text);

                    int existe = (int)cmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
       
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_contraseña.Text == "")
            {
                MessageBox.Show("Completar campos");
                return;
            }
            else
            {
                iniciosesion();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
