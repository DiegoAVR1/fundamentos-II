namespace Prueba_datagrid_20_3_2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            lblcodigo = new Label();
            lblnombre = new Label();
            lblprecio = new Label();
            txtnombre = new TextBox();
            txtcodigo = new TextBox();
            txtprecio = new TextBox();
            lblinformacion = new Label();
            btnadiccionar = new Button();
            btnborrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio });
            dgv.Location = new Point(12, 204);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(769, 172);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo del Producto";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre del Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio del Producto";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(45, 31);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(58, 20);
            lblcodigo.TabIndex = 1;
            lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(45, 69);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(64, 20);
            lblnombre.TabIndex = 2;
            lblnombre.Text = "Nombre";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(45, 111);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(50, 20);
            lblprecio.TabIndex = 3;
            lblprecio.Text = "Precio";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(115, 66);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(174, 27);
            txtnombre.TabIndex = 4;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(115, 24);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(174, 27);
            txtcodigo.TabIndex = 5;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(115, 108);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(174, 27);
            txtprecio.TabIndex = 6;
            // 
            // lblinformacion
            // 
            lblinformacion.AutoSize = true;
            lblinformacion.Location = new Point(143, 165);
            lblinformacion.Name = "lblinformacion";
            lblinformacion.Size = new Size(50, 20);
            lblinformacion.TabIndex = 7;
            lblinformacion.Text = "label1";
            // 
            // btnadiccionar
            // 
            btnadiccionar.Location = new Point(295, 41);
            btnadiccionar.Name = "btnadiccionar";
            btnadiccionar.Size = new Size(111, 26);
            btnadiccionar.TabIndex = 8;
            btnadiccionar.Text = "Adiccionar";
            btnadiccionar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(295, 84);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(111, 26);
            btnborrar.TabIndex = 9;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnborrar);
            Controls.Add(btnadiccionar);
            Controls.Add(lblinformacion);
            Controls.Add(txtprecio);
            Controls.Add(txtcodigo);
            Controls.Add(txtnombre);
            Controls.Add(lblprecio);
            Controls.Add(lblnombre);
            Controls.Add(lblcodigo);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Label lblcodigo;
        private Label lblnombre;
        private Label lblprecio;
        private TextBox txtnombre;
        private TextBox txtcodigo;
        private TextBox txtprecio;
        private Label lblinformacion;
        private Button btnadiccionar;
        private Button btnborrar;
    }
}
