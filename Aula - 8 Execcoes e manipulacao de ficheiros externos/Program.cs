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

            #region Escrever Ficheiro

            //Opcionalmente concatenar o nome do ficheiro com um ID explorar o Randow
            //colocar a extensão
            string path = @"c:\temp\Logs1\Log_123.txt";


            //Aplicar num tratamento de erro - TODO == por fazer
            try
            {
                // Verifica se o diretório existe e cria se não existir
                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Usa StreamWriter para abrir ou criar o ficheiro e escrever conteúdo e esmagar o existente
                //using (StreamWriter sw = new StreamWriter(path))

                // Usa StreamWriter para abrir o ficheiro em modo de append (acrescentar)
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Linha 1: Este é o conteúdo da primeira linha.");
                    sw.WriteLine("Linha 2: Aqui vai a segunda linha.");
                    sw.WriteLine("Linha 3: E esta é a terceira linha.");
                    sw.WriteLine("Exception Invalid Number ...");
                    sw.WriteLine("Exception 2: Invalid Number ...");
                }

                Console.WriteLine("O ficheiro foi escrito com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao escrever o ficheiro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Acabou de escrever");
            }

            #endregion


            #region Ler Ficheiro 

            //path = @"c:\temp\Benfica\Benfica1.txt";

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
