namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblItem = new Label();
            btnBorrar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            lblIndex = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(12, 318);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 15);
            lblItem.TabIndex = 16;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(185, 116);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(185, 87);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(185, 58);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(150, 29);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(144, 23);
            txtElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 11);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 29);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 274);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(12, 358);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(0, 15);
            lblIndex.TabIndex = 17;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(175, 145);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(94, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 394);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItem;
        private Button btnBorrar;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Label lblIndex;
        private Button btnSeleccionados;
    }
}