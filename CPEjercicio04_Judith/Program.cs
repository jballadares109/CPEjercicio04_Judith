using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio04_Judith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            Auto auto = new Auto();
            Moto moto = new Moto(123, "Dukati", "dhgag", 100, 7000, 2007, 's');

            Console.WriteLine("El precio final es de: {0}", moto.Precitotal());

            Console.WriteLine("A continuacion de la informacion del primer vehiculo a añdir: ");
            Console.WriteLine("\n Modelo: ");
            auto.Modelo = Console.ReadLine();
            Console.WriteLine("\n Marca: ");
            auto.Marca = Console.ReadLine();
            Console.WriteLine("\n Kilometraje: ");
            auto.Kilometraje = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Año: ");
            auto.Annio = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Precio: ");
            auto.Precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("El precio final es de: {0}", auto.Precitotal());
            Console.ReadKey();
        }
    }
}
