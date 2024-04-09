using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class ClasseProduto
    {
        int codigo;
       public string nome;
       public decimal preco;
       public int quantidade;
       public string foto;
       public int fornecedor;
        //construtor da classe produto
    public ClasseProduto()
        {
            //inicializar as variáveis
            codigo = 0;
            nome = "";
            preco = 0;
            quantidade = 0;
            foto = "";
            fornecedor = 0;

        }
        
    }
}
