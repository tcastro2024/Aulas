using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Aula___8_Execcoes_e_manipulacao_de_ficheiros_externos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LIST
           // List < T > -Tipado
            List<string> listaDeNomes = new List<string> { "Alice", "Filipe", "Nuno" };
            listaDeNomes.Add("Davide");
            Console.WriteLine("List<T>:");
            foreach (string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            #endregion

            #region ARRAY LIST

            //// ArrayList - Não Tipado
            //ArrayList arrayListNomes = new ArrayList { "Miguel", "Matilde", "Andreia" };
            //arrayListNomes.Add("Paulo");
            //arrayListNomes.Add(123);
            //arrayListNomes.Add(true);
            //Console.WriteLine("\nArrayList:");
            //foreach (var nome in arrayListNomes)
            //{
            //    Console.WriteLine(nome);
            //}

            #endregion

            #region SORTEDLIST

            //// SortedList - Chave/Valor ordenado por chave
            //SortedList<int, string> sortedListNomes = new SortedList<int, string>
            //    {
            //        { 3, "Mara" },
            //        { 1, "Telmo" },
            //        { 2, "Tiago" }
            //    };
            //Console.WriteLine("\nSortedList:");

            //foreach (var nomeList in sortedListNomes)
            //{
            //    Console.WriteLine($"Chave: {nomeList.Key}, valor: {nomeList.Value}");
            //}

            #endregion

            #region STACK

            //// Stack - LIFO (Last In, First Out)
            //Stack<string> stackNomes = new Stack<string>();
            //stackNomes.Push("Mafalda");
            //stackNomes.Push("Oscar");
            //stackNomes.Push("Dinis");
            //Console.WriteLine("\nStack:");
            //while (stackNomes.Count > 0)
            //{
            //    Console.WriteLine(stackNomes.Pop());
            //}

            #endregion

            #region QUEUE

            //// Queue - FIFO (First In, First Out)
            //Queue<string> queueNomes = new Queue<string>();
            //queueNomes.Enqueue("Armando");
            //queueNomes.Enqueue("Lucio");
            //queueNomes.Enqueue("Daniel");
            //Console.WriteLine("\nQueue:");
            //while (queueNomes.Count > 0)
            //{
            //    Console.WriteLine(queueNomes.Dequeue());
            //}

            #endregion

            #region HASTABLE

            // Hashtable - Chave/Valor, não tipado e sem ordenação específica
            //Hashtable hashTableNomes = new Hashtable
            //    {
            //        { 1, "Telmo" },
            //        { 2, "Vitor" },
            //        { 3, "Rafael" }
            //    };

            //hashTableNomes.Add(4, "Andre");
            //Console.WriteLine("\nHashtable:");
            //foreach (DictionaryEntry dicionarioNomes in hashTableNomes)
            //{
            //    Console.WriteLine($"Chave: {dicionarioNomes.Key}, Valor: {dicionarioNomes.Value}");
            //}

            #endregion

            #region DICIONARIO

            // Dictionary<TKey, TValue> - Chave/Valor, tipado e sem ordenação específica
            //Dictionary<int, string> dictionaryNomes = new Dictionary<int, string>
            //    {
            //        { 1, "Manuel" },
            //        { 2, "Maria" },
            //        { 3, "Elsa" }
            //    };

            //dictionaryNomes.Add(4, "Antonio");
            //Console.WriteLine("\nDictionary:");
            //foreach (var dicionario in dictionaryNomes)
            //{
            //    Console.WriteLine($"Key: {dicionario.Key}, Value: {dicionario.Value}");
            //}

            #endregion


            #region Ler Ficheiro 

            string path = @"c:\temp\Benfica\Benfica1.txt";

            if (File.Exists(path))
            {
                // Abrir o ficheiro e ler linha a linha
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("O ficheiro não existe no caminho especificado.");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
