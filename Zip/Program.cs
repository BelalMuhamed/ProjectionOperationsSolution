using ProjectionOperations.Repo;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex01
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };
            var NameWithHex = colorName.Zip(colorHEX,(name,hex)=>$"{name} ({hex})");
            foreach (var item in NameWithHex) 
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Ex02
            Console.Clear();
            var employees = Repository.LoadEmployees().ToArray();
            var FirstThree = employees[..3];
            var LastThree = employees[^3..];
            var Result02 =  FirstThree.Zip(LastThree,(f,l)=>$"{f.FullName} with {l.FullName}");
            foreach (var pair in Result02) 
            {
                Console.WriteLine(pair);
            }
            #endregion
        }
    }
}
