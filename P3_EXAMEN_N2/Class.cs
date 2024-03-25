namespace P3_EXAMEN_N2
{
  
      namespace P3_EXAMEN_N2.Models
    {
        public class Profesor
        {
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string AreaConocimiento { get; set; }
        }

        public class Estudiante
        {
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Carrera { get; set; }
            public int CantidadCursos { get; set; }
        }
    }

}

