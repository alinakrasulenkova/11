// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;

int [] GetArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
numbers[i]= new Random().Next(99,1000);   
    if (numbers [i] % 2 == 0)
    {
        count++;
    }
}
return numbers;
}
GetArray(numbers);
Console.WriteLine(String.Join(" ",numbers));
Console.WriteLine(count);