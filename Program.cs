Console.Clear();

// Ввод количества строк
Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];

// Ввод строк
for (int i = 0; i < n; i++)
{
  Console.WriteLine("Введите строку {0}:", i + 1);
  array[i] = Console.ReadLine();
}

