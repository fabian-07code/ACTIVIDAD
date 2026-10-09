namespace ACTIVIDAD
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
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            registarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            salasToolStripMenuItem = new ToolStripMenuItem();
            registarToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            reservacionesToolStripMenuItem = new ToolStripMenuItem();
            registarToolStripMenuItem2 = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, salasToolStripMenuItem, reservacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarToolStripMenuItem, consultarToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registarToolStripMenuItem
            // 
            registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            registarToolStripMenuItem.Size = new Size(154, 26);
            registarToolStripMenuItem.Text = "Registar";
            registarToolStripMenuItem.Click += registarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(154, 26);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // salasToolStripMenuItem
            // 
            salasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarToolStripMenuItem1, consultarToolStripMenuItem1 });
            salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            salasToolStripMenuItem.Size = new Size(57, 24);
            salasToolStripMenuItem.Text = "Salas";
            // 
            // registarToolStripMenuItem1
            // 
            registarToolStripMenuItem1.Name = "registarToolStripMenuItem1";
            registarToolStripMenuItem1.Size = new Size(154, 26);
            registarToolStripMenuItem1.Text = "Registar";
            registarToolStripMenuItem1.Click += registarToolStripMenuItem1_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(154, 26);
            consultarToolStripMenuItem1.Text = "Consultar";
            consultarToolStripMenuItem1.Click += consultarToolStripMenuItem1_Click;
            // 
            // reservacionesToolStripMenuItem
            // 
            reservacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarToolStripMenuItem2, consultarToolStripMenuItem2 });
            reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            reservacionesToolStripMenuItem.Size = new Size(116, 24);
            reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // registarToolStripMenuItem2
            // 
            registarToolStripMenuItem2.Name = "registarToolStripMenuItem2";
            registarToolStripMenuItem2.Size = new Size(224, 26);
            registarToolStripMenuItem2.Text = "Registar";
            registarToolStripMenuItem2.Click += registarToolStripMenuItem2_Click;
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(224, 26);
            consultarToolStripMenuItem2.Text = "Consultar";
            consultarToolStripMenuItem2.Click += consultarToolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem registarToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem salasToolStripMenuItem;
        private ToolStripMenuItem registarToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem reservacionesToolStripMenuItem;
        private ToolStripMenuItem registarToolStripMenuItem2;
        private ToolStripMenuItem consultarToolStripMenuItem2;
    }
}
