using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeInventario
{
    public static class Inventario
    {
        private static Dictionary<string, int> produtos = new Dictionary<string, int>();

        public static void AdicionarProduto(string nome, int quantidade)
        {
            if (produtos.ContainsKey(nome))
            {
                produtos[nome] += quantidade;
            }
            else
            {
                produtos[nome] = quantidade;
            }
        }

        public static int ObterQuantidadeProduto(string nome)
        {
            return produtos.ContainsKey(nome) ? produtos[nome] : 0;
        }

        // Método para limpar o inventário
        public static void ResetarInventario()
        {
            produtos.Clear();
        }
    }
}
