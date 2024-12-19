using System;

namespace c_assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1)
            //when we pass value type by value and changed in their value in the function
            //it will not be changed in the original one
            //if we pass it by reference it will be changed in the original one
            //ex: 
            //int a = 1 , b = 2 ;
            //static void change(int a, int b)
            //{
            //    a = 5;
            //    b = 6 ;
            //}
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //change(a, b);
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //static void changebyref(ref int a, ref int b)
            //{
            //    a = 5;
            //    b = 6;
            //}
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //changebyref(ref a, ref b);
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            #endregion

            #region question 2)
            //when we pass reference type by value or by reference and changed in their value in the function
            //it will be changed in the original one but only when you do an operation on it if you want to change the 
            //values of the array itself it will changes only with passing by reference
            //ex: 
            //int[] arr1 = { 1, 2, 3 };
            //static void changereftype(int[] arr1)
            //{
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        arr1[i] = i + 4;
            //    }
            //}
            //foreach (int x in arr1)
            //    Console.WriteLine(x);
            //changereftype(arr1);
            //foreach (int x in arr1)
            //    Console.WriteLine(x);

            //static void changereftypebyref(ref int[] arr1)
            //{
            //    arr1 = new int[] {4,5,6};
            //}
            //foreach (int x in arr1)
            //    Console.WriteLine(x);
            //changereftypebyref(ref arr1);
            //foreach (int x in arr1)
            //    Console.WriteLine(x);

            #endregion

            #region question 3)
            //static void sumandsub(int num1, int num2 , out int sum , out int sub)
            //{
            //    sum = num1 + num2;
            //    sub = num1 - num2;
            //}
            //int num1 = 10;
            //int num2 = 5;
            //int sum = 0;
            //int sub = 0;
            //sumandsub(num1 , num2 , out sum ,out  sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);


            #endregion

            #region question 4)
            //static int sumofdigits(int num)
            //{
            //    int sum = 0;
            //    sum += (num / 10);
            //    sum += (num % 10);
            //    return sum;
            //}
            //int number = 25;
            //int result = sumofdigits(number);
            //Console.WriteLine(result);

            #endregion

            #region question 5)
            //static bool IsPrime(int n)
            //{
            //    if (n <= 1)
            //        return false;

            //    for (int i = 2; i <= n / 2; i++)
            //    {
            //        if (n % i == 0)
            //            return false;
            //    }
            //    return true;
            //}

            //int number = 4;
            //bool result  = IsPrime(number);
            //Console.WriteLine(result);

            #endregion

            #region question 6)
            //int max = 0;
            //int min = 0;
            //static void MinMaxArray(ref int[] array ,ref int max , ref int min)
            //{
            //    max = array[0];
            //    min = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] > max)
            //        {
            //            max = array[i];
            //        }
            //        else if (array[i] < min)
            //        {
            //            min = array[i];
            //        }
            //    }
            //}
            //int[] arr = { 1, 2, 3, 4, 5 };
            //MinMaxArray(ref arr, ref max, ref min);
            //Console.WriteLine($"{max}");
            //Console.WriteLine($"{min}");
            #endregion

            #region question 7)
            //static int factorial(int num)
            //{
            //    int result = 1;
            //    for (int i = num; i > 0; i--)
            //    {
            //        result *= i;

            //    }
            //    return result;
            //}
            //int num = 5 , result = 0;
            //result = factorial(num);
            //Console.WriteLine(result);
            #endregion

            #region question 8)
            //static string ChangeChar(string s , int pos , char c)
            //{

            //        char[] chars = s.ToCharArray();

            //        // Modify the character at the specified position
            //        chars[pos] = c;

            //    // Convert back to a string and return
            //    return new string(chars);

            //}
            //string s = "alaa";
            //string snew = ChangeChar(s, 1, 'L');
            //Console.WriteLine(snew);


            #endregion

        }
    }
}
