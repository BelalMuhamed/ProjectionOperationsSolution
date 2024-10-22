using ProjectionOperations.Repo;

namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ex01
            string[] sentences = {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };
            var words = sentences.SelectMany(sent => sent.Split(' '));
            foreach (var word in words) 
            {
                Console.WriteLine(word);
            }
            #endregion

            #region Ex02
            var employees = Repository.LoadEmployees();
            var result02 =  employees.SelectMany( x => x.Skills).Distinct();
            foreach (var item in result02)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
