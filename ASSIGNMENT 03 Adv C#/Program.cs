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

            #region Exercise 3: Phone Book

            //    // 1️ Create phone book with 4 contacts
            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    {"Ahmed", "01012345678"},
            //    {"Sara", "01198765432"},
            //    {"Ali", "01234567890"},
            //    {"Mona", "01567891234"}
            //};

            //    // 2️ Add a new contact using [] syntax (add or update)
            //    phoneBook["Hana"] = "01055555555"; // Adds new
            //    phoneBook["Sara"] = "01111111111"; // Updates existing

            //    // 3️ Try adding a duplicate using .Add() and catch exception
            //    try
            //    {
            //        phoneBook.Add("Ahmed", "01099999999"); // Duplicate key
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("Error adding duplicate with Add(): " + ex.Message);
            //    }

            //    // 4️ Try adding a duplicate using .TryAdd()
            //    bool success = phoneBook.TryAdd("Ali", "01222222222"); // Duplicate
            //    Console.WriteLine("TryAdd for 'Ali' succeeded? " + success);

            //    // 5️ Search for a contact that doesn’t exist
            //    if (phoneBook.ContainsKey("Yara"))
            //    {
            //        Console.WriteLine("Found Yara: " + phoneBook["Yara"]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yara not found in phone book");
            //    }

            //    // 6️ Get a contact with fallback of "Not Found"
            //    string contact = phoneBook.GetValueOrDefault("Yara", "Not Found");
            //    Console.WriteLine("GetValueOrDefault for Yara: " + contact);

            //    // 7️ Print all Keys on one line, then all Values on another line
            //    Console.WriteLine("Contacts: " + string.Join(", ", phoneBook.Keys));
            //    Console.WriteLine("Phone Numbers: " + string.Join(", ", phoneBook.Values)); 
            #endregion

            #region Exercise 4: Unique Email Validator

            //    // 1️ Create HashSet with case-insensitive comparer
            //    HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",   // duplicate (case-insensitive)
            //    "sara@test.com",
            //    "Sara@Test.Com"     // duplicate (case-insensitive)
            //};

            //    // 2️ Print count — how many are actually stored?
            //    Console.WriteLine("Number of unique emails: " + emails.Count);
            //    // Explanation: HashSet ignores duplicates. Since "ahmed@test.com" and "AHMED@test.com" 
            //    // are same ignoring case, only one is stored. Same for Sara.

            //    // 3️ Create two sets: A and B
            //    HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //    HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //    // 4️ UnionWith: combines all elements
            //    HashSet<int> union = new HashSet<int>(setA);
            //    union.UnionWith(setB);
            //    Console.WriteLine("Union of A and B: " + string.Join(", ", union));

            //    // 5️ IntersectWith: only common elements
            //    HashSet<int> intersect = new HashSet<int>(setA);
            //    intersect.IntersectWith(setB);
            //    Console.WriteLine("Intersection of A and B: " + string.Join(", ", intersect));

            //    // 6️ ExceptWith: elements in A but not in B
            //    HashSet<int> except = new HashSet<int>(setA);
            //    except.ExceptWith(setB);
            //    Console.WriteLine("A except B: " + string.Join(", ", except));

            //    // 7️ Check if {1,2} is a subset of Set A
            //    HashSet<int> subset = new HashSet<int> { 1, 2 };
            //    bool isSubset = subset.IsSubsetOf(setA);
            //    Console.WriteLine("{1,2} is subset of A? " + isSubset); 
            #endregion

            #region Exercise 5: Print Queue Simulator


            //// 1 Create a queue and enqueue 5 documents
            //Queue<string> printQueue = new Queue<string>();
            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //// 2️ Print queue contents and count
            //Console.WriteLine("Queue contents: " + string.Join(", ", printQueue));
            //Console.WriteLine("Queue count: " + printQueue.Count);

            //// 3️ Use Peek to see which document will print next
            //string nextDoc = printQueue.Peek();
            //Console.WriteLine("Next document to print: " + nextDoc);

            //// 4️ Process the queue: Dequeue each document and print
            //while (printQueue.Count > 0)
            //{
            //    string doc = printQueue.Dequeue();
            //    Console.WriteLine("Printing: " + doc);
            //}

            //// 5️ Try TryDequeue on the now-empty queue
            //if (printQueue.TryDequeue(out string docAfterEmpty))
            //{
            //    Console.WriteLine("Printing: " + docAfterEmpty);
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty. No document to print.");
            //} 
            #endregion

            #region Exercise 6: Browser History (Undo)

            //// 1️ Create a stack for browser history and push 5 URLs
            //Stack<string> browserHistory = new Stack<string>();
            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");

            //// 2️ Peek to see the current page
            //string currentPage = browserHistory.Peek();
            //Console.WriteLine("Current page: " + currentPage);

            //// 3️ Press "back" 3 times using Pop
            //for (int i = 0; i < 3; i++)
            //{
            //    string leftPage = browserHistory.Pop();
            //    Console.WriteLine("Leaving page: " + leftPage);
            //}

            //// 4️ Print the current page after going back
            //if (browserHistory.Count > 0)
            //{
            //    Console.WriteLine("Current page after going back: " + browserHistory.Peek());
            //}
            //else
            //{
            //    Console.WriteLine("No pages left in history");
            //}

            //// 5️ Try TryPop on an empty stack
            //Stack<string> emptyStack = new Stack<string>();
            //if (emptyStack.TryPop(out string poppedPage))
            //{
            //    Console.WriteLine("Popped page: " + poppedPage);
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty. Nothing to pop.");
            //} 
            #endregion
        }


    }
    
    
}
