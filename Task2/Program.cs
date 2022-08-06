Console.WriteLine("Введите целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
   Console.WriteLine(n1 + " больше чем " + n2); 
}
else if (n1 < n2)
{
    Console.WriteLine(n2 + " больше чем " + n1);
}
else
{
    Console.WriteLine(n2 + " равно " + n1);
}