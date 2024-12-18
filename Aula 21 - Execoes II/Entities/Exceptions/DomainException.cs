using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___Execoes_II.Entities.Exceptions
{
    // Classe para gerenciar exceções de domínio com códigos
    class DomainException : ApplicationException
    {
        // Dicionário para mapear códigos a mensagens
        private static readonly Dictionary<int, string> ErrorMessages = new Dictionary<int, string>
        {
            { 1001, "The amount exceeds withdraw limit" },
            { 1002, "Not enough balance" },
            { 1003, "Invalid account number" },
            { 1004, "Account holder name cannot be empty" }
        };

        public int Code { get; }

        // Construtor usando apenas a mensagem
        public DomainException(string message) : base(message)
        {
        }

        // Construtor usando código de erro
        // Verificar que estamos a receber o método da própria classe 
        // como parametro
        public DomainException(int code) : base(GetMessageFromCode(code))
        {
            Code = code;
        }

        // Método para buscar mensagem pelo código
        private static string GetMessageFromCode(int code)
        {
            if (ErrorMessages.TryGetValue(code, out var message))
            {
                return message;
            }
            return "Unknown error code";
        }
    }

}
