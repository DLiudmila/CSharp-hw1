Console.WriteLine("Введите целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

switch (n1 % 2)
{
    case 1:
        Console.WriteLine(n1 + " не четное");
        break;
    case 0:
        Console.WriteLine(n1 + " четное");
        break;
    default:
        break;
}