namespace Alumno_Materia
{
    partial class Carreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carreras));
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.btMostrarCarreras = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btBuscarCarrera = new System.Windows.Forms.Button();
            this.btID = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIDelete = new System.Windows.Forms.TextBox();
            this.txtNewCarreraname = new System.Windows.Forms.TextBox();
            this.txtNewSede = new System.Windows.Forms.TextBox();
            this.txtNewIDcarrera = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.CheckBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Location = new System.Drawing.Point(201, 11);
            this.dgvCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.RowHeadersWidth = 62;
            this.dgvCarreras.RowTemplate.Height = 28;
            this.dgvCarreras.Size = new System.Drawing.Size(425, 225);
            this.dgvCarreras.TabIndex = 0;
            this.dgvCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellContentClick);
            // 
            // btMostrarCarreras
            // 
            this.btMostrarCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btMostrarCarreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMostrarCarreras.FlatAppearance.BorderSize = 0;
            this.btMostrarCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarCarreras.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btMostrarCarreras.ForeColor = System.Drawing.Color.White;
            this.btMostrarCarreras.Location = new System.Drawing.Point(201, 240);
            this.btMostrarCarreras.Margin = new System.Windows.Forms.Padding(2);
            this.btMostrarCarreras.Name = "btMostrarCarreras";
            this.btMostrarCarreras.Size = new System.Drawing.Size(89, 25);
            this.btMostrarCarreras.TabIndex = 1;
            this.btMostrarCarreras.Text = "Actualizar";
            this.btMostrarCarreras.UseVisualStyleBackColor = false;
            this.btMostrarCarreras.Click += new System.EventHandler(this.btMostrarCarerras_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(9, 321);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(78, 25);
            this.btBack.TabIndex = 2;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btBuscarCarrera
            // 
            this.btBuscarCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBuscarCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarCarrera.FlatAppearance.BorderSize = 0;
            this.btBuscarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarCarrera.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btBuscarCarrera.ForeColor = System.Drawing.Color.White;
            this.btBuscarCarrera.Location = new System.Drawing.Point(229, 322);
            this.btBuscarCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarCarrera.Name = "btBuscarCarrera";
            this.btBuscarCarrera.Size = new System.Drawing.Size(78, 25);
            this.btBuscarCarrera.TabIndex = 3;
            this.btBuscarCarrera.Text = "Buscar";
            this.btBuscarCarrera.UseVisualStyleBackColor = false;
            this.btBuscarCarrera.Click += new System.EventHandler(this.btBuscarCarrera_Click);
            // 
            // btID
            // 
            this.btID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btID.FlatAppearance.BorderSize = 0;
            this.btID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btID.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btID.ForeColor = System.Drawing.Color.White;
            this.btID.Location = new System.Drawing.Point(389, 322);
            this.btID.Margin = new System.Windows.Forms.Padding(2);
            this.btID.Name = "btID";
            this.btID.Size = new System.Drawing.Size(78, 25);
            this.btID.TabIndex = 4;
            this.btID.Text = "Buscar";
            this.btID.UseVisualStyleBackColor = false;
            this.btID.Click += new System.EventHandler(this.btID_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(507, 322);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(78, 25);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 298);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(389, 298);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(26, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtIDelete
            // 
            this.txtIDelete.Location = new System.Drawing.Point(507, 298);
            this.txtIDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDelete.Name = "txtIDelete";
            this.txtIDelete.Size = new System.Drawing.Size(26, 20);
            this.txtIDelete.TabIndex = 8;
            // 
            // txtNewCarreraname
            // 
            this.txtNewCarreraname.Location = new System.Drawing.Point(56, 47);
            this.txtNewCarreraname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewCarreraname.Name = "txtNewCarreraname";
            this.txtNewCarreraname.Size = new System.Drawing.Size(87, 20);
            this.txtNewCarreraname.TabIndex = 9;
            // 
            // txtNewSede
            // 
            this.txtNewSede.Location = new System.Drawing.Point(56, 85);
            this.txtNewSede.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewSede.Name = "txtNewSede";
            this.txtNewSede.Size = new System.Drawing.Size(87, 20);
            this.txtNewSede.TabIndex = 10;
            // 
            // txtNewIDcarrera
            // 
            this.txtNewIDcarrera.Location = new System.Drawing.Point(56, 167);
            this.txtNewIDcarrera.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewIDcarrera.Name = "txtNewIDcarrera";
            this.txtNewIDcarrera.Size = new System.Drawing.Size(39, 20);
            this.txtNewIDcarrera.TabIndex = 11;
            // 
            // cbestado
            // 
            this.cbestado.AutoSize = true;
            this.cbestado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbestado.Location = new System.Drawing.Point(56, 110);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(59, 17);
            this.cbestado.TabIndex = 36;
            this.cbestado.Text = "Estado";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Location = new System.Drawing.Point(56, 191);
            this.btModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(78, 25);
            this.btModificar.TabIndex = 37;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderSize = 0;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Location = new System.Drawing.Point(56, 132);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(78, 25);
            this.btAgregar.TabIndex = 38;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Sede";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(226, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar por carrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(504, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(386, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Buscar por ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(537, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(636, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.txtNewIDcarrera);
            this.Controls.Add(this.txtNewSede);
            this.Controls.Add(this.txtNewCarreraname);
            this.Controls.Add(this.txtIDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btID);
            this.Controls.Add(this.btBuscarCarrera);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btMostrarCarreras);
            this.Controls.Add(this.dgvCarreras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Carreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Button btMostrarCarreras;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btBuscarCarrera;
        private System.Windows.Forms.Button btID;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDelete;
        private System.Windows.Forms.TextBox txtNewCarreraname;
        private System.Windows.Forms.TextBox txtNewSede;
        private System.Windows.Forms.TextBox txtNewIDcarrera;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}