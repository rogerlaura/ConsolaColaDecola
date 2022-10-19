using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaColaDecola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato, opcion;
            Cola cola = new Cola(4);
            do {
                Console.WriteLine("\t=============[ COLA DECOLA ] ============");
                Console.WriteLine("\t\t1.- AGREGAR POR DELANTE ");
                Console.WriteLine("\t\t2.- AGREGAR POR DETRAS ");
                Console.WriteLine("\t\t3.- ELIMINAR POR DELANTE ");
                Console.WriteLine("\t\t4.- ELIMINAR POR DETRAS ");
                Console.WriteLine("\t\t5.- LISTAR");
                Console.WriteLine("\t\t6.- SALIR");
                Console.Write("\tELIJA UN OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("DIGITE UN VALOR");
                        dato=int.Parse(Console.ReadLine());
                        cola.InsertarItemsDelate(dato);
                        break;
                    case 2:
                        Console.WriteLine("DIGITE UN VALOR");
                        dato = int.Parse(Console.ReadLine());
                        cola.InsertarItemsDetras(dato);
                        break;
                    case 3:
                        cola.EliminarItemsDelante();
                        break;
                    case 4:
                        cola.EliminarItemsDetras();
                        break;
                    case 5:
                        cola.ListarItems();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDO");
                        break;

                }
                Console.ReadKey(true);
                Console.Clear();
            } while (opcion!=6);

        }
    }
}
