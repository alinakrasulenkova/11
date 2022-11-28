//  Задайте одномерный массив, заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int sum=0;
int [] GetArray(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
numbers[i]= new Random().Next(0,100);   
    if (i % 2 == 0)
    {
        sum += numbers[i];
    }
}
return numbers;
}
GetArray(numbers);
Console.WriteLine(String.Join(" ",numbers));
Console.WriteLine(sum);

