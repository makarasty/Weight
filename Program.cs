namespace Weight;

public class Program
{
	// (✿◠‿◠)
	private static void LazyPrint(string title, List<MyWeight> weights) => Console.WriteLine($"{title} \n{string.Join("\n", weights.Select(w => $"{w.Mass}, {w.Color}, {w.Size}"))}");
	public static void Main(string[] args)
	{
		System.Console.WriteLine("МАСА / КОЛІР / РОЗМІР");

		List<MyWeight> weights = [
			new() {Mass = 100, Color = ConsoleColor.Yellow, Size = 20},
			new() {Mass = 5, Color = ConsoleColor.Red, Size = 3},
			new() {Mass = 7, Color = ConsoleColor.Green, Size = 1},
			new() {Mass = 3, Color = ConsoleColor.Blue, Size = 2},
			new() {Mass = 70, Color = ConsoleColor.Black, Size = 10},
			new() {Mass = 1, Color = ConsoleColor.Magenta, Size = 1},
			new() {Mass = 40, Color = ConsoleColor.Gray, Size = 21},
		];

		weights.Sort();

		LazyPrint("\nСортовані за масою:", weights);

		weights.Sort(new MyWeight());

		LazyPrint("\nСортовані за розміром:", weights);

		weights.Sort((x, y) => x.Color.CompareTo(y.Color));

		LazyPrint("\nСортовані за кольором:", weights);
	}
}