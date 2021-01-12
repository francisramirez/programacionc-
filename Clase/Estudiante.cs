

using Clase.EstudianteExcep;
using System;

namespace Clase
{
    /// <summary>
    /// Clase para manejar las operaciones realizadas sobre el estudiante.
    /// </summary>
    public class Estudiante : Persona
    {
        public int EstudianteId { get; set; }
        public Estudiante(string carrera, string matricula)
        {
            this.Matricula = matricula;
            this.Carrera = carrera;
        }
        public Estudiante(string carrera)
        {
           
        }
        public Estudiante() { }

        private string _carrera;

        public string Carrera 
        {
            get 
            { 
                return _carrera; 
            }
            set 
            {
                //Validar que no sea nulo//

                if (string.IsNullOrEmpty(value))
                {
                    throw new EstudianteException($"El campo carrera es requerido..");
                }

                //Validar que no sea nulo//
                if (value.Length > 50)
                {
                    throw new EstudianteException($"El campo carrera no puede ser mayor a 50 carácteres..");
                }

                _carrera = value;
            } 
        }
        public string Matricula { get; set; }

        public string Departamento { get; set; }
        /// <summary>
        /// Obtener estudiantes por la matricula
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula) 
        {
            return new Estudiante();
        }
        /// <summary>
        /// Obtener estudiantes por la matricula y carrera
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <param name="carrera">Carrera a la que pertenece el estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula, string carrera) 
        {
            return new Estudiante();
        }
        /// <summary>
        ///  Obtener estudiantes por la matricula, carrera y departamento
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <param name="carrera">Carrera a la que pertenece el estudiante</param>
        /// <param name="departamento">Departamento al que pertenece el estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula, string carrera, string departamento = null)
        {
            //Estudiante estudiante = null;
            //int? tipoNullable = null;
            //DateTime? fecha = null;
            //var myValue = fecha.HasValue ? fecha.Value :(DateTime?) null;

            return new Estudiante();
        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Estudiante----");

            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nombre: {this.ObtenerNombreCompleto()}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Carrera: {Carrera}");
        

            Console.WriteLine("----------------------------");
        }

        public override void AgregarPersona(Persona persona, out int personaId)
        {
            ///insert data //

            try
            {
                //int value = int.Parse(persona.Nombre);
            }
            catch (EstudianteException exp) 
            {
                Console.WriteLine(exp.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido error durante el proceso.");
            }
            finally
            {
                Console.WriteLine("Entre como quiera"); 
            }

            personaId = 1;
        }

    }
}
