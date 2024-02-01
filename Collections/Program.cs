
using Collections;


#region Task1

//Dictionary<string, DateTime> examDates = new Dictionary<string, DateTime>();

//examDates.Add("Math", new DateTime(2024, 2, 8));
//examDates.Add("Programming", new DateTime(2024, 3, 12));
//examDates.Add("Network", new DateTime(2024, 2, 17));

//DateTime currentDate = DateTime.Now;
//foreach (var item in examDates)
//{
//    var diff = (item.Value.Date - currentDate.Date).TotalDays;
//    if (diff > -1)
//    {
//        Console.WriteLine($"{item.Key} imtahani {item.Value:dd-MM-yyyy} tarixindedir ve imtahana {(int)diff} gun qalib.\n");
//    }
//    else
//        Console.WriteLine($"{item.Key} imtahani {item.Value:dd-MM-yyyy} tarixinde idi.\n");
//}

#endregion

#region Task3

Library library = new Library(4);

string opt;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Remove a book");
    Console.WriteLine("3. Display all books");
    Console.WriteLine("4. Search");
    Console.WriteLine("5. Exit");

    Console.WriteLine("Enter your choice (1-5): ");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            string bookName;
            do
            {
                Console.WriteLine("Book Name: ");
                bookName = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(bookName)) ;
            try
            {
                library.AddBook(bookName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            break;
        case "2":
            string bookRmv;
            do
            {
                Console.WriteLine("Book Name: ");
                bookRmv = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(bookRmv));
            bool removed = library.RemoveBook(bookRmv);
            if (!removed)
            {
            Console.WriteLine("Book not found!");
            break;
            }
            break;
        case "3":
            Console.WriteLine("\tKitablar:\n");
            library.DisplayAll();
            break;
        case "4":
            string bookSrc;
            do
            {
                Console.WriteLine("Book Name: ");
                bookSrc = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(bookSrc));
            library.Search(bookSrc);
            break;
        case "5":
            Console.WriteLine("Program Finished!");
            break;
        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
} while (opt != "5") ;
#endregion