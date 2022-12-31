
namespace Diseño
{
    partial class Ajuste_usuario
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
            this.DtListaEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DtListaEmpleados
            // 
            this.DtListaEmpleados.AllowUserToAddRows = false;
            this.DtListaEmpleados.AllowUserToDeleteRows = false;
            this.DtListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DtListaEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtListaEmpleados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DtListaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtListaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtListaEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtListaEmpleados.EnableHeadersVisualStyles = false;
            this.DtListaEmpleados.GridColor = System.Drawing.Color.SteelBlue;
            this.DtListaEmpleados.Location = new System.Drawing.Point(0, 0);
            this.DtListaEmpleados.Name = "DtListaEmpleados";
            this.DtListaEmpleados.ReadOnly = true;
            this.DtListaEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtListaEmpleados.RowHeadersVisible = false;
            this.DtListaEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DtListaEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtListaEmpleados.RowTemplate.Height = 24;
            this.DtListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtListaEmpleados.ShowCellToolTips = false;
            this.DtListaEmpleados.ShowEditingIcon = false;
            this.DtListaEmpleados.Size = new System.Drawing.Size(1505, 756);
            this.DtListaEmpleados.TabIndex = 3;
            // 
            // Ajuste_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1505, 756);
            this.Controls.Add(this.DtListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ajuste_usuario";
            this.Text = "Ajuste_usuario";
            this.Load += new System.EventHandler(this.Ajuste_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtListaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtListaEmpleados;
    }
}