using System; 

class URI {

    static void Main(string[] args) { 
        string [] dados1 = Console.ReadLine().Split(' ');
        int cod1;
        int qtd1;
        double val1;
        int.TryParse(dados1[0], out cod1);
        int.TryParse(dados1[1], out qtd1);
        double.TryParse(dados1[2], out val1);
        
        string [] dados2 = Console.ReadLine().Split(' ');
        int cod2;
        int qtd2;
        double val2;
        int.TryParse(dados2[0], out cod2);
        int.TryParse(dados2[1], out qtd2);
        double.TryParse(dados2[2], out val2);
        
        double total = qtd1 * val1 + qtd2 * val2;
        
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");


    }

}
