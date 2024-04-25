internal class Program
{
	private static void Main(string[] args)
	{
		double S = 0, S_2 = 0, Disp = 0, Abs_1 = 0, Abs_2 = 0, D = 3.0, a = 1.5;
		int N = 100000000;
		Console.WriteLine("Входные данные:");
		Console.WriteLine($"S = {S}, S_2 = {S_2}, Disp = {Disp}, D = {D}, a = {a}");
		getDispersion(D, a, N, out S, out S_2);
		S = S / (2 * N);
		S_2 = S_2 / (2 * N);
		Disp = S_2 - Math.Pow(S_2, 2);
		Abs_1 = Math.Abs(a - S);
		Abs_2 = Math.Abs(Disp - D);
		Console.WriteLine("Выходные данные:");
		Console.WriteLine($"S = {S}, S_2 = {S_2}, Disp = {Disp}, Abs(a - S) = {Abs_1}, Abs(Disp - D) = {Abs_2}");
	}
	private static void getDispersion(double D, double a, int N, out double S, out double S_2)
	{
		S = 0; S_2 = 0;
		Random rnd = new Random();
		for (int i = 0; i < N; i++) 
		{
			double r = rnd.NextDouble();
			double s = rnd.NextDouble();
			double t_1 = Math.Cos(2*Math.PI) * Math.Sqrt(-2 * Math.Log(r));
			double t_2 = Math.Sin(2 * Math.PI) * Math.Sqrt(-2 * Math.Log(s));
			double x = Math.Sqrt(D) * t_1 + a;
			double y = Math.Sqrt(D) * t_2 + a;
			S = S + x + y;
			S_2 = S_2 + Math.Pow(x, 2) + Math.Pow(y, 2);
		}
	}
}