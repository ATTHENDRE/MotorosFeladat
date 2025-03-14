namespace MotorosFeladat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika file = new Statisztika();

			string fileName = "motors.txt";
			file.ReadFromFile(fileName);
		}
	}
}
