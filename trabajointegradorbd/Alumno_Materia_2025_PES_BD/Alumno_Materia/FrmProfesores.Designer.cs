namespace Alumno_Materia
{
    partial class FrmProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesores));
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.btBuscarID = new System.Windows.Forms.Button();
            this.btBuscarApellido = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.txbBuscarApe = new System.Windows.Forms.RichTextBox();
            this.txbBuscarID = new System.Windows.Forms.RichTextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.txbEliminar = new System.Windows.Forms.RichTextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbAgregar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.lbEliminar = new System.Windows.Forms.Label();
            this.txtNewname = new System.Windows.Forms.TextBox();
            this.txtNewapell = new System.Windows.Forms.TextBox();
            this.txtNewemail = new System.Windows.Forms.TextBox();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.txtNewtel = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbNewname = new System.Windows.Forms.Label();
            this.lbNewapell = new System.Windows.Forms.Label();
            this.lbNewemail = new System.Windows.Forms.Label();
            this.lbNewID = new System.Windows.Forms.Label();
            this.lbNewtel = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(197, 46);
            this.dgvProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.RowHeadersWidth = 62;
            this.dgvProfesores.RowTemplate.Height = 28;
            this.dgvProfesores.Size = new System.Drawing.Size(655, 300);
            this.dgvProfesores.TabIndex = 7;
            this.dgvProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellContentClick);
            // 
            // btBuscarID
            // 
            this.btBuscarID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBuscarID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarID.FlatAppearance.BorderSize = 0;
            this.btBuscarID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarID.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btBuscarID.ForeColor = System.Drawing.Color.White;
            this.btBuscarID.Location = new System.Drawing.Point(24, 180);
            this.btBuscarID.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarID.Name = "btBuscarID";
            this.btBuscarID.Size = new System.Drawing.Size(71, 24);
            this.btBuscarID.TabIndex = 6;
            this.btBuscarID.Text = "Buscar";
            this.btBuscarID.UseVisualStyleBackColor = false;
            this.btBuscarID.Click += new System.EventHandler(this.btBuscarID_Click);
            // 
            // btBuscarApellido
            // 
            this.btBuscarApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBuscarApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarApellido.FlatAppearance.BorderSize = 0;
            this.btBuscarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscarApellido.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btBuscarApellido.ForeColor = System.Drawing.Color.White;
            this.btBuscarApellido.Location = new System.Drawing.Point(53, 105);
            this.btBuscarApellido.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarApellido.Name = "btBuscarApellido";
            this.btBuscarApellido.Size = new System.Drawing.Size(107, 24);
            this.btBuscarApellido.TabIndex = 5;
            this.btBuscarApellido.Text = "Buscar";
            this.btBuscarApellido.UseVisualStyleBackColor = false;
            this.btBuscarApellido.Click += new System.EventHandler(this.btBuscarApellido_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Location = new System.Drawing.Point(885, 257);
            this.btModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(195, 26);
            this.btModificar.TabIndex = 4;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // txbBuscarApe
            // 
            this.txbBuscarApe.BackColor = System.Drawing.SystemColors.Info;
            this.txbBuscarApe.Location = new System.Drawing.Point(53, 75);
            this.txbBuscarApe.Margin = new System.Windows.Forms.Padding(2);
            this.txbBuscarApe.Name = "txbBuscarApe";
            this.txbBuscarApe.Size = new System.Drawing.Size(109, 25);
            this.txbBuscarApe.TabIndex = 9;
            this.txbBuscarApe.Text = "";
            // 
            // txbBuscarID
            // 
            this.txbBuscarID.BackColor = System.Drawing.SystemColors.Info;
            this.txbBuscarID.Location = new System.Drawing.Point(119, 179);
            this.txbBuscarID.Margin = new System.Windows.Forms.Padding(2);
            this.txbBuscarID.Name = "txbBuscarID";
            this.txbBuscarID.Size = new System.Drawing.Size(65, 25);
            this.txbBuscarID.TabIndex = 10;
            this.txbBuscarID.Text = "";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbApellido.Location = new System.Drawing.Point(69, 49);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(82, 13);
            this.lbApellido.TabIndex = 12;
            this.lbApellido.Text = "Ingrese Apellido";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbID.Location = new System.Drawing.Point(75, 149);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(56, 13);
            this.lbID.TabIndex = 13;
            this.lbID.Text = "Ingrese ID";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(11, 357);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(71, 24);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "Volver";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // txbEliminar
            // 
            this.txbEliminar.BackColor = System.Drawing.SystemColors.Info;
            this.txbEliminar.Location = new System.Drawing.Point(119, 257);
            this.txbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.txbEliminar.Name = "txbEliminar";
            this.txbEliminar.Size = new System.Drawing.Size(65, 25);
            this.txbEliminar.TabIndex = 16;
            this.txbEliminar.Text = "";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(24, 257);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(71, 24);
            this.btEliminar.TabIndex = 15;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderSize = 0;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Location = new System.Drawing.Point(885, 320);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(195, 26);
            this.btAgregar.TabIndex = 17;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbAgregar
            // 
            this.lbAgregar.AutoSize = true;
            this.lbAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbAgregar.Location = new System.Drawing.Point(942, 305);
            this.lbAgregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAgregar.Name = "lbAgregar";
            this.lbAgregar.Size = new System.Drawing.Size(76, 13);
            this.lbAgregar.TabIndex = 19;
            this.lbAgregar.Text = "Nuevo registro";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbModificar.Location = new System.Drawing.Point(931, 242);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(100, 13);
            this.lbModificar.TabIndex = 20;
            this.lbModificar.Text = "Registro a modificar";
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbEliminar.Location = new System.Drawing.Point(51, 228);
            this.lbEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(96, 13);
            this.lbEliminar.TabIndex = 21;
            this.lbEliminar.Text = "Registro a eliminar:";
            this.lbEliminar.Click += new System.EventHandler(this.lbEliminar_Click);
            // 
            // txtNewname
            // 
            this.txtNewname.Location = new System.Drawing.Point(947, 49);
            this.txtNewname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewname.Name = "txtNewname";
            this.txtNewname.Size = new System.Drawing.Size(93, 20);
            this.txtNewname.TabIndex = 22;
            // 
            // txtNewapell
            // 
            this.txtNewapell.Location = new System.Drawing.Point(947, 82);
            this.txtNewapell.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewapell.Name = "txtNewapell";
            this.txtNewapell.Size = new System.Drawing.Size(93, 20);
            this.txtNewapell.TabIndex = 23;
            // 
            // txtNewemail
            // 
            this.txtNewemail.Location = new System.Drawing.Point(947, 113);
            this.txtNewemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewemail.Name = "txtNewemail";
            this.txtNewemail.Size = new System.Drawing.Size(115, 20);
            this.txtNewemail.TabIndex = 24;
            // 
            // txtNewID
            // 
            this.txtNewID.Location = new System.Drawing.Point(947, 175);
            this.txtNewID.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(71, 20);
            this.txtNewID.TabIndex = 25;
            // 
            // txtNewtel
            // 
            this.txtNewtel.Location = new System.Drawing.Point(947, 145);
            this.txtNewtel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewtel.Name = "txtNewtel";
            this.txtNewtel.Size = new System.Drawing.Size(115, 20);
            this.txtNewtel.TabIndex = 26;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(197, 350);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 27);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbNewname
            // 
            this.lbNewname.AutoSize = true;
            this.lbNewname.BackColor = System.Drawing.Color.Transparent;
            this.lbNewname.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNewname.Location = new System.Drawing.Point(895, 49);
            this.lbNewname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewname.Name = "lbNewname";
            this.lbNewname.Size = new System.Drawing.Size(47, 13);
            this.lbNewname.TabIndex = 28;
            this.lbNewname.Text = "Nombre:";
            // 
            // lbNewapell
            // 
            this.lbNewapell.AutoSize = true;
            this.lbNewapell.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNewapell.Location = new System.Drawing.Point(895, 84);
            this.lbNewapell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewapell.Name = "lbNewapell";
            this.lbNewapell.Size = new System.Drawing.Size(47, 13);
            this.lbNewapell.TabIndex = 29;
            this.lbNewapell.Text = "Apellido:";
            // 
            // lbNewemail
            // 
            this.lbNewemail.AutoSize = true;
            this.lbNewemail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNewemail.Location = new System.Drawing.Point(905, 117);
            this.lbNewemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewemail.Name = "lbNewemail";
            this.lbNewemail.Size = new System.Drawing.Size(35, 13);
            this.lbNewemail.TabIndex = 30;
            this.lbNewemail.Text = "Email:";
            // 
            // lbNewID
            // 
            this.lbNewID.AutoSize = true;
            this.lbNewID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNewID.Location = new System.Drawing.Point(919, 174);
            this.lbNewID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewID.Name = "lbNewID";
            this.lbNewID.Size = new System.Drawing.Size(21, 13);
            this.lbNewID.TabIndex = 31;
            this.lbNewID.Text = "ID:";
            // 
            // lbNewtel
            // 
            this.lbNewtel.AutoSize = true;
            this.lbNewtel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNewtel.Location = new System.Drawing.Point(893, 149);
            this.lbNewtel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewtel.Name = "lbNewtel";
            this.lbNewtel.Size = new System.Drawing.Size(52, 13);
            this.lbNewtel.TabIndex = 32;
            this.lbNewtel.Text = "Telefono:";
            // 
            // cbestado
            // 
            this.cbestado.AutoSize = true;
            this.cbestado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbestado.Location = new System.Drawing.Point(947, 209);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(59, 17);
            this.cbestado.TabIndex = 35;
            this.cbestado.Text = "Estado";
            this.cbestado.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btClear.Location = new System.Drawing.Point(735, 350);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(117, 27);
            this.btClear.TabIndex = 36;
            this.btClear.Text = "Limpiar";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FrmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1092, 392);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.lbNewtel);
            this.Controls.Add(this.lbNewID);
            this.Controls.Add(this.lbNewemail);
            this.Controls.Add(this.lbNewapell);
            this.Controls.Add(this.lbNewname);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNewtel);
            this.Controls.Add(this.txtNewID);
            this.Controls.Add(this.txtNewemail);
            this.Controls.Add(this.txtNewapell);
            this.Controls.Add(this.txtNewname);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.lbAgregar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txbEliminar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.txbBuscarID);
            this.Controls.Add(this.txbBuscarApe);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btBuscarID);
            this.Controls.Add(this.btBuscarApellido);
            this.Controls.Add(this.btModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProfesores";
            this.Text = "FrmProfesores";
            this.Load += new System.EventHandler(this.FrmProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btBuscarID;
        private System.Windows.Forms.Button btBuscarApellido;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.RichTextBox txbBuscarApe;
        private System.Windows.Forms.RichTextBox txbBuscarID;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.RichTextBox txbEliminar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbAgregar;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Label lbEliminar;
        private System.Windows.Forms.TextBox txtNewname;
        private System.Windows.Forms.TextBox txtNewapell;
        private System.Windows.Forms.TextBox txtNewemail;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.TextBox txtNewtel;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lbNewname;
        private System.Windows.Forms.Label lbNewapell;
        private System.Windows.Forms.Label lbNewemail;
        private System.Windows.Forms.Label lbNewID;
        private System.Windows.Forms.Label lbNewtel;
        private System.Windows.Forms.CheckBox cbestado;
        private System.Windows.Forms.Button btClear;
    }
}