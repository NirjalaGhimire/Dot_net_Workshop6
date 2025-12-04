using Task_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Task 1: Selection / Projection ===");

        // 1. Selection / Projection
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squaredNumbers = numbers.Select(n => n * n);

        Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNumbers));



        Console.WriteLine("\n=== Task 2: Filtering (Where) ===");

        // 2. Filtering: Books priced above Rs. 1000
        List<Book> books = new List<Book>
        {
            new Book("C# Programming", 850),
            new Book("Artificial Intelligence", 1450),
            new Book("Cloud Computing", 2200),
            new Book("Data Structures", 999)
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("Premium Books (Price > 1000):");
        foreach (var b in premiumBooks)
        {
            Console.WriteLine($"{b.Name} - Rs. {b.Price}");
        }



        Console.WriteLine("\n=== Task 3: Sorting (OrderBy / OrderByDescending) ===");

        // 3. Sorting: Student names alphabetically
        List<Student> students = new List<Student>
        {
            new Student("Rita"),
            new Student("Aman"),
            new Student("Suresh"),
            new Student("Bikash"),
            new Student("Anjali"),
            new Student("Kiran"),
            new Student("Zara"),
            new Student("Laxmi"),
            new Student("Manav"),
            new Student("Rojina")
        };

        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("Sorted Students (Alphabetical Order):");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name);
        }
    }
}