using Aula_22___Exercicio_3_POO.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___Exercicio_3_POO
{
    class Colaborador
    {
        public string Nome { get; set; }
        public NivelOperario Nivel { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
        public List<CustoHora> ListaCustoHora { get; private set; } = new List<CustoHora>();

        public Colaborador() { }

        public Colaborador(string nomeParametro, NivelOperario nivelParametro, double salarioParametro, Departamento departamentoParametro)
        {
            Nome = nomeParametro;
            Nivel = nivelParametro;
            Salario = salarioParametro;
            Departamento = departamentoParametro;
        }

        public void AdicionaContrato(CustoHora custoHoraParametro)
        {
            ListaCustoHora.Add(custoHoraParametro);
        }

        public void RemoverContrato(CustoHora custoHoraParametro)
        {
            ListaCustoHora.Remove(custoHoraParametro);
        }

        public Double ValorAcrescentado(int ano, int mes)
        {
            double soma = Salario;

            foreach (CustoHora custoHora in ListaCustoHora)
            {
                if (custoHora.DataAtributo.Month == mes && custoHora.DataAtributo.Year == ano)
                {
                    soma += custoHora.ValorTotal();
                }
            }

            return soma;
        }
    }
}
