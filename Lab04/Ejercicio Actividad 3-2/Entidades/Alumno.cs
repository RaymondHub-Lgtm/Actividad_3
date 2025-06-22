using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Actividad_3_2.Entidades
{
    internal class Alumno
    { //constructor
        public Alumno() { }
        
        //Propiedades Automaticas de los atributos
        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public double Promedio { get; set; }
    }
}
 