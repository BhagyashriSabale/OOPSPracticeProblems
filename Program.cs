namespace OOPSPracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome OOPS Array Practice Problem");
            Console.WriteLine("Choose 1 Program from below list:");
            Console.WriteLine("1.CountofDuplicates\n2.UniqueElements\n3.FindMinMax\n4.Pattern1\n5.Pattern2\n6.ReverseString\n7.SumallofDigit");
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
                case 4:
                    Pattern1 pattern = new Pattern1();
                    pattern.PatternStar();
                    break;
                case 5:
                    Pattern2 pattern2 = new Pattern2();
                    pattern2.StarPattern();
                    break;
                case 6:
                    ReverseS reverse = new ReverseS();
                    reverse.ReverseString();
                    break;
                case 7:
                    Sum sum = new Sum();
                    sum.SumOfAllNumbers();
                    break;
            }
        }
    }
}