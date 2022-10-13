Console.Write("ВВедите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());

if(numberB / numberA == numberA)
    {
    Console.WriteLine($"{numberB} является квадратом числа {numberA}");
    }
else 
    {
    Console.WriteLine($"{numberB} не является квадратом числа {numberA}");
    }