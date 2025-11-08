namespace Alumno_Materia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos_Materias = new System.Windows.Forms.DataGridView();
            this.gbxAlumnos = new System.Windows.Forms.GroupBox();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbDni = new System.Windows.Forms.RadioButton();
            this.rdbLejajo = new System.Windows.Forms.RadioButton();
            this.txtBuscAlumno = new System.Windows.Forms.TextBox();
            this.gbxMaterias = new System.Windows.Forms.GroupBox();
            this.rbtCarrera = new System.Windows.Forms.RadioButton();
            this.rbtMateria = new System.Windows.Forms.RadioButton();
            this.txtBuscMaterias = new System.Windows.Forms.TextBox();
            this.gbxCursos = new System.Windows.Forms.GroupBox();
            this.rbtCurso = new System.Windows.Forms.RadioButton();
            this.rbtAlumno = new System.Windows.Forms.RadioButton();
            this.txtBuscCursos = new System.Windows.Forms.TextBox();
            this.txt_id_Alumn = new System.Windows.Forms.TextBox();
            this.txt_Id_Materia = new System.Windows.Forms.TextBox();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCombos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos_Materias)).BeginInit();
            this.gbxAlumnos.SuspendLayout();
            this.gbxMaterias.SuspendLayout();
            this.gbxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(24, 75);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(416, 160);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            this.dgvAlumnos.DoubleClick += new System.EventHandler(this.dgvAlumnos_DoubleClick);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(460, 75);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(525, 160);
            this.dgvMaterias.TabIndex = 1;
            this.dgvMaterias.DoubleClick += new System.EventHandler(this.dgvMaterias_DoubleClick);
            // 
            // dgvAlumnos_Materias
            // 
            this.dgvAlumnos_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos_Materias.Location = new System.Drawing.Point(24, 293);
            this.dgvAlumnos_Materias.Name = "dgvAlumnos_Materias";
            this.dgvAlumnos_Materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos_Materias.Size = new System.Drawing.Size(740, 216);
            this.dgvAlumnos_Materias.TabIndex = 2;
            // 
            // gbxAlumnos
            // 
            this.gbxAlumnos.Controls.Add(this.rdbApellido);
            this.gbxAlumnos.Controls.Add(this.rdbDni);
            this.gbxAlumnos.Controls.Add(this.rdbLejajo);
            this.gbxAlumnos.Controls.Add(this.txtBuscAlumno);
            this.gbxAlumnos.Location = new System.Drawing.Point(24, 23);
            this.gbxAlumnos.Name = "gbxAlumnos";
            this.gbxAlumnos.Size = new System.Drawing.Size(416, 46);
            this.gbxAlumnos.TabIndex = 6;
            this.gbxAlumnos.TabStop = false;
            this.gbxAlumnos.Text = "ALUMNOS:";
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(299, 19);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(77, 17);
            this.rdbApellido.TabIndex = 3;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "APELLIDO";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // rdbDni
            // 
            this.rdbDni.AutoSize = true;
            this.rdbDni.Location = new System.Drawing.Point(239, 20);
            this.rdbDni.Name = "rdbDni";
            this.rdbDni.Size = new System.Drawing.Size(44, 17);
            this.rdbDni.TabIndex = 2;
            this.rdbDni.TabStop = true;
            this.rdbDni.Text = "DNI";
            this.rdbDni.UseVisualStyleBackColor = true;
            // 
            // rdbLejajo
            // 
            this.rdbLejajo.AutoSize = true;
            this.rdbLejajo.Location = new System.Drawing.Point(167, 19);
            this.rdbLejajo.Name = "rdbLejajo";
            this.rdbLejajo.Size = new System.Drawing.Size(57, 17);
            this.rdbLejajo.TabIndex = 1;
            this.rdbLejajo.TabStop = true;
            this.rdbLejajo.Text = "Legajo";
            this.rdbLejajo.UseVisualStyleBackColor = true;
            // 
            // txtBuscAlumno
            // 
            this.txtBuscAlumno.Location = new System.Drawing.Point(6, 19);
            this.txtBuscAlumno.Name = "txtBuscAlumno";
            this.txtBuscAlumno.Size = new System.Drawing.Size(144, 20);
            this.txtBuscAlumno.TabIndex = 0;
            this.txtBuscAlumno.TextChanged += new System.EventHandler(this.txtBuscAlumno_TextChanged);
            // 
            // gbxMaterias
            // 
            this.gbxMaterias.Controls.Add(this.rbtCarrera);
            this.gbxMaterias.Controls.Add(this.rbtMateria);
            this.gbxMaterias.Controls.Add(this.txtBuscMaterias);
            this.gbxMaterias.Location = new System.Drawing.Point(460, 23);
            this.gbxMaterias.Name = "gbxMaterias";
            this.gbxMaterias.Size = new System.Drawing.Size(416, 46);
            this.gbxMaterias.TabIndex = 7;
            this.gbxMaterias.TabStop = false;
            this.gbxMaterias.Text = "MATERIAS:";
            // 
            // rbtCarrera
            // 
            this.rbtCarrera.AutoSize = true;
            this.rbtCarrera.Location = new System.Drawing.Point(291, 20);
            this.rbtCarrera.Name = "rbtCarrera";
            this.rbtCarrera.Size = new System.Drawing.Size(59, 17);
            this.rbtCarrera.TabIndex = 2;
            this.rbtCarrera.TabStop = true;
            this.rbtCarrera.Text = "Carrera";
            this.rbtCarrera.UseVisualStyleBackColor = true;
            // 
            // rbtMateria
            // 
            this.rbtMateria.AutoSize = true;
            this.rbtMateria.Location = new System.Drawing.Point(190, 19);
            this.rbtMateria.Name = "rbtMateria";
            this.rbtMateria.Size = new System.Drawing.Size(60, 17);
            this.rbtMateria.TabIndex = 1;
            this.rbtMateria.TabStop = true;
            this.rbtMateria.Text = "Materia";
            this.rbtMateria.UseVisualStyleBackColor = true;
            // 
            // txtBuscMaterias
            // 
            this.txtBuscMaterias.Location = new System.Drawing.Point(6, 19);
            this.txtBuscMaterias.Name = "txtBuscMaterias";
            this.txtBuscMaterias.Size = new System.Drawing.Size(160, 20);
            this.txtBuscMaterias.TabIndex = 0;
            this.txtBuscMaterias.TextChanged += new System.EventHandler(this.txtBuscMaterias_TextChanged);
            // 
            // gbxCursos
            // 
            this.gbxCursos.Controls.Add(this.rbtCurso);
            this.gbxCursos.Controls.Add(this.rbtAlumno);
            this.gbxCursos.Controls.Add(this.txtBuscCursos);
            this.gbxCursos.Location = new System.Drawing.Point(24, 241);
            this.gbxCursos.Name = "gbxCursos";
            this.gbxCursos.Size = new System.Drawing.Size(416, 46);
            this.gbxCursos.TabIndex = 7;
            this.gbxCursos.TabStop = false;
            this.gbxCursos.Text = "CURSOS:";
            // 
            // rbtCurso
            // 
            this.rbtCurso.AutoSize = true;
            this.rbtCurso.Location = new System.Drawing.Point(291, 20);
            this.rbtCurso.Name = "rbtCurso";
            this.rbtCurso.Size = new System.Drawing.Size(52, 17);
            this.rbtCurso.TabIndex = 2;
            this.rbtCurso.TabStop = true;
            this.rbtCurso.Text = "Curso";
            this.rbtCurso.UseVisualStyleBackColor = true;
            // 
            // rbtAlumno
            // 
            this.rbtAlumno.AutoSize = true;
            this.rbtAlumno.Location = new System.Drawing.Point(190, 19);
            this.rbtAlumno.Name = "rbtAlumno";
            this.rbtAlumno.Size = new System.Drawing.Size(57, 17);
            this.rbtAlumno.TabIndex = 1;
            this.rbtAlumno.TabStop = true;
            this.rbtAlumno.Text = "Lejago";
            this.rbtAlumno.UseVisualStyleBackColor = true;
            // 
            // txtBuscCursos
            // 
            this.txtBuscCursos.Location = new System.Drawing.Point(6, 19);
            this.txtBuscCursos.Name = "txtBuscCursos";
            this.txtBuscCursos.Size = new System.Drawing.Size(160, 20);
            this.txtBuscCursos.TabIndex = 0;
            this.txtBuscCursos.TextChanged += new System.EventHandler(this.txtBuscCursos_TextChanged);
            // 
            // txt_id_Alumn
            // 
            this.txt_id_Alumn.Enabled = false;
            this.txt_id_Alumn.Location = new System.Drawing.Point(812, 260);
            this.txt_id_Alumn.Multiline = true;
            this.txt_id_Alumn.Name = "txt_id_Alumn";
            this.txt_id_Alumn.Size = new System.Drawing.Size(42, 27);
            this.txt_id_Alumn.TabIndex = 8;
            // 
            // txt_Id_Materia
            // 
            this.txt_Id_Materia.Enabled = false;
            this.txt_Id_Materia.Location = new System.Drawing.Point(915, 260);
            this.txt_Id_Materia.Multiline = true;
            this.txt_Id_Materia.Name = "txt_Id_Materia";
            this.txt_Id_Materia.Size = new System.Drawing.Size(42, 27);
            this.txt_Id_Materia.TabIndex = 9;
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.Location = new System.Drawing.Point(784, 306);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(201, 39);
            this.btnAgregarCurso.TabIndex = 10;
            this.btnAgregarCurso.Text = "AGREGAR CURSO";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(912, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Materia:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(809, 290);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(0, 13);
            this.lblAlumno.TabIndex = 13;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(912, 290);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(0, 13);
            this.lblMateria.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Doble click en grilla Alumnos \r\ny Doble click en grilla de Materias ";
            // 
            // btnCombos
            // 
            this.btnCombos.Location = new System.Drawing.Point(784, 470);
            this.btnCombos.Name = "btnCombos";
            this.btnCombos.Size = new System.Drawing.Size(70, 39);
            this.btnCombos.TabIndex = 16;
            this.btnCombos.Text = "Combos";
            this.btnCombos.UseVisualStyleBackColor = true;
            this.btnCombos.Click += new System.EventHandler(this.btnCombos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 530);
            this.Controls.Add(this.btnCombos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.txt_Id_Materia);
            this.Controls.Add(this.txt_id_Alumn);
            this.Controls.Add(this.gbxCursos);
            this.Controls.Add(this.gbxMaterias);
            this.Controls.Add(this.gbxAlumnos);
            this.Controls.Add(this.dgvAlumnos_Materias);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "ALUMNO_MATERIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos_Materias)).EndInit();
            this.gbxAlumnos.ResumeLayout(false);
            this.gbxAlumnos.PerformLayout();
            this.gbxMaterias.ResumeLayout(false);
            this.gbxMaterias.PerformLayout();
            this.gbxCursos.ResumeLayout(false);
            this.gbxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridView dgvAlumnos_Materias;
        private System.Windows.Forms.GroupBox gbxAlumnos;
        private System.Windows.Forms.RadioButton rdbDni;
        private System.Windows.Forms.RadioButton rdbLejajo;
        private System.Windows.Forms.TextBox txtBuscAlumno;
        private System.Windows.Forms.GroupBox gbxMaterias;
        private System.Windows.Forms.RadioButton rbtCarrera;
        private System.Windows.Forms.RadioButton rbtMateria;
        private System.Windows.Forms.TextBox txtBuscMaterias;
        private System.Windows.Forms.GroupBox gbxCursos;
        private System.Windows.Forms.RadioButton rbtCurso;
        private System.Windows.Forms.RadioButton rbtAlumno;
        private System.Windows.Forms.TextBox txtBuscCursos;
        private System.Windows.Forms.TextBox txt_id_Alumn;
        private System.Windows.Forms.TextBox txt_Id_Materia;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.Button btnCombos;
    }
}

