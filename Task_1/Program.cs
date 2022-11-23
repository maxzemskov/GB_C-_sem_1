	{
		Console.WriteLine("Введите первое число");
		int a = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите второе число");
		int b = int.Parse(Console.ReadLine());

		Console.Clear();

		if (a > b)
		{
			Console.WriteLine("max");
			Console.WriteLine(a);
			Console.WriteLine("min");
			Console.WriteLine(b);
		}
		else
		{
			Console.WriteLine("max");
			Console.WriteLine(b);
			Console.WriteLine("min");
			Console.WriteLine(a);
		}
	}
