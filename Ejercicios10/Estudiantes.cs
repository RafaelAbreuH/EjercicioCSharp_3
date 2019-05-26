using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCSharp_3.Ejercicios10
{
    public class Estudiantes
    {
        [Key]
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public int Grado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NombrePadre { get; set; }
        public string Direccion { get; set; }
        public string TelefonoPadre { get; set; }

        public Estudiantes()
        {
            Nombre = string.Empty;
            Matricula = 0;
            Grado = 0;
            FechaIngreso = DateTime.Now;
            NombrePadre = string.Empty;
            Direccion = string.Empty;
            TelefonoPadre = String.Empty;
        }
    }
}
