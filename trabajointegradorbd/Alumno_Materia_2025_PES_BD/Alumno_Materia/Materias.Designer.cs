using System.Windows.Forms;

namespace Alumno_Materia
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.dgv_materias = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.CheckBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_borrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_nombreM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_estadoM = new System.Windows.Forms.CheckBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_materias
            // 
            this.dgv_materias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materias.Location = new System.Drawing.Point(15, 12);
            this.dgv_materias.Name = "dgv_materias";
            this.dgv_materias.Size = new System.Drawing.Size(583, 196);
            this.dgv_materias.TabIndex = 0;
            this.dgv_materias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(12, 342);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_nombre.Location = new System.Drawing.Point(166, 220);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Agregar materia";
            // 
            // cb_estado
            // 
            this.cb_estado.AutoSize = true;
            this.cb_estado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cb_estado.Location = new System.Drawing.Point(169, 262);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(65, 17);
            this.cb_estado.TabIndex = 3;
            this.cb_estado.Text = "Estado?";
            this.cb_estado.UseVisualStyleBackColor = true;
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(169, 236);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(100, 20);
            this.txt_materia.TabIndex = 4;
            this.txt_materia.Enter += new System.EventHandler(this.txt_materia_Enter);
            this.txt_materia.Leave += new System.EventHandler(this.txt_materia_Leave);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(169, 285);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(15, 236);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar.TabIndex = 6;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar materia por nombre";
            // 
            // txt_borrar
            // 
            this.txt_borrar.Location = new System.Drawing.Point(490, 236);
            this.txt_borrar.Name = "txt_borrar";
            this.txt_borrar.Size = new System.Drawing.Size(100, 20);
            this.txt_borrar.TabIndex = 8;
            this.txt_borrar.Enter += new System.EventHandler(this.txt_borrar_Enter);
            this.txt_borrar.Leave += new System.EventHandler(this.txt_borrar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(487, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Borrar materia";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(490, 262);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Borrar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_nombreM
            // 
            this.txt_nombreM.Location = new System.Drawing.Point(337, 278);
            this.txt_nombreM.Name = "txt_nombreM";
            this.txt_nombreM.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreM.TabIndex = 11;
            this.txt_nombreM.Enter += new System.EventHandler(this.txt_nombreM_Enter);
            this.txt_nombreM.Leave += new System.EventHandler(this.txt_nombreM_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(334, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Modificar materia";
            // 
            // cb_estadoM
            // 
            this.cb_estadoM.AutoSize = true;
            this.cb_estadoM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cb_estadoM.Location = new System.Drawing.Point(338, 304);
            this.cb_estadoM.Name = "cb_estadoM";
            this.cb_estadoM.Size = new System.Drawing.Size(65, 17);
            this.cb_estadoM.TabIndex = 13;
            this.cb_estadoM.Text = "Estado?";
            this.cb_estadoM.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(337, 327);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(337, 236);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 15;
            this.txt_id.Enter += new System.EventHandler(this.txt_id_Enter);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_id.Location = new System.Drawing.Point(487, 308);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(84, 13);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "ID de la materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(335, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cambiar nombre:";
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(610, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cb_estadoM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombreM);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_borrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_materias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_materias;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.CheckBox cb_estado;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_borrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_nombreM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_estadoM;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label4;
    }
}