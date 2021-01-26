using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entities
{
    public class Departamento : BaseEntity
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

    }
}
