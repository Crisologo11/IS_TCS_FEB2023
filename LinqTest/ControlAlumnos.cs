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
            carreras.Add(new Carrera { IdCarrera = 1, NombreCarrera = "Ingeniería de Software" });
            carreras.Add(new Carrera { IdCarrera = 2, NombreCarrera = "Redes y Servicios de Computo" });

            alumnos.Add(new Alumno { IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "s090032", Promedio = 8.9, IdCarrera = 1 });
            alumnos.Add(new Alumno { IdAlumno = 2, Nombre = "María Rodríguez Martínez", Matricula = "s421512", Promedio = 9.2, IdCarrera = 2 });
            alumnos.Add(new Alumno { IdAlumno = 3, Nombre = "José Trelles Jiménez", Matricula = "s941520", Promedio = 6.5, IdCarrera = 2 });
        }

        public void obtenerAlumnosPorCarrera(int IdCarrera)
        {
             var resultado = from alumno in alumnos join carrera in carreras
                                            on alumno.IdCarrera equals carrera.IdCarrera
                                            where alumno.IdCarrera == IdCarrera
                                            select new { alumno.Nombre, alumno.Matricula, alumno.Promedio, carrera.NombreCarrera };

            foreach (var alumno in resultado)
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} en la carrera {3}",
                alumno.Nombre, alumno.Matricula, alumno.Promedio, alumno.NombreCarrera);
            }

        }
    }
}
