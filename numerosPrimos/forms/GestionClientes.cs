using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
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

            if (lblld.Text != "")
            {
                cliente.Id = lblld.Text;
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarListado();

            //ListClientes.Items.Add(cliente);

            //string nombre = txtNombre.Text;
            //ListClientes.Items.Add(nombre);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)ListClientes.SelectedItem;


            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();
            limpiarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.obtenerListadoDeClientes();


            ListClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                ListClientes.Items.Add(cliente);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)ListClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtCredito.Text = cliente.TarjetaDeCredito;
            lblld.Text = cliente.Id;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarListado();
        }

        private void limpiarListado()
        {
            lblld.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCredito.Text = "";
        }
    }
}
