namespace Estructura_de_datos_Tipo_Lista_Practica_14_4_2024
{
    partial class FrmDatos
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
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.tslAcercade = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tsmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(126, 96);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(188, 182);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(139, 22);
            this.txtEdad.TabIndex = 4;
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Items.AddRange(new object[] {
            "",
            "Labrador",
            "Pastor Aleman",
            "Dowerman",
            "Chau Chau"});
            this.cmbRaza.Location = new System.Drawing.Point(188, 140);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(139, 24);
            this.cmbRaza.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(48, 224);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(658, 150);
            this.dgvDatos.TabIndex = 6;
            // 
            // tsmMenu
            // 
            this.tsmMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistar,
            this.tslConsultar,
            this.tslEliminar,
            this.tslSalir,
            this.tslAcercade});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(800, 31);
            this.tsmMenu.TabIndex = 8;
            this.tsmMenu.Text = "toolStrip2";
            // 
            // tslRegistar
            // 
            this.tslRegistar.Name = "tslRegistar";
            this.tslRegistar.Size = new System.Drawing.Size(68, 28);
            this.tslRegistar.Text = "Registrar";
            // 
            // tslConsultar
            // 
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(71, 28);
            this.tslConsultar.Text = "Consultar";
            // 
            // tslEliminar
            // 
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(63, 28);
            this.tslEliminar.Text = "Eliminar";
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(38, 28);
            this.tslSalir.Text = "Salir";
            // 
            // tslAcercade
            // 
            this.tslAcercade.Name = "tslAcercade";
            this.tslAcercade.Size = new System.Drawing.Size(84, 28);
            this.tslAcercade.Text = "Acerca de...";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "FrmDatos";
            this.Text = "Lista de mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslRegistar;
        private System.Windows.Forms.ToolStripLabel tslConsultar;
        private System.Windows.Forms.ToolStripLabel tslEliminar;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripLabel tslAcercade;
    }
}

