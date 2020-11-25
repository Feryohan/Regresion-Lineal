namespace DatosTemporales
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPendiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxOrdenada = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnImportar = new System.Windows.Forms.Button();
            this.txtBoxImportar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFormulaRegresionLineal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pendiente (m)";
            // 
            // txtBoxPendiente
            // 
            this.txtBoxPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPendiente.Location = new System.Drawing.Point(405, 94);
            this.txtBoxPendiente.Name = "txtBoxPendiente";
            this.txtBoxPendiente.Size = new System.Drawing.Size(152, 24);
            this.txtBoxPendiente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ordenada al origen (b)";
            // 
            // txtBoxOrdenada
            // 
            this.txtBoxOrdenada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOrdenada.Location = new System.Drawing.Point(405, 162);
            this.txtBoxOrdenada.Name = "txtBoxOrdenada";
            this.txtBoxOrdenada.Size = new System.Drawing.Size(152, 24);
            this.txtBoxOrdenada.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(405, 219);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(763, 461);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // bttnImportar
            // 
            this.bttnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnImportar.Location = new System.Drawing.Point(281, 71);
            this.bttnImportar.Name = "bttnImportar";
            this.bttnImportar.Size = new System.Drawing.Size(91, 35);
            this.bttnImportar.TabIndex = 4;
            this.bttnImportar.Text = "Importar";
            this.bttnImportar.UseVisualStyleBackColor = true;
            this.bttnImportar.Click += new System.EventHandler(this.bttnImportar_Click);
            // 
            // txtBoxImportar
            // 
            this.txtBoxImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxImportar.Location = new System.Drawing.Point(26, 76);
            this.txtBoxImportar.Name = "txtBoxImportar";
            this.txtBoxImportar.Size = new System.Drawing.Size(223, 24);
            this.txtBoxImportar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Regresión Lineal";
            // 
            // labelFormulaRegresionLineal
            // 
            this.labelFormulaRegresionLineal.AutoSize = true;
            this.labelFormulaRegresionLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormulaRegresionLineal.Location = new System.Drawing.Point(576, 120);
            this.labelFormulaRegresionLineal.Name = "labelFormulaRegresionLineal";
            this.labelFormulaRegresionLineal.Size = new System.Drawing.Size(113, 31);
            this.labelFormulaRegresionLineal.TabIndex = 7;
            this.labelFormulaRegresionLineal.Text = "Formula";
            this.labelFormulaRegresionLineal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 692);
            this.Controls.Add(this.labelFormulaRegresionLineal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxImportar);
            this.Controls.Add(this.bttnImportar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtBoxOrdenada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPendiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPendiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxOrdenada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bttnImportar;
        private System.Windows.Forms.TextBox txtBoxImportar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFormulaRegresionLineal;
    }
}

