using System;

public class Program
{
	public static void Main()
	{
		string input = "IX";
		int res = convertromantodecimal(input);
		Console.WriteLine(res);
	}

	public static int convertromantodecimal(string input)
	{
		int result = 0;
		int length = input.Length;
		for (int i = 0; i < length; i++)
		{
			int s1 = romantodecimalMap(input[i]);
			if (i + 1 < length)
			{
				int s2 = romantodecimalMap(input[i + 1]);
				if (s1 >= s2)
				{
					result = result + s1;
				}
				else
				{
					result = result + s2 - s1;
					i++;
				}
			}
			else
			{
				result = result + s1;
				i++;
			}
		}

		return result;
	}

	public static int romantodecimalMap(Char c)
	{
		if (c == 'I')
			return 1;
		if (c == 'V')
			return 5;
		if (c == 'X')
			return 10;
		if (c == 'L')
			return 50;
		if (c == 'C')
			return 100;
		if (c == 'D')
			return 500;
		if (c == 'M')
			return 1000;
		return -1;
	}
}
