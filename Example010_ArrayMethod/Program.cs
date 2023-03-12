int[] array = { 1, 12, 34, 43, 2, 5, 65, 6, 7, 34 };

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}