namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 10;
            string response;

            if (answer < 9)
            {
                response = (answer + " is less than nine.");
            }
            else 
            {
                response = (answer + " is greater than nine.");
            }
            Console.WriteLine(response);

            var input = 7;
            var output = (input < 9) ? $"{input} is less than nine" : $"{input} is greater than nine";
            Console.WriteLine(output);
        }
    }
}
