namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            label1 = new Label();
            lstTienda = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            btnTodos = new Button();
            btnSeleccion = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            lstAlmacen = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(155, 42);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(150, 184);
            lstTienda.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 24);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Almacen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 24);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Tienda";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(26, 42);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(26, 82);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 28);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 116);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 28);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(26, 150);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 28);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(311, 130);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(100, 28);
            btnTodos.TabIndex = 9;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(311, 96);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(100, 28);
            btnSeleccion.TabIndex = 10;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(573, 96);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(64, 28);
            btnSubir.TabIndex = 12;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(573, 130);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(64, 28);
            btnBajar.TabIndex = 11;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(417, 42);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(150, 184);
            lstAlmacen.TabIndex = 13;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 247);
            Controls.Add(lstAlmacen);
            Controls.Add(btnSubir);
            Controls.Add(btnBajar);
            Controls.Add(btnSeleccion);
            Controls.Add(btnTodos);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstTienda);
            Controls.Add(label1);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTienda;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrar;
        private Button btnTodos;
        private Button btnSeleccion;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstAlmacen;
    }
}