namespace pry_Godoy_AppRegistroVentasHardware
{
    partial class frmRegistro
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
            lblproducto = new Label();
            lblFecha = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            dtpFecha = new DateTimePicker();
            lstProductos = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cmdRegistrar = new Button();
            cmdCancelar = new Button();
            SuspendLayout();
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.Location = new Point(121, 96);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(56, 15);
            lblproducto.TabIndex = 0;
            lblproducto.Text = "Producto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(121, 65);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(121, 127);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(121, 158);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(84, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio unitario";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(258, 63);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 23);
            dtpFecha.TabIndex = 4;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(258, 91);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(121, 23);
            lstProductos.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 7;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(379, 210);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(75, 23);
            cmdRegistrar.TabIndex = 8;
            cmdRegistrar.Text = "Aceptar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(258, 210);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 9;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 267);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdRegistrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lstProductos);
            Controls.Add(dtpFecha);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblFecha);
            Controls.Add(lblproducto);
            Name = "frmRegistro";
            Text = "Registro ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblproducto;
        private Label lblFecha;
        private Label lblCantidad;
        private Label lblPrecio;
        private DateTimePicker dtpFecha;
        private ComboBox lstProductos;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button cmdRegistrar;
        private Button cmdCancelar;
    }
}