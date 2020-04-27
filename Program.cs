using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaligada01
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n |_________________________________|");
                Console.WriteLine("  |          LISTA SIMPLE            |");
                Console.WriteLine("  |>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|");
                Console.WriteLine("  | 1. Insertar   |  4. Eliminar     |");
                Console.WriteLine("  | 2. Buscar     |  5. Desplegar    |");
                Console.WriteLine("  | 3. Modificar  |  6. Salir        |");
                Console.WriteLine("  |>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|");
                Console.Write(" Escoja Una Opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n\n INSERTA NODO EN LA LISTA \n");
                        l.insertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n\n BUSCAR UN NODO EN LA LISTA \n");
                        l.buscarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n MODIFICAR UN NODO EN LA LISTA \n");
                        l.modificarNodo();
                        break;
                    case 4:
                        Console.WriteLine("\n\n ELIMINAR UN NODO EN LA LISTA \n");
                        l.eliminarNodo();
                        break;
                    case 5:
                        Console.WriteLine("\n\n DESPLEGAR LISTA DE NODOS \n");
                        l.desplegarlistaPU();
                        break;
                    case 6:
                    default:
                        Console.WriteLine("\n\n Opcion No Valida \n");
                        break;
                }
            }
            while (opcionMenu != 6);
        }
    }
}
