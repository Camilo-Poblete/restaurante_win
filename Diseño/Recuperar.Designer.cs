namespace Diseño
{
    partial class Recuperar
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
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlRecuperar = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnEnviar_Clave = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblRecuperar = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlRecuperar.SuspendLayout();
            this.panelContenedor.SuspendLayout();
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
            // PnlRecuperar
            // 
            this.PnlRecuperar.Controls.Add(this.BtnVolver);
            this.PnlRecuperar.Controls.Add(this.BtnEnviar_Clave);
            this.PnlRecuperar.Controls.Add(this.TxtCorreo);
            this.PnlRecuperar.Controls.Add(this.LblRecuperar);
            this.PnlRecuperar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlRecuperar.Location = new System.Drawing.Point(0, 0);
            this.PnlRecuperar.Name = "PnlRecuperar";
            this.PnlRecuperar.Size = new System.Drawing.Size(833, 492);
            this.PnlRecuperar.TabIndex = 8;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(394, 256);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(136, 37);
            this.BtnVolver.TabIndex = 5;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnEnviar_Clave
            // 
            this.BtnEnviar_Clave.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnEnviar_Clave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnviar_Clave.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar_Clave.Location = new System.Drawing.Point(394, 165);
            this.BtnEnviar_Clave.Name = "BtnEnviar_Clave";
            this.BtnEnviar_Clave.Size = new System.Drawing.Size(136, 37);
            this.BtnEnviar_Clave.TabIndex = 4;
            this.BtnEnviar_Clave.Text = "Enviar";
            this.BtnEnviar_Clave.UseVisualStyleBackColor = false;
            this.BtnEnviar_Clave.Click += new System.EventHandler(this.BtnEnviar_Clave_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.Moccasin;
            this.TxtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCorreo.Location = new System.Drawing.Point(318, 102);
            this.TxtCorreo.Multiline = true;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(302, 24);
            this.TxtCorreo.TabIndex = 3;
            this.TxtCorreo.Text = "Ingrese su correo.";
            // 
            // LblRecuperar
            // 
            this.LblRecuperar.AutoSize = true;
            this.LblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecuperar.ForeColor = System.Drawing.Color.Black;
            this.LblRecuperar.Location = new System.Drawing.Point(290, 29);
            this.LblRecuperar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRecuperar.Name = "LblRecuperar";
            this.LblRecuperar.Size = new System.Drawing.Size(330, 31);
            this.LblRecuperar.TabIndex = 2;
            this.LblRecuperar.Text = "Recuperacion Contraseña";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelContenedor.Controls.Add(this.PnlRecuperar);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 36);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(975, 492);
            this.panelContenedor.TabIndex = 2;
            // 
            // Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(975, 528);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Recuperar";
            this.Text = "Restaurante";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlRecuperar.ResumeLayout(false);
            this.PnlRecuperar.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlRecuperar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnEnviar_Clave;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LblRecuperar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

