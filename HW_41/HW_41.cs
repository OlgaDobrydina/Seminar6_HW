// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел - ");
int quantity = int.Parse(Console.ReadLine());
int result = CountNumber(quantity);
Console.WriteLine($"Количество чисел больше 0 - {result}");


int CountNumber(int number)
{
    int count = 0;
    for(int i = 1; i <= number; i++)
    {
        Console.Write($"Введите число {i} = ");
        int quantity = int.Parse(Console.ReadLine());
        if(quantity > 0) count++;
    }
    return count;
}