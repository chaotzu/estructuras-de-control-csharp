using System;

namespace estructuras
{
    class Calificaciones
    {
        private int representacionNumerica;
        private string representacionTextual;
        public Calificaciones()
        {
            
        }

        public Calificaciones(int representacionNumerica, string representacionTextual= "")
        {
            this.representacionNumerica = representacionNumerica;
            this.representacionTextual = representacionTextual;
        }

        public string getRepresentacionTextual(){
            return this.representacionTextual;
        }
        

        /// <summary>
        /// Usamos la estrucutra de control if para determinar si un número es par o impar
        /// </summary>
        /// <param name="num">número a evaluar</param>
        /// <returns>falso o verdadero</returns>
        public Boolean esPar(int num){
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Usamos la estrucutra de control if para determinar si dos numeros son iguales
        /// </summary>
        /// <param name="num1">Primer número a comparar</param>
        /// <param name="num2">Segundo número a comparar</param>
        /// <returns>Falso o verdadero</returns>
        public Boolean sonIguales(int num1, int num2){
            if( num1 == num2 )
                return true;
            else{
                return false;
            }
        }

        /// <summary>
        /// Devuelve una calificación como una expresión escrita
        /// </summary>
        /// <param name="calificacion">Número que representa una calificación</param>
        /// <returns>Expresión equivalente a la calificación</returns>
        public String calificacionExpresion(int calificacion)
        {
            if (calificacion == 10)
                return "Matricula de honor";
            else if(calificacion == 9){
                return "Sobresaliente";
            }
            else if(calificacion >= 7 &  calificacion <= 8){
                return "Notable";
            }
            else if (calificacion == 6){
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }

        /// <summary>
        /// Devuelve una calificación como una expresión escrita usando Switch
        /// </summary>
        /// <param name="calificacion">Número que representa una calificación</param>
        /// <returns>Expresión equivalente a la calificación</returns>
        public String calificacionExpresionSwitch(int calificacion)
        {
            switch (calificacion)
            {
                /*case 10: {
                    this.representacionTextual="Matricula de honor";
                    break;                    
                } */                
                case 10: return "Matrícula de honor";
                case 9: return "Sobresaliente";
                case 8: return "sobresaliente";
                case 7: return "Notable";
                case 6: return "Aprobado";
                default: return "Reporbado";
            }
        }


        /// <summary>
        /// Suma o resta dos calificaciones
        /// </summary>
        /// <param name="calificacion1">Calificación uno</param>
        /// <param name="calificacion2">Calificación 2</param>
        /// <param name="operador">Operados + para sumar o - para restar</param>
        /// <returns>Suma ó resta de calificaciones o 0 si no coincide ningún caso</returns>
        public int operarCalificaciones(int calificacion1, int calificacion2, char operador='+')
        {
            switch (operador)
            {
                case '+':
                    {
                        return calificacion1 + calificacion2;
                    }
                case '-':
                    {
                        return calificacion1 - calificacion2;
                    }
                default: return 0;
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calificacion"></param>
        /// <returns></returns>
        public String calificacionToAsteriscos(int calificacion)
        {
            String resultado= "";
            while (calificacion >= 1)
            {
                resultado = resultado + " *";
                calificacion--;

            }
            return resultado;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="calificacion"></param>
        /// <returns></returns>
        public String calificacionToAsteriscosDoWhile(int calificacion)
        {
            String resultado = "";
            do
            {
                resultado = resultado + " *";
                calificacion--;
            }
            while (calificacion >= 1);
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calificacion"></param>
        /// <returns></returns>
        public String calificacionToAsteriscosFor(int calificacion)
        {
            String resultado = "";
            for (int i = 1; i <= calificacion; i ++ )
            {
                resultado = resultado + " *";
            }
            /*for (int i = calificacion; i >= calificacion; i--)
            {
                resultado = resultado + "*";
            }*/
            return resultado;
        }

    }
}
