int[] array = {1, 21, 13, 4, 51, 16, 71, 18};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}