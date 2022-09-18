int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
        result = arg2;
    if (arg3 > result)
        result = arg3;
    return result;
}

int a1 = 55;
int b1 = 676;
int c1 = 1;
int d1 = 432;

int max1 = Max(a1, b1, c1, d1);

Console.WriteLine(max1);