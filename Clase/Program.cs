using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObtenerDatosCuenta();
            //ObtenerDatosPersonas();
            var estudiante = ObtenerEstudiante();

            Console.ReadLine();
        }
        static void ObtenerDatosCuenta()
        {
            CuentaCorriente cuentaCorriente = new CuentaCorriente();

            cuentaCorriente.NumeroCuenta = "78945612";
            cuentaCorriente.Nombre = "Mi cuenta cuenta corriente";
            cuentaCorriente.Saldo = 500;

            cuentaCorriente.Depositar();
            cuentaCorriente.Girar();

            var saldo = cuentaCorriente.ContultarSaldo();

            Console.WriteLine($"Mi numero de cuenta {cuentaCorriente.NumeroCuenta}");
            Console.WriteLine($"Nombre de la cuenta {cuentaCorriente.Nombre} ");
            Console.WriteLine($"Saldo de la cuenta {cuentaCorriente.Saldo}");

        }

        static void ObtenerDatosPersonas()
        {

            Estudiante estudiante = new Estudiante("Contabilidad", "7894562")
            {
                Nombre = "Jose Perez",
                Apellido = "De Leon",
                Direccion = "Mi direccion",
                Rut = "123456"
            };

            estudiante.ImprimirDatos();

            Estudiante estudiante2 = new Estudiante()
            {
                Nombre = "Jose Perez",
                Apellido = "De Leon",
                Direccion = "Mi direccion",
                Rut = "123456"
            };

            estudiante2.ImprimirDatos();

            //Cliente cliente = new Cliente()
            //{
            //    Nombre = "Juan",
            //    Apellido = "De los santos",
            //    Direccion = "Su direccion",
            //    Rut = "4567895",
            //    Cuenta = "4567892"
            //};

            //Empleado empleado = new Empleado()
            //{
            //    Nombre = "Rafael",
            //    Apellido = "Gonzales",
            //    Direccion = "Otra direccion",
            //    Rut = "258552",
            //    Sueldo = 800
            //};

            //estudiante.ImprimirDatos();
            //empleado.ImprimirDatos();
            //cliente.ImprimirDatos();

            Console.ReadLine();
        }

        static Estudiante ObtenerEstudiante() 
        {

            Estudiante estudiante = new Estudiante();

            //var datosEstudiantes = estudiante.ObtenerEstudiante("", "",);

            int personaId = 0;

            string numero = "aaa";

            if (!int.TryParse(numero, out personaId))
            {
                Console.WriteLine($"Este campo {numero} es inválido");
            }

            estudiante.AgregarPersona(new Estudiante() 
            {
                Nombre = "Jose Perez",
                Apellido = "De Leon",
                Direccion = "Mi direccion",
                Rut = "123456", 
                Carrera ="Contabilidad", 
                Departamento ="Administracion", 
                Matricula = "101-45255"
            }, 
            out personaId);


            estudiante.EstudianteId = personaId;

            return estudiante;
        }
    }
}
