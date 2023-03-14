<Query Kind="Program" />

public class Program
{
    public static void Main()
    {
		IList<int> Suma = new List<int>() { 1, 24, 23, 3, 45, 32 };

		var resultado = Suma.Sum();
		var NumMax = Suma.Max();
		
		Console.WriteLine("Suma total de los elementos: {0}", resultado);
		
		var SumaDeElementos = Suma.Sum(i => {
			if(i%2 == 0)
				return i;
			
			return 0;
		});
		
		Console.WriteLine("Suma de los elementos pares: {0}", SumaDeElementos );
		Console.WriteLine("El elemento mas grande es: {0}", NumMax);
    }
}
