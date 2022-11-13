// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число (число B): ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine("Ведденные вами числа равны");
}
else if (numberA > numberB)
{
    Console.WriteLine($"Число А ({numberA}) больше числа В ({numberB})");
}
else
{
    Console.WriteLine($"Число A ({numberA}) меньше числа В ({numberB})");
}
