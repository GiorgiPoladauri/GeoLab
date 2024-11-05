using System;
using System.Collections.Generic;

public class ListFinder
{
    public static int FindFirstIndex<T>(List<T> list, T item)
    {
        return list.IndexOf(item);
    }

    public static int FindLastIndex<T>(List<T> list, T item)
    {
        return list.LastIndexOf(item);
    }

    public static List<int> FindAllIndexes<T>(List<T> list, T item)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(list[i], item))
            {
                indexes.Add(i);
            }
        }
        return indexes;
    }

    public static T FindFirst<T>(List<T> list, T item)
    {
        int index = list.IndexOf(item);
        return index >= 0 ? list[index] : default(T);
    }
}

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 1 };

        Console.WriteLine("First index: " + ListFinder.FindFirstIndex(numbers, 2));
        Console.WriteLine("Last index: " + ListFinder.FindLastIndex(numbers, 2));
        Console.WriteLine("All indexes: " + string.Join(", ", ListFinder.FindAllIndexes(numbers, 2)));
        Console.WriteLine("First item: " + ListFinder.FindFirst(numbers, 2));
    }
}
