namespace ACTIVIDAD
{
    partial class frRegistraUsuario
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
            txtNombre = new TextBox();
            txtDepartamento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Label3 = new Label();
            btnGuardarU = new Button();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(46, 136);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(224, 27);
            txtDepartamento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 113);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Departamento";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(46, 166);
            Label3.Name = "Label3";
            Label3.Size = new Size(67, 20);
            Label3.TabIndex = 5;
            Label3.Text = "Telefono";
            // 
            // btnGuardarU
            // 
            btnGuardarU.Location = new Point(313, 246);
            btnGuardarU.Name = "btnGuardarU";
            btnGuardarU.Size = new Size(94, 29);
            btnGuardarU.TabIndex = 6;
            btnGuardarU.Text = "Guardar";
            btnGuardarU.UseVisualStyleBackColor = true;
            btnGuardarU.Click += btnGuardarU_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(46, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 7;
            // 
            // frRegistraUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 288);
            Controls.Add(txtTelefono);
            Controls.Add(btnGuardarU);
            Controls.Add(Label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartamento);
            Controls.Add(txtNombre);
            Name = "frRegistraUsuario";
            Text = "frRegistraUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDepartamento;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label Label3;
        private Button btnGuardarU;
        private TextBox txtTelefono;
    }
}