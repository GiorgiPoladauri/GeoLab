using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkGeoLab;

class Program
{
    public static int FindFirstIndex(List<int> list, int value)
    {
        return list.IndexOf(value);
    }

    public static int FindLastIndex(List<int> list, int value)
    {
        return list.LastIndexOf(value);
    }

    public static List<int> FindAllIndices(List<int> list, int value)
    {
        List<int> indices = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == value)
            {
                indices.Add(i);
            }
        }
        return indices;
    }

    public static int? FindObject(List<int> list, int value)
    {
        int index = list.IndexOf(value);
        return index >= 0 ? (int?)list[index] : null;
    }

    public static int? FindLastObject(List<int> list, int value)
    {
        int index = list.LastIndexOf(value);
        return index >= 0 ? (int?)list[index] : null;
    }

    public static List<int> FindAllObjects(List<int> list, int value)
    {
        List<int> objects = new List<int>();
        foreach (var item in list)
        {
            if (item == value)
            {
                objects.Add(item);
            }
        }
        return objects;
    }

    public static int? FindMaxValue(List<int> list)
    {
        if (list.Count == 0) return null;
        return list.Max();
    }

    public static int? FindMinValue(List<int> list)
    {
        if (list.Count == 0) return null; 
        return list.Min();
    }

    static void Main()
    {
        List<int> myList = new List<int> { 1, 2, 3, 2, 4, 2, 5 };

        Console.WriteLine("First index of 2: " + FindFirstIndex(myList, 2));

        Console.WriteLine("Last index of 2: " + FindLastIndex(myList, 2));
        
        var indices = FindAllIndices(myList, 2);
        Console.WriteLine("All indices of 2: " + string.Join(", ", indices));

        Console.WriteLine("First object found (3): " + FindObject(myList, 3));

        Console.WriteLine("Last object found (2): " + FindLastObject(myList, 2));

        var allObjects = FindAllObjects(myList, 2);
        Console.WriteLine("All objects found (2): " + string.Join(", ", allObjects));

        Console.WriteLine("Max value: " + FindMaxValue(myList));

        Console.WriteLine("Min value: " + FindMinValue(myList));
    }
}
