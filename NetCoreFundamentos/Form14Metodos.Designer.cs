namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(23, 40);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 97);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(175, 39);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(75, 23);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(160, 68);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(103, 23);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(158, 97);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(107, 23);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.LightGreen;
            lblRaton.Location = new Point(324, 84);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(186, 88);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 50);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo letras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 21);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Solo numeros";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(410, 18);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(100, 23);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(410, 47);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(100, 23);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 189);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private Label label2;
        private Label label3;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
    }
}