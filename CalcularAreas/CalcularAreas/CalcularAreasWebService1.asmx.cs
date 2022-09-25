using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcularAreas
{
    /// <summary>
    /// Descripción breve de CalcularAreasWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularAreasWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double CalcularCuadrado(string Dato1)
        {
            Calcular c = new Calcular();
            return c.CalcularCuadrado(Dato1);
        }
        [WebMethod]
        public string CalcularTriángulo(string Dato1, string Dato2)
        {
            Calcular c = new Calcular();
            return c.CalcularTriángulo(Dato1, Dato2);
        }
        [WebMethod]
        public string CalcularCirculo(string Dato1)
        {
            Calcular c = new Calcular();
            return c.CalcularCirculo(Dato1);
        }
    }
}
