using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using numerosPrimos.dao;
using numerosPrimos.models;

namespace numerosPrimos
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        public void ListClientes_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TarjetaDeCredito = txtCredito.Text;
            cliente.Telefono = txtTelefono.Text;


            ListClientes.Items.Add(cliente);

            //string nombre = txtNombre.Text;
            //ListClientes.Items.Add(nombre);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            ListClientes.Items.RemoveAt(ListClientes.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Conectar();
        }
    }
}
