namespace ACTIVIDAD
{
    partial class frRegistraSala
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
            txtNombreSala = new TextBox();
            txtCapacidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGuardarS = new Button();
            SuspendLayout();
            // 
            // txtNombreSala
            // 
            txtNombreSala.Location = new Point(30, 75);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(125, 27);
            txtNombreSala.TabIndex = 0;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(30, 150);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(125, 27);
            txtCapacidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 127);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Capacidad";
            // 
            // btnGuardarS
            // 
            btnGuardarS.Location = new Point(169, 214);
            btnGuardarS.Name = "btnGuardarS";
            btnGuardarS.Size = new Size(94, 29);
            btnGuardarS.TabIndex = 4;
            btnGuardarS.Text = "Guardar";
            btnGuardarS.UseVisualStyleBackColor = true;
            btnGuardarS.Click += btnGuardarS_Click;
            // 
            // frRegistraSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 279);
            Controls.Add(btnGuardarS);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombreSala);
            Name = "frRegistraSala";
            Text = "frRegistraSala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreSala;
        private TextBox txtCapacidad;
        private Label label1;
        private Label label2;
        private Button btnGuardarS;
    }
}