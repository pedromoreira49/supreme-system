using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    public static class OperacoesAritmeticas // Uma classe estática não pode ser instanciada, não pode herdar e nem ser herdada, ela só pode ter membros estáticos
    {

        /// <summary>
        /// Operação básica de Adição
        /// </summary>
        /// <param name="parcela1">
        /// A parcela 1
        /// </param>
        /// <param name="parcela2">
        /// A parcela 2
        /// </param>
        /// <returns>O resultado da Adição</returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação básica de Subtrção
        /// </summary>
        /// <param name="minuando">
        /// O minuando
        /// </param>
        /// <param name="subtraendo">
        /// O subtraendo
        /// </param>
        /// <returns>O resultado da subtração</returns>

        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

        /// <summary>
        /// Operação básica de Multiplicação
        /// </summary>
        /// <param name="multiplicando">
        /// O multiplicando
        /// </param>
        /// <param name="multiplicador">
        /// O multiplicador
        /// </param>
        /// <returns>O resultado da multiplicação</returns>

        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        /// <summary>
        /// Opereção básica de Divisão
        /// </summary>
        /// <param name="dividendo">
        /// O dividendo.
        /// </param>
        /// <param name="divisor">
        /// O divisor.
        /// </param>
        /// <returns>O resultado da divisão.</returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
