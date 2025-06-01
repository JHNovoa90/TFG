using System.Configuration;

namespace Sistema.Logica
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
