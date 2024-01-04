namespace numerosPrimos
{
    partial class GestionClientes
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
            ListClientes = new ListBox();
            label1 = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtCredito = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ListClientes
            // 
            ListClientes.FormattingEnabled = true;
            ListClientes.ItemHeight = 15;
            ListClientes.Location = new Point(12, 12);
            ListClientes.Name = "ListClientes";
            ListClientes.Size = new Size(259, 334);
            ListClientes.TabIndex = 0;
            ListClientes.SelectedIndexChanged += ListClientes_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 61);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(450, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(450, 82);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 23);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 90);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellidos:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(450, 111);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(175, 23);
            txtTelefono.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 119);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtCredito
            // 
            txtCredito.Location = new Point(360, 166);
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(265, 23);
            txtCredito.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(526, 148);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 9;
            label4.Text = "Tarjeta de Credito";
            // 
            // button1
            // 
            button1.Location = new Point(360, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCredito);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(ListClientes);
            Name = "GestionClientes";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListClientes;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Button btnEliminar;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtCredito;
        private Label label4;
        private Button button1;
    }
}