using MiPrimerApp;
 Tanque tanque1 = new Tanque(); 

for (int i = 0; i < tanque1.mediciones.length; i++)
{
    Console.WriteLine($"Ingrese la medición {i + 1}: ");

        var medicion = int.Parse(Console.ReadLine() );

    tanque1.RegistrarMedicion( medicion);
}

double promedio = tanque1.CalcularPromedio();
Console.WriteLine(promedio);



