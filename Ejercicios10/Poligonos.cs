using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCSharp_3.Ejercicios10
{
    public class Poligonos
    {
        public class Poligono
        {
            public int Lados { get; set; }
            public int Vertices { get; set; }
            public float AnguloInterior { get; set; }
            public float AnguloExterior { get; set; }


            public Poligono()
            {

            }

            public Poligono(int lados, int vertices)
            {
                Lados = lados;
                Vertices = vertices;
            }

            public Poligono(int lados, int vertices, float anguloInterior, float anguloExterioro)
            {
                this.Lados = lados;
                this.Vertices = vertices;
                this.AnguloInterior = anguloInterior;
                this.AnguloExterior = anguloExterioro;
            }

            public override string ToString()
            {
                string cadena;

                cadena = "Lados =" + Lados + ", Vertices =" + Vertices + "," +
                    " Angulo Interior =" + AnguloInterior + ", Angulo Exterior =" + AnguloExterior;

                return cadena;

            }
        }

    }
}
