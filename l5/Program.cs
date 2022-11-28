int [] array = {-8,5,4,6,7,-2};
int [] array2 =new int[array.Length/2+array.Length%2];

int index =array.Length -1;


for (int i = 0; i < array2.Length; i++)
{
array2[i]= array[i]*array[index-i];

if (i==index-i)
{
array2[i]= array[i];
}
}

Console.WriteLine(String.Join(" ", array2));