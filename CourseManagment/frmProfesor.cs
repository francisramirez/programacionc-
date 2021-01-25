using System.Windows.Forms;
using CourseManagment.Domain.BL;
using CourseManagment.Domain.Entities;
using CourseManagment.Domain.Interfaces;

namespace CourseManagment
{
    public partial class frmProfesor : Form
    {
        private IProfesor profesorBL;

        public frmProfesor()
        {
            this.profesorBL = new ProfesorBL();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                Nombre = tbxNombre.Text,
                Apellido = tbxApellido.Text,
                Carrera = tbxCarrera.Text,
                Codigo = tbxCodigo.Text,
                Departamento = tbxDepartamento.Text,
                Direccion = tbxDireccion.Text,
                Rut = tbxRut.Text
            };

            this.profesorBL.Guardar(profesor);
            CargaProfesores();
            LimpiarCampos();
        }

        private void CargaProfesores()
        {
            this.dgvProfesores.DataSource = this.profesorBL.ObtenerRegistros().ToArray();
            this.dgvProfesores.Refresh();
        }

        private void LimpiarCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellido.Text = string.Empty;
            tbxCarrera.Text = string.Empty;
            tbxDepartamento.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxCodigo.Text = string.Empty;
            tbxRut.Text = string.Empty;
            tbxNombre.Focus();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxCodigo.Text))
            {
                MessageBox.Show("El codigo del profesor es requerido.", "Eliminar Profesor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodigo.Focus();
                return;
            }

            Profesor profesor = this.profesorBL.ObtenerProfesorPorCodigo(tbxCodigo.Text);

            this.profesorBL.Eliminar(profesor);

            LimpiarCampos();
            CargaProfesores();
            
            MessageBox.Show("Profesor Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvProfesores.Rows[e.RowIndex];

                tbxNombre.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                tbxApellido.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                tbxCarrera.Text = gridViewRow.Cells["Carrera"].Value.ToString();
                tbxDepartamento.Text = gridViewRow.Cells["Departamento"].Value.ToString();
                tbxDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                tbxCodigo.Text = gridViewRow.Cells["Codigo"].Value.ToString();
                tbxRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
            }
        }
    }
}
