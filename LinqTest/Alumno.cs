using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double Promedio { get; set; }
        public int IdCarrera { get; set; }

        public void getDatosAlumno()
        {
            Console.WriteLine("Alumno {0} con matrícula {1} y promedio {2} en la carrera con ID {3}", Nombre, Matricula, Promedio, IdCarrera);
        }
    }
}
