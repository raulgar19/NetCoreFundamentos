namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtFile = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnLeer = new Button();
            btnWrite = new Button();
            lstNombres = new ListBox();
            label3 = new Label();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(12, 38);
            txtFile.Multiline = true;
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(211, 270);
            txtFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 11);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(229, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(229, 97);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(100, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer file";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(229, 126);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 23);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(335, 38);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(157, 274);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 11);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(229, 68);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 23);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 322);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtFile);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFile;
        private Label label2;
        private TextBox txtNombre;
        private Button btnLeer;
        private Button btnWrite;
        private ListBox lstNombres;
        private Label label3;
        private Button btnNuevo;
    }
}