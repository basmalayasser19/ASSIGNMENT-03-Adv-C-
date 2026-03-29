namespace ASSIGNMENT_03_Adv_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

            //// Create the collection with grades
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// Print the collection
            //Console.WriteLine("Grades: " + string.Join(", ", grades));

            //// Print Count, First and Last grade
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First Grade: " + grades.First());
            //Console.WriteLine("Last Grade: " + grades.Last());

            //// Sort grades ascending and print
            //grades.Sort();
            //Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));

            //// Get first grade above 90
            //int firstAbove90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine("First grade above 90: " + firstAbove90);

            //// Get all failing grades (below 75)
            //var failingGrades = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing grades: " + string.Join(", ", failingGrades));

            //// Remove all failing grades
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades after removing failing: " + string.Join(", ", grades));

            //// Check if any grade equals 100
            //bool hasPerfect = grades.Contains(100);
            //Console.WriteLine("Contains 100? " + hasPerfect);

            //// Convert grades to List<string> as "Grade: X"
            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("Grades as strings: " + string.Join(", ", gradeStrings)); 
            #endregion

            #region Exercise 2: Leaderboard
            //    // Create a leaderboard: key = score, value = player name
            //    SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}
            //};

            //    // Print all entries (sorted by score automatically)
            //    Console.WriteLine("Leaderboard:");
            //    foreach (var entry in leaderboard)
            //    {
            //        Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //    }

            //    // Access the first key and first value
            //    int firstScore = leaderboard.Keys.First();
            //    string firstPlayer = leaderboard[firstScore];
            //    Console.WriteLine($"\nFirst Entry -> Score: {firstScore}, Player: {firstPlayer}");

            //    // Check if score 500 exists
            //    bool hasScore500 = leaderboard.ContainsKey(500);
            //    Console.WriteLine("Contains score 500? " + hasScore500);

            //    // Safely get the player with score 999
            //    if (leaderboard.TryGetValue(999, out string player999))
            //    {
            //        Console.WriteLine("Player with score 999: " + player999);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No player found with score 999");
            //    }

            //    // Remove the player with score 200
            //    leaderboard.Remove(200);

            //    // Print updated leaderboard
            //    Console.WriteLine("\nUpdated Leaderboard:");
            //    foreach (var entry in leaderboard)
            //    {
            //        Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //    } 
            #endregion
        }
    }
    
}
