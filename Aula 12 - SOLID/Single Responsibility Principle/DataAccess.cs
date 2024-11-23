using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    class DataAccess
    {

        #region Metodos 
        public static void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");

            /*Sempre que for feito um Novo Registo vai ser disponibilizada esta informação
              mas e se o pretendido for obter o log de entrada de ficheiros
              ou de eventos de pedidos feitos ao programa
              vamos ter de mudar a nossa classe ou pior PONDERAR DUPLICAR MÉTODOS IGUAIS????
            
              SOLUÇÃO: criar uma classe para escrita de logs
            */
            //Console.WriteLine("Logged Time:" 
            //    + DateTime.Now.ToLongTimeString()
            //    + " Log  Data insertion completed successfully");
        }

        #endregion
    }
}
