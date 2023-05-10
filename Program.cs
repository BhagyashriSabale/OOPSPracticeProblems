namespace OOPSPracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome OOPS Array Practice Problem");
            Console.WriteLine("Choose 1 Program from below list:");
            Console.WriteLine("1.CountofDuplicates\n2.UniqueElements\n3.FindMinMax");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    TotalDuplicates duplicate = new TotalDuplicates();
                    duplicate.DuplicateElement();
                    break;
                case 2:
                    UniqueElements unique = new UniqueElements();
                    unique.UniqueEle();
                    break;
                case 3:
                    FindMinMax max = new FindMinMax();
                    max.MinMax();
                    break;
            }
        }
    }
}