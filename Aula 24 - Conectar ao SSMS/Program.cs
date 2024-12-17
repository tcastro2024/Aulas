using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Aula_24___Conectar_ao_SSMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                String de Conexão:
                Trusted_Connection=True indica que se está a utilizar a autenticação do Windows. 
                YOUR_SERVER_NAME: nome do servidor, por norma é o nome da vossa máquina 
                e podem ver pesquisando por system no search do Windows.
                TestDB: substituir por a vossa base de dados.

                A classe SqlConnection gerência a conexão a base de dados. 
                É recomendável utilizar um bloco using para garantir que a conexão 
                seja fechada após a utilização.
                SqlCommand é utilizado para executar comandos SQL ou operações CRUD, 
                como consultas (SELECT) ou modificações (INSERT, UPDATE, DELETE).
                SqlDataReader permite percorrer os resultados de uma consulta.
            */

            //string connectionString = "Server=YOUR_SERVER_NAME;Database=TestDB;Trusted_Connection=True;";
            //string connectionString = "Server=DESKTOP-V4SOL10;Database=ProjetoLP2;Trusted_Connection=True;";
            //
            //OU utilizar a configuração criada no App.config
            //
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Query para selecionar dados
            string query = "SELECT * FROM Produtos";

            // Inicicar a conexão com a base de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso!");

                    // Executando a consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["ID"]}, NomeDoProduto: {reader["NomeProduto"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
