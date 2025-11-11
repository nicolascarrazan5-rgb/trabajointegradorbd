namespace Alumno_Materia
{
    partial class CursoAlumnos
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
            this.dgv_alumnos_materias = new System.Windows.Forms.DataGridView();
            this.cbxAlumnos = new System.Windows.Forms.ComboBox();
            this.cbxMaterias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lbl_alumno = new System.Windows.Forms.Label();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.cargarCurso = new System.Windows.Forms.Button();
            this.bntGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alumnos_materias
            // 
            this.dgv_alumnos_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alumnos_materias.Location = new System.Drawing.Point(12, 12);
            this.dgv_alumnos_materias.Name = "dgv_alumnos_materias";
            this.dgv_alumnos_materias.Size = new System.Drawing.Size(720, 176);
            this.dgv_alumnos_materias.TabIndex = 0;
            this.dgv_alumnos_materias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alumnos_materias_CellContentClick);
            // 
            // cbxAlumnos
            // 
            this.cbxAlumnos.FormattingEnabled = true;
            this.cbxAlumnos.Location = new System.Drawing.Point(12, 207);
            this.cbxAlumnos.Name = "cbxAlumnos";
            this.cbxAlumnos.Size = new System.Drawing.Size(282, 21);
            this.cbxAlumnos.TabIndex = 1;
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.FormattingEnabled = true;
            this.cbxMaterias.Location = new System.Drawing.Point(12, 287);
            this.cbxMaterias.Name = "cbxMaterias";
            this.cbxMaterias.Size = new System.Drawing.Size(282, 21);
            this.cbxMaterias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALUMNOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MATERIAS:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(468, 248);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(63, 20);
            this.txtAlumno.TabIndex = 5;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(468, 207);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(63, 20);
            this.txtMateria.TabIndex = 6;
            // 
            // lbl_alumno
            // 
            this.lbl_alumno.AutoSize = true;
            this.lbl_alumno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_alumno.Location = new System.Drawing.Point(465, 231);
            this.lbl_alumno.Name = "lbl_alumno";
            this.lbl_alumno.Size = new System.Drawing.Size(42, 13);
            this.lbl_alumno.TabIndex = 7;
            this.lbl_alumno.Text = "nombre";
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_materia.Location = new System.Drawing.Point(465, 191);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(41, 13);
            this.lbl_materia.TabIndex = 8;
            this.lbl_materia.Text = "materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CARRERAS:";
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(12, 247);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(282, 21);
            this.cboCarrera.TabIndex = 9;
            this.cboCarrera.SelectedIndexChanged += new System.EventHandler(this.cboCarrera_SelectedIndexChanged);
            // 
            // cargarCurso
            // 
            this.cargarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cargarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cargarCurso.FlatAppearance.BorderSize = 0;
            this.cargarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cargarCurso.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.cargarCurso.ForeColor = System.Drawing.Color.White;
            this.cargarCurso.Location = new System.Drawing.Point(324, 236);
            this.cargarCurso.Name = "cargarCurso";
            this.cargarCurso.Size = new System.Drawing.Size(113, 40);
            this.cargarCurso.TabIndex = 11;
            this.cargarCurso.Text = "CargarCurso";
            this.cargarCurso.UseVisualStyleBackColor = true;
            this.cargarCurso.Click += new System.EventHandler(this.cargarCurso_Click);
            // 
            // bntGrabar
            // 
            this.bntGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bntGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGrabar.FlatAppearance.BorderSize = 0;
            this.bntGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGrabar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.bntGrabar.ForeColor = System.Drawing.Color.White;
            this.bntGrabar.Location = new System.Drawing.Point(468, 276);
            this.bntGrabar.Name = "bntGrabar";
            this.bntGrabar.Size = new System.Drawing.Size(113, 40);
            this.bntGrabar.TabIndex = 12;
            this.bntGrabar.Text = "GrabarCurso";
            this.bntGrabar.UseVisualStyleBackColor = true;
            this.bntGrabar.Click += new System.EventHandler(this.bntGrabar_Click);
            // 
            // CursoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(742, 324);
            this.Controls.Add(this.bntGrabar);
            this.Controls.Add(this.cargarCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.lbl_alumno);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMaterias);
            this.Controls.Add(this.cbxAlumnos);
            this.Controls.Add(this.dgv_alumnos_materias);
            this.Name = "CursoAlumnos";
            this.Text = "CursoAlumnos";
            this.Load += new System.EventHandler(this.CursoAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alumnos_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alumnos_materias;
        private System.Windows.Forms.ComboBox cbxAlumnos;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lbl_alumno;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCarrera;
        private System.Windows.Forms.Button cargarCurso;
        private System.Windows.Forms.Button bntGrabar;
    }
}