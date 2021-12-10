using Hashset;

char option;



Produto prod = new Produto();

do { 

Console.WriteLine("ID: ");
int id =int.Parse(Console.ReadLine());

Console.WriteLine("NOME: ");
string nome = Console.ReadLine();


     prod.Id = id;
     prod.Nome = nome ;
    Console.WriteLine(prod.hashProduto.Contains(prod));

    if (prod.hashProduto.Contains(prod))
    {
        Console.WriteLine("produto Já Existe");

    }
    else 
    

        prod.hashProduto.Add(new Produto(id ,nome));

    
    Console.WriteLine("Cadastrar (S/N) ");
    option = char.Parse(Console.ReadLine());
}

while (option == 's' || option == 'S');




   

foreach (var item in  prod.hashProduto )
{
   
    Console.WriteLine(item);
    Console.WriteLine("HashCode " + item.GetHashCode());

}



