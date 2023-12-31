using System;

class MoonactivePalindrome
{
    public static void Main()
    {
        string input1 = "?ab??a";
        string input2 = "bab??a";
        string input3 = "?a?";

        Console.WriteLine("Input: " + input1 + ", Output: " + IsStringPalindrome(input1));
        Console.WriteLine("Input: " + input2 + ", Output: " + IsStringPalindrome(input2));
        Console.WriteLine("Input: " + input3 + ", Output: " + IsStringPalindrome(input3));
    }

    public static string IsStringPalindrome(string S)
    {
        return IsStringPalindromeHelper(S);
    }

    public static string IsStringPalindromeHelper(string a)
    {
        char[] arr = a.ToCharArray();
        int startIndex = 0;
        int endIndex = a.Length - 1;
        bool isPoli = true;

        while (startIndex < endIndex)
        {
            if (arr[startIndex] != '?' && arr[endIndex] != '?')
            {
                if (arr[startIndex] != arr[endIndex])
                {
                    isPoli = false;
                    break;
                }
            }
            else if (arr[startIndex] == '?' && arr[endIndex] == '?')
            {
                arr[startIndex] = 'a';
                arr[endIndex] = 'a';
            }
            else if (arr[startIndex] == '?')
            {
                arr[startIndex] = arr[endIndex];
            }
            else
            {
                arr[endIndex] = arr[startIndex];
            }
            startIndex++;
            endIndex--;
        }

        if (isPoli)
        {
            return new string(arr);
        }
        else
        {
            return "NO";
        }
    }
}
