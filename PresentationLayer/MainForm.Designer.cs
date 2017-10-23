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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPgOrienta = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminarOrienta = new System.Windows.Forms.Button();
            this.btnEditOrienta = new System.Windows.Forms.Button();
            this.dtGrdVwOrienta = new System.Windows.Forms.DataGridView();
            this.tbPgNotas8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelNota = new System.Windows.Forms.Button();
            this.btnEditNota = new System.Windows.Forms.Button();
            this.dtGrdVwNotas = new System.Windows.Forms.DataGridView();
            this.tbPgNotas9 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dtGrdVwNotas9 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelNota9 = new System.Windows.Forms.Button();
            this.btnEditNota9 = new System.Windows.Forms.Button();
            this.tbPgReportes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnEscogenciaEspec = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPgEstudiantes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEstudiantes)).BeginInit();
            this.tbPgOrienta.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrienta)).BeginInit();
            this.tbPgNotas8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwNotas)).BeginInit();
            this.tbPgNotas9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwNotas9)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tbPgReportes.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgEstudiantes);
            this.tabControl1.Controls.Add(this.tbPgOrienta);
            this.tabControl1.Controls.Add(this.tbPgNotas8);
            this.tabControl1.Controls.Add(this.tbPgNotas9);
            this.tabControl1.Controls.Add(this.tbPgReportes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPgEstudiantes
            // 
            this.tbPgEstudiantes.Controls.Add(this.tableLayoutPanel1);
            this.tbPgEstudiantes.Location = new System.Drawing.Point(4, 29);
            this.tbPgEstudiantes.Name = "tbPgEstudiantes";
            this.tbPgEstudiantes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEstudiantes.Size = new System.Drawing.Size(1256, 568);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 562);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1244, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDelStud
            // 
            this.btnDelStud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelStud.Location = new System.Drawing.Point(976, 19);
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
            this.btnEditStudent.Location = new System.Drawing.Point(561, 19);
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
            this.btnAddEstud.Location = new System.Drawing.Point(147, 19);
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
            this.dtGrdVwEstudiantes.AllowUserToResizeRows = false;
            this.dtGrdVwEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdVwEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrdVwEstudiantes.Location = new System.Drawing.Point(3, 87);
            this.dtGrdVwEstudiantes.MultiSelect = false;
            this.dtGrdVwEstudiantes.Name = "dtGrdVwEstudiantes";
            this.dtGrdVwEstudiantes.ReadOnly = true;
            this.dtGrdVwEstudiantes.ShowEditingIcon = false;
            this.dtGrdVwEstudiantes.Size = new System.Drawing.Size(1244, 387);
            this.dtGrdVwEstudiantes.TabIndex = 1;
            this.dtGrdVwEstudiantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwEstudiantes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos de estudiantes y selección de especialidad";
            // 
            // tbPgOrienta
            // 
            this.tbPgOrienta.Controls.Add(this.tableLayoutPanel3);
            this.tbPgOrienta.Location = new System.Drawing.Point(4, 29);
            this.tbPgOrienta.Name = "tbPgOrienta";
            this.tbPgOrienta.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOrienta.Size = new System.Drawing.Size(1256, 568);
            this.tbPgOrienta.TabIndex = 1;
            this.tbPgOrienta.Text = "Notas orientación";
            this.tbPgOrienta.UseVisualStyleBackColor = true;
            this.tbPgOrienta.Enter += new System.EventHandler(this.tbPgOrienta_Enter);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1250, 562);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notas de orientación";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEliminarOrienta, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEditOrienta, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1244, 79);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnEliminarOrienta
            // 
            this.btnEliminarOrienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarOrienta.Location = new System.Drawing.Point(873, 19);
            this.btnEliminarOrienta.Name = "btnEliminarOrienta";
            this.btnEliminarOrienta.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarOrienta.TabIndex = 3;
            this.btnEliminarOrienta.Text = "Eliminar";
            this.btnEliminarOrienta.UseVisualStyleBackColor = true;
            this.btnEliminarOrienta.Click += new System.EventHandler(this.btnEliminarOrienta_Click);
            // 
            // btnEditOrienta
            // 
            this.btnEditOrienta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditOrienta.Location = new System.Drawing.Point(251, 19);
            this.btnEditOrienta.Name = "btnEditOrienta";
            this.btnEditOrienta.Size = new System.Drawing.Size(120, 40);
            this.btnEditOrienta.TabIndex = 2;
            this.btnEditOrienta.Text = "Modificar";
            this.btnEditOrienta.UseVisualStyleBackColor = true;
            this.btnEditOrienta.Click += new System.EventHandler(this.btnEditOrienta_Click);
            // 
            // dtGrdVwOrienta
            // 
            this.dtGrdVwOrienta.AllowUserToAddRows = false;
            this.dtGrdVwOrienta.AllowUserToDeleteRows = false;
            this.dtGrdVwOrienta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwOrienta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwOrienta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwOrienta.Location = new System.Drawing.Point(3, 87);
            this.dtGrdVwOrienta.Name = "dtGrdVwOrienta";
            this.dtGrdVwOrienta.ReadOnly = true;
            this.dtGrdVwOrienta.Size = new System.Drawing.Size(1244, 387);
            this.dtGrdVwOrienta.TabIndex = 5;
            this.dtGrdVwOrienta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwOrienta_CellDoubleClick_1);
            // 
            // tbPgNotas8
            // 
            this.tbPgNotas8.Controls.Add(this.tableLayoutPanel5);
            this.tbPgNotas8.Location = new System.Drawing.Point(4, 29);
            this.tbPgNotas8.Name = "tbPgNotas8";
            this.tbPgNotas8.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNotas8.Size = new System.Drawing.Size(1256, 568);
            this.tbPgNotas8.TabIndex = 2;
            this.tbPgNotas8.Text = "Notas asignaturas 8";
            this.tbPgNotas8.UseVisualStyleBackColor = true;
            this.tbPgNotas8.Enter += new System.EventHandler(this.tbPgNotas8_Enter);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.dtGrdVwNotas, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1250, 562);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notas de asignaturas 8 nivel";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btnDelNota, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnEditNota, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1244, 79);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // btnDelNota
            // 
            this.btnDelNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelNota.Location = new System.Drawing.Point(873, 19);
            this.btnDelNota.Name = "btnDelNota";
            this.btnDelNota.Size = new System.Drawing.Size(120, 40);
            this.btnDelNota.TabIndex = 4;
            this.btnDelNota.Text = "Eliminar";
            this.btnDelNota.UseVisualStyleBackColor = true;
            this.btnDelNota.Click += new System.EventHandler(this.btnDelNota_Click);
            // 
            // btnEditNota
            // 
            this.btnEditNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditNota.Enabled = false;
            this.btnEditNota.Location = new System.Drawing.Point(251, 19);
            this.btnEditNota.Name = "btnEditNota";
            this.btnEditNota.Size = new System.Drawing.Size(120, 40);
            this.btnEditNota.TabIndex = 3;
            this.btnEditNota.Text = "Modificar";
            this.btnEditNota.UseVisualStyleBackColor = true;
            this.btnEditNota.Click += new System.EventHandler(this.btnEditNota_Click);
            // 
            // dtGrdVwNotas
            // 
            this.dtGrdVwNotas.AllowUserToAddRows = false;
            this.dtGrdVwNotas.AllowUserToDeleteRows = false;
            this.dtGrdVwNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwNotas.Location = new System.Drawing.Point(3, 87);
            this.dtGrdVwNotas.Name = "dtGrdVwNotas";
            this.dtGrdVwNotas.ReadOnly = true;
            this.dtGrdVwNotas.Size = new System.Drawing.Size(1244, 387);
            this.dtGrdVwNotas.TabIndex = 6;
            this.dtGrdVwNotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwNotas_CellDoubleClick);
            // 
            // tbPgNotas9
            // 
            this.tbPgNotas9.Controls.Add(this.tableLayoutPanel7);
            this.tbPgNotas9.Location = new System.Drawing.Point(4, 29);
            this.tbPgNotas9.Name = "tbPgNotas9";
            this.tbPgNotas9.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNotas9.Size = new System.Drawing.Size(1256, 568);
            this.tbPgNotas9.TabIndex = 3;
            this.tbPgNotas9.Text = "Notas asignaturas 9";
            this.tbPgNotas9.UseVisualStyleBackColor = true;
            this.tbPgNotas9.Enter += new System.EventHandler(this.tbPgNotas9_Enter);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.dtGrdVwNotas9, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1250, 562);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dtGrdVwNotas9
            // 
            this.dtGrdVwNotas9.AllowUserToAddRows = false;
            this.dtGrdVwNotas9.AllowUserToDeleteRows = false;
            this.dtGrdVwNotas9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwNotas9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwNotas9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwNotas9.Location = new System.Drawing.Point(3, 87);
            this.dtGrdVwNotas9.Name = "dtGrdVwNotas9";
            this.dtGrdVwNotas9.ReadOnly = true;
            this.dtGrdVwNotas9.Size = new System.Drawing.Size(1244, 387);
            this.dtGrdVwNotas9.TabIndex = 7;
            this.dtGrdVwNotas9.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwNotas9_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notas de asignaturas 9 nivel";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.btnDelNota9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnEditNota9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1244, 79);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // btnDelNota9
            // 
            this.btnDelNota9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelNota9.Location = new System.Drawing.Point(873, 19);
            this.btnDelNota9.Name = "btnDelNota9";
            this.btnDelNota9.Size = new System.Drawing.Size(120, 40);
            this.btnDelNota9.TabIndex = 5;
            this.btnDelNota9.Text = "Eliminar";
            this.btnDelNota9.UseVisualStyleBackColor = true;
            this.btnDelNota9.Click += new System.EventHandler(this.btnDelNota9_Click);
            // 
            // btnEditNota9
            // 
            this.btnEditNota9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditNota9.Location = new System.Drawing.Point(251, 19);
            this.btnEditNota9.Name = "btnEditNota9";
            this.btnEditNota9.Size = new System.Drawing.Size(120, 40);
            this.btnEditNota9.TabIndex = 4;
            this.btnEditNota9.Text = "Modificar";
            this.btnEditNota9.UseVisualStyleBackColor = true;
            this.btnEditNota9.Click += new System.EventHandler(this.btnEditNota9_Click);
            // 
            // tbPgReportes
            // 
            this.tbPgReportes.Controls.Add(this.tableLayoutPanel9);
            this.tbPgReportes.Location = new System.Drawing.Point(4, 29);
            this.tbPgReportes.Name = "tbPgReportes";
            this.tbPgReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgReportes.Size = new System.Drawing.Size(1256, 568);
            this.tbPgReportes.TabIndex = 4;
            this.tbPgReportes.Text = "Reportes";
            this.tbPgReportes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1250, 562);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reportes y configuración";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.btnConfig, 2, 2);
            this.tableLayoutPanel10.Controls.Add(this.btnEscogenciaEspec, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1244, 416);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.Location = new System.Drawing.Point(916, 306);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(240, 80);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnEscogenciaEspec
            // 
            this.btnEscogenciaEspec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscogenciaEspec.Enabled = false;
            this.btnEscogenciaEspec.Location = new System.Drawing.Point(87, 29);
            this.btnEscogenciaEspec.Name = "btnEscogenciaEspec";
            this.btnEscogenciaEspec.Size = new System.Drawing.Size(240, 80);
            this.btnEscogenciaEspec.TabIndex = 1;
            this.btnEscogenciaEspec.Text = "Escogencia de especialidad por estudiante";
            this.btnEscogenciaEspec.UseVisualStyleBackColor = true;
            this.btnEscogenciaEspec.Click += new System.EventHandler(this.btnEscogenciaEspec_Click);
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrienta)).EndInit();
            this.tbPgNotas8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwNotas)).EndInit();
            this.tbPgNotas9.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwNotas9)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tbPgReportes.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgEstudiantes;
        private System.Windows.Forms.TabPage tbPgOrienta;
        private System.Windows.Forms.TabPage tbPgNotas8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtGrdVwEstudiantes;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAddEstud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEliminarOrienta;
        private System.Windows.Forms.Button btnEditOrienta;
        private System.Windows.Forms.DataGridView dtGrdVwOrienta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnDelNota;
        private System.Windows.Forms.Button btnEditNota;
        private System.Windows.Forms.DataGridView dtGrdVwNotas;
        private System.Windows.Forms.TabPage tbPgNotas9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dtGrdVwNotas9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnDelNota9;
        private System.Windows.Forms.Button btnEditNota9;
        private System.Windows.Forms.TabPage tbPgReportes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEscogenciaEspec;
    }
}