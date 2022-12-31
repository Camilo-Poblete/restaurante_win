namespace Diseño.Garzones_r
{
    partial class Registro_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DtClientes = new System.Windows.Forms.DataGridView();
            this.PnlFormulario = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblRut = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CbxId = new System.Windows.Forms.ComboBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblFono = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.DtEliminados = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).BeginInit();
            this.PnlFormulario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.003752F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.347092F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42402F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07502F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.17475F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76853F));
            this.tableLayoutPanel2.Controls.Add(this.TxtBuscar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnVolver, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1066, 55);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolver.BackColor = System.Drawing.Color.Teal;
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(870, 10);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(167, 35);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.Location = new System.Drawing.Point(124, 14);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(297, 26);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarEmpleado_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de empleados.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diseño.Properties.Resources.add_user1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Diseño.Properties.Resources.search1;
            this.pictureBox2.Location = new System.Drawing.Point(67, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // DtClientes
            // 
            this.DtClientes.AllowUserToAddRows = false;
            this.DtClientes.AllowUserToDeleteRows = false;
            this.DtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.DtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtClientes.EnableHeadersVisualStyles = false;
            this.DtClientes.GridColor = System.Drawing.Color.SteelBlue;
            this.DtClientes.Location = new System.Drawing.Point(0, 55);
            this.DtClientes.Name = "DtClientes";
            this.DtClientes.ReadOnly = true;
            this.DtClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtClientes.RowHeadersVisible = false;
            this.DtClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DtClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DtClientes.RowTemplate.Height = 24;
            this.DtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtClientes.ShowCellToolTips = false;
            this.DtClientes.ShowEditingIcon = false;
            this.DtClientes.Size = new System.Drawing.Size(1066, 715);
            this.DtClientes.TabIndex = 12;
            this.DtClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtClientes_CellMouseClick);
            this.DtClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DtClientes_MouseDoubleClick);
            // 
            // PnlFormulario
            // 
            this.PnlFormulario.AutoSize = true;
            this.PnlFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PnlFormulario.Controls.Add(this.tableLayoutPanel1);
            this.PnlFormulario.Controls.Add(this.DtEliminados);
            this.PnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormulario.Location = new System.Drawing.Point(0, 55);
            this.PnlFormulario.Name = "PnlFormulario";
            this.PnlFormulario.Size = new System.Drawing.Size(1066, 715);
            this.PnlFormulario.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6235F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.68022F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.72983F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.19512F));
            this.tableLayoutPanel1.Controls.Add(this.TxtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtApellido, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblApellido, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblRut, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtRut, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtID, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbxId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblEmail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFono, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtFono, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtDireccion, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardarCambios, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.BtnCerrar, 2, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.802722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.908612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.151142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.029877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.34446F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 715);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(190, 58);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(554, 33);
            this.TxtNombre.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(190, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(240, 47);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "EDICION DE USUARIOS.";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(48, 64);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(90, 20);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombres:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.Location = new System.Drawing.Point(190, 111);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(554, 24);
            this.TxtApellido.TabIndex = 2;
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(47, 113);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(92, 20);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellidos:";
            // 
            // LblRut
            // 
            this.LblRut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRut.AutoSize = true;
            this.LblRut.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRut.ForeColor = System.Drawing.Color.White;
            this.LblRut.Location = new System.Drawing.Point(71, 163);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(44, 20);
            this.LblRut.TabIndex = 3;
            this.LblRut.Text = "Rut:";
            // 
            // TxtRut
            // 
            this.TxtRut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRut.Location = new System.Drawing.Point(190, 156);
            this.TxtRut.MaxLength = 12;
            this.TxtRut.Multiline = true;
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(554, 33);
            this.TxtRut.TabIndex = 3;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(938, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(50, 22);
            this.TxtID.TabIndex = 7;
            this.TxtID.Visible = false;
            // 
            // CbxId
            // 
            this.CbxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxId.Enabled = false;
            this.CbxId.FormattingEnabled = true;
            this.CbxId.Location = new System.Drawing.Point(750, 3);
            this.CbxId.Name = "CbxId";
            this.CbxId.Size = new System.Drawing.Size(174, 24);
            this.CbxId.TabIndex = 13;
            this.CbxId.Visible = false;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(62, 221);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(62, 20);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // LblFono
            // 
            this.LblFono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFono.AutoSize = true;
            this.LblFono.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblFono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFono.ForeColor = System.Drawing.Color.White;
            this.LblFono.Location = new System.Drawing.Point(65, 279);
            this.LblFono.Name = "LblFono";
            this.LblFono.Size = new System.Drawing.Size(56, 20);
            this.LblFono.TabIndex = 3;
            this.LblFono.Text = "Fono:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Location = new System.Drawing.Point(190, 214);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(554, 33);
            this.TxtEmail.TabIndex = 6;
            // 
            // TxtFono
            // 
            this.TxtFono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFono.Location = new System.Drawing.Point(190, 272);
            this.TxtFono.MaxLength = 12;
            this.TxtFono.Multiline = true;
            this.TxtFono.Name = "TxtFono";
            this.TxtFono.Size = new System.Drawing.Size(554, 33);
            this.TxtFono.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Direccion:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(753, 443);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(176, 39);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "CERRAR";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(339, 502);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(255, 38);
            this.BtnGuardarCambios.TabIndex = 11;
            this.BtnGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(339, 385);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(256, 39);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDireccion.Location = new System.Drawing.Point(190, 330);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(554, 33);
            this.TxtDireccion.TabIndex = 16;
            // 
            // DtEliminados
            // 
            this.DtEliminados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.DtEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtEliminados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtEliminados.Location = new System.Drawing.Point(0, 0);
            this.DtEliminados.Name = "DtEliminados";
            this.DtEliminados.RowHeadersWidth = 51;
            this.DtEliminados.RowTemplate.Height = 24;
            this.DtEliminados.Size = new System.Drawing.Size(1066, 715);
            this.DtEliminados.TabIndex = 5;
            // 
            // Registro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 770);
            this.Controls.Add(this.PnlFormulario);
            this.Controls.Add(this.DtClientes);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Clientes";
            this.Text = "Registro_Clientes";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).EndInit();
            this.PnlFormulario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DtClientes;
        private System.Windows.Forms.Panel PnlFormulario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblFono;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtFono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DtEliminados;
        private System.Windows.Forms.ComboBox CbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccion;
    }
}