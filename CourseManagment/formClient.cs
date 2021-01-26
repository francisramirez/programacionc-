using System;
using System.Windows.Forms;
using CourseManagment.Domain.BL;
using CourseManagment.Domain.Entities;

namespace CourseManagment
{
    public partial class formClient : Form
    {
        private ClienteBL clienteBL;

        private int clienteId;
        public formClient()
        {
            this.clienteBL = new ClienteBL();

            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = tbxNombre.Text,
                Apellido = tbxApellidos.Text,
                Direccion = tbxDireccion.Text,
                Rut = tbxRut.Text,
                Cuenta = tbxNroCuenta.Text
            };

            this.clienteBL.Guardar(cliente);
            CargaClientes();
            LimpiarCampos();
        }

        private void CargaClientes()
        {
            dgvClientes.DataSource = this.clienteBL.ObtenerRegistros().ToArray();
            dgvClientes.Refresh();
        }
        private void LimpiarCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxRut.Text = string.Empty;
            tbxNroCuenta.Text = string.Empty;
            tbxNroCuenta.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.clienteBL.ObtenerEntity(this.clienteId);
            this.clienteBL.Eliminar(cliente);
            CargaClientes();
            LimpiarCampos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvClientes.Rows[e.RowIndex];

                tbxNombre.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                tbxApellidos.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                tbxDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                tbxNroCuenta.Text = gridViewRow.Cells["Cuenta"].Value.ToString();
                tbxRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
                this.clienteId = Convert.ToInt32(gridViewRow.Cells["ClienteId"].Value);
            }
        }
    }
}
