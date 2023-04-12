// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите целые числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)  // цикл выявления значений больше 0
{
  if (numbers[i] > 0)
  {
    sum++;
  }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {sum}");


int[] StringToNum(string input)   // Метод преобразования чисел в массив
{
  int count = 1;
  for (int i = 0; i < input.Length; i++)  // Цикл для пропуска запятых и выборки чисел
  {
    if (input[i] == ',')
    {
      count++;
    }
  }

  int[] numbers = new int[count];
  int index = 0;

  for (int i = 0; i < input.Length; i++)  // 
  {
    string temp = "";

    while (input[i] != ',')
    {
      if (i != input.Length - 1)
      {
        temp += input[i].ToString();
        i++;
      }
      else
      {
        temp += input[i].ToString();
        break;
      }
    }
    numbers[index] = Convert.ToInt32(temp);
    index++;
  }
  return numbers;
}

void PrintArray(int[] array)   // метод вывода на печать
{
  Console.Write("[ ");
  int i = 0;
  while ( i < array.Length - 1)
  {
    Console.Write($"{array[i]} | ");
     i++;
  }
  Console.Write($"{array[i]} ]");
}






