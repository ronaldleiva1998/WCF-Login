using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginServiceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = string.Empty, pass = string.Empty;
            ServiceReferenceLogin.IloginServiceClient objClient = new ServiceReferenceLogin.IloginServiceClient();
            Console.WriteLine("Ingresar Usuario:");
            user = Console.ReadLine();
            Console.WriteLine("Ingresar Password");
            pass =Console.ReadLine();
            if (objClient.validateLogin(user, pass))
            {
                Console.WriteLine("Conexion exitosa");
            }
            else
            {
                Console.WriteLine("Conexion Fallida");
            }
            Console.ReadKey();
        }
    }
}
