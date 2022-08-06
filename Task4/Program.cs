int[] array = new int[3];
Console.WriteLine("Введите целое число: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
array[2] = Convert.ToInt32(Console.ReadLine());
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }    
}
Console.WriteLine("Максимальное число: " + max);



