internal class Program
{
	private static void Main(string[] args)
	{
		//Length; 
		//ToLower();
		//ToUpper();
		//Trim();
		//Split(" ")[0];
		//StartsWith("x");
		//EndsWith("x);
		//Contains("xxx");
		//IndexOf("xxx");
		//Substring(x, x); "
		Console.WriteLine("Hi, enter your message: ");
		string text;
		text = Console.ReadLine();

		var resultlength = text.Length;
		Console.WriteLine("Length of your message: " + resultlength);
		Console.WriteLine();

		var resultUp = text.ToUpper();
		Console.WriteLine("Your message in uppercase: " + resultUp);
		Console.WriteLine();

		var resultLow = text.ToLower();
		Console.WriteLine("Your message in lowercase: " + resultLow);
		Console.WriteLine();


		var resulttrim = text.Trim();
		Console.WriteLine("Your message trim both side: " + resulttrim);
		Console.WriteLine();

		var resultarry = text[3];
		Console.WriteLine("Your messages 3th letter:  " +  resultarry);
		Console.WriteLine();
		
		var resultstarts = text.StartsWith("M");
		Console.WriteLine("Your messages starts with M:  " + resultstarts);
		Console.WriteLine();

		var resultend = text.StartsWith("S");
		Console.WriteLine("Your messages end with S:  " + resultend);
		Console.WriteLine();

		var resultcont = text.Contains("Ömer");
		Console.WriteLine("Your messages contains Ömer  " + resultcont);
		Console.WriteLine();

		var resultindxof = text.IndexOf("t");
		Console.WriteLine("Your messages contains T unit: " + resultindxof);
		Console.WriteLine();
		
		var resultsubstr = text.Substring(0,15);
		Console.WriteLine("Your messages substrint between 0/15 " + resultsubstr);

	}
}