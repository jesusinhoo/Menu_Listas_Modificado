using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Listas
{
    internal class Lista
    {

        private Nodo inicio;
        private int contador;

        public Lista()
        {
            inicio = null;
            contador = 0;
        }

        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevo;
            }
            contador++;
        }

        public int Count()
        {
            return contador;
        }

        public int Find(int pos)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia.");
                return -1;
            }
            Nodo act = inicio;
            int poss = 0;
            while (act != null)
            {
                if (poss == pos)
                {
                    return act.Valor;
                }
                act = act.Sig;
                poss++;
            }
            if (act == null)
            Console.WriteLine("Pocicion fuera de rango");

            return -1;
        }

        public bool Delete(int pos)
        {
            try
            {
                if (inicio == null || pos < 0)
                {
                    Console.WriteLine("La lista esta vacia.");
                    return false;
                }

                if (pos == 0)
                {
                    inicio = inicio.Sig;
                    Console.WriteLine("Nodo eliminado.");
                    return true;
                }

                Nodo nuevoNodo = inicio;
                Nodo nNoSig = null;
                int contador = 0;

                while (nuevoNodo != null && contador < pos)
                {
                    nNoSig = nuevoNodo;
                    nuevoNodo = nuevoNodo.Sig;
                    contador++;
                }

                if (nuevoNodo == null)
                {
                    Console.WriteLine("Pocicion no encontrada.");
                    return false;
                }

                nNoSig.Sig = nuevoNodo.Sig;
                Console.WriteLine("Nodo eliminado.");
                return true;
            }
            catch
            {
                Console.WriteLine("Nodo no eliminado.");
                return false;
            }
        }

        public bool Change(int pos, int nuevoV)
        {
            if (inicio == null || pos < 0)
            {
                Console.WriteLine("La lista esta vacia.");
                return false;
            }

            Nodo nuevoNodo = inicio;
            int contador = 0;

            while (nuevoNodo !=  null && contador < pos)
            {
                nuevoNodo = nuevoNodo.Sig;
                contador++;
            }

            if (nuevoNodo == null)
            {
                Console.WriteLine("Pocicion no encontrada.");
                return false;
            }

            nuevoNodo.Valor = nuevoV;
            Console.WriteLine("El nodo fue modificado.");
            return true;

        }

        public int FindValue(int valorN)
        {
            Nodo nuevoNodo = inicio;
            int contador = 0;

            while (nuevoNodo != null)
            {
                if (nuevoNodo.Valor == valorN)
                {
                    Console.WriteLine("La pocicion es: ");
                    return contador;
                }
                nuevoNodo = nuevoNodo.Sig;
                contador++;
            }

            if (nuevoNodo == null)
            {
                Console.WriteLine("La lista esta vacia.");
                return -1;
            }

            Console.WriteLine("No se encontro el valor.");
            return -1;
        }

        public void Imprimir()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor}" + " " + "->" + " ");
                    act = act.Sig;
                }
            }
        }

    }
}
