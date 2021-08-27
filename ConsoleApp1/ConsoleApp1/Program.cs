using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CPU Simplified");
			string loop = "YES";

			while (loop == "YES")
			{
				string AX = "";
				string BX = "";
				string CX = "";
				string DX = "";

				Console.WriteLine("Set AX registry value:");
				AX = Console.ReadLine();
				Console.WriteLine("Set BX registry value:");
				BX = Console.ReadLine();
				Console.WriteLine("Set CX registry value:");
				CX = Console.ReadLine();
				Console.WriteLine("Set DX registry value:");
				DX = Console.ReadLine();

				Console.WriteLine();

				Console.WriteLine($"AX: {AX}");
				Console.WriteLine($"BX: {BX}");
				Console.WriteLine($"CX: {CX}");
				Console.WriteLine($"DX: {DX}");

				Console.WriteLine();

				Console.WriteLine("For MOVE(MOV) enter 0");
				Console.WriteLine("For EXCHANGE(XCHG) enter 1");
				int choice = Convert.ToInt32(Console.ReadLine());

				if (choice == 1)
				{
					Console.WriteLine("EXCHANGE");

					Console.Write("Enter first register ");
					string firstR = Console.ReadLine();
					Console.Write("Enter second register ");
					string secondR = Console.ReadLine();

					if (firstR == "AX" && secondR == "BX" || firstR == "BX" && secondR == "AX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {BX}");
						Console.WriteLine($"BX: {AX}");
						Console.WriteLine($"CX: {DX}");
						Console.WriteLine($"DX: {DX}");
					}
					else if (firstR == "AX" && secondR == "CX" || firstR == "CX" && secondR == "AX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {CX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {AX}");
						Console.WriteLine($"DX: {DX}");
					}
					else if (firstR == "AX" && secondR == "DX" || firstR == "DX" && secondR == "AX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {DX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {AX}");
					}
					else if (firstR == "BX" && secondR == "CX" || firstR == "CX" && secondR == "BX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {CX}");
						Console.WriteLine($"CX: {BX}");
						Console.WriteLine($"DX: {DX}");
					}
					else if (firstR == "BX" && secondR == "DX" || firstR == "DX" && secondR == "BX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {DX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {BX}");
					}
					else if (firstR == "CX" && secondR == "DX" || firstR == "DX" && secondR == "CX")
					{
						Console.WriteLine("EXCHANGE results: ");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {DX}");
						Console.WriteLine($"DX: {CX}");
					}

				}
				else if (choice == 0)
				{
					Console.WriteLine("MOVE");

					Console.Write("Enter first register ");
					string firstR = Console.ReadLine();
					Console.Write("Enter second register ");
					string secondR = Console.ReadLine();
					if (firstR == "AX" && secondR == "BX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {AX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "AX" && secondR == "CX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {AX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "AX" && secondR == "DX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {AX}");

					}
					else if (firstR == "BX" && secondR == "AX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {BX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "BX" && secondR == "CX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {BX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "BX" && secondR == "DX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {BX}");

					}
					else if (firstR == "CX" && secondR == "AX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {CX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "CX" && secondR == "BX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {CX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "CX" && secondR == "DX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {CX}");

					}
					else if (firstR == "DX" && secondR == "AX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {DX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "DX" && secondR == "BX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {DX}");
						Console.WriteLine($"CX: {CX}");
						Console.WriteLine($"DX: {DX}");

					}
					else if (firstR == "DX" && secondR == "CX")
					{
						Console.WriteLine("MOVE results");
						Console.WriteLine($"AX: {AX}");
						Console.WriteLine($"BX: {BX}");
						Console.WriteLine($"CX: {DX}");
						Console.WriteLine($"DX: {DX}");

					}
				}

				Console.Write("DO YOU WANT RUN CPU SIMPLIFIED ONCE MORE(YES/NO): ");
				loop = Console.ReadLine();
			}

			Console.WriteLine("Goodbye!");

		}
	}
}
