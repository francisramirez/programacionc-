using System.Windows.Forms;
using CourseManagment.Domain.Entities;
namespace CourseManagment
{
    public partial class formEstudiante : Form
    {
        private Estudiante estudianteBL;
        public formEstudiante()
        {
            this.estudianteBL = new Estudiante();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Estudiante newEstudiante = new Estudiante();

            newEstudiante.Nombre = tbxNombre.Text;
            newEstudiante.Apellido = tbxApellido.Text;
            newEstudiante.Carrera = tbxCarrera.Text;
            newEstudiante.Departamento = tbxDepartamento.Text;
            newEstudiante.Direccion = tbxDireccion.Text;
            newEstudiante.Matricula = tbxMat.Text;
            newEstudiante.Rut = tbxRut.Text;

            estudianteBL.AgregarEstudiante(newEstudiante);
           
            CargarEstudiantes();
            LimpiarCampos();
            tbxNombre.Focus();

            MessageBox.Show("El estudiante fue creado correctamente","Informacion");
        }

        private void CargarEstudiantes()
        {
            dgvEstudiantes.DataSource = estudianteBL.ObtenerEstudiantes().ToArray();
            dgvEstudiantes.Refresh();
        }

       

        private void btnCancelar_Click(object sender, System.EventArgs e) 
        {
            LimpiarCampos();
        }
         
        private void LimpiarCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellido.Text = string.Empty;
            tbxCarrera.Text = string.Empty;
            tbxDepartamento.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxMat.Text = string.Empty;
            tbxRut.Text = string.Empty;
            tbxNombre.Focus();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            this.estudianteBL.EliminarEstudiante(tbxMat.Text);
            this.LimpiarCampos();
            this.CargarEstudiantes();
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvEstudiantes.Rows[e.RowIndex];
                
                tbxNombre.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                tbxApellido.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                tbxCarrera.Text = gridViewRow.Cells["Carrera"].Value.ToString();
                tbxDepartamento.Text = gridViewRow.Cells["Departamento"].Value.ToString();
                tbxDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                tbxMat.Text = gridViewRow.Cells["Matricula"].Value.ToString();
                tbxRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
            }
        }
    }
}
