	{
		Console.WriteLine("Введите первое число");
		int a = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите второе число");
		int b = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите третье число");
		int c = int.Parse(Console.ReadLine());

		Console.Clear();

		if (a > b && a > c)
		{
			Console.WriteLine("максимальное число ");
			Console.WriteLine(a);
		}
		else if (b > c)
		{
		Console.WriteLine("максимальное число ");
			Console.WriteLine(b);
		}
		else
		{
		Console.WriteLine("максимальное число ");
			Console.WriteLine(c);	
		}
	}
