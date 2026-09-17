using System; 

class URI {

    static void Main(string[] args) { 
        int valor = int.Parse(Console.ReadLine());
        int original = valor;
        int [] notas = {100, 50, 20, 10, 5, 2, 1};
        Console.WriteLine(original);
        for (int i = 0; i < notas.Length; i++)
        {
            int qtd = valor / notas[i];
            Console.WriteLine($"{qtd} nota(s) de R$ {notas[i]},00");
            valor = valor % notas[i];
        }
        
    

    }

}
