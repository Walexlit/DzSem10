// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от M до N в обратном порядке. M = 1; N = 5. -> «5, 4, 3, 2, 1»

Console.WriteLine("введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void Nat (int a, int b)
{
if (b>a)
{
   Nat(a+1,b);
}
Console.Write($"{a}");
}
Nat(M,N);






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

// Console.WriteLine("введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int Nat(int a, int b)
// {
//     if ( a<b)
//     {
//         sum +=  a + 1;
//         Nat(a + 1, b);
        
//     }
//    return sum+a;
    

// }
// Console.WriteLine($"сумма элементов от {M} до {N} равна {Nat(M, N)}"); 