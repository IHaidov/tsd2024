using System;
using System.Collections.Generic;

public class RandomizedCollection<T>
{
    private List<T> items = new List<T>();
    private Random random = new Random();

    public void Add(T element)
    {
        if (random.Next(2) == 0)
        {
            items.Add(element); 
        }
        else
        {
            items.Insert(0, element); 
        }
    }

    public T Get(int index)
    {
        int adjustedIndex = random.Next(Math.Min(index + 1, items.Count));
        return items[adjustedIndex];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }
}					
public class Program
{
	
	public static void Main()
	{
		Func<int, bool> isLeapYear = year => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

		bool is2020LeapYear = isLeapYear(2020); // True
		bool is1900LeapYear = isLeapYear(1900); // False
		
		Console.WriteLine("Leap years: 1900, 2020:");
		Console.WriteLine(is1900LeapYear);
		Console.WriteLine(is2020LeapYear);

		var collection = new RandomizedCollection<string>();
		Console.WriteLine($"\nEmpty collection?\n{collection.IsEmpty()} ");

		collection.Add("1 Element");
		collection.Add("2 Element");
		collection.Add("4 Element");
		collection.Add("5 Element");
		collection.Add("6 Element");
		collection.Add("7 Element");

		Console.WriteLine("\nRandomized collection:");
		var element = collection.Get(1); 
		Console.WriteLine(element);
		
		Console.WriteLine($"\nEmpty collection?\n{collection.IsEmpty()} ");

	}
}