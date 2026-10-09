namespace ACTIVIDAD
{
    partial class frConsultaSalas
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
            dvgSalas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgSalas).BeginInit();
            SuspendLayout();
            // 
            // dvgSalas
            // 
            dvgSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSalas.Location = new Point(4, 36);
            dvgSalas.Name = "dvgSalas";
            dvgSalas.RowHeadersWidth = 51;
            dvgSalas.Size = new Size(784, 274);
            dvgSalas.TabIndex = 0;
            // 
            // frConsultaSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 319);
            Controls.Add(dvgSalas);
            Name = "frConsultaSalas";
            Text = "frConsultaSalas";
            Load += frConsultaSalas_Load;
            ((System.ComponentModel.ISupportInitialize)dvgSalas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgSalas;
    }
}