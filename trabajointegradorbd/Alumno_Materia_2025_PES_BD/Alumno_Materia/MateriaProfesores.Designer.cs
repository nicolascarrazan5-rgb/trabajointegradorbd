namespace Alumno_Materia
{
    partial class MateriaProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaProfesores));
            this.dgv_profesores = new System.Windows.Forms.DataGridView();
            this.dgv_materias = new System.Windows.Forms.DataGridView();
            this.idmateria = new System.Windows.Forms.TextBox();
            this.idprofesor = new System.Windows.Forms.TextBox();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_profesores
            // 
            this.dgv_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profesores.Location = new System.Drawing.Point(371, 12);
            this.dgv_profesores.Name = "dgv_profesores";
            this.dgv_profesores.Size = new System.Drawing.Size(353, 150);
            this.dgv_profesores.TabIndex = 0;
            this.dgv_profesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_profesores_CellClick);
            // 
            // dgv_materias
            // 
            this.dgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materias.Location = new System.Drawing.Point(12, 12);
            this.dgv_materias.Name = "dgv_materias";
            this.dgv_materias.Size = new System.Drawing.Size(353, 150);
            this.dgv_materias.TabIndex = 1;
            this.dgv_materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_materias_CellClick);
            // 
            // idmateria
            // 
            this.idmateria.Location = new System.Drawing.Point(265, 181);
            this.idmateria.Name = "idmateria";
            this.idmateria.Size = new System.Drawing.Size(100, 20);
            this.idmateria.TabIndex = 3;
            this.idmateria.TextChanged += new System.EventHandler(this.idmateria_TextChanged);
            // 
            // idprofesor
            // 
            this.idprofesor.Location = new System.Drawing.Point(371, 181);
            this.idprofesor.Name = "idprofesor";
            this.idprofesor.Size = new System.Drawing.Size(100, 20);
            this.idprofesor.TabIndex = 4;
            this.idprofesor.TextChanged += new System.EventHandler(this.idprofesor_TextChanged);
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_asignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_asignar.FlatAppearance.BorderSize = 0;
            this.btn_asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asignar.ForeColor = System.Drawing.Color.White;
            this.btn_asignar.Location = new System.Drawing.Point(330, 207);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(75, 23);
            this.btn_asignar.TabIndex = 5;
            this.btn_asignar.Text = "Asignar";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(262, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id materia:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(416, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id profesor:";
            // 
            // MateriaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(732, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.idprofesor);
            this.Controls.Add(this.idmateria);
            this.Controls.Add(this.dgv_materias);
            this.Controls.Add(this.dgv_profesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(169, 285);
            this.MaximizeBox = false;
            this.Name = "MateriaProfesores";
            this.Text = "MateriaProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_profesores;
        private System.Windows.Forms.DataGridView dgv_materias;
        private System.Windows.Forms.TextBox idmateria;
        private System.Windows.Forms.TextBox idprofesor;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}