namespace Alumno_Materia
{
    partial class FrmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlumnos));
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lbbuscarNombre = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btBuscarNombre = new System.Windows.Forms.Button();
            this.lbEliminarAlumno = new System.Windows.Forms.Label();
            this.richtextEliminarAlumno = new System.Windows.Forms.RichTextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lbAgregarOactualizarAlumno = new System.Windows.Forms.Label();
            this.richTextNombre = new System.Windows.Forms.RichTextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.richTextApellido = new System.Windows.Forms.RichTextBox();
            this.richTextEmail = new System.Windows.Forms.RichTextBox();
            this.richTextTelefono = new System.Windows.Forms.RichTextBox();
            this.richText_ID = new System.Windows.Forms.RichTextBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.btRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(201, 22);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(561, 317);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // lbbuscarNombre
            // 
            this.lbbuscarNombre.AutoSize = true;
            this.lbbuscarNombre.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscarNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbbuscarNombre.Location = new System.Drawing.Point(35, 22);
            this.lbbuscarNombre.Name = "lbbuscarNombre";
            this.lbbuscarNombre.Size = new System.Drawing.Size(142, 19);
            this.lbbuscarNombre.TabIndex = 1;
            this.lbbuscarNombre.Text = "Buscar por nombre";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 27);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btBuscarNombre
            // 
            this.btBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBuscarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarNombre.FlatAppearance.BorderSize = 0;
            this.btBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarNombre.Font = new System.Drawing.Font("Verdana", 9F);
            this.btBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.btBuscarNombre.Location = new System.Drawing.Point(39, 103);
            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Size = new System.Drawing.Size(138, 30);
            this.btBuscarNombre.TabIndex = 3;
            this.btBuscarNombre.Text = "Buscar";
            this.btBuscarNombre.UseVisualStyleBackColor = false;
            this.btBuscarNombre.Click += new System.EventHandler(this.btBuscarNombre_Click);
            // 
            // lbEliminarAlumno
            // 
            this.lbEliminarAlumno.AutoSize = true;
            this.lbEliminarAlumno.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminarAlumno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbEliminarAlumno.Location = new System.Drawing.Point(26, 161);
            this.lbEliminarAlumno.Name = "lbEliminarAlumno";
            this.lbEliminarAlumno.Size = new System.Drawing.Size(169, 19);
            this.lbEliminarAlumno.TabIndex = 4;
            this.lbEliminarAlumno.Text = "Eliminar alumno por ID";
            // 
            // richtextEliminarAlumno
            // 
            this.richtextEliminarAlumno.Location = new System.Drawing.Point(39, 199);
            this.richtextEliminarAlumno.Name = "richtextEliminarAlumno";
            this.richtextEliminarAlumno.Size = new System.Drawing.Size(138, 27);
            this.richtextEliminarAlumno.TabIndex = 5;
            this.richtextEliminarAlumno.Text = "";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(39, 244);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(138, 30);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lbAgregarOactualizarAlumno
            // 
            this.lbAgregarOactualizarAlumno.AutoSize = true;
            this.lbAgregarOactualizarAlumno.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarOactualizarAlumno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbAgregarOactualizarAlumno.Location = new System.Drawing.Point(768, 22);
            this.lbAgregarOactualizarAlumno.Name = "lbAgregarOactualizarAlumno";
            this.lbAgregarOactualizarAlumno.Size = new System.Drawing.Size(202, 19);
            this.lbAgregarOactualizarAlumno.TabIndex = 7;
            this.lbAgregarOactualizarAlumno.Text = "Agregar/Actualizar Alumno";
            // 
            // richTextNombre
            // 
            this.richTextNombre.Location = new System.Drawing.Point(821, 63);
            this.richTextNombre.Name = "richTextNombre";
            this.richTextNombre.Size = new System.Drawing.Size(138, 16);
            this.richTextNombre.TabIndex = 8;
            this.richTextNombre.Text = "";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNombre.Location = new System.Drawing.Point(768, 63);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbApellido.Location = new System.Drawing.Point(768, 92);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(47, 13);
            this.lbApellido.TabIndex = 10;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbEmail.Location = new System.Drawing.Point(789, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(26, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Dni:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTelefono.Location = new System.Drawing.Point(773, 149);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(42, 13);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "Legajo:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lb_ID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_ID.Location = new System.Drawing.Point(794, 268);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(21, 13);
            this.lb_ID.TabIndex = 13;
            this.lb_ID.Text = "ID:";
            // 
            // richTextApellido
            // 
            this.richTextApellido.Location = new System.Drawing.Point(821, 92);
            this.richTextApellido.Name = "richTextApellido";
            this.richTextApellido.Size = new System.Drawing.Size(138, 16);
            this.richTextApellido.TabIndex = 14;
            this.richTextApellido.Text = "";
            // 
            // richTextEmail
            // 
            this.richTextEmail.Location = new System.Drawing.Point(821, 120);
            this.richTextEmail.Name = "richTextEmail";
            this.richTextEmail.Size = new System.Drawing.Size(138, 16);
            this.richTextEmail.TabIndex = 15;
            this.richTextEmail.Text = "";
            this.richTextEmail.TextChanged += new System.EventHandler(this.richTextEmail_TextChanged);
            // 
            // richTextTelefono
            // 
            this.richTextTelefono.Location = new System.Drawing.Point(821, 149);
            this.richTextTelefono.Name = "richTextTelefono";
            this.richTextTelefono.Size = new System.Drawing.Size(138, 16);
            this.richTextTelefono.TabIndex = 16;
            this.richTextTelefono.Text = "";
            // 
            // richText_ID
            // 
            this.richText_ID.Location = new System.Drawing.Point(821, 265);
            this.richText_ID.Name = "richText_ID";
            this.richText_ID.Size = new System.Drawing.Size(59, 16);
            this.richText_ID.TabIndex = 17;
            this.richText_ID.Text = "";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxEstado.Location = new System.Drawing.Point(821, 176);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEstado.TabIndex = 18;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderSize = 0;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Location = new System.Drawing.Point(821, 219);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(138, 30);
            this.btAgregar.TabIndex = 19;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualizar.FlatAppearance.BorderSize = 0;
            this.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btActualizar.ForeColor = System.Drawing.Color.White;
            this.btActualizar.Location = new System.Drawing.Point(821, 309);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(138, 30);
            this.btActualizar.TabIndex = 20;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVolver.FlatAppearance.BorderSize = 0;
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Font = new System.Drawing.Font("Verdana", 9F);
            this.btVolver.ForeColor = System.Drawing.Color.White;
            this.btVolver.Location = new System.Drawing.Point(39, 309);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(138, 30);
            this.btVolver.TabIndex = 21;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btRefrescar
            // 
            this.btRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRefrescar.FlatAppearance.BorderSize = 0;
            this.btRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefrescar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btRefrescar.ForeColor = System.Drawing.Color.White;
            this.btRefrescar.Location = new System.Drawing.Point(412, 345);
            this.btRefrescar.Name = "btRefrescar";
            this.btRefrescar.Size = new System.Drawing.Size(135, 27);
            this.btRefrescar.TabIndex = 22;
            this.btRefrescar.Text = "Clear";
            this.btRefrescar.UseVisualStyleBackColor = false;
            this.btRefrescar.Click += new System.EventHandler(this.btRefrescar_Click);
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(981, 384);
            this.Controls.Add(this.btRefrescar);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.richText_ID);
            this.Controls.Add(this.richTextTelefono);
            this.Controls.Add(this.richTextEmail);
            this.Controls.Add(this.richTextApellido);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.richTextNombre);
            this.Controls.Add(this.lbAgregarOactualizarAlumno);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.richtextEliminarAlumno);
            this.Controls.Add(this.lbEliminarAlumno);
            this.Controls.Add(this.btBuscarNombre);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbbuscarNombre);
            this.Controls.Add(this.dgvAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lbbuscarNombre;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btBuscarNombre;
        private System.Windows.Forms.Label lbEliminarAlumno;
        private System.Windows.Forms.RichTextBox richtextEliminarAlumno;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lbAgregarOactualizarAlumno;
        private System.Windows.Forms.RichTextBox richTextNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.RichTextBox richTextApellido;
        private System.Windows.Forms.RichTextBox richTextEmail;
        private System.Windows.Forms.RichTextBox richTextTelefono;
        private System.Windows.Forms.RichTextBox richText_ID;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btRefrescar;
    }
}