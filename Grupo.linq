<Query Kind="Program" />

public class Program
{
    public static void Main()
    {
        var empleadoList = new List<Empleado>()
        {
            new Empleado() { EmpleadoId = 1, Nombre = "Jack", Edad = 20 },
            new Empleado() { EmpleadoId = 2, Nombre = "Brayan", Edad = 12 },
            new Empleado() { EmpleadoId = 3, Nombre = "Mario", Edad = 22 },
            new Empleado() { EmpleadoId = 4, Nombre = "Luis", Edad = 17 },
            new Empleado() { EmpleadoId = 5, Nombre = "Axel", Edad = 21 }
        };
		
		var grupo = from s in empleadoList
                    group s by s.Edad;
					
		foreach (var edadGrupo in grupo)
		{
		
			foreach(Empleado s in edadGrupo) 
			Console.WriteLine("Nombre del empleado: {0}", s.Nombre);
				
			Console.WriteLine("Edad: {0}", edadGrupo.Key); 
					 
		}

    }
}

public class Empleado
{
    public int EmpleadoId { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
