using System.Collections.Generic;
using System.Linq;

// Given an input string, reverse the string word by word.
// A word is defined as a sequence of non-space characters.
// The input string does not contain leading or trailing spaces and
//  the words are always separated by a single space.
//  For example,
//      Utils.Reverse("the sky is blue") // will return "blue is sky the"
public static class Text 
{
    const string Separator = " ";

    public static string Reverse(string text)
    {
        string[] array = text.Split(Separator);
        IEnumerable<string> reversedArray = array.ReverseArray();
        return string.Join(Separator, reversedArray);
    }

    public static string ReverseByLinq(string text)
    {
        string[] reversedArray = text
            .Split(Separator)
            .Reverse()
            .ToArray();

        return string.Join(Separator, reversedArray);
    }
}

public static class ArrayHelper
{
    public static IEnumerable<T> ReverseArray<T>(this IEnumerable<T> array)
    {
        T[] reversedArray = array.ToArray();
        int arrayLenght = reversedArray.Count();
        for (int i = 0; i < arrayLenght / 2; i++)
        {
            T temp = reversedArray[i];
            reversedArray[i] = reversedArray[arrayLenght - i - 1];
            reversedArray[arrayLenght - i - 1] = temp;
        }

        return reversedArray;
    }
}
