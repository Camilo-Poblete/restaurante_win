namespace Diseño
{
    partial class Inicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TablaGraficos = new System.Windows.Forms.TableLayoutPanel();
            this.ChartMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblTituloTotal = new System.Windows.Forms.Label();
            this.LblTituloVentasDia = new System.Windows.Forms.Label();
            this.LblVentasDia = new System.Windows.Forms.Label();
            this.LblTotalDia = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TablaGraficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(303, 83);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(105, 29);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "FECHA:";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMACION IMPORTANTE DEL DIA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaGraficos
            // 
            this.TablaGraficos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TablaGraficos.ColumnCount = 2;
            this.TablaGraficos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.90379F));
            this.TablaGraficos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.09621F));
            this.TablaGraficos.Controls.Add(this.ChartMasVendidos, 0, 1);
            this.TablaGraficos.Controls.Add(this.ChartStock, 1, 1);
            this.TablaGraficos.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TablaGraficos.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TablaGraficos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaGraficos.Location = new System.Drawing.Point(0, 0);
            this.TablaGraficos.Name = "TablaGraficos";
            this.TablaGraficos.RowCount = 2;
            this.TablaGraficos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.63935F));
            this.TablaGraficos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.36066F));
            this.TablaGraficos.Size = new System.Drawing.Size(1564, 793);
            this.TablaGraficos.TabIndex = 3;
            // 
            // ChartMasVendidos
            // 
            this.ChartMasVendidos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChartMasVendidos.BackSecondaryColor = System.Drawing.Color.DarkSlateGray;
            this.ChartMasVendidos.BorderlineColor = System.Drawing.Color.DarkSlateGray;
            this.ChartMasVendidos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.ChartMasVendidos.ChartAreas.Add(chartArea1);
            this.ChartMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.AutoFitMinFontSize = 9;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.ChartMasVendidos.Legends.Add(legend1);
            this.ChartMasVendidos.Location = new System.Drawing.Point(4, 215);
            this.ChartMasVendidos.Name = "ChartMasVendidos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartMasVendidos.Series.Add(series1);
            this.ChartMasVendidos.Size = new System.Drawing.Size(772, 574);
            this.ChartMasVendidos.TabIndex = 0;
            this.ChartMasVendidos.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "PLATOS MAS VENDIDOS DE HOY.";
            this.ChartMasVendidos.Titles.Add(title1);
            this.ChartMasVendidos.Click += new System.EventHandler(this.ChartMasVendidos_Click_1);
            // 
            // ChartStock
            // 
            this.ChartStock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChartStock.BackSecondaryColor = System.Drawing.Color.DarkSlateGray;
            this.ChartStock.BorderlineColor = System.Drawing.Color.DarkSlateGray;
            this.ChartStock.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorTickMark.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            chartArea2.Name = "ChartArea1";
            this.ChartStock.ChartAreas.Add(chartArea2);
            this.ChartStock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.AutoFitMinFontSize = 9;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.ChartStock.Legends.Add(legend2);
            this.ChartStock.Location = new System.Drawing.Point(783, 215);
            this.ChartStock.Name = "ChartStock";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.ChartStock.Series.Add(series2);
            this.ChartStock.Size = new System.Drawing.Size(777, 574);
            this.ChartStock.TabIndex = 0;
            this.ChartStock.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "STOCK ACTUAL";
            this.ChartStock.Titles.Add(title2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4898F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5102F));
            this.tableLayoutPanel1.Controls.Add(this.LblTituloTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTituloVentasDia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblVentasDia, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalDia, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(783, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 204);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblTituloTotal
            // 
            this.LblTituloTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloTotal.AutoSize = true;
            this.LblTituloTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloTotal.ForeColor = System.Drawing.Color.White;
            this.LblTituloTotal.Location = new System.Drawing.Point(3, 73);
            this.LblTituloTotal.Name = "LblTituloTotal";
            this.LblTituloTotal.Size = new System.Drawing.Size(378, 29);
            this.LblTituloTotal.TabIndex = 0;
            this.LblTituloTotal.Text = "TOTAL RECAUDADO HOY:";
            this.LblTituloTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTituloVentasDia
            // 
            this.LblTituloVentasDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloVentasDia.AutoSize = true;
            this.LblTituloVentasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentasDia.ForeColor = System.Drawing.Color.White;
            this.LblTituloVentasDia.Location = new System.Drawing.Point(387, 73);
            this.LblTituloVentasDia.Name = "LblTituloVentasDia";
            this.LblTituloVentasDia.Size = new System.Drawing.Size(387, 29);
            this.LblTituloVentasDia.TabIndex = 0;
            this.LblTituloVentasDia.Text = "TOTAL VENTAS HOY:";
            this.LblTituloVentasDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVentasDia
            // 
            this.LblVentasDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblVentasDia.AutoSize = true;
            this.LblVentasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVentasDia.ForeColor = System.Drawing.Color.White;
            this.LblVentasDia.Location = new System.Drawing.Point(387, 102);
            this.LblVentasDia.Name = "LblVentasDia";
            this.LblVentasDia.Size = new System.Drawing.Size(387, 102);
            this.LblVentasDia.TabIndex = 0;
            this.LblVentasDia.Text = "0";
            this.LblVentasDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalDia
            // 
            this.LblTotalDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalDia.AutoSize = true;
            this.LblTotalDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDia.ForeColor = System.Drawing.Color.White;
            this.LblTotalDia.Location = new System.Drawing.Point(3, 102);
            this.LblTotalDia.Name = "LblTotalDia";
            this.LblTotalDia.Size = new System.Drawing.Size(378, 102);
            this.LblTotalDia.TabIndex = 0;
            this.LblTotalDia.Text = "$";
            this.LblTotalDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 204);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 102);
            this.label2.TabIndex = 0;
            this.label2.Text = "FECHA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(766, 102);
            this.label3.TabIndex = 0;
            this.label3.Text = "INFORMACION IMPORTANTE DEL DIA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1564, 793);
            this.Controls.Add(this.TablaGraficos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.TablaGraficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TablaGraficos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblTituloTotal;
        private System.Windows.Forms.Label LblTituloVentasDia;
        private System.Windows.Forms.Label LblVentasDia;
        private System.Windows.Forms.Label LblTotalDia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}