/*Hacer un programa que lea 3 numeros, si los numeros son iguales, se calculara el promedio de lo contrario se sumaran los numeros
que son pares o impares entre ellos y por ultimo muestra el mayor y menor de ellos */
float a, b, c;
Console.Write("Escribe el primero numero -->");
a = (float) Convert.ToDecimal(Console.ReadLine());
Console.Write("Escribe el segundo numero -->");
b = (float)Convert.ToDecimal(Console.ReadLine());
Console.Write("Escribe el tercer numero -->");
c = (float)Convert.ToDecimal(Console.ReadLine());

if ((a == b) && (a == c) && (b == a) && (b == c) && (c == a) && (c == b))
{
    Console.Write("Todos los numero son iguales, el promedio es{0}", (a + b + c)/3);
}

//NUMEROS PARES 

if ((a % 2 == 0)&&(b% 2 == 0))
{
    Console.WriteLine("La suma de los numero pares son --> {0}", a + b );
}else if ((b % 2 == 0)&&(c % 2 == 0))
{
    Console.WriteLine("La suma de los numero pares son --> {0}", b + c);
}else if((a % 2 == 0)&&(c % 2== 0))
{
    Console.WriteLine("La suma de los numero pares son --> {0}", a + c);
}
if((a % 2==0)&&(b % 2 == 0) && (c % 2 == 0)){
    Console.WriteLine("La suma de los numero pares son --> {0}", a + b + c);
}

//NUMEROS IMPARES

if((a % 2 == 1) && (b % 2 == 1))
{
    Console.WriteLine("La suma de los numero impares son --> {0}", a + b);
}else if ((b % 2 == 1) && (c % 2 == 1))
{
    Console.WriteLine("La suma de los numero impares son --> {0}", b + c);
}
else if ((a % 2 == 1) && (c % 2 == 1))
{
    Console.WriteLine("La suma de los numero impares son --> {0}", a + c);
}
if ((a % 2 == 1) && (b % 2 == 1) && (c % 2 == 1))
{
    Console.WriteLine("La suma de los numero impares son --> {0}", a + b + c);
}



if ((a> b)&& (a > c)){
    Console.WriteLine("El numero mayor es --> {0}", a);
}
if ((b > a) && (b > c))
{
    Console.WriteLine("El numero mayor es --> {0}", b);
}
if ((c > a) && (c > b))
{
    Console.WriteLine("El numero mayor es --> {0}", c);
}

if ((a < b) && (a < c))
{
    Console.WriteLine("El numero menor es --> {0}", a);
}
if ((b < a) && (b < c))
{
    Console.WriteLine("El numero menor es --> {0}", b);
}
if ((c < a) && (c < b))
{
    Console.WriteLine("El numero menor es --> {0}", c);
}