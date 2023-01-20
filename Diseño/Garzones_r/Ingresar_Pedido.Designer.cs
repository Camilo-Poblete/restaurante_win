
namespace Diseño.Garzones_r
{
    partial class Ingresar_Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dtpedido = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnPedidosActivos = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.BtnIngresarPedido = new System.Windows.Forms.Button();
            this.CbxPersonas = new System.Windows.Forms.ComboBox();
            this.CbxMesa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CbxIDplato = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.CbxPlato = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPlato = new System.Windows.Forms.Button();
            this.BtnEliminarPlato = new System.Windows.Forms.Button();
            this.BtnIngresarComanda = new System.Windows.Forms.Button();
            this.DtPlatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtpedido)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtPlatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.Dtpedido);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.DtPlatos);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 683);
            this.panel1.TabIndex = 1;
            // 
            // Dtpedido
            // 
            this.Dtpedido.AllowUserToAddRows = false;
            this.Dtpedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtpedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtpedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtpedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtpedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtpedido.EnableHeadersVisualStyles = false;
            this.Dtpedido.Location = new System.Drawing.Point(0, 205);
            this.Dtpedido.MultiSelect = false;
            this.Dtpedido.Name = "Dtpedido";
            this.Dtpedido.ReadOnly = true;
            this.Dtpedido.RowHeadersVisible = false;
            this.Dtpedido.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Dtpedido.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtpedido.RowTemplate.Height = 24;
            this.Dtpedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtpedido.Size = new System.Drawing.Size(1093, 429);
            this.Dtpedido.TabIndex = 7;
            this.Dtpedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtpedido_CellDoubleClick_2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.69355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.30645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.BtnVolver, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnPedidosActivos, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtCliente, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CbxCliente, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnIngresarPedido, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.CbxPersonas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbxMesa, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtCantidad, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CbxIDplato, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtID, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbxCategoria, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbxPlato, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAgregarPlato, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminarPlato, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnIngresarComanda, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 205);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(455, 172);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(156, 28);
            this.BtnVolver.TabIndex = 13;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Visible = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnPedidosActivos
            // 
            this.BtnPedidosActivos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPedidosActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnPedidosActivos.ForeColor = System.Drawing.Color.White;
            this.BtnPedidosActivos.Location = new System.Drawing.Point(455, 124);
            this.BtnPedidosActivos.Name = "BtnPedidosActivos";
            this.BtnPedidosActivos.Size = new System.Drawing.Size(156, 42);
            this.BtnPedidosActivos.TabIndex = 11;
            this.BtnPedidosActivos.Text = "PEDIDOS ACTIVOS";
            this.BtnPedidosActivos.UseVisualStyleBackColor = false;
            this.BtnPedidosActivos.Click += new System.EventHandler(this.BtnPedidosActivos_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtCliente.Location = new System.Drawing.Point(165, 98);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(236, 22);
            this.TxtCliente.TabIndex = 3;
            this.TxtCliente.Text = "Ingrese un nombre para filtrar.";
            this.TxtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCliente_KeyPress);
            this.TxtCliente.Leave += new System.EventHandler(this.TxtCliente_Leave);
            this.TxtCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TxtCliente_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxCliente
            // 
            this.CbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(165, 124);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(236, 24);
            this.CbxCliente.TabIndex = 4;
            // 
            // BtnIngresarPedido
            // 
            this.BtnIngresarPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnIngresarPedido.ForeColor = System.Drawing.Color.White;
            this.BtnIngresarPedido.Location = new System.Drawing.Point(201, 172);
            this.BtnIngresarPedido.Name = "BtnIngresarPedido";
            this.BtnIngresarPedido.Size = new System.Drawing.Size(202, 28);
            this.BtnIngresarPedido.TabIndex = 5;
            this.BtnIngresarPedido.Text = "INGRESAR PEDIDO";
            this.BtnIngresarPedido.UseVisualStyleBackColor = false;
            this.BtnIngresarPedido.Click += new System.EventHandler(this.BtnIngresarPedido_Click);
            // 
            // CbxPersonas
            // 
            this.CbxPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPersonas.FormattingEnabled = true;
            this.CbxPersonas.Location = new System.Drawing.Point(165, 42);
            this.CbxPersonas.Name = "CbxPersonas";
            this.CbxPersonas.Size = new System.Drawing.Size(256, 24);
            this.CbxPersonas.TabIndex = 1;
            this.CbxPersonas.TextChanged += new System.EventHandler(this.CbxPersonas_TextChanged);
            // 
            // CbxMesa
            // 
            this.CbxMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMesa.FormattingEnabled = true;
            this.CbxMesa.Location = new System.Drawing.Point(165, 70);
            this.CbxMesa.Name = "CbxMesa";
            this.CbxMesa.Size = new System.Drawing.Size(256, 24);
            this.CbxMesa.TabIndex = 2;
            this.CbxMesa.SelectedIndexChanged += new System.EventHandler(this.CbxMesa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "N° Personas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesa: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de pedidos.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(446, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoria";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(626, 98);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(97, 22);
            this.TxtCantidad.TabIndex = 8;
            // 
            // CbxIDplato
            // 
            this.CbxIDplato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxIDplato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CbxIDplato.Enabled = false;
            this.CbxIDplato.FormattingEnabled = true;
            this.CbxIDplato.Location = new System.Drawing.Point(915, 42);
            this.CbxIDplato.Name = "CbxIDplato";
            this.CbxIDplato.Size = new System.Drawing.Size(175, 22);
            this.CbxIDplato.TabIndex = 10;
            this.CbxIDplato.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(915, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(175, 22);
            this.TxtID.TabIndex = 11;
            this.TxtID.Text = "TxtID";
            this.TxtID.Visible = false;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(626, 42);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(283, 24);
            this.CbxCategoria.TabIndex = 6;
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged_1);
            // 
            // CbxPlato
            // 
            this.CbxPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxPlato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPlato.FormattingEnabled = true;
            this.CbxPlato.Location = new System.Drawing.Point(626, 70);
            this.CbxPlato.Name = "CbxPlato";
            this.CbxPlato.Size = new System.Drawing.Size(283, 24);
            this.CbxPlato.TabIndex = 7;
            this.CbxPlato.SelectedIndexChanged += new System.EventHandler(this.CbxPlato_SelectedIndexChanged);
            // 
            // BtnAgregarPlato
            // 
            this.BtnAgregarPlato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnAgregarPlato.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarPlato.Location = new System.Drawing.Point(687, 124);
            this.BtnAgregarPlato.Name = "BtnAgregarPlato";
            this.BtnAgregarPlato.Size = new System.Drawing.Size(161, 42);
            this.BtnAgregarPlato.TabIndex = 10;
            this.BtnAgregarPlato.Text = "AGREGAR ITEM";
            this.BtnAgregarPlato.UseVisualStyleBackColor = false;
            this.BtnAgregarPlato.Visible = false;
            this.BtnAgregarPlato.Click += new System.EventHandler(this.BtnAgregarPlato_Click);
            // 
            // BtnEliminarPlato
            // 
            this.BtnEliminarPlato.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnEliminarPlato.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarPlato.Location = new System.Drawing.Point(924, 124);
            this.BtnEliminarPlato.Name = "BtnEliminarPlato";
            this.BtnEliminarPlato.Size = new System.Drawing.Size(157, 42);
            this.BtnEliminarPlato.TabIndex = 12;
            this.BtnEliminarPlato.Text = "ELIMINAR PLATO";
            this.BtnEliminarPlato.UseVisualStyleBackColor = false;
            this.BtnEliminarPlato.Visible = false;
            this.BtnEliminarPlato.Click += new System.EventHandler(this.BtnEliminarPlato_Click);
            // 
            // BtnIngresarComanda
            // 
            this.BtnIngresarComanda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIngresarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnIngresarComanda.ForeColor = System.Drawing.Color.White;
            this.BtnIngresarComanda.Location = new System.Drawing.Point(671, 172);
            this.BtnIngresarComanda.Name = "BtnIngresarComanda";
            this.BtnIngresarComanda.Size = new System.Drawing.Size(192, 30);
            this.BtnIngresarComanda.TabIndex = 8;
            this.BtnIngresarComanda.Text = "INGRESAR COMANDA";
            this.BtnIngresarComanda.UseVisualStyleBackColor = false;
            this.BtnIngresarComanda.Visible = false;
            this.BtnIngresarComanda.Click += new System.EventHandler(this.BtnIngresarComanda_Click);
            // 
            // DtPlatos
            // 
            this.DtPlatos.AllowUserToAddRows = false;
            this.DtPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtPlatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtPlatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtPlatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtPlatos.EnableHeadersVisualStyles = false;
            this.DtPlatos.Location = new System.Drawing.Point(0, 0);
            this.DtPlatos.MultiSelect = false;
            this.DtPlatos.Name = "DtPlatos";
            this.DtPlatos.ReadOnly = true;
            this.DtPlatos.RowHeadersVisible = false;
            this.DtPlatos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DtPlatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtPlatos.RowTemplate.Height = 24;
            this.DtPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtPlatos.Size = new System.Drawing.Size(1093, 634);
            this.DtPlatos.TabIndex = 4;
            this.DtPlatos.Visible = false;
            this.DtPlatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtPlatos_CellClick_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutPanel2.Controls.Add(this.LblTotal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtTotal, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 634);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1093, 49);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(691, 7);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(62, 33);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total:";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.White;
            this.TxtTotal.Location = new System.Drawing.Point(759, 10);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(331, 23);
            this.TxtTotal.TabIndex = 1;
            // 
            // Ingresar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1093, 683);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ingresar_Pedido";
            this.Text = "Ingresar_Pedido";
            this.Load += new System.EventHandler(this.Ingresar_Pedido_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtpedido)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtPlatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridView DtPlatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnPedidosActivos;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxCliente;
        private System.Windows.Forms.Button BtnIngresarPedido;
        private System.Windows.Forms.ComboBox CbxPersonas;
        private System.Windows.Forms.ComboBox CbxMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CbxIDplato;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.ComboBox CbxPlato;
        private System.Windows.Forms.Button BtnAgregarPlato;
        private System.Windows.Forms.Button BtnEliminarPlato;
        private System.Windows.Forms.Button BtnIngresarComanda;
        private System.Windows.Forms.DataGridView Dtpedido;
    }
}