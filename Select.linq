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
		var resultado = from s in empleadoList
						   select new { Nombre = "Mr. " + s.Nombre, Edad = s.Edad }; 
		
		// iterate selectResult
		foreach (var item in resultado)
			Console.WriteLine("Empleado : {0}, Age: {1}", item.Nombre, item.Edad);
		
    }
}

public class Empleado
{
    public int EmpleadoId { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
