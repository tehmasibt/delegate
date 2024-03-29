using delegates.predicate.Models;

namespace delegates.predicate
{
   
       
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task-1
            //Person person1 = new();
            //person1.Id = Guid.NewGuid();
            //person1.Name = "Tehmasib";
            //person1.Surname = "Taghiyev";
            //person1.Adress = "Kamal Rehimov Kucesi";
            //person1.Salary = 5500;
            //Person person2 = new();
            //person2.Id = Guid.NewGuid();
            //person2.Name = "Emil";
            //person2.Surname = "Abbasov";
            //person2.Adress = "Abbas Mirze Serifzade Kucesi";
            //person2.Salary = 10000;


            //List<Person> list1 = new List<Person>() { person2, person1 };
            //foreach (var item in CalculateSalary(p => p.Salary > 1000, list1))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region task-2
            //Book book1 = new Book();
            //book1.Author = "Nizami";
            //Book book2 = new Book();
            //book2.Author = "Semed Vurgun";
            //Book book3 = new Book();
            //book3.Author = "Huseyn Cavid";
            //Book book4 = new Book();
            //book4.Author = "Nizami";

            //List<Book> books = new List<Book>() { book1, book2, book3, book4 };
            //int count = 0;
            //foreach (var item in BookCount(p => p.Author == "Nizami", books))
            //{
            //    count++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region task-3
            //List<Employee> employees = new()
            //{
            //    new(){Id=Guid.NewGuid(),Name="Tehmasib",Surname="Taghiyev",Age=21,Salary=5500},
            //    new(){Id=Guid.NewGuid(),Name="Kenan",Surname="Quliyev",Age=69,Salary=3500},
            //    new(){Id=Guid.NewGuid(),Name="Emin",Surname = "Musayev", Age=19,Salary=6000},
            //    new(){Id=Guid.NewGuid(),Name="Emil",Surname="Abbasov",Age=27,Salary=4500}
            //};
            //var newList = employees.FindAll(ag => ag.Age > 20 && ag.Age < 40);
            //int sum = newList.Sum(s => s.Salary);
            //Console.WriteLine(sum);
            //double avg = newList.Average(a => a.Salary);
            //Console.WriteLine(avg);
            //int min = newList.Min(a => a.Salary);
            //Console.WriteLine(min);
            //int max = newList.Max(a => a.Salary);
            //Console.WriteLine(max);
            #endregion

        }
        #region task-1
        //static List<Person> CalculateSalary(Predicate<Person> predicate, List<Person> list)
        //{
        //    return list.FindAll(predicate); 

        //}
        #endregion
        #region task-2
        //static List<Book> BookCount(Predicate<Book> predicate, List<Book> list)
        //{
        //    return list.FindAll(predicate);
        //}
        #endregion
    }
}
