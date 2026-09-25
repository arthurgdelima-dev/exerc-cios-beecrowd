using System; 

class URI {

    static void Main(string[] args) { 
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int anos = n / 365;
        int resto = n % 365;
        int meses = resto / 30;
        int dias = resto % 30;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");

    }

}
