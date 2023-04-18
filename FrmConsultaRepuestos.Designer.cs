namespace pryPonssaRepuestos._2
{
    partial class FrmConsultaRepuestos
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
            this.lstMarca2 = new System.Windows.Forms.ComboBox();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.optImportado2 = new System.Windows.Forms.RadioButton();
            this.optNacional2 = new System.Windows.Forms.RadioButton();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optAmbos = new System.Windows.Forms.RadioButton();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMarca2
            // 
            this.lstMarca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarca2.FormattingEnabled = true;
            this.lstMarca2.Items.AddRange(new object[] {
            "Marca A",
            "Marca B",
            "Marca C"});
            this.lstMarca2.Location = new System.Drawing.Point(113, 23);
            this.lstMarca2.Name = "lstMarca2";
            this.lstMarca2.Size = new System.Drawing.Size(251, 28);
            this.lstMarca2.TabIndex = 9;
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(22, 26);
            this.lblMarca2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(53, 20);
            this.lblMarca2.TabIndex = 8;
            this.lblMarca2.Text = "Marca";
            // 
            // optImportado2
            // 
            this.optImportado2.AutoSize = true;
            this.optImportado2.Location = new System.Drawing.Point(129, 36);
            this.optImportado2.Name = "optImportado2";
            this.optImportado2.Size = new System.Drawing.Size(107, 24);
            this.optImportado2.TabIndex = 13;
            this.optImportado2.Text = "Importado";
            this.optImportado2.UseVisualStyleBackColor = true;
            // 
            // optNacional2
            // 
            this.optNacional2.AutoSize = true;
            this.optNacional2.Checked = true;
            this.optNacional2.Location = new System.Drawing.Point(15, 34);
            this.optNacional2.Name = "optNacional2";
            this.optNacional2.Size = new System.Drawing.Size(95, 24);
            this.optNacional2.TabIndex = 12;
            this.optNacional2.TabStop = true;
            this.optNacional2.Text = "Nacional";
            this.optNacional2.UseVisualStyleBackColor = true;
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optAmbos);
            this.mrcOrigen.Controls.Add(this.optImportado2);
            this.mrcOrigen.Controls.Add(this.optNacional2);
            this.mrcOrigen.Location = new System.Drawing.Point(26, 71);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(354, 82);
            this.mrcOrigen.TabIndex = 14;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optAmbos
            // 
            this.optAmbos.AutoSize = true;
            this.optAmbos.Location = new System.Drawing.Point(254, 36);
            this.optAmbos.Name = "optAmbos";
            this.optAmbos.Size = new System.Drawing.Size(84, 24);
            this.optAmbos.TabIndex = 14;
            this.optAmbos.TabStop = true;
            this.optAmbos.Text = "Ambos";
            this.optAmbos.UseVisualStyleBackColor = true;
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.Location = new System.Drawing.Point(594, 23);
            this.btnConsultar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(117, 55);
            this.btnConsultar2.TabIndex = 18;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = true;
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(594, 98);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(117, 55);
            this.btnSalir2.TabIndex = 17;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Código,
            this.Marca,
            this.Origen,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(26, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(750, 469);
            this.dataGridView1.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 150;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 8;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Código.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Marca.Width = 150;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.MinimumWidth = 8;
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Origen.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Precio.Width = 150;
            // 
            // FrmConsultaRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsultar2);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.lstMarca2);
            this.Controls.Add(this.lblMarca2);
            this.Name = "FrmConsultaRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaRepuestos";
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstMarca2;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.RadioButton optImportado2;
        private System.Windows.Forms.RadioButton optNacional2;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optAmbos;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}