namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            btnCrear = new Button();
            lstClases = new ListBox();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(25, 255);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(101, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(25, 65);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(430, 184);
            lstClases.TabIndex = 3;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(132, 255);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(101, 23);
            btnEmpleado.TabIndex = 4;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 307);
            Controls.Add(btnEmpleado);
            Controls.Add(lstClases);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnCrear;
        private ListBox lstClases;
        private Button btnEmpleado;
    }
}