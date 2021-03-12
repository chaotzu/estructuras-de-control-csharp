using System;

namespace estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Calificaciones calificacion = new Calificaciones();
            Console.WriteLine(calificacion.esPar(2));
            Console.WriteLine(calificacion.sonIguales(1,2));
            Console.WriteLine(calificacion.calificacionExpresion(8));
            Console.WriteLine(calificacion.getRepresentacionTextual());
            Console.WriteLine(calificacion.calificacionExpresionSwitch(9));
            Console.WriteLine(calificacion.operarCalificaciones(1,2,'-'));            
            Console.WriteLine(calificacion.calificacionToAsteriscos(9));
            Console.WriteLine(calificacion.calificacionToAsteriscosDoWhile(9));
            Console.WriteLine(calificacion.calificacionToAsteriscosFor(9));
        }           
    }    
}
