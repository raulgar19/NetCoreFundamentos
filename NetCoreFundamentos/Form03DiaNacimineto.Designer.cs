namespace NetCoreFundamentos
{
    partial class Form03DiaNacimineto
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
            label2 = new Label();
            label3 = new Label();
            lblMostrar = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAno = new TextBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 48);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 77);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Location = new Point(24, 157);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(124, 15);
            lblMostrar.TabIndex = 3;
            lblMostrar.Text = "El día de la semana es ";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(79, 16);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(79, 45);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 5;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(79, 74);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(24, 103);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(155, 41);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar día";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // Form03DiaNacimineto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 201);
            Controls.Add(btnMostrar);
            Controls.Add(txtAno);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblMostrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimineto";
            Text = "Form03DiaNacimineto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMostrar;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAno;
        private Button btnMostrar;
    }
}