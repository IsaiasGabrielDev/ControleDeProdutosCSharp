using System;
using System.Globalization;

namespace ControledeProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantd;

        public double ValorTotal()
        {
             return Quantd * Preco;
        }

        
        public void AdicionarProduto(int quantidade)
        {
            Quantd += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            
            Quantd -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " 
            + Quantd 
            + " unidades, Total: R$ " 
            + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
