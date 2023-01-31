// See https://aka.ms/new-console-template for more information
//Hacer un programa que lea 4 calificaciones y obtenga el promedio 

float a, b, c, d, cal;
Console.WriteLine("Escribe un valor");
a = (float)Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe un valor");
b = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe un valor");
c = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escribe un valor");
d = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
cal = (a + b + c + d)/ 4;
Console.WriteLine("El resultado es: ");
Console.WriteLine(cal);

                   