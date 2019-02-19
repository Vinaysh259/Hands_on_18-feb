using System;

namespace String
{
class program4
{
    public static void Main()
    {
        string str1;
        char[] arr1;
        int l, i;
        l = 0;
        char ch;

        Console.Write("Input the string : ");
        str1 = Console.ReadLine();
        l = str1.Length;
        arr1 = str1.ToCharArray(0, l); // Converts string into char array.

        Console.Write("\nAfter conversion, the string is : ");
        for (i = 0; i < l; i++)
        {
            ch = arr1[i];
            if (Char.IsLower(ch))
                Console.Write(Char.ToUpper(ch));
            else
                Console.Write(Char.ToLower(ch));
        }
        Console.ReadKey();
    }
}
}
