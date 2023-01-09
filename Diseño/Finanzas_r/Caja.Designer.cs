
namespace Diseño.Finanzas_r
{
    partial class Caja
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlActivos = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.DtActivos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtPropina = new System.Windows.Forms.TextBox();
            this.BtnBoletaElec = new System.Windows.Forms.Button();
            this.btndescargar = new System.Windows.Forms.Button();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDtco = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblCbxPropina = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblIDpedido = new System.Windows.Forms.Label();
            this.TxtIdBoleta = new System.Windows.Forms.TextBox();
            this.LblMesa = new System.Windows.Forms.Label();
            this.CbxTipoPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxPropina = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.TxtDcto = new System.Windows.Forms.TextBox();
            this.PnlDia = new System.Windows.Forms.TableLayoutPanel();
            this.DtVentasDia = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnVolver_peddias = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblPersonal = new System.Windows.Forms.Label();
            this.Lblefectivo = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblTransferencias = new System.Windows.Forms.Label();
            this.LblDebitoCredito = new System.Windows.Forms.Label();
            this.LblPropinas = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtMesa = new System.Windows.Forms.TextBox();
            this.TxtEfectivo = new System.Windows.Forms.TextBox();
            this.TxtDebitoCredito = new System.Windows.Forms.TextBox();
            this.TxtTransferencia = new System.Windows.Forms.TextBox();
            this.TxtPropinasDia = new System.Windows.Forms.TextBox();
            this.PnlPrincipal.SuspendLayout();
            this.PnlActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtActivos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.PnlDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVentasDia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PnlPrincipal.Controls.Add(this.PnlActivos);
            this.PnlPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.PnlPrincipal.Controls.Add(this.PnlDia);
            this.PnlPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1591, 798);
            this.PnlPrincipal.TabIndex = 1;
            this.PnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPrincipal_Paint);
            // 
            // PnlActivos
            // 
            this.PnlActivos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlActivos.ColumnCount = 1;
            this.PnlActivos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlActivos.Controls.Add(this.label8, 0, 1);
            this.PnlActivos.Controls.Add(this.DtActivos, 0, 2);
            this.PnlActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlActivos.Location = new System.Drawing.Point(460, 125);
            this.PnlActivos.Name = "PnlActivos";
            this.PnlActivos.RowCount = 3;
            this.PnlActivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.398438F));
            this.PnlActivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.273438F));
            this.PnlActivos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.13281F));
            this.PnlActivos.Size = new System.Drawing.Size(559, 673);
            this.PnlActivos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(202, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pedidos activos.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtActivos
            // 
            this.DtActivos.AllowUserToAddRows = false;
            this.DtActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtActivos.EnableHeadersVisualStyles = false;
            this.DtActivos.Location = new System.Drawing.Point(3, 94);
            this.DtActivos.MultiSelect = false;
            this.DtActivos.Name = "DtActivos";
            this.DtActivos.ReadOnly = true;
            this.DtActivos.RowHeadersVisible = false;
            this.DtActivos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DtActivos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtActivos.RowTemplate.Height = 24;
            this.DtActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtActivos.Size = new System.Drawing.Size(553, 576);
            this.DtActivos.TabIndex = 0;
            this.DtActivos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtActivos_CellMouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24475F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.74126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.18881F));
            this.tableLayoutPanel2.Controls.Add(this.TxtPropina, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnBoletaElec, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btndescargar, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnPagar, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnVolver, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.LblDtco, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblTotal, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LblSubTotal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LblCbxPropina, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblIDpedido, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtIdBoleta, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.LblMesa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CbxTipoPago, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.CbxPropina, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtTotal, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtSubTotal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TxtDcto, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1019, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74219F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.35156F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.21053F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(572, 673);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // TxtPropina
            // 
            this.TxtPropina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPropina.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtPropina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPropina.Enabled = false;
            this.TxtPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPropina.ForeColor = System.Drawing.Color.White;
            this.TxtPropina.Location = new System.Drawing.Point(367, 130);
            this.TxtPropina.Name = "TxtPropina";
            this.TxtPropina.Size = new System.Drawing.Size(202, 27);
            this.TxtPropina.TabIndex = 9;
            this.TxtPropina.Text = "0";
            // 
            // BtnBoletaElec
            // 
            this.BtnBoletaElec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBoletaElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnBoletaElec.FlatAppearance.BorderSize = 0;
            this.BtnBoletaElec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnBoletaElec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoletaElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletaElec.ForeColor = System.Drawing.Color.White;
            this.BtnBoletaElec.Location = new System.Drawing.Point(383, 452);
            this.BtnBoletaElec.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBoletaElec.Name = "BtnBoletaElec";
            this.BtnBoletaElec.Size = new System.Drawing.Size(170, 58);
            this.BtnBoletaElec.TabIndex = 7;
            this.BtnBoletaElec.Text = "BOLETA ELECTRONICA";
            this.BtnBoletaElec.UseVisualStyleBackColor = false;
            this.BtnBoletaElec.Visible = false;
            this.BtnBoletaElec.Click += new System.EventHandler(this.BtnBoletaElec_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.btndescargar.FlatAppearance.BorderSize = 0;
            this.btndescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Location = new System.Drawing.Point(395, 573);
            this.btndescargar.Margin = new System.Windows.Forms.Padding(4);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(145, 60);
            this.btndescargar.TabIndex = 8;
            this.btndescargar.Text = "IMPRIMIR BOLETA";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnPagar.FlatAppearance.BorderSize = 0;
            this.BtnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ForeColor = System.Drawing.Color.White;
            this.BtnPagar.Location = new System.Drawing.Point(195, 582);
            this.BtnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(145, 43);
            this.BtnPagar.TabIndex = 6;
            this.BtnPagar.Text = "PAGAR";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(28, 582);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(116, 43);
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Visible = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medio de pago: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDtco
            // 
            this.LblDtco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDtco.AutoSize = true;
            this.LblDtco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDtco.ForeColor = System.Drawing.Color.White;
            this.LblDtco.Location = new System.Drawing.Point(27, 227);
            this.LblDtco.Name = "LblDtco";
            this.LblDtco.Size = new System.Drawing.Size(117, 25);
            this.LblDtco.TabIndex = 0;
            this.LblDtco.Text = "Descuento: ";
            this.LblDtco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(55, 382);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(62, 25);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "Total:";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.Color.White;
            this.LblSubTotal.Location = new System.Drawing.Point(34, 311);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(103, 25);
            this.LblSubTotal.TabIndex = 0;
            this.LblSubTotal.Text = "Sub Total:";
            this.LblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCbxPropina
            // 
            this.LblCbxPropina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCbxPropina.AutoSize = true;
            this.LblCbxPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCbxPropina.ForeColor = System.Drawing.Color.White;
            this.LblCbxPropina.Location = new System.Drawing.Point(8, 119);
            this.LblCbxPropina.Name = "LblCbxPropina";
            this.LblCbxPropina.Size = new System.Drawing.Size(156, 50);
            this.LblCbxPropina.TabIndex = 0;
            this.LblCbxPropina.Text = "¿Desea Agregar Propina?.";
            this.LblCbxPropina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(180, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Termino de pedido";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIDpedido
            // 
            this.LblIDpedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblIDpedido.AutoSize = true;
            this.LblIDpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDpedido.ForeColor = System.Drawing.Color.White;
            this.LblIDpedido.Location = new System.Drawing.Point(421, 38);
            this.LblIDpedido.Name = "LblIDpedido";
            this.LblIDpedido.Size = new System.Drawing.Size(94, 20);
            this.LblIDpedido.TabIndex = 0;
            this.LblIDpedido.Text = "N° Pedido: ";
            this.LblIDpedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtIdBoleta
            // 
            this.TxtIdBoleta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtIdBoleta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtIdBoleta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdBoleta.Enabled = false;
            this.TxtIdBoleta.ForeColor = System.Drawing.Color.White;
            this.TxtIdBoleta.Location = new System.Drawing.Point(383, 316);
            this.TxtIdBoleta.Name = "TxtIdBoleta";
            this.TxtIdBoleta.Size = new System.Drawing.Size(170, 15);
            this.TxtIdBoleta.TabIndex = 9;
            this.TxtIdBoleta.Visible = false;
            // 
            // LblMesa
            // 
            this.LblMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMesa.AutoSize = true;
            this.LblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesa.ForeColor = System.Drawing.Color.White;
            this.LblMesa.Location = new System.Drawing.Point(56, 38);
            this.LblMesa.Name = "LblMesa";
            this.LblMesa.Size = new System.Drawing.Size(60, 20);
            this.LblMesa.TabIndex = 0;
            this.LblMesa.Text = "Mesa: ";
            this.LblMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxTipoPago
            // 
            this.CbxTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoPago.Enabled = false;
            this.CbxTipoPago.FormattingEnabled = true;
            this.CbxTipoPago.Items.AddRange(new object[] {
            "-- SELECCIONE TIPO PAGO --",
            "EFECTIVO",
            "TRANSFERENCIA",
            "DEBITO/CREDITO"});
            this.CbxTipoPago.Location = new System.Drawing.Point(175, 469);
            this.CbxTipoPago.Name = "CbxTipoPago";
            this.CbxTipoPago.Size = new System.Drawing.Size(186, 24);
            this.CbxTipoPago.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxPropina
            // 
            this.CbxPropina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxPropina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPropina.Enabled = false;
            this.CbxPropina.FormattingEnabled = true;
            this.CbxPropina.Items.AddRange(new object[] {
            "-- SELECCIONE OPCION --",
            "SI",
            "NO"});
            this.CbxPropina.Location = new System.Drawing.Point(175, 132);
            this.CbxPropina.Name = "CbxPropina";
            this.CbxPropina.Size = new System.Drawing.Size(186, 24);
            this.CbxPropina.TabIndex = 1;
            this.CbxPropina.SelectedIndexChanged += new System.EventHandler(this.CbxPropina_SelectedIndexChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(175, 383);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(186, 22);
            this.TxtTotal.TabIndex = 4;
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(175, 313);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(186, 22);
            this.TxtSubTotal.TabIndex = 3;
            // 
            // TxtDcto
            // 
            this.TxtDcto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDcto.Location = new System.Drawing.Point(175, 229);
            this.TxtDcto.Name = "TxtDcto";
            this.TxtDcto.Size = new System.Drawing.Size(186, 22);
            this.TxtDcto.TabIndex = 2;
            // 
            // PnlDia
            // 
            this.PnlDia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlDia.ColumnCount = 3;
            this.PnlDia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.PnlDia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.PnlDia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.PnlDia.Controls.Add(this.DtVentasDia, 1, 2);
            this.PnlDia.Controls.Add(this.label16, 1, 1);
            this.PnlDia.Controls.Add(this.BtnVolver_peddias, 1, 0);
            this.PnlDia.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlDia.Location = new System.Drawing.Point(0, 125);
            this.PnlDia.Name = "PnlDia";
            this.PnlDia.RowCount = 3;
            this.PnlDia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.398438F));
            this.PnlDia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.273438F));
            this.PnlDia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.32813F));
            this.PnlDia.Size = new System.Drawing.Size(460, 673);
            this.PnlDia.TabIndex = 2;
            // 
            // DtVentasDia
            // 
            this.DtVentasDia.AllowUserToAddRows = false;
            this.DtVentasDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtVentasDia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtVentasDia.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVentasDia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtVentasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVentasDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtVentasDia.EnableHeadersVisualStyles = false;
            this.DtVentasDia.Location = new System.Drawing.Point(7, 94);
            this.DtVentasDia.MultiSelect = false;
            this.DtVentasDia.Name = "DtVentasDia";
            this.DtVentasDia.ReadOnly = true;
            this.DtVentasDia.RowHeadersVisible = false;
            this.DtVentasDia.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DtVentasDia.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtVentasDia.RowTemplate.Height = 24;
            this.DtVentasDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVentasDia.Size = new System.Drawing.Size(444, 576);
            this.DtVentasDia.TabIndex = 0;
            this.DtVentasDia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtVentasDia_CellDoubleClick);
            this.DtVentasDia.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtVentasDia_CellMouseDoubleClick);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(154, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pedidos del dia.";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVolver_peddias
            // 
            this.BtnVolver_peddias.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnVolver_peddias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnVolver_peddias.FlatAppearance.BorderSize = 0;
            this.BtnVolver_peddias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnVolver_peddias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver_peddias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver_peddias.ForeColor = System.Drawing.Color.White;
            this.BtnVolver_peddias.Location = new System.Drawing.Point(8, 10);
            this.BtnVolver_peddias.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolver_peddias.Name = "BtnVolver_peddias";
            this.BtnVolver_peddias.Size = new System.Drawing.Size(116, 35);
            this.BtnVolver_peddias.TabIndex = 10;
            this.BtnVolver_peddias.Text = "VOLVER";
            this.BtnVolver_peddias.UseVisualStyleBackColor = false;
            this.BtnVolver_peddias.Visible = false;
            this.BtnVolver_peddias.Click += new System.EventHandler(this.BtnVolver_peddias_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.37102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.66602F));
            this.tableLayoutPanel1.Controls.Add(this.LblPersonal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lblefectivo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTransferencias, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblDebitoCredito, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblPropinas, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtId, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtMesa, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtEfectivo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtDebitoCredito, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtTransferencia, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtPropinasDia, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1591, 125);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblPersonal
            // 
            this.LblPersonal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPersonal.AutoSize = true;
            this.LblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPersonal.ForeColor = System.Drawing.Color.White;
            this.LblPersonal.Location = new System.Drawing.Point(3, 0);
            this.LblPersonal.Name = "LblPersonal";
            this.LblPersonal.Size = new System.Drawing.Size(171, 24);
            this.LblPersonal.TabIndex = 0;
            this.LblPersonal.Text = "Personal de venta: ";
            this.LblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lblefectivo
            // 
            this.Lblefectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lblefectivo.AutoSize = true;
            this.Lblefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblefectivo.ForeColor = System.Drawing.Color.White;
            this.Lblefectivo.Location = new System.Drawing.Point(129, 25);
            this.Lblefectivo.Name = "Lblefectivo";
            this.Lblefectivo.Size = new System.Drawing.Size(159, 25);
            this.Lblefectivo.TabIndex = 0;
            this.Lblefectivo.Text = "Total Efectivo";
            this.Lblefectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(761, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(62, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Caja";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTransferencias
            // 
            this.LblTransferencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTransferencias.AutoSize = true;
            this.LblTransferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTransferencias.ForeColor = System.Drawing.Color.White;
            this.LblTransferencias.Location = new System.Drawing.Point(1269, 25);
            this.LblTransferencias.Name = "LblTransferencias";
            this.LblTransferencias.Size = new System.Drawing.Size(234, 25);
            this.LblTransferencias.TabIndex = 0;
            this.LblTransferencias.Text = "Total Transferencias";
            this.LblTransferencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDebitoCredito
            // 
            this.LblDebitoCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDebitoCredito.AutoSize = true;
            this.LblDebitoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDebitoCredito.ForeColor = System.Drawing.Color.White;
            this.LblDebitoCredito.Location = new System.Drawing.Point(677, 25);
            this.LblDebitoCredito.Name = "LblDebitoCredito";
            this.LblDebitoCredito.Size = new System.Drawing.Size(231, 25);
            this.LblDebitoCredito.TabIndex = 0;
            this.LblDebitoCredito.Text = "Total Debito/Credito";
            this.LblDebitoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPropinas
            // 
            this.LblPropinas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPropinas.AutoSize = true;
            this.LblPropinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPropinas.ForeColor = System.Drawing.Color.White;
            this.LblPropinas.Location = new System.Drawing.Point(1044, 102);
            this.LblPropinas.Name = "LblPropinas";
            this.LblPropinas.Size = new System.Drawing.Size(134, 20);
            this.LblPropinas.TabIndex = 0;
            this.LblPropinas.Text = "Propinas del dia:";
            this.LblPropinas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtId
            // 
            this.TxtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(1184, 78);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(404, 22);
            this.TxtId.TabIndex = 9;
            this.TxtId.Visible = false;
            // 
            // TxtMesa
            // 
            this.TxtMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMesa.Location = new System.Drawing.Point(1004, 78);
            this.TxtMesa.Name = "TxtMesa";
            this.TxtMesa.Size = new System.Drawing.Size(174, 22);
            this.TxtMesa.TabIndex = 9;
            this.TxtMesa.Visible = false;
            // 
            // TxtEfectivo
            // 
            this.TxtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEfectivo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEfectivo.ForeColor = System.Drawing.Color.White;
            this.TxtEfectivo.Location = new System.Drawing.Point(3, 53);
            this.TxtEfectivo.Name = "TxtEfectivo";
            this.TxtEfectivo.Size = new System.Drawing.Size(411, 23);
            this.TxtEfectivo.TabIndex = 10;
            this.TxtEfectivo.Text = "$";
            this.TxtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDebitoCredito
            // 
            this.TxtDebitoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDebitoCredito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtDebitoCredito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDebitoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDebitoCredito.ForeColor = System.Drawing.Color.White;
            this.TxtDebitoCredito.Location = new System.Drawing.Point(587, 53);
            this.TxtDebitoCredito.Name = "TxtDebitoCredito";
            this.TxtDebitoCredito.Size = new System.Drawing.Size(411, 23);
            this.TxtDebitoCredito.TabIndex = 10;
            this.TxtDebitoCredito.Text = "$";
            this.TxtDebitoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTransferencia
            // 
            this.TxtTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTransferencia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTransferencia.ForeColor = System.Drawing.Color.White;
            this.TxtTransferencia.Location = new System.Drawing.Point(1184, 53);
            this.TxtTransferencia.Name = "TxtTransferencia";
            this.TxtTransferencia.Size = new System.Drawing.Size(404, 23);
            this.TxtTransferencia.TabIndex = 10;
            this.TxtTransferencia.Text = "$";
            this.TxtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPropinasDia
            // 
            this.TxtPropinasDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPropinasDia.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtPropinasDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPropinasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPropinasDia.ForeColor = System.Drawing.Color.White;
            this.TxtPropinasDia.Location = new System.Drawing.Point(1184, 103);
            this.TxtPropinasDia.Name = "TxtPropinasDia";
            this.TxtPropinasDia.Size = new System.Drawing.Size(404, 23);
            this.TxtPropinasDia.TabIndex = 10;
            this.TxtPropinasDia.Text = "$";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1591, 798);
            this.Controls.Add(this.PnlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlActivos.ResumeLayout(false);
            this.PnlActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtActivos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PnlDia.ResumeLayout(false);
            this.PnlDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVentasDia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.TableLayoutPanel PnlActivos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DtActivos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TxtPropina;
        private System.Windows.Forms.Button BtnBoletaElec;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDtco;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblCbxPropina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblIDpedido;
        private System.Windows.Forms.TextBox TxtIdBoleta;
        private System.Windows.Forms.Label LblMesa;
        private System.Windows.Forms.ComboBox CbxTipoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxPropina;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.TextBox TxtDcto;
        private System.Windows.Forms.TableLayoutPanel PnlDia;
        private System.Windows.Forms.DataGridView DtVentasDia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnVolver_peddias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblPersonal;
        private System.Windows.Forms.Label Lblefectivo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblTransferencias;
        private System.Windows.Forms.Label LblDebitoCredito;
        private System.Windows.Forms.Label LblPropinas;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMesa;
        private System.Windows.Forms.TextBox TxtEfectivo;
        private System.Windows.Forms.TextBox TxtDebitoCredito;
        private System.Windows.Forms.TextBox TxtTransferencia;
        private System.Windows.Forms.TextBox TxtPropinasDia;
    }
}