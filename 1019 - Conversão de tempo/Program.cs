using System; 

class URI {

    static void Main(string[] args) { 
        int seg = int.Parse(Console.ReadLine());
        int h = seg/3600;
        seg = seg % 3600;
        int m = seg/60;
        int s = seg% 60;
        
        Console.WriteLine($"{h}:{m}:{s}");
       
        

        

    }

}
