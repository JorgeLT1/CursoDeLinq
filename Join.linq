<Query Kind="Program" />

public class Program
{
    public static void Main()
    {
		IList<string> Empleados1 = new List<string>() 
		{ 
            "Jack",
            "Brayan",
            "Mario",
         	"Axel"
		};
		
		IList<string> Empleados2 = new List<string>() 
		{ 
            "Jack",
            "Brayan",
            "Luis",
            "Rafael",
		};
		
		var unirse = Empleados1.Join(
                      Empleados2,  
                      Empleados1 => Empleados1,   
                      Empleados2 => Empleados2,  
                      (Empleados1, Empleados2) => Empleados1);		
		
		foreach (var s in unirse)
		{			
			Console.WriteLine(s);
		}
		
    }
}


