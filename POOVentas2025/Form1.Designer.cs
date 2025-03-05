namespace POOVentas2025
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
            lblCliente = new Label();
            lblLimonadaLimon = new Label();
            lblLimonadaFresa = new Label();
            lblUvola = new Label();
            TxtCliente = new TextBox();
            txtLimonadaLimon = new TextBox();
            txtLimonadaFresa = new TextBox();
            txtUvola = new TextBox();
            txtPrecioLimonadaLimon = new TextBox();
            txtPrecioLimonadaFresa = new TextBox();
            txtPrecioUvola = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            rbtnContado = new RadioButton();
            rbtnCredito = new RadioButton();
            btnAgregar = new Button();
            btnRestaurar = new Button();
            DgvLimonada = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Limon = new DataGridViewTextBoxColumn();
            Fresa = new DataGridViewTextBoxColumn();
            Uvola = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvLimonada).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(41, 18);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            lblCliente.Click += lblCliente_Click;
            // 
            // lblLimonadaLimon
            // 
            lblLimonadaLimon.AutoSize = true;
            lblLimonadaLimon.Location = new Point(413, 21);
            lblLimonadaLimon.Name = "lblLimonadaLimon";
            lblLimonadaLimon.Size = new Size(113, 15);
            lblLimonadaLimon.TabIndex = 1;
            lblLimonadaLimon.Text = "Limonada de Limon";
            // 
            // lblLimonadaFresa
            // 
            lblLimonadaFresa.AutoSize = true;
            lblLimonadaFresa.Location = new Point(413, 65);
            lblLimonadaFresa.Name = "lblLimonadaFresa";
            lblLimonadaFresa.Size = new Size(106, 15);
            lblLimonadaFresa.TabIndex = 2;
            lblLimonadaFresa.Text = "Limonada de Fresa";
            // 
            // lblUvola
            // 
            lblUvola.AutoSize = true;
            lblUvola.Location = new Point(413, 109);
            lblUvola.Name = "lblUvola";
            lblUvola.Size = new Size(37, 15);
            lblUvola.TabIndex = 3;
            lblUvola.Text = "Uvola";
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(91, 13);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(316, 23);
            TxtCliente.TabIndex = 4;
            // 
            // txtLimonadaLimon
            // 
            txtLimonadaLimon.Location = new Point(541, 18);
            txtLimonadaLimon.Name = "txtLimonadaLimon";
            txtLimonadaLimon.Size = new Size(100, 23);
            txtLimonadaLimon.TabIndex = 5;
            txtLimonadaLimon.Text = "0";
            txtLimonadaLimon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLimonadaFresa
            // 
            txtLimonadaFresa.Location = new Point(541, 57);
            txtLimonadaFresa.Name = "txtLimonadaFresa";
            txtLimonadaFresa.Size = new Size(100, 23);
            txtLimonadaFresa.TabIndex = 6;
            txtLimonadaFresa.Text = "0";
            txtLimonadaFresa.TextAlign = HorizontalAlignment.Center;
            txtLimonadaFresa.TextChanged += textBox1_TextChanged;
            // 
            // txtUvola
            // 
            txtUvola.Location = new Point(541, 99);
            txtUvola.Name = "txtUvola";
            txtUvola.Size = new Size(100, 23);
            txtUvola.TabIndex = 7;
            txtUvola.Text = "0";
            txtUvola.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecioLimonadaLimon
            // 
            txtPrecioLimonadaLimon.Location = new Point(669, 18);
            txtPrecioLimonadaLimon.Name = "txtPrecioLimonadaLimon";
            txtPrecioLimonadaLimon.Size = new Size(100, 23);
            txtPrecioLimonadaLimon.TabIndex = 8;
            txtPrecioLimonadaLimon.Text = "0.00";
            txtPrecioLimonadaLimon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecioLimonadaFresa
            // 
            txtPrecioLimonadaFresa.Location = new Point(669, 57);
            txtPrecioLimonadaFresa.Name = "txtPrecioLimonadaFresa";
            txtPrecioLimonadaFresa.Size = new Size(100, 23);
            txtPrecioLimonadaFresa.TabIndex = 9;
            txtPrecioLimonadaFresa.Text = "0.00";
            txtPrecioLimonadaFresa.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrecioUvola
            // 
            txtPrecioUvola.Location = new Point(669, 99);
            txtPrecioUvola.Name = "txtPrecioUvola";
            txtPrecioUvola.Size = new Size(100, 23);
            txtPrecioUvola.TabIndex = 10;
            txtPrecioUvola.Text = "0.00";
            txtPrecioUvola.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(489, 154);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total";
            lblTotal.Click += label1_Click_1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(541, 151);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 12;
            // 
            // rbtnContado
            // 
            rbtnContado.AutoSize = true;
            rbtnContado.Location = new Point(140, 73);
            rbtnContado.Name = "rbtnContado";
            rbtnContado.Size = new Size(71, 19);
            rbtnContado.TabIndex = 13;
            rbtnContado.TabStop = true;
            rbtnContado.Text = "Contado";
            rbtnContado.UseVisualStyleBackColor = true;
            // 
            // rbtnCredito
            // 
            rbtnCredito.AutoSize = true;
            rbtnCredito.Location = new Point(140, 103);
            rbtnCredito.Name = "rbtnCredito";
            rbtnCredito.Size = new Size(64, 19);
            rbtnCredito.TabIndex = 14;
            rbtnCredito.TabStop = true;
            rbtnCredito.Text = "Credito";
            rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(239, 73);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(239, 109);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(100, 23);
            btnRestaurar.TabIndex = 16;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // DgvLimonada
            // 
            DgvLimonada.AllowUserToOrderColumns = true;
            DgvLimonada.BackgroundColor = SystemColors.GradientInactiveCaption;
            DgvLimonada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLimonada.Columns.AddRange(new DataGridViewColumn[] { Cliente, Limon, Fresa, Uvola, Total, TipoPago });
            DgvLimonada.Location = new Point(41, 216);
            DgvLimonada.Name = "DgvLimonada";
            DgvLimonada.Size = new Size(641, 275);
            DgvLimonada.TabIndex = 17;
            DgvLimonada.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Limon
            // 
            Limon.HeaderText = "Limon";
            Limon.Name = "Limon";
            // 
            // Fresa
            // 
            Fresa.HeaderText = "Fresa";
            Fresa.Name = "Fresa";
            // 
            // Uvola
            // 
            Uvola.HeaderText = "Uvola";
            Uvola.Name = "Uvola";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // TipoPago
            // 
            TipoPago.HeaderText = "Tipo de pago";
            TipoPago.Name = "TipoPago";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 525);
            Controls.Add(DgvLimonada);
            Controls.Add(btnRestaurar);
            Controls.Add(btnAgregar);
            Controls.Add(rbtnCredito);
            Controls.Add(rbtnContado);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtPrecioUvola);
            Controls.Add(txtPrecioLimonadaFresa);
            Controls.Add(txtPrecioLimonadaLimon);
            Controls.Add(txtUvola);
            Controls.Add(txtLimonadaFresa);
            Controls.Add(txtLimonadaLimon);
            Controls.Add(TxtCliente);
            Controls.Add(lblUvola);
            Controls.Add(lblLimonadaFresa);
            Controls.Add(lblLimonadaLimon);
            Controls.Add(lblCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvLimonada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblLimonadaLimon;
        private Label lblLimonadaFresa;
        private Label lblUvola;
        private TextBox TxtCliente;
        private TextBox txtLimonadaLimon;
        private TextBox txtLimonadaFresa;
        private TextBox txtUvola;
        private TextBox txtPrecioLimonadaLimon;
        private TextBox txtPrecioLimonadaFresa;
        private TextBox txtPrecioUvola;
        private Label lblTotal;
        private TextBox txtTotal;
        private RadioButton rbtnContado;
        private RadioButton rbtnCredito;
        private Button btnAgregar;
        private Button btnRestaurar;
        private DataGridView DgvLimonada;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Limon;
        private DataGridViewTextBoxColumn Fresa;
        private DataGridViewTextBoxColumn Uvola;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn TipoPago;
    }
}
