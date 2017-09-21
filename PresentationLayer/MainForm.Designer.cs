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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.tbPgOrienta = new System.Windows.Forms.TabPage();
            this.tbPgNotas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOrienta = new System.Windows.Forms.Button();
            this.btnEditOrienta = new System.Windows.Forms.Button();
            this.btnEliminarOrienta = new System.Windows.Forms.Button();
            this.dtGrdVwOrienta = new System.Windows.Forms.DataGridView();
            this.idNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_lectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPgEstudiantes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstudiantes)).BeginInit();
            this.tbPgOrienta.SuspendLayout();
            this.tbPgNotas.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrienta)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgEstudiantes);
            this.tabControl1.Controls.Add(this.tbPgOrienta);
            this.tabControl1.Controls.Add(this.tbPgNotas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPgEstudiantes
            // 
            this.tbPgEstudiantes.Controls.Add(this.tableLayoutPanel1);
            this.tbPgEstudiantes.Location = new System.Drawing.Point(4, 22);
            this.tbPgEstudiantes.Name = "tbPgEstudiantes";
            this.tbPgEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEstudiantes.Size = new System.Drawing.Size(1256, 575);
            this.tbPgEstudiantes.TabIndex = 0;
            this.tbPgEstudiantes.Text = "Estudiantes";
            this.tbPgEstudiantes.UseVisualStyleBackColor = true;
            this.tbPgEstudiantes.Enter += new System.EventHandler(this.tbPgEstudiantes_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtGrdVwEstudiantes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 569);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 486);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1244, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDelStud
            // 
            this.btnDelStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelStud.Location = new System.Drawing.Point(976, 20);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(120, 40);
            this.btnDelStud.TabIndex = 2;
            this.btnDelStud.Text = "Eliminar";
            this.btnDelStud.UseVisualStyleBackColor = true;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditStudent.Location = new System.Drawing.Point(561, 20);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(120, 40);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Modificar";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnAddEstud
            // 
            this.btnAddEstud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddEstud.Location = new System.Drawing.Point(147, 20);
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
            this.dtGrdVwEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dtGrdVwEstudiantes.Location = new System.Drawing.Point(3, 88);
            this.dtGrdVwEstudiantes.Name = "dtGrdVwEstudiantes";
            this.dtGrdVwEstudiantes.ReadOnly = true;
            this.dtGrdVwEstudiantes.Size = new System.Drawing.Size(1244, 392);
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
            // tbPgOrienta
            // 
            this.tbPgOrienta.Controls.Add(this.tableLayoutPanel3);
            this.tbPgOrienta.Location = new System.Drawing.Point(4, 22);
            this.tbPgOrienta.Name = "tbPgOrienta";
            this.tbPgOrienta.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOrienta.Size = new System.Drawing.Size(1256, 575);
            this.tbPgOrienta.TabIndex = 1;
            this.tbPgOrienta.Text = "Notas orientación";
            this.tbPgOrienta.UseVisualStyleBackColor = true;
            this.tbPgOrienta.Enter += new System.EventHandler(this.tbPgOrienta_Enter);
            // 
            // tbPgNotas
            // 
            this.tbPgNotas.Controls.Add(this.tableLayoutPanel5);
            this.tbPgNotas.Location = new System.Drawing.Point(4, 22);
            this.tbPgNotas.Name = "tbPgNotas";
            this.tbPgNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNotas.Size = new System.Drawing.Size(1256, 575);
            this.tbPgNotas.TabIndex = 2;
            this.tbPgNotas.Text = "Notas asignaturas";
            this.tbPgNotas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos de estudiantes y selección de especialidad";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtGrdVwOrienta, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1250, 569);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notas de orientación";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEliminarOrienta, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditOrienta, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddOrienta, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 486);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1244, 80);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnAddOrienta
            // 
            this.btnAddOrienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrienta.Location = new System.Drawing.Point(147, 20);
            this.btnAddOrienta.Name = "btnAddOrienta";
            this.btnAddOrienta.Size = new System.Drawing.Size(120, 40);
            this.btnAddOrienta.TabIndex = 1;
            this.btnAddOrienta.Text = "Agregar";
            this.btnAddOrienta.UseVisualStyleBackColor = true;
            this.btnAddOrienta.Click += new System.EventHandler(this.btnAddOrienta_Click);
            // 
            // btnEditOrienta
            // 
            this.btnEditOrienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditOrienta.Location = new System.Drawing.Point(561, 20);
            this.btnEditOrienta.Name = "btnEditOrienta";
            this.btnEditOrienta.Size = new System.Drawing.Size(120, 40);
            this.btnEditOrienta.TabIndex = 2;
            this.btnEditOrienta.Text = "Modificar";
            this.btnEditOrienta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarOrienta
            // 
            this.btnEliminarOrienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarOrienta.Location = new System.Drawing.Point(976, 20);
            this.btnEliminarOrienta.Name = "btnEliminarOrienta";
            this.btnEliminarOrienta.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarOrienta.TabIndex = 3;
            this.btnEliminarOrienta.Text = "Eliminar";
            this.btnEliminarOrienta.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwOrienta
            // 
            this.dtGrdVwOrienta.AllowUserToAddRows = false;
            this.dtGrdVwOrienta.AllowUserToDeleteRows = false;
            this.dtGrdVwOrienta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwOrienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwOrienta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNota,
            this.Asignatura,
            this.Curso_lectivo,
            this.Nivel,
            this.Periodo,
            this.Matricula,
            this.ApellidoOne,
            this.ApellidoTwo,
            this.Nombre1,
            this.Calificacion});
            this.dtGrdVwOrienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwOrienta.Location = new System.Drawing.Point(3, 88);
            this.dtGrdVwOrienta.Name = "dtGrdVwOrienta";
            this.dtGrdVwOrienta.ReadOnly = true;
            this.dtGrdVwOrienta.Size = new System.Drawing.Size(1244, 392);
            this.dtGrdVwOrienta.TabIndex = 5;
            // 
            // idNota
            // 
            this.idNota.DataPropertyName = "idNota";
            this.idNota.HeaderText = "ID";
            this.idNota.Name = "idNota";
            this.idNota.ReadOnly = true;
            this.idNota.Visible = false;
            // 
            // Asignatura
            // 
            this.Asignatura.DataPropertyName = "Asignatura";
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            this.Asignatura.Visible = false;
            // 
            // Curso_lectivo
            // 
            this.Curso_lectivo.DataPropertyName = "Curso_lectivo";
            this.Curso_lectivo.HeaderText = "Curso_lectivo";
            this.Curso_lectivo.Name = "Curso_lectivo";
            this.Curso_lectivo.ReadOnly = true;
            this.Curso_lectivo.Visible = false;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "Nivel";
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            this.Nivel.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Visible = false;
            // 
            // ApellidoOne
            // 
            this.ApellidoOne.DataPropertyName = "Apellido1";
            this.ApellidoOne.HeaderText = "Primer apellido";
            this.ApellidoOne.Name = "ApellidoOne";
            this.ApellidoOne.ReadOnly = true;
            // 
            // ApellidoTwo
            // 
            this.ApellidoTwo.DataPropertyName = "Apellido2";
            this.ApellidoTwo.HeaderText = "Segundo apellido";
            this.ApellidoTwo.Name = "ApellidoTwo";
            this.ApellidoTwo.ReadOnly = true;
            // 
            // Nombre1
            // 
            this.Nombre1.DataPropertyName = "Nombre";
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.ReadOnly = true;
            // 
            // Calificacion
            // 
            this.Calificacion.DataPropertyName = "Calificacion";
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1250, 569);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notas de asignaturas";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 486);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1244, 80);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(147, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(561, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(976, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 601);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sistema de admisión de novenos 2017 b1";
            this.tabControl1.ResumeLayout(false);
            this.tbPgEstudiantes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstudiantes)).EndInit();
            this.tbPgOrienta.ResumeLayout(false);
            this.tbPgNotas.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrienta)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgEstudiantes;
        private System.Windows.Forms.TabPage tbPgOrienta;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEliminarOrienta;
        private System.Windows.Forms.Button btnEditOrienta;
        private System.Windows.Forms.Button btnAddOrienta;
        private System.Windows.Forms.DataGridView dtGrdVwOrienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_lectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}