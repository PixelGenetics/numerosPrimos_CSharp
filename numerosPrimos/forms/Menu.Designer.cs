namespace numerosPrimos
{
    partial class Menu
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
            GestionClientes = new Button();
            SuspendLayout();
            // 
            // GestionClientes
            // 
            GestionClientes.Location = new Point(298, 163);
            GestionClientes.Name = "GestionClientes";
            GestionClientes.Size = new Size(142, 78);
            GestionClientes.TabIndex = 0;
            GestionClientes.Text = "Gestionar Clientes";
            GestionClientes.UseVisualStyleBackColor = true;
            GestionClientes.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GestionClientes);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button GestionClientes;
    }
}
