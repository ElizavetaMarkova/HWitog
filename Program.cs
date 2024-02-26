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

string[] new_array = new string[n];
int j = 0;

for(int i = 0; i < n; i++)
{
    if(array[i].Length <= 3)
    {
      new_array[j] = array[i];
      j++;
    }
}

Console.WriteLine("Вывод нового массива: ");
foreach(string e in new_array) Console.WriteLine(e);