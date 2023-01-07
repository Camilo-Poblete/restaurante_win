namespace Diseño.Reportes
{
    partial class Reporte_stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.LblTituloVencido = new System.Windows.Forms.Label();
            this.TablaBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TablaCritico = new System.Windows.Forms.TableLayoutPanel();
            this.Dtcritico = new System.Windows.Forms.DataGridView();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LbltituloCritico = new System.Windows.Forms.Label();
            this.TablaInformacion = new System.Windows.Forms.TableLayoutPanel();
            this.LblDisponible = new System.Windows.Forms.Label();
            this.NumDisponible = new System.Windows.Forms.Label();
            this.NumVencidos = new System.Windows.Forms.Label();
            this.NumCritico = new System.Windows.Forms.Label();
            this.LblVencidos = new System.Windows.Forms.Label();
            this.LblCritico = new System.Windows.Forms.Label();
            this.TablaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.TablaVencidos = new System.Windows.Forms.TableLayoutPanel();
            this.DtVencido = new System.Windows.Forms.DataGridView();
            this.PnlPrincipal.SuspendLayout();
            this.TablaBotones.SuspendLayout();
            this.TablaCritico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtcritico)).BeginInit();
            this.TablaInformacion.SuspendLayout();
            this.TablaPrincipal.SuspendLayout();
            this.TablaVencidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtVencido)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PnlPrincipal.Controls.Add(this.TablaPrincipal);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1330, 758);
            this.PnlPrincipal.TabIndex = 1;
            // 
            // LblTituloVencido
            // 
            this.LblTituloVencido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloVencido.AutoSize = true;
            this.LblTituloVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVencido.ForeColor = System.Drawing.Color.White;
            this.LblTituloVencido.Location = new System.Drawing.Point(872, 30);
            this.LblTituloVencido.Name = "LblTituloVencido";
            this.LblTituloVencido.Size = new System.Drawing.Size(455, 29);
            this.LblTituloVencido.TabIndex = 0;
            this.LblTituloVencido.Text = "STOCK VENCIDO";
            this.LblTituloVencido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaBotones
            // 
            this.TablaBotones.ColumnCount = 3;
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.83721F));
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.72093F));
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2093F));
            this.TablaBotones.Controls.Add(this.BtnImprimir, 1, 0);
            this.TablaBotones.Controls.Add(this.BtnGenerar, 1, 1);
            this.TablaBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaBotones.Location = new System.Drawing.Point(443, 613);
            this.TablaBotones.Name = "TablaBotones";
            this.TablaBotones.RowCount = 3;
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablaBotones.Size = new System.Drawing.Size(423, 142);
            this.TablaBotones.TabIndex = 3;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGenerar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerar.ForeColor = System.Drawing.Color.White;
            this.BtnGenerar.Location = new System.Drawing.Point(100, 50);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(227, 40);
            this.BtnGenerar.TabIndex = 2;
            this.BtnGenerar.Text = "GENERAR PDF REPORTE";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnImprimir.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnImprimir.ForeColor = System.Drawing.Color.White;
            this.BtnImprimir.Location = new System.Drawing.Point(123, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(182, 40);
            this.BtnImprimir.TabIndex = 1;
            this.BtnImprimir.Text = "IMPRIMIR REPORTE";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // TablaCritico
            // 
            this.TablaCritico.ColumnCount = 3;
            this.TablaCritico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.757188F));
            this.TablaCritico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.48563F));
            this.TablaCritico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.757188F));
            this.TablaCritico.Controls.Add(this.Dtcritico, 1, 0);
            this.TablaCritico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaCritico.Location = new System.Drawing.Point(3, 62);
            this.TablaCritico.Name = "TablaCritico";
            this.TablaCritico.RowCount = 1;
            this.TablaCritico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablaCritico.Size = new System.Drawing.Size(434, 545);
            this.TablaCritico.TabIndex = 1;
            // 
            // Dtcritico
            // 
            this.Dtcritico.AllowUserToAddRows = false;
            this.Dtcritico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtcritico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtcritico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtcritico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Dtcritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtcritico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtcritico.EnableHeadersVisualStyles = false;
            this.Dtcritico.GridColor = System.Drawing.Color.SteelBlue;
            this.Dtcritico.Location = new System.Drawing.Point(10, 3);
            this.Dtcritico.Name = "Dtcritico";
            this.Dtcritico.ReadOnly = true;
            this.Dtcritico.RowHeadersVisible = false;
            this.Dtcritico.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Dtcritico.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Dtcritico.RowTemplate.Height = 24;
            this.Dtcritico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtcritico.Size = new System.Drawing.Size(412, 539);
            this.Dtcritico.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(443, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(423, 59);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "REPORTE DE STOCK";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbltituloCritico
            // 
            this.LbltituloCritico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbltituloCritico.AutoSize = true;
            this.LbltituloCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltituloCritico.ForeColor = System.Drawing.Color.White;
            this.LbltituloCritico.Location = new System.Drawing.Point(3, 30);
            this.LbltituloCritico.Name = "LbltituloCritico";
            this.LbltituloCritico.Size = new System.Drawing.Size(434, 29);
            this.LbltituloCritico.TabIndex = 0;
            this.LbltituloCritico.Text = "STOCK CRITICO";
            this.LbltituloCritico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaInformacion
            // 
            this.TablaInformacion.ColumnCount = 3;
            this.TablaInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.62791F));
            this.TablaInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30233F));
            this.TablaInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.83721F));
            this.TablaInformacion.Controls.Add(this.LblCritico, 0, 2);
            this.TablaInformacion.Controls.Add(this.LblVencidos, 0, 1);
            this.TablaInformacion.Controls.Add(this.NumCritico, 1, 2);
            this.TablaInformacion.Controls.Add(this.NumVencidos, 1, 1);
            this.TablaInformacion.Controls.Add(this.NumDisponible, 1, 0);
            this.TablaInformacion.Controls.Add(this.LblDisponible, 0, 0);
            this.TablaInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaInformacion.Location = new System.Drawing.Point(443, 62);
            this.TablaInformacion.Name = "TablaInformacion";
            this.TablaInformacion.RowCount = 4;
            this.TablaInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaInformacion.Size = new System.Drawing.Size(423, 545);
            this.TablaInformacion.TabIndex = 4;
            // 
            // LblDisponible
            // 
            this.LblDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDisponible.AutoSize = true;
            this.LblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisponible.ForeColor = System.Drawing.Color.White;
            this.LblDisponible.Location = new System.Drawing.Point(3, 43);
            this.LblDisponible.Name = "LblDisponible";
            this.LblDisponible.Size = new System.Drawing.Size(170, 50);
            this.LblDisponible.TabIndex = 0;
            this.LblDisponible.Text = "STOCK DISPONIBLE:";
            this.LblDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumDisponible
            // 
            this.NumDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumDisponible.AutoSize = true;
            this.NumDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDisponible.ForeColor = System.Drawing.Color.White;
            this.NumDisponible.Location = new System.Drawing.Point(179, 55);
            this.NumDisponible.Name = "NumDisponible";
            this.NumDisponible.Size = new System.Drawing.Size(203, 25);
            this.NumDisponible.TabIndex = 0;
            this.NumDisponible.Text = "0";
            this.NumDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumVencidos
            // 
            this.NumVencidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumVencidos.AutoSize = true;
            this.NumVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumVencidos.ForeColor = System.Drawing.Color.White;
            this.NumVencidos.Location = new System.Drawing.Point(179, 191);
            this.NumVencidos.Name = "NumVencidos";
            this.NumVencidos.Size = new System.Drawing.Size(203, 25);
            this.NumVencidos.TabIndex = 0;
            this.NumVencidos.Text = "0";
            this.NumVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumCritico
            // 
            this.NumCritico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumCritico.AutoSize = true;
            this.NumCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCritico.ForeColor = System.Drawing.Color.White;
            this.NumCritico.Location = new System.Drawing.Point(179, 327);
            this.NumCritico.Name = "NumCritico";
            this.NumCritico.Size = new System.Drawing.Size(203, 25);
            this.NumCritico.TabIndex = 0;
            this.NumCritico.Text = "0";
            this.NumCritico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVencidos
            // 
            this.LblVencidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVencidos.AutoSize = true;
            this.LblVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVencidos.ForeColor = System.Drawing.Color.White;
            this.LblVencidos.Location = new System.Drawing.Point(3, 179);
            this.LblVencidos.Name = "LblVencidos";
            this.LblVencidos.Size = new System.Drawing.Size(170, 50);
            this.LblVencidos.TabIndex = 0;
            this.LblVencidos.Text = "PRODUCTOS VENCIDOS:";
            this.LblVencidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCritico
            // 
            this.LblCritico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCritico.AutoSize = true;
            this.LblCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCritico.ForeColor = System.Drawing.Color.White;
            this.LblCritico.Location = new System.Drawing.Point(3, 302);
            this.LblCritico.Name = "LblCritico";
            this.LblCritico.Size = new System.Drawing.Size(170, 75);
            this.LblCritico.TabIndex = 0;
            this.LblCritico.Text = "PRODUCTOS CON STOCK CRITICO:";
            this.LblCritico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaPrincipal
            // 
            this.TablaPrincipal.ColumnCount = 3;
            this.TablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09301F));
            this.TablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29993F));
            this.TablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.53497F));
            this.TablaPrincipal.Controls.Add(this.TablaInformacion, 1, 1);
            this.TablaPrincipal.Controls.Add(this.LbltituloCritico, 0, 0);
            this.TablaPrincipal.Controls.Add(this.LblTitulo, 1, 0);
            this.TablaPrincipal.Controls.Add(this.TablaCritico, 0, 1);
            this.TablaPrincipal.Controls.Add(this.TablaVencidos, 2, 1);
            this.TablaPrincipal.Controls.Add(this.TablaBotones, 1, 2);
            this.TablaPrincipal.Controls.Add(this.LblTituloVencido, 2, 0);
            this.TablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TablaPrincipal.Name = "TablaPrincipal";
            this.TablaPrincipal.RowCount = 3;
            this.TablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.792208F));
            this.TablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.TablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.48052F));
            this.TablaPrincipal.Size = new System.Drawing.Size(1330, 758);
            this.TablaPrincipal.TabIndex = 1;
            // 
            // TablaVencidos
            // 
            this.TablaVencidos.ColumnCount = 3;
            this.TablaVencidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.212121F));
            this.TablaVencidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.27273F));
            this.TablaVencidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.515152F));
            this.TablaVencidos.Controls.Add(this.DtVencido, 1, 0);
            this.TablaVencidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaVencidos.Location = new System.Drawing.Point(872, 62);
            this.TablaVencidos.Name = "TablaVencidos";
            this.TablaVencidos.RowCount = 1;
            this.TablaVencidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablaVencidos.Size = new System.Drawing.Size(455, 545);
            this.TablaVencidos.TabIndex = 1;
            // 
            // DtVencido
            // 
            this.DtVencido.AllowUserToAddRows = false;
            this.DtVencido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtVencido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtVencido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVencido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DtVencido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVencido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtVencido.EnableHeadersVisualStyles = false;
            this.DtVencido.GridColor = System.Drawing.Color.SteelBlue;
            this.DtVencido.Location = new System.Drawing.Point(8, 3);
            this.DtVencido.Name = "DtVencido";
            this.DtVencido.ReadOnly = true;
            this.DtVencido.RowHeadersVisible = false;
            this.DtVencido.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.DtVencido.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DtVencido.RowTemplate.Height = 24;
            this.DtVencido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVencido.Size = new System.Drawing.Size(436, 539);
            this.DtVencido.TabIndex = 0;
            // 
            // Reporte_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 758);
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "Reporte_stock";
            this.Text = "Reporte_stock";
            this.Load += new System.EventHandler(this.Reporte_stock_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.TablaBotones.ResumeLayout(false);
            this.TablaCritico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtcritico)).EndInit();
            this.TablaInformacion.ResumeLayout(false);
            this.TablaInformacion.PerformLayout();
            this.TablaPrincipal.ResumeLayout(false);
            this.TablaPrincipal.PerformLayout();
            this.TablaVencidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtVencido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.TableLayoutPanel TablaPrincipal;
        private System.Windows.Forms.TableLayoutPanel TablaInformacion;
        private System.Windows.Forms.Label LblCritico;
        private System.Windows.Forms.Label LblVencidos;
        private System.Windows.Forms.Label NumCritico;
        private System.Windows.Forms.Label NumVencidos;
        private System.Windows.Forms.Label NumDisponible;
        private System.Windows.Forms.Label LblDisponible;
        private System.Windows.Forms.Label LbltituloCritico;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TablaCritico;
        private System.Windows.Forms.DataGridView Dtcritico;
        private System.Windows.Forms.TableLayoutPanel TablaVencidos;
        private System.Windows.Forms.DataGridView DtVencido;
        private System.Windows.Forms.TableLayoutPanel TablaBotones;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label LblTituloVencido;
    }
}