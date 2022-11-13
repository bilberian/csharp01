// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число (число B): ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И еще одно число (число С), пожалуйста: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > number3)
{
    Console.WriteLine($"Число А ({numberA}) - максимальное из трех введенных чисел");
}
else if (numberB > numberA && numberB > number3)
{
    Console.WriteLine($"Число B ({numberB}) - максимальное из трех введенных чисел");
}
else if (number3 > numberA && number3 > numberB)
{
    Console.WriteLine($"Число C ({number3}) - максимальное из трех введенных чисел");
}
else
{
    Console.WriteLine("Не получается сравнить. Возможно, все три введенных числа равны");
}