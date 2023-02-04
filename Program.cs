// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Enter the values separated by a space: ");
string Values = Convert.ToString(Console.ReadLine());

string[] X = Values.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int[] array = X.Select(Int32.Parse).ToArray(); // Преобразование массива строк, в массив числовых значений
int quantity = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i] > 0)
    {
        quantity++;
    }
}
Console.WriteLine();
Console.WriteLine(quantity);
