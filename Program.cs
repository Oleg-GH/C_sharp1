Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int ostatok = number%10;

Console.WriteLine($"{ostatok}");