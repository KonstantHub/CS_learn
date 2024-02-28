//int n = 5;
// for (int neg = 2; neg <= n; neg = neg + 2)
// {
//     Console.Write(neg + " ");
//        }
// 

// int num = 42;
// if (num % 7 != 0 || num % 23 != 0)
// {
//     Console.WriteLine(num + " не кратно одновременно 7 и 23");
// }

// else
// {
//     Console.WriteLine(num + " кратно одновременно 7 и 23");
// }

// int x = -10;
// int y = 5;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("I");
// }
// if (x > 0 && y < 0)
// {
//   Console.WriteLine("IV");
// }
// if (x < 0 && y > 0)
// {
//    Console.WriteLine("II");
// }
// if (x < 0 && y < 0)
// {
//    Console.WriteLine("III");
//     }
// int num = 88;
// int first = num / 10;
// int sec = num % 10;
// if (first >= sec)
// {
//     Console.WriteLine(first);
// }
// else
// {
//     Console.WriteLine(sec);
// }

int n = 196;
if (n < 10)
{
    Console.Write(n);
}
else
{
    while (n > 0)
    {
        int curDig = n % 10;
        n = n / 10;
        if (n > 0)
        {
            Console.Write(curDig + ",");
        }
        else
        {
            Console.Write(curDig);
        }
    }
    {

    }
}