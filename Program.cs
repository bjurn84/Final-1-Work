		public class Program
{
	public static void Main()
	{
        string[] arr1 = {"Hello", "2", "world", "Goodbye"};
		string[] arr2 = {"129643", "3111200", "-2", "radio"};

		int symbol = 3;
		
		string[] GetShortWordsArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= symbol)
				{
					result[count] = array[i];
					count++;
				}
			}
			
            Array.Resize(ref result, count);
			return result;

		}
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Array is empty");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		void PrintTask(string[] array)
		{
			Console.WriteLine("Source array:");
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.WriteLine($"Result array (words are less or equal than {symbol} symbols)");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr1);
		PrintTask(arr2);
	}
}