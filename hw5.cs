using System;
class Program{
    // passed by value doesn't change the original value
    static void by_value(int x)
    {
        x += 1;
        Console.WriteLine(x);
    }

    // passed by reference changes the original value
    static void by_ref(ref int x)
    {
        x += 1;
        Console.WriteLine(x);
    }
    

    
    // Reference type passed by value doesn't change the original value
    static void Modify_ref_by_value(string[] arr)
    {
        arr[0] = "new";
        arr = new string[] { "NewArray" };
        Console.WriteLine(arr[0]);
    }

    // Reference type passed by reference changes the original value
    static void Modify_ref_by_ref(ref string[] arr)
    {
        arr[0] = "new";
        arr = new string[] { "NewArray" };
        Console.WriteLine(arr[0]);
    }
    

    
    static (int sum, int diff) sum_and_diff(int a, int b, int c, int d)
    {
        int sum = a + b + c + d;
        int diff = a - b - c - d;
        return (sum, diff);
    }
    

    
    static int sum_of_digits(int n)
    {
        int sum = 0;
        while (n)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i*i <= n; i++) // it's a trick by make compelexity is O(sqrt(n)) not O(n) __ :)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    


    static void MinMaxArray(int[] arr, out int min, out int max)
    {
        min = int.MaxValue;
        max = int.MinValue;
        foreach (var n in arr)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }
    }



    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }



    static string ChangeChar(string input, int position, char new_c)
    {
        if (position < 0 || position >= input.Length)
            throw new ArgumentOutOfRangeException("Position is out of range.");

        char[] chars = input.ToCharArray();
        chars[position] = new_c;
        return new string(chars);
    }


    static void Main(string[] args)
    {
        #region // Q 1

        int val = 5;
        by_value(val);
        Console.WriteLine("After by_value: " + val);
        by_ref(ref val);
        Console.WriteLine("After by_ref: " + val);

        #endregion




        #region // Q 2

        string[] array = { "Original" };
        Modify_ref_by_value(array);
        Console.WriteLine("After Modify_ref_by_value: " + array[0]);
        Modify_ref_by_ref(ref array);
        Console.WriteLine("After Modify_ref_by_ref: " + array[0]);

        #endregion




        #region // Q 3

        var opr = sum_and_diff(10, 2, 3, 1);
        Console.WriteLine($"Sum: {opr.sum}, Difference: {opr.difference}");

        #endregion




        #region // Q 4

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The sum of the digits of the number {number} is: {sum_of_digits(number)}");

        #endregion



        #region // Q 5

        Console.Write("Enter a number to check if is prime: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");

        #endregion



        #region // Q 6

        int[] nums = { 3, 5, 7, 2, 8 };
        MinMaxArray(nums, out int min, out int max);
        Console.WriteLine($"Mini: {min}, Maxi: {max}");

        #endregion



        #region // Q 7

        Console.Write("Enter a number to calculate factorial: ");
        int fact = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial: {Factorial(fact)}");

        #endregion

        #region // Q 8

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter position to change : ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Enter new character : ");
        char new_c = Console.ReadLine()[0];
        Console.WriteLine($"Modified string : {ChangeChar(input, pos, new_c)}");

        #endregion
    }
}
