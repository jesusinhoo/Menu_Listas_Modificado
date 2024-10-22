using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista miLista= new Lista();
            int wh = 5;
            while (wh == 5)
            {
                Console.Clear();
                Console.WriteLine("===========MENU LISTAS==========");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Selecciona una opcion: ");
                Console.WriteLine("1.- Insertar Nodo.");
                Console.WriteLine("2.- Imprimir Tamaño.");
                Console.WriteLine("3.- Buscar Nodo.");
                Console.WriteLine("4.- Borrar Nodo.");
                Console.WriteLine("5.- Modificar Nodo.");
                Console.WriteLine("6.- Buscar Valo.");
                Console.WriteLine("7.- Imprimir Lista.");
                Console.WriteLine("8.-  Salir");
                int opc = int.Parse(Console.ReadLine());

                if (opc == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Agrega un nodo: ");
                    int nodo = int.Parse(Console.ReadLine());   
                    miLista.Add(nodo);
                    //  Console.Clear();
                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("El tamaño de la lista es de: " + miLista.Count());
                    Console.ReadKey();
                }
                else if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa la pocision: ");
                    int pos = int.Parse(Console.ReadLine());
                    Console.WriteLine("El valor es: "+miLista.Find(pos));
                    Console.ReadKey();
                }
                else if (opc == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa la pocicion: ");
                    int pos = int.Parse(Console.ReadLine());
                    Console.WriteLine(miLista.Delete(pos));
                    Console.ReadKey();
                }
                else if (opc == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa la pocicion del valor a modificar: ");
                    int pos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el nuevo valor: ");
                    int nuevoValor = int.Parse(Console.ReadLine());
                    Console.WriteLine(miLista.Change(pos,nuevoValor));
                }
                else if (opc == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(miLista.FindValue(valor));
                    Console.ReadKey();
                }
                else if (opc == 7)
                {
                    Console.Clear() ;
                    miLista.Imprimir(); 
                    Console.ReadKey();
                }
                else if (opc == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    wh = 1; 
                    Console.ReadKey();
                }
            }
        }
    }
}
