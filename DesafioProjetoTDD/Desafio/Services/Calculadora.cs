using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Services
{
    public class Calculadora
    {

        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            historico.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3,historico.Count - 3);
            return historico;
        }

    }
}
