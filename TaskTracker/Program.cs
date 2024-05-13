using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TaskTracker
{
	internal class Program
	{
		public static string[] Tasks = new string[25];
		public static int Index = 0;
		static void Main(string[] args)
		{
			// Welcome User
			// ADD TASK
			// VIEW ALL TASK
			// COMPLETE TASK [MARK]
			// REMOVE TASK
			//EXIT

			Console.WriteLine("welcome to my Task Tracker :) ");
			Console.WriteLine();
			int choice = 0;
			bool Flag = false;



		start: do
			{
				if (Flag == true) { Console.Clear(); }
				Console.WriteLine("Please Enter Your Numbers choice :)");
				Console.WriteLine("1.Add Your Tasks ");
				Console.WriteLine("2.View ALL Tasks ");
				Console.WriteLine("3.Mark Tasks ");
				Console.WriteLine("4.Remove Tasks ");
				Console.WriteLine("5.EXIT ");

				Console.Write("Enter Your Numbers :) ");
			} while (Flag = !int.TryParse(Console.ReadLine(), out choice));

			switch (choice)
			{
				case 1:
					// Add Your Tasks
					AddTask();
					goto start;

				case 2:
					//View ALL Tasks
					Console.Clear();
					ViewAllTasks();
						goto start;
					break;
				case 3:
					//Mark Tasks
					Console.Clear();
					Complete();
					Console.Clear();
					ViewAllTasks();
					
					break;
				case 4:
					//Remove Tasks
					Delelte();
					ViewAllTasks();
					break;
				case 5:
					//EXIT
					Exit();
					break;
				default:
					Console.Clear();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("please enter a valid Numbers");
					Console.ForegroundColor = ConsoleColor.White;

					goto start;

			}
			Console.ReadKey();

		}



		public static void AddTask()
		{
			//Console.WriteLine($"Please Enter Your Task Number {Index + 1} :) ");
			//string TaskInput = Console.ReadLine();
			//Tasks[Index] = TaskInput;
			;

			int NumbersTasks;
			do
			{
				Console.Write("How Many tasks do You Want today ?: ");

			} while (!int.TryParse(Console.ReadLine(), out NumbersTasks));

			for (int i = 0; i < NumbersTasks; i++)
			{
				Console.Write($"Enter Your Task {i + 1} ");
				string TaskName = Console.ReadLine();

				Tasks[i] = TaskName;
				Index++;

			}
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Add Successfully ");
			Console.ForegroundColor = ConsoleColor.White;

		}

		public static void ViewAllTasks()
		{
           

            if (Index > 0)
			{
				Console.WriteLine("All Tasks ");
				for (int i = 0; i < Index; i++)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"Task Numbers {i + 1} ---> [{Tasks[i]}]");
				}
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Please Enter Tasks :( ");
				Console.ForegroundColor = ConsoleColor.White;

			}

		}
	
	 
		public static void Exit()
		{
			Console.Clear();
			Environment.Exit(0);
		}

		public static void Complete()
		{
            Console.WriteLine("Please Enter Numbers Tasks Complete");

			int Numbers =int.Parse( Console.ReadLine());

            for (int i = 1; i < Index -1; i++)
            {
				Tasks[Numbers - 1] = Tasks[Numbers -1 ] + " COMPLETE ";

			}
        }   

		public static void Delelte()
		{
            Console.WriteLine("Please Enter Your Numbers Remove Task ");
			int delete = int.Parse(Console.ReadLine());

		

			for (int i = 1; i < Index ; i++)
			{
				Tasks[delete - 1] = "";
				Index--;
			}
		}
	}
}
