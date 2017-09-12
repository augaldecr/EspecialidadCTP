namespace PresentationLayer
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgEstudiantes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnAddEstud = new System.Windows.Forms.Button();
            this.dtGrdVwEstudiantes = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPgEspecialidad = new System.Windows.Forms.TabPage();
            this.tbPgNotas = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbPgEstudiantes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgEstudiantes);
            this.tabControl1.Controls.Add(this.tbPgEspecialidad);
            this.tabControl1.Controls.Add(this.tbPgNotas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPgEstudiantes
            // 
            this.tbPgEstudiantes.Controls.Add(this.tableLayoutPanel1);
            this.tbPgEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tbPgEstudiantes.Name = "tbPgEstudiantes";
            this.tbPgEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEstudiantes.Size = new System.Drawing.Size(748, 484);
            this.tbPgEstudiantes.TabIndex = 0;
            this.tbPgEstudiantes.Text = "Estudiantes";
            this.tbPgEstudiantes.UseVisualStyleBackColor = true;
            this.tbPgEstudiantes.Enter += new System.EventHandler(this.tbPgEstudiantes_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtGrdVwEstudiantes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.19247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.80753F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnDelStud, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditStudent, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddEstud, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 414);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(736, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDelStud
            // 
            this.btnDelStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelStud.Location = new System.Drawing.Point(553, 10);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(120, 40);
            this.btnDelStud.TabIndex = 2;
            this.btnDelStud.Text = "Eliminar";
            this.btnDelStud.UseVisualStyleBackColor = true;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditStudent.Location = new System.Drawing.Point(307, 10);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(120, 40);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Modificar";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddEstud
            // 
            this.btnAddEstud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEstud.Location = new System.Drawing.Point(62, 10);
            this.btnAddEstud.Name = "btnAddEstud";
            this.btnAddEstud.Size = new System.Drawing.Size(120, 40);
            this.btnAddEstud.TabIndex = 0;
            this.btnAddEstud.Text = "Agregar";
            this.btnAddEstud.UseVisualStyleBackColor = true;
            this.btnAddEstud.Click += new System.EventHandler(this.btnAddEstud_Click);
            // 
            // dtGrdVwEstudiantes
            // 
            this.dtGrdVwEstudiantes.AllowUserToAddRows = false;
            this.dtGrdVwEstudiantes.AllowUserToDeleteRows = false;
            this.dtGrdVwEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstudiante,
            this.Cedula,
            this.Nombre,
            this.Apellido1,
            this.Apellido2,
            this.Direccion,
            this.Telefono,
            this.Celular,
            this.Email,
            this.Ctpp});
            this.dtGrdVwEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwEstudiantes.Location = new System.Drawing.Point(3, 3);
            this.dtGrdVwEstudiantes.Name = "dtGrdVwEstudiantes";
            this.dtGrdVwEstudiantes.ReadOnly = true;
            this.dtGrdVwEstudiantes.Size = new System.Drawing.Size(736, 405);
            this.dtGrdVwEstudiantes.TabIndex = 1;
            this.dtGrdVwEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwEstudiantes_CellDoubleClick);
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.DataPropertyName = "IdEstudiante";
            this.IdEstudiante.HeaderText = "ID";
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.ReadOnly = true;
            this.IdEstudiante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdEstudiante.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido1
            // 
            this.Apellido1.DataPropertyName = "Apellido1";
            this.Apellido1.HeaderText = "Primer apellido";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            // 
            // Apellido2
            // 
            this.Apellido2.DataPropertyName = "Apellido2";
            this.Apellido2.HeaderText = "Segundo apellido";
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Correo electrónico";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Ctpp
            // 
            this.Ctpp.DataPropertyName = "Ctpp";
            this.Ctpp.HeaderText = "Local";
            this.Ctpp.Name = "Ctpp";
            this.Ctpp.ReadOnly = true;
            // 
            // tbPgEspecialidad
            // 
            this.tbPgEspecialidad.Location = new System.Drawing.Point(4, 22);
            this.tbPgEspecialidad.Name = "tbPgEspecialidad";
            this.tbPgEspecialidad.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEspecialidad.Size = new System.Drawing.Size(748, 484);
            this.tbPgEspecialidad.TabIndex = 1;
            this.tbPgEspecialidad.Text = "Especialidad";
            this.tbPgEspecialidad.UseVisualStyleBackColor = true;
            // 
            // tbPgNotas
            // 
            this.tbPgNotas.Location = new System.Drawing.Point(4, 22);
            this.tbPgNotas.Name = "tbPgNotas";
            this.tbPgNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNotas.Size = new System.Drawing.Size(748, 484);
            this.tbPgNotas.TabIndex = 2;
            this.tbPgNotas.Text = "Notas";
            this.tbPgNotas.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tbPgEstudiantes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgEstudiantes;
        private System.Windows.Forms.TabPage tbPgEspecialidad;
        private System.Windows.Forms.TabPage tbPgNotas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtGrdVwEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctpp;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAddEstud;
    }
}