double[] array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
double findMin(double[] numbers)
{
    double min = numbers[0];
    foreach (double e in numbers)
    {
        if (e < min)
        {
            min = e;
        }
    }
    return min;
}

double findMax(double[] numbers)
{
    double max = 0;
    foreach (double e in numbers)
    {
        if (e > max)
        {
            max = e;
        }
    }
    return max;
}
Console.Write(findMax(array) - findMin(array));
