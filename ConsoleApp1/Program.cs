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
            var result = str.ToLower()      //ToLower() for ignore case
                .Replace(" ", "")           //Replace() for delete all whitespaces
                .GroupBy(_ => _)            //GroupBy() for split all characters to single char
                .Where(x => x.Count() > 1)  //Where() for find dublicates, i.e. count char's that we have more than one time
                .Select(x => x.Key);        //Select() group all characters into small groups
            return result.Count();          //Count() count and return biggest group
        }
    }
}
