// Задайте массив вещественных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
int dif = 0;
int min = 0;
int max = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(-100,100);   
    
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
      
}

dif = max - min;
Console.WriteLine(String.Join(" ",numbers));
Console.WriteLine("Максимальное " +max);
Console.WriteLine("Минимальное " +min);
Console.WriteLine("разница " +dif);
