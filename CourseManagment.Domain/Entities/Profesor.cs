﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entities
{
    public class Profesor : Persona
    {
        public int ProfesorId { get; set; }
        public string Codigo { get; set; }
        public string  Carrera { get; set; }
        public string Departamento { get; set; }
    }
}
