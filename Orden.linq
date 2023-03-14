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
		
			var OrdeResultado = from s in empleadoList
                   orderby s.Nombre
                   select s;
		
			var OrdeResultaDesc = from s in empleadoList
                   orderby s.Nombre descending
                   select s;
				   
			Console.WriteLine("Orden ascendente:");
			
			foreach (var e in OrdeResultado)
        	Console.WriteLine(e.Nombre);
			
			Console.WriteLine("Orden desendente:");
		
			foreach (var t in OrdeResultaDesc)
        	Console.WriteLine(t.Nombre);

    }
}

public class Empleado
{
    public int EmpleadoId { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
