int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 16874;
int b1 = 4563;
int c1 = 57;
int a2 = 6576;
int b2 = 345;
int c2 = 4567;
int a3 = 97;
int b3 = 789;
int c3 = 347;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
    
Console.WriteLine(max);