namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tour> tours = new()
        {
            new Tour{CustomerName="A", Destination="Mundhum", Price=8000, DurationInDay=3, IsInternational=false},
            new Tour{CustomerName="B", Destination="Korea", Price=25000, DurationInDay=8, IsInternational=true},
            new Tour{CustomerName="C", Destination="Malta", Price=40000, DurationInDay=2, IsInternational=true},
            new Tour{CustomerName="D", Destination="Gorkha", Price=12000, DurationInDay=3, IsInternational=false},
        };

            // Filter
            var filtered = tours
                .Where(t => t.Price > 10000 && t.DurationInDay > 4);

            // Projection
            var result = filtered.Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic"
            });

            // Sorting: Domestic first, then International, and then by price
            var sorted = result
                .OrderBy(r => r.Category)
                .ThenBy(r => tours.First(t => t.CustomerName == r.CustomerName).Price);

            // Display
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.CustomerName} | {item.Destination} | {item.Category}");
            }
        }
    }
}
