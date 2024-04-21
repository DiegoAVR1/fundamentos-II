namespace Tabla_de_Amortizacion_practica__2023_1828
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtmontoprestamo = new TextBox();
            txtpagocuotas = new TextBox();
            txtinteresmensual = new TextBox();
            txttiempo = new TextBox();
            txtinteresanual = new TextBox();
            dtfecha = new DateTimePicker();
            btmcalcular = new Button();
            btmlimpiar = new Button();
            dataGridView1 = new DataGridView();
            numerocuota = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            cuota = new DataGridViewTextBoxColumn();
            intereses = new DataGridViewTextBoxColumn();
            montoinicial = new DataGridViewTextBoxColumn();
            montofinal = new DataGridViewTextBoxColumn();
            abonocapital = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Monto del Prestamo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 1;
            label2.Text = "Tasa de Interes Anual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo (Meses):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 3;
            label4.Text = "Tasa de Interes Mensual:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 166);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Pago Cuotas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 205);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha:";
            // 
            // txtmontoprestamo
            // 
            txtmontoprestamo.Location = new Point(182, 19);
            txtmontoprestamo.Name = "txtmontoprestamo";
            txtmontoprestamo.Size = new Size(305, 27);
            txtmontoprestamo.TabIndex = 6;
            // 
            // txtpagocuotas
            // 
            txtpagocuotas.Location = new Point(182, 166);
            txtpagocuotas.Name = "txtpagocuotas";
            txtpagocuotas.ReadOnly = true;
            txtpagocuotas.Size = new Size(305, 27);
            txtpagocuotas.TabIndex = 11;
            txtpagocuotas.TextChanged += txtpagocuotas_TextChanged;
            // 
            // txtinteresmensual
            // 
            txtinteresmensual.Location = new Point(182, 131);
            txtinteresmensual.Name = "txtinteresmensual";
            txtinteresmensual.ReadOnly = true;
            txtinteresmensual.Size = new Size(305, 27);
            txtinteresmensual.TabIndex = 12;
            // 
            // txttiempo
            // 
            txttiempo.Location = new Point(182, 95);
            txttiempo.Name = "txttiempo";
            txttiempo.Size = new Size(305, 27);
            txttiempo.TabIndex = 13;
            // 
            // txtinteresanual
            // 
            txtinteresanual.Location = new Point(182, 59);
            txtinteresanual.Name = "txtinteresanual";
            txtinteresanual.Size = new Size(305, 27);
            txtinteresanual.TabIndex = 14;
            // 
            // dtfecha
            // 
            dtfecha.Location = new Point(184, 198);
            dtfecha.Name = "dtfecha";
            dtfecha.Size = new Size(303, 27);
            dtfecha.TabIndex = 15;
            // 
            // btmcalcular
            // 
            btmcalcular.Location = new Point(493, 17);
            btmcalcular.Name = "btmcalcular";
            btmcalcular.Size = new Size(91, 29);
            btmcalcular.TabIndex = 16;
            btmcalcular.Text = "Calcular";
            btmcalcular.UseVisualStyleBackColor = true;
            btmcalcular.Click += btmcalcular_Click;
            // 
            // btmlimpiar
            // 
            btmlimpiar.Location = new Point(590, 18);
            btmlimpiar.Name = "btmlimpiar";
            btmlimpiar.Size = new Size(91, 29);
            btmlimpiar.TabIndex = 17;
            btmlimpiar.Text = "Limpiar";
            btmlimpiar.UseVisualStyleBackColor = true;
            btmlimpiar.Click += btmlimpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numerocuota, fecha, cuota, intereses, montoinicial, montofinal, abonocapital });
            dataGridView1.Location = new Point(12, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 217);
            dataGridView1.TabIndex = 18;
            // 
            // numerocuota
            // 
            numerocuota.HeaderText = "Numero Cuota";
            numerocuota.MinimumWidth = 6;
            numerocuota.Name = "numerocuota";
            numerocuota.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // cuota
            // 
            cuota.HeaderText = "Cuota";
            cuota.MinimumWidth = 6;
            cuota.Name = "cuota";
            cuota.Width = 125;
            // 
            // intereses
            // 
            intereses.HeaderText = "Intereses";
            intereses.MinimumWidth = 6;
            intereses.Name = "intereses";
            intereses.Width = 125;
            // 
            // montoinicial
            // 
            montoinicial.HeaderText = "Monto Inicial";
            montoinicial.MinimumWidth = 6;
            montoinicial.Name = "montoinicial";
            montoinicial.Width = 125;
            // 
            // montofinal
            // 
            montofinal.HeaderText = "Monto Final";
            montofinal.MinimumWidth = 6;
            montofinal.Name = "montofinal";
            montofinal.Width = 125;
            // 
            // abonocapital
            // 
            abonocapital.HeaderText = "Abono Capital";
            abonocapital.MinimumWidth = 6;
            abonocapital.Name = "abonocapital";
            abonocapital.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btmlimpiar);
            Controls.Add(btmcalcular);
            Controls.Add(dtfecha);
            Controls.Add(txtinteresanual);
            Controls.Add(txttiempo);
            Controls.Add(txtinteresmensual);
            Controls.Add(txtpagocuotas);
            Controls.Add(txtmontoprestamo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmontoprestamo;
        private TextBox txtpagocuotas;
        private TextBox txtinteresmensual;
        private TextBox txttiempo;
        private TextBox txtinteresanual;
        private DateTimePicker dtfecha;
        private Button btmcalcular;
        private Button btmlimpiar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numerocuota;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn cuota;
        private DataGridViewTextBoxColumn intereses;
        private DataGridViewTextBoxColumn montoinicial;
        private DataGridViewTextBoxColumn montofinal;
        private DataGridViewTextBoxColumn abonocapital;
    }
}
