//Hacer un programa que lea nombre, cantidad y precio de 5 productos, el programa mostrara al finalizar el porcentaje de iva
//y el total a pagar
using System.Runtime.CompilerServices;

double  pr1,cant1;
String p1;
double totlap = 0.0, totlp = 0.0, iva = 0.0, ivaT=0.0 ;

for( int i=0; i<=1; i++)
    {
    Console.WriteLine("Ingresa el nombre del producto");
    p1 =Convert.ToString(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad del producto");
    cant1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa el precio del producto");
    pr1 =Convert.ToDouble(Console.ReadLine());
    totlp = cant1 * pr1;
    totlap = totlap + totlp;
    iva = totlap * .16;
    ivaT = totlap + iva;
    Console.WriteLine("Total a pagar de estos productos {0}", totlp);

}

Console.WriteLine(" El total sin iva es {0} ",totlap);
Console.WriteLine("El iva de los productos son {0}", iva);
Console.WriteLine("El iva de los productos son {0}", ivaT);

