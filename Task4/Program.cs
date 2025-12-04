using Microsoft.VisualBasic;
using Task4;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Selectio and projection using LINQ

            List<int> number = [1, 2, 3, 4, 5];

            var squaredNumber = from n in number
                                select n * n;

            Console.WriteLine(string.Join(",", squaredNumber));


            // Filtering using LINQ
            Book book1 = new Book("C#", 999.99);
            Book book2 = new Book("Java", 1239.99);
            Book book3 = new Book("Python", 2225.50);
            List<Book> bookList = [book1, book2, book3];

            var premiumBooks = from book in bookList
                               where book.price > 1000
                               select book;

            Console.WriteLine(string.Join(',', premiumBooks));

            // Sorting using LINQ

            Student student1 = new Student("elice", "L3C2");
            Student student2 = new Student("dob", "L3C9");
            Student student3 = new Student("Charlie", "L3C7");
            Student student4 = new Student("David", "L3C6");
            Student student5 = new Student("Eve", "L3C8");
            Student student6 = new Student("Zrank", "L3C8");
            Student student7 = new Student("Trace", "L3C10");
            Student student8 = new Student("Beidi", "L3C11");
            Student student9 = new Student("Aven", "L3C9");
            Student student10 = new Student("asudy", "L3C5");

            List<Student> studentList = [student1, student2, student3, student4, student5,
                                         student6, student7, student8, student9, student10];

            var sortedStudentsWithOrderBy = from student in studentList
                                            orderby student.studentName
                                            select student;
            Console.WriteLine("\nSorted Students by Name (Ascending) i.e. using orderby:");

            foreach (var student in sortedStudentsWithOrderBy)
            {
                Console.WriteLine($"Name: {student.studentName}, Section: {student.section}");
            }



            var sortedStudentsWithOrderByDesc = from student in studentList
                                                orderby student.studentName descending
                                                select student;
            Console.WriteLine("\nSorted Students by Name (Descending) i.e. using orderby ... descending:");

            foreach (var student in sortedStudentsWithOrderByDesc)
            {
                Console.WriteLine($"Name: {student.studentName}, Section: {student.section}");

            }
        }
    }
}