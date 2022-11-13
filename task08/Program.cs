// Программа, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2; // четные числа либо с 0, либо с 2, но не с 1, как в задаче. немного смутило
int countneg = -2;

if (number > -2 && number < 2)
{
    Console.WriteLine("От 1 до введенного числа нет четных чисел");
}
else if (number <= -2)
{
    while (countneg >= number) {
    Console.Write(countneg + " ");
    countneg -= 2;
    }
}
else
 if (number >= 2)
{
    while (count <= number) {
    Console.Write(count + " ");
    count += 2;
    }
}