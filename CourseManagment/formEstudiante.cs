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

            dgvEstudiantes.DataSource = estudianteBL.ObtenerEstudiantes().ToArray();
            dgvEstudiantes.Refresh();
        }
    }
}
