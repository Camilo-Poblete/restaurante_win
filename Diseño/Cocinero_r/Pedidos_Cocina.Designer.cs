
namespace Diseño.Cocinero_r
{
    partial class Pedidos_Cocina
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
            this.PnlSuperior = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlMenu = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PnlGrid = new System.Windows.Forms.TableLayoutPanel();
            this.DtPedidos = new System.Windows.Forms.DataGridView();
            this.PnlSuperior.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.ColumnCount = 3;
            this.PnlSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.Controls.Add(this.label1, 1, 0);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.RowCount = 3;
            this.PnlSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlSuperior.Size = new System.Drawing.Size(1260, 161);
            this.PnlSuperior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos Activos";
            // 
            // PnlMenu
            // 
            this.PnlMenu.ColumnCount = 3;
            this.PnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PnlMenu.Controls.Add(this.BtnTerminar, 1, 0);
            this.PnlMenu.Controls.Add(this.BtnVolver, 0, 0);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMenu.Location = new System.Drawing.Point(867, 161);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.RowCount = 4;
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlMenu.Size = new System.Drawing.Size(393, 584);
            this.PnlMenu.TabIndex = 2;
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnTerminar.ForeColor = System.Drawing.Color.White;
            this.BtnTerminar.Location = new System.Drawing.Point(134, 3);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(125, 35);
            this.BtnTerminar.TabIndex = 12;
            this.BtnTerminar.Text = "TERMINAR";
            this.BtnTerminar.UseVisualStyleBackColor = false;
            this.BtnTerminar.Visible = false;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click_1);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(3, 3);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(125, 35);
            this.BtnVolver.TabIndex = 1;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Visible = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click_1);
            // 
            // PnlGrid
            // 
            this.PnlGrid.ColumnCount = 3;
            this.PnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.PnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.PnlGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.PnlGrid.Controls.Add(this.DtPedidos, 1, 0);
            this.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGrid.Location = new System.Drawing.Point(0, 161);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.RowCount = 1;
            this.PnlGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlGrid.Size = new System.Drawing.Size(867, 584);
            this.PnlGrid.TabIndex = 3;
            // 
            // DtPedidos
            // 
            this.DtPedidos.AllowUserToAddRows = false;
            this.DtPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtPedidos.EnableHeadersVisualStyles = false;
            this.DtPedidos.Location = new System.Drawing.Point(11, 3);
            this.DtPedidos.Name = "DtPedidos";
            this.DtPedidos.ReadOnly = true;
            this.DtPedidos.RowHeadersVisible = false;
            this.DtPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DtPedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtPedidos.RowTemplate.Height = 24;
            this.DtPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtPedidos.Size = new System.Drawing.Size(843, 578);
            this.DtPedidos.TabIndex = 0;
            this.DtPedidos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtPedidos_CellMouseDoubleClick);
            // 
            // Pedidos_Cocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1260, 745);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pedidos_Cocina";
            this.Text = "Pedidos_Cocina";
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.PnlMenu.ResumeLayout(false);
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel PnlMenu;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TableLayoutPanel PnlGrid;
        private System.Windows.Forms.DataGridView DtPedidos;
    }
}