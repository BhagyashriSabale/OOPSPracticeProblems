namespace OOPSPracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome OOPS Array Practice Problem");
            Console.WriteLine("Choose 1 Program from below list:");
            Console.WriteLine("1.CountofDuplicates");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    TotalDuplicates duplicate = new TotalDuplicates();
                    duplicate.DuplicateElement();
                    break;
            }
        }
    }
}