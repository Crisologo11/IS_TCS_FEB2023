using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }

        public void getDatosCarrera()
        {
            Console.WriteLine("Carrera {0}, con ID {1}", Nombre, IdCarrera);
        }
    }
}
