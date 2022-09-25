using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreas
{
    public class Calcular
    {
        public double resultado { get; set; }
        public double Base { get; set;}
        public double Altura { get; set; }   
        public double Radio { get; set; }

        public string CalcularCuadrado(string Dato1)
        {
            //Calcular el área de un cuadrado
             resultado = Math.Pow(double.Parse(Dato1), 2);
            
            return resultado.ToString();
        }
        public string CalcularTriángulo(string Dato1, string Dato2)
        {
            Base = double.Parse(Dato1);
            Altura = double.Parse(Dato2);
            resultado = (Base * Altura) / 2;
            return resultado.ToString();
        }
        public string CalcularCirculo(string Dato1)
        {
            Radio = double.Parse(Dato1);
            resultado = System.Math.PI * Math.Pow(Radio, 2);
            return resultado.ToString();
        }
    }
}