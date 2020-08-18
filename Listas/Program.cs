using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string>();

            //Adicionar elemento na lista add -> adiciona no final da lista
            lista.Add("Ana");
            lista.Add("Pedro");
            lista.Add("Bob");

            // Insert  -> Adicionar em uma posicao determinada na lista
            lista.Insert(2, "Carlos");

            //Encontra elementos da lista
            string s1 = lista.Find(x=> x[0] == 'A');
            Console.WriteLine("Primeira com A : " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima com A : " + s2);

            //Posicao por indice
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position : "+ pos1 );

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First position : " + pos2);

            //Filtro de lista
            List<string> lista2 = lista.FindAll(x => x.Length == 3);
            Console.WriteLine("-----------------");
            foreach(string obj in lista2) {
                Console.WriteLine(obj);
            }

            //Remover da lista
            lista.Remove("Carlos");

            //Remover todos que possui a letra m
            lista.RemoveAll(x => x[0] == 'M');

            //Remover por posicao
            lista.RemoveRange(2,2);

            foreach(string nomes in lista) {
                Console.WriteLine(nomes);
            }

            Console.WriteLine("Numero de usuários: " + lista.Count);

        }
    }
}
