namespace progobj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź boki trójkąta oddzielając je spacją: ");
            string[] input = (Console.ReadLine() ?? "").Split(" ");
            if (input.Length != 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawna liczba boków");
                Console.ResetColor();
                return;
            }
            double[] edges = new double[3];
            for(int i = 0; i < input.Length; i++)
            {
                if(!double.TryParse(input[i], out edges[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niepoprawnie wprowadzone wartości długości boków");
                    Console.ResetColor();
                    return;
                }
            }
            if (edges[0] + edges[1] <= edges[2] || edges[0] + edges[2] <= edges[1] || edges[1] + edges[2] <= edges[0])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Z podanych boków nie da się zbudować trójkąta");
                Console.ResetColor();
                return;
            }
            
            double p = edges.Sum() / 2;
            double area = Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
            Console.WriteLine($"Pole trójkąta wynosi: {area}");
            
        }
    }
}