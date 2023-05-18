using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera { IdCarrera = 1, Nombre = "Ingeniería de Software" });
            carreras.Add(new Carrera { IdCarrera = 2, Nombre = "Redes y Servicios de Computo" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "s090032", Promedio = 8.9, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "María Rodríguez Martínez", Matricula = "s421512", Promedio = 9.2, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "José Trelles Jiménez", Matricula = "s941520", Promedio = 6.5, IdCarrera = 2 });
        }

        public void obtenerAlumnosPorCarrera(int IdCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos where alumno.IdCarrera == IdCarrera select alumno;

            foreach (Alumno alumno in resultado)
            {
                alumno.getDatosAlumno();
            }
        }
    }
}
