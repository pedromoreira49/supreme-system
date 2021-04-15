using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    public static class OperacoesAritmeticas // Uma classe estática não pode ser instanciada, não pode herdar e nem ser herdada, ela só pode ter membros estáticos
    {
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

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
