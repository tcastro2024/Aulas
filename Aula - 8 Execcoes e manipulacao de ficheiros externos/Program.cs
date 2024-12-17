/*
* by lufer
* 
* Adaptado de C# Unleshead
* Manipulação de Ficheiros e Pastas
* 
* Ver: 
* http://msdn.microsoft.com/en-us/library/k3352a4t%28v=vs.110%29.aspx
* http://csharp.net-informations.com/file/csharp-file-class.htm
* 
* Streams: reading and writing bytes
*      : FileStream | Stream
*      
* Writers/Readers: reading and writing characters
*      : StreamReader/StreamWriter
* 
* 
* */
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
    enum X
    {
        A,
        B,
        C
    }

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

            #region Enumerados (REVISÔES)

            //foreach (X foo in Enum.GetValues(typeof(X)))
            //{
            //    Console.WriteLine(foo + "= " + ((int)foo).ToString());

            //}

            //foreach (string foo in Enum.GetNames(typeof(X)))
            //{
            //    Console.WriteLine(foo);
            //}

            #endregion

            #region Drives

            //foreach (var drive in DriveInfo.GetDrives())
            //{
            //    Console.WriteLine("{0} - {1}", drive.Name, drive.DriveType);
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine(drive.DriveFormat);
            //        Console.WriteLine(string.IsNullOrEmpty(drive.VolumeLabel) ? "(no label)" : drive.VolumeLabel);
            //        Console.WriteLine("{0} free of {1}", DoThings.GetSize(drive.TotalFreeSpace), DoThings.GetSize(drive.TotalSize));
            //    }
            //    else
            //    {
            //        Console.WriteLine("(No disk present)");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Folders

            //Console.Write("Path: ");
            //var path = Console.ReadLine();
            //Console.WriteLine();
            //var folder = new DirectoryInfo(path);
            //if (folder.Exists)
            //{
            //    Console.WriteLine("Full name: " + folder.FullName);
            //    Console.WriteLine("Name: " + folder.Name);
            //    Console.WriteLine("Created: " + folder.CreationTime);
            //    Console.WriteLine("Parent: " + folder.Parent.FullName);
            //    Console.WriteLine("Root: " + folder.Root);
            //}


            //try
            //{
            //    if (folder.Exists)
            //    {
            //        foreach (var exe in folder.EnumerateFiles("*.exe", SearchOption.AllDirectories))
            //            Console.WriteLine(exe.FullName);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region TextFiles

            bool b = DoThings.SaveToFile(@"c:\temp\Campeao.txt", "O Benfica é o maior");

            #endregion

            #region File and Collections

            Pessoas p = new Pessoas();
            p.InsertPerson(new Pessoa(12));
            p.InsertPerson(new Pessoa(13));
            p.InsertPerson(new Pessoa(14));
            p.Show();           //É possível?
            //p.Sort();           //É possível?
            //Preserva Hashtable
            p.Save(@"c:\temp\hashData.bin");

            //limpa Hashtable
            p.Limpa();
            p.Show();
            p.Load(@"c:\temp\hashData.bin");
            p.Show();
            Console.ReadKey();
            p.SetHashFields();
            p.Show();

            #endregion


            #region Files and Generics

            #region Colmeias

            Colmeia c1 = new Colmeia(1, DateTime.Now);
            Apiarios a = new Apiarios("APIMIL");
            a.AddColmeia(c1);
            a.AddColmeia(new Colmeia(2, DateTime.Now));
            a.AddColmeia(new Colmeia(3, DateTime.Now));
            a.AddColmeia(new Colmeia(4, DateTime.Now));

            Console.WriteLine("Inicio Apiario ");
            Console.WriteLine(a.MyToString());

            a.SaveApiario(@"c:\temp\apiario.bin");
            a.SaveApiarioXML(@"c:\temp\apiario.xml");

            a.ClearApiario();

            Console.WriteLine("Apiario Limpo ");
            Console.WriteLine(a.MyToString());

            a.LoadApiario(@"c:\temp\apiario.bin");

            Console.WriteLine("Fim Apiario ");
            Console.WriteLine(a.MyToString());

            a.ClearApiario();

            Console.WriteLine("Apiario XML ");
            a.LoadApiarioXML(@"c:\temp\apiario.xml");
            Console.WriteLine(a.MyToString());

            #endregion

            #region Apicultura

            Apicultura.AddApiario("APIMIL", a);
            Console.WriteLine(Apicultura.MyToString());
            Apicultura.SaveApicultura(@"c:\temp\fnap.bin");
            Apicultura.ClearApicultura();

            Console.WriteLine("Apiario Limpo ");
            Console.WriteLine(Apicultura.MyToString());

            Console.WriteLine("Apiario em Ficheiro:");
            Apicultura.LoadApicultura(@"c:\temp\fnap.bin");
            Console.WriteLine(Apicultura.MyToString());


            #endregion


            #endregion

            Console.ReadKey();
        }
    }
}
