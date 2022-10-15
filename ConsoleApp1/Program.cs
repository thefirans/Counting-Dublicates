using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            var result = str.Replace(" ", "").GroupBy(_ => _).Where(x => x.Count() > 1).Select(x => x.Key);
            return result.Count();    
        }
    }
}
