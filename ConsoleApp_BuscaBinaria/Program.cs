using System;

namespace ConsoleApp_BuscaBinaria
{
    class Program
    {

        public static bool buscaBinaria(int[] relacaoIdades, int num)
        {
            int esq = 0;
            int dir = relacaoIdades.Length - 1;
            while (esq <= dir)
            {
                int meio = (esq + dir) / 2;
                if (relacaoIdades[meio] == num) return true;
                if (relacaoIdades[meio] < num) esq = meio + 1;
                else dir = meio - 1;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] idadesRelacao = new int[] { 14, 16, 17, 19 };

            for (int i = 0; i < idadesRelacao.Length; i++)
            {
                Console.WriteLine("Idades são {0}", idadesRelacao[i]);
            }

            bool resultado = buscaBinaria(idadesRelacao, 20);


            Console.WriteLine("Resultado {0}", resultado);

            Console.ReadLine();
        }
    }
}
