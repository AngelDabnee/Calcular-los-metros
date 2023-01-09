// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Permite que usuario capture la cantidad de cuantos metros de tubo se necesitan instalar en una construcción. Imprime cuantas pulgadas son su equivalente.");
//Datos de entrada
double metros = 0;
double pulgadas = 0;
const double eqPulgada = 39.3701;//Equivalente de una pulgda a metro
//Proceso
Console.WriteLine("Captura los metros de tubo que necesitas ");
metros = double.Parse(Console.ReadLine());
pulgadas = metros * eqPulgada;
//Datos de salida
Console.WriteLine($"La cantidad de pulgadas que necesitas es {pulgadas} in");
