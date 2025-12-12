namespace NetCoreFundamentos
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
            btnPulsar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(101, 67);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(75, 23);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 20);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(118, 103);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 139);
            Controls.Add(lblResultado);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox txtNombre;
        private Label lblResultado;
    }
}
