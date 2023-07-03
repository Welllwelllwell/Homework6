// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
System.Console.Write("Введите количество чисел: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];
FillArray(array);
int count = 0;
Zero(array);

void FillArray(int[] array)
{
    for (int z = 0; z < array.Length; z++)
    {
        System.Console.Write("Введите чисело: ");
        array[z] = Convert.ToInt32(Console.ReadLine());
    }
}
void Zero(int[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
      if(array[x]>0)
      {
        count++;
      }
    }
   System.Console.WriteLine(count);
}
