using System;
using System.Web.Services;

namespace MathService
{
    /// <summary>
    /// Descripción breve de MathService
    /// </summary>
    [WebService(Namespace = "http://TrainingUniqueIdentifier.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Add(int a, int b)
        {
            return (a + b);
        }
        [WebMethod]
        public float Subtract(float a, float b)
        {
            return (a - b);
        }
        [WebMethod]
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        [WebMethod]
        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                return -1;
            }

            return Convert.ToSingle(a / b);
        }
    }
}
