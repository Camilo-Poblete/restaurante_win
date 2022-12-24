namespace Diseño
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.Label();
            this.BtnOlvidarContra = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.ChkMostrar = new System.Windows.Forms.CheckBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(975, 36);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelContenedor.Controls.Add(this.Error);
            this.panelContenedor.Controls.Add(this.BtnOlvidarContra);
            this.panelContenedor.Controls.Add(this.lblError);
            this.panelContenedor.Controls.Add(this.ChkMostrar);
            this.panelContenedor.Controls.Add(this.BtnAcceder);
            this.panelContenedor.Controls.Add(this.TxtContrasena);
            this.panelContenedor.Controls.Add(this.txtUsuario);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 36);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(975, 492);
            this.panelContenedor.TabIndex = 2;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Error.Location = new System.Drawing.Point(523, 312);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(29, 13);
            this.Error.TabIndex = 10;
            this.Error.Text = "Error";
            // 
            // BtnOlvidarContra
            // 
            this.BtnOlvidarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnOlvidarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOlvidarContra.FlatAppearance.BorderSize = 0;
            this.BtnOlvidarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnOlvidarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnOlvidarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOlvidarContra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnOlvidarContra.Location = new System.Drawing.Point(343, 384);
            this.BtnOlvidarContra.Name = "BtnOlvidarContra";
            this.BtnOlvidarContra.Size = new System.Drawing.Size(233, 27);
            this.BtnOlvidarContra.TabIndex = 9;
            this.BtnOlvidarContra.Text = "¿Has olvidado tu contraseña?.";
            this.BtnOlvidarContra.UseVisualStyleBackColor = false;
            this.BtnOlvidarContra.Click += new System.EventHandler(this.BtnOlvidarContra_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(424, 337);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // ChkMostrar
            // 
            this.ChkMostrar.AutoSize = true;
            this.ChkMostrar.Location = new System.Drawing.Point(588, 232);
            this.ChkMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.ChkMostrar.Name = "ChkMostrar";
            this.ChkMostrar.Size = new System.Drawing.Size(118, 17);
            this.ChkMostrar.TabIndex = 5;
            this.ChkMostrar.Text = "Mostrar Contraseña";
            this.ChkMostrar.UseVisualStyleBackColor = true;
            this.ChkMostrar.CheckedChanged += new System.EventHandler(this.ChkMostrar_CheckedChanged);
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAcceder.Location = new System.Drawing.Point(358, 288);
            this.BtnAcceder.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(160, 37);
            this.BtnAcceder.TabIndex = 4;
            this.BtnAcceder.Text = "Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.Color.Moccasin;
            this.TxtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContrasena.Location = new System.Drawing.Point(284, 231);
            this.TxtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(301, 20);
            this.TxtContrasena.TabIndex = 3;
            this.TxtContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(284, 182);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(301, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Image = global::Diseño.Properties.Resources.restaurant;
            this.pictureBox1.Location = new System.Drawing.Point(831, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::Diseño.Properties.Resources.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(920, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::Diseño.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(947, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Restaurante";
            this.BarraTitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.CheckBox ChkMostrar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button BtnOlvidarContra;
        private System.Windows.Forms.Label Error;
    }
}

