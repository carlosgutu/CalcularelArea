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
        public string CalcularCuadrado(string Calcular)
        {
            Calcular c = new Calcular();
            return c.CalcularCuadrado(Calcular);
        }
        [WebMethod]
        public string CalcularTriángulo(string Base, string Altura)
        {
            Calcular c = new Calcular();
            return c.CalcularTriángulo(Base, Altura);
        }
        [WebMethod]
        public string CalcularCirculo(string Radio)
        {
            Calcular c = new Calcular();
            return c.CalcularCirculo(Radio);
        }
    }
}
