//Hacer un programa que lea un numero, si es el numero no es par. se volvera a pedir, de lo contrario mostrara todos
//los numero que hay entre el 0 y el 
//Alvaro Dannte Reyes Mercado
int a;
int x;
do
{
Console.WriteLine("Ingrese un numero");
a = Convert.ToInt32(Console.ReadLine());

} while ((a%2==1)||(a<=0));
{
    Console.WriteLine("Los datos son");
    for (x=0; x <= a; x++)
    {
        Console.WriteLine(x);
    }
}
