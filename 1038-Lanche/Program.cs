using System; 

class URI {

    static void Main(string[] args) { 
       string [] entrada = Console.ReadLine().Split(' ');
       int codigo = int.Parse(entrada[0]);
       int quantidade = int.Parse(entrada[1]);
        double preco = 0;
        switch (codigo)
        {
            case 1:
            preco = 4.00;
            break;
            
            case 2:
            preco = 4.50;
            break;
            
            case 3:
            preco = 5.00;
            break;
            
            case 4:
            preco = 2.00;
            break;
            
            case 5:
            preco = 1.50;
            break;
        }
        double total = preco * quantidade;
        Console.WriteLine($"Total: R$ {total:F2}");
    }

}
