namespace Producto
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
            lbnombre = new Label();
            txtnombre = new TextBox();
            lbmarca = new Label();
            txtmarca = new TextBox();
            txtprecio = new TextBox();
            lbprecio = new Label();
            txtunidades = new TextBox();
            lbunidades = new Label();
            dgv = new DataGridView();
            btnagregar = new Button();
            btneliminar = new Button();
            lbproductos = new Label();
            pictureBox1 = new PictureBox();
            btnsalir = new Button();
            btnmostrar = new Button();
            btnbuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Georgia", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnombre.Location = new Point(39, 29);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(74, 18);
            lbnombre.TabIndex = 0;
            lbnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Georgia", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(12, 50);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(123, 26);
            txtnombre.TabIndex = 1;
            // 
            // lbmarca
            // 
            lbmarca.AutoSize = true;
            lbmarca.Font = new Font("Georgia", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbmarca.Location = new Point(48, 95);
            lbmarca.Name = "lbmarca";
            lbmarca.Size = new Size(60, 18);
            lbmarca.TabIndex = 2;
            lbmarca.Text = "Marca";
            // 
            // txtmarca
            // 
            txtmarca.Font = new Font("Georgia", 10.0173912F);
            txtmarca.Location = new Point(12, 116);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(123, 26);
            txtmarca.TabIndex = 3;
            // 
            // txtprecio
            // 
            txtprecio.Font = new Font("Georgia", 10.0173912F);
            txtprecio.Location = new Point(12, 182);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(123, 26);
            txtprecio.TabIndex = 4;
            // 
            // lbprecio
            // 
            lbprecio.AutoSize = true;
            lbprecio.Font = new Font("Georgia", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbprecio.Location = new Point(48, 161);
            lbprecio.Name = "lbprecio";
            lbprecio.Size = new Size(61, 18);
            lbprecio.TabIndex = 5;
            lbprecio.Text = "Precio";
            // 
            // txtunidades
            // 
            txtunidades.Font = new Font("Georgia", 10.0173912F);
            txtunidades.Location = new Point(12, 254);
            txtunidades.Name = "txtunidades";
            txtunidades.Size = new Size(123, 26);
            txtunidades.TabIndex = 6;
            // 
            // lbunidades
            // 
            lbunidades.AutoSize = true;
            lbunidades.Font = new Font("Georgia", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbunidades.Location = new Point(26, 233);
            lbunidades.Name = "lbunidades";
            lbunidades.Size = new Size(87, 18);
            lbunidades.TabIndex = 7;
            lbunidades.Text = "Unidades";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(154, 238);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 49;
            dgv.Size = new Size(526, 177);
            dgv.TabIndex = 10;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(699, 34);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(100, 30);
            btnagregar.TabIndex = 11;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(699, 145);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(100, 34);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // lbproductos
            // 
            lbproductos.AutoSize = true;
            lbproductos.Font = new Font("Georgia", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbproductos.Location = new Point(257, 20);
            lbproductos.Margin = new Padding(2, 0, 2, 0);
            lbproductos.Name = "lbproductos";
            lbproductos.Size = new Size(291, 27);
            lbproductos.TabIndex = 13;
            lbproductos.Text = "Productos de vestimenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FB_fbe8458caf97d032ede053fae8744712;
            pictureBox1.Location = new Point(267, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(697, 191);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(100, 31);
            btnsalir.TabIndex = 15;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(699, 107);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(98, 32);
            btnmostrar.TabIndex = 16;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(699, 70);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(100, 31);
            btnbuscar.TabIndex = 17;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(811, 427);
            Controls.Add(btnbuscar);
            Controls.Add(btnmostrar);
            Controls.Add(btnsalir);
            Controls.Add(pictureBox1);
            Controls.Add(lbproductos);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgv);
            Controls.Add(lbunidades);
            Controls.Add(txtunidades);
            Controls.Add(lbprecio);
            Controls.Add(txtprecio);
            Controls.Add(txtmarca);
            Controls.Add(lbmarca);
            Controls.Add(txtnombre);
            Controls.Add(lbnombre);
            Font = new Font("Georgia", 10.0173912F);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnombre;
        private TextBox txtnombre;
        private Label lbmarca;
        private TextBox txtmarca;
        private TextBox txtprecio;
        private Label lbprecio;
        private TextBox txtunidades;
        private Label lbunidades;
        private DataGridView dgv;
        private Button btnagregar;
        private Button btneliminar;
        private Label lbproductos;
        private PictureBox pictureBox1;
        private Button btnsalir;
        private Button btnmostrar;
        private Button btnbuscar;
    }
}
