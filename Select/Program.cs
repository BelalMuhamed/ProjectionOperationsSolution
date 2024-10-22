using ProjectionOperations.Entities;
using ProjectionOperations.Repo;

namespace Select

{
    public class Program
    {
        static void Main(string[] args)
        {
            
            #region Ex01
            List<string> Words =new() { "i", "love", "asp.net", "core" };
            var result01 = Words.Select(x => x.ToUpper());
            foreach (var word in result01) 
            {
                Console.WriteLine(word);
            }
            #endregion

            #region Ex02
            Console.Clear();
            List<int> numbers = new() { 1, 2, 3, 4, 5, 6 };
            var Result02 = numbers.Select(n => n * n);
            foreach(int n in Result02)
            {
                Console.WriteLine(n);
            }
            #endregion

            #region Ex03
            Console.Clear();
            List<Employee> Employees =Repository.LoadEmployees().ToList();
            var result03 = Employees.Select(e => 
            new EmployeeDto() {
                Name=e.FullName,
                TotalSkills=e.Skills.Count() });
            foreach (var employee in result03) 
            {
                Console.WriteLine(employee);
            }
            #endregion 
        }
    }
}
