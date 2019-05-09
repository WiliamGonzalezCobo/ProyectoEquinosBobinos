using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;

namespace ClasificacionAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Animal objAnimal = new Animal();
                objAnimal.ClasificarAnimal("");
                Console.WriteLine("Ejecucion Exitosa");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                Console.Read();
            }

        }
    }
}
