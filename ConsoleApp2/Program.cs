Double[] Sueldo;
Sueldo = new Double[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("ingrese el sueldo del empelado" + (i + 1));
    Sueldo[i] = Double.Parse(Console.ReadLine());
}
    Console.WriteLine("Los sueldos ingresado son:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write("\t" + Sueldo[i]);

    }
  Console.ReadKey();




