Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;

while(count <= num)
{
    count++;
    Console.Write(Math.Pow(count, 3));
    if (count <= num)
        Console.Write(", ");
}
