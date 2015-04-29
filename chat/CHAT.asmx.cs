using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace chat
{
    /// <summary>
    /// Descripción breve de CHAT
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CHAT : System.Web.Services.WebService
    {

        [WebMethod]
        public string chat(string mensaje)
        {
            switch (mensaje)
            {
                case "hola bebe!!!": return "hola quien eres";
                case "De donde eres?": return "De tu corazon";
                case "como estas?": return "Bien y tu";
                case "como te llamas?": return "la shina coshinaa";
                case "tienes cel?": return"si porque";
                case "tienes web cam?": return "si me quieres ver";
                case "quieres mostrart?": return "no que pena!";
                case "que buscas realmente?": return "lo que quieras";
                case "osea que te gusta experimentar nuevas cosas?": return "siii";
                case "que tal si empiezas a subir la temperatura": return "si anda asiendo frio";
                case "hasta donde quiere llegar?": return "hasta lo mas fondo de ti";
                case "cuantos años tienes?": return "estoy en la edad de la punzada";
                case "que te gusta hacer?": return "lo que quieras que te haga";
                case "y luego que cuentas?": return "aqui esperandote";
                case "ahorita llego a tu casa": return "vamonos riki papi!!";
                default: return "perdon?";


                  
            }
        }
    }
}
