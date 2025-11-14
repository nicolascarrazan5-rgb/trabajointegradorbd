using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alumno_Materia
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_alumnos = new System.Windows.Forms.Button();
            this.btn_profesores = new System.Windows.Forms.Button();
            this.btn_materias = new System.Windows.Forms.Button();
            this.btn_carreras = new System.Windows.Forms.Button();
            this.btn_curso = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_alumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alumnos.FlatAppearance.BorderSize = 0;
            this.btn_alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumnos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnos.ForeColor = System.Drawing.Color.White;
            this.btn_alumnos.Location = new System.Drawing.Point(86, 45);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(198, 33);
            this.btn_alumnos.TabIndex = 0;
            this.btn_alumnos.Text = "Alumnos";
            this.btn_alumnos.UseVisualStyleBackColor = false;
            this.btn_alumnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_profesores
            // 
            this.btn_profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_profesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profesores.FlatAppearance.BorderSize = 0;
            this.btn_profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profesores.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_profesores.ForeColor = System.Drawing.Color.White;
            this.btn_profesores.Location = new System.Drawing.Point(86, 84);
            this.btn_profesores.Name = "btn_profesores";
            this.btn_profesores.Size = new System.Drawing.Size(198, 33);
            this.btn_profesores.TabIndex = 1;
            this.btn_profesores.Text = "Profesores";
            this.btn_profesores.UseVisualStyleBackColor = false;
            this.btn_profesores.Click += new System.EventHandler(this.btn_profesores_Click);
            // 
            // btn_materias
            // 
            this.btn_materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_materias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_materias.FlatAppearance.BorderSize = 0;
            this.btn_materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materias.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_materias.ForeColor = System.Drawing.Color.White;
            this.btn_materias.Location = new System.Drawing.Point(86, 123);
            this.btn_materias.Name = "btn_materias";
            this.btn_materias.Size = new System.Drawing.Size(198, 33);
            this.btn_materias.TabIndex = 2;
            this.btn_materias.Text = "Materias";
            this.btn_materias.UseVisualStyleBackColor = false;
            this.btn_materias.Click += new System.EventHandler(this.btn_materias_Click);
            // 
            // btn_carreras
            // 
            this.btn_carreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_carreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carreras.FlatAppearance.BorderSize = 0;
            this.btn_carreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carreras.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_carreras.ForeColor = System.Drawing.Color.White;
            this.btn_carreras.Location = new System.Drawing.Point(86, 162);
            this.btn_carreras.Name = "btn_carreras";
            this.btn_carreras.Size = new System.Drawing.Size(198, 33);
            this.btn_carreras.TabIndex = 3;
            this.btn_carreras.Text = "Carreras";
            this.btn_carreras.UseVisualStyleBackColor = false;
            this.btn_carreras.Click += new System.EventHandler(this.btn_carreras_Click);
            // 
            // btn_curso
            // 
            this.btn_curso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_curso.FlatAppearance.BorderSize = 0;
            this.btn_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_curso.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_curso.ForeColor = System.Drawing.Color.White;
            this.btn_curso.Location = new System.Drawing.Point(86, 201);
            this.btn_curso.Name = "btn_curso";
            this.btn_curso.Size = new System.Drawing.Size(198, 33);
            this.btn_curso.TabIndex = 4;
            this.btn_curso.Text = "Curso";
            this.btn_curso.UseVisualStyleBackColor = false;
            this.btn_curso.Click += new System.EventHandler(this.btn_curso_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(12, 262);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(112, 54);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "Cerrar sesion";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(369, 327);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_curso);
            this.Controls.Add(this.btn_carreras);
            this.Controls.Add(this.btn_materias);
            this.Controls.Add(this.btn_profesores);
            this.Controls.Add(this.btn_alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alumnos;
        private System.Windows.Forms.Button btn_profesores;
        private System.Windows.Forms.Button btn_materias;
        private System.Windows.Forms.Button btn_carreras;
        private System.Windows.Forms.Button btn_curso;
        private System.Windows.Forms.Button btn_cerrar;
    }
}