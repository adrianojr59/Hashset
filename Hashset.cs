using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Hashset
{

    public class Produto
    {
        public int Id { get; set; } 
        public  string Nome { get; set; }

        public Produto (int id , string nome)
        {

            Id=id;
            Nome=nome;

        }
       

        public Produto() { }
       
       

        public HashSet<Produto> hashProduto = new HashSet<Produto>(new ProdutoComparar());


        private class ProdutoComparar : IEqualityComparer<Produto> 
        {
            public bool Equals(Produto? x, Produto? y)
            {
                return x.Nome.Equals(y.Nome,StringComparison.CurrentCultureIgnoreCase);   
            }


            public int GetHashCode(Produto obj)
            {
                return obj.Nome.ToUpper().GetHashCode();
            }
        }





    
          





    public override string ToString()
        {
            return "ID "+Id + "\nNOME: "+Nome ;
        }

        
    }



}
