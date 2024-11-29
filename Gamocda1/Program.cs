#region davaleba1
/*
class Program
{
    static void Main()
    {
        double x;
        double y;
        string operation;
        char gagrdzeleba;
        do
        {
            // იღებს პირველ რიცხვს
            x = GetValidNumber("Enter the first number: ");
            // იღებს მეორე რიცხვს
            y = GetValidNumber("Enter the second number: ");
            // ოპერაციის ვალიდაცია
            operation = GetValidOperation();
            // ასრულებს კალკულაციას
            double result = PerformCalculation(x, y, operation);
            // გამოაქვს შედეგი
            Console.WriteLine($"The result of {x} {operation} {y} is: {result}");
            // მორიგი ოპერაციის შესრულება შედეგზე
            char operGagrdzeleba;
            do
            {
                Console.WriteLine("Do you want to perform another operation on the current result? (y/Y for Yes, any other key for No): ");
                string inputi = Console.ReadLine()?.Trim();
                operGagrdzeleba = string.IsNullOrEmpty(inputi) ? 'n' : char.ToLower(inputi[0]);
                if (operGagrdzeleba == 'y')
                {
                    // იღებს მეორე რიცხვს
                    y = GetValidNumber("Enter another number: ");
                    // ოპერაციის ვალიდაცია
                    operation = GetValidOperation();
                    // ასრულებს ახალ კალკულაციას
                    double resultNew = PerformCalculation(result, y, operation);
                    // გამოაქვს ახალი შედეგი
                    Console.WriteLine($"The new result of {result} {operation} {y} is: {resultNew}");
                }
            }
            while (operGagrdzeleba == 'y');
            // ძირითადი ციკლის გაგრძელება
            Console.WriteLine("Do you want to start over with new numbers? (y/Y for Yes, any other key for No): ");
            string input = Console.ReadLine()?.Trim();
            gagrdzeleba = string.IsNullOrEmpty(input) ? 'n' : char.ToLower(input[0]);
        }
        while (gagrdzeleba == 'y');
        Console.WriteLine("Byee! :)");
    }
    // სწორი რიცხვის შეყვანის ფუნქცია
    static double GetValidNumber(string prompt)
    {
        double number;
        bool validInput;
        do
        {
            Console.WriteLine(prompt);
            validInput = double.TryParse(Console.ReadLine(), out number);
            if (!validInput)
            {
                Console.WriteLine("Invalid input!");
            }
        }
        while (!validInput);
        return number;
    }
    // არითმეტიკული მოქმედებების სწორად შეყვანის ფუნქცია
    static string GetValidOperation()
    {
        string operation;
        bool validOperation;
        do
        {
            Console.Write("Enter an operation (+, -, *, /): ");
            operation = Console.ReadLine();
            validOperation = operation == "+" || operation == "-" || operation == "*" || operation == "/";
            if (!validOperation)
            {
                Console.WriteLine("Invalid operation! Please enter one of this: +, -, *, /.");
            }
        } while (!validOperation);
        return operation;
    }
    // ოპერაციაზე დაფუძნებული ფუნქცია რომელიც ასრულებს კალკულაციას
    static double PerformCalculation(double x, double y, string operation)
    {
        double result = 0;
        switch (operation)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x * y;
                break;
            case "/":
                if (y == 0)
                {
                    Console.WriteLine("division by zero is not allowed.");
                    return double.NaN;  // აბრუნებს nan თუ ხდება ნულზე გაყოფა
                }
                result = x / y;
                break;
        }
        return result;
    }
}
*/
#endregion

#region davaleba2
/*
class Program
{
    static void Main()
    {
        RendomNumber rendom = new RendomNumber();
        rendom.gamoicani();
    }
    public class RendomNumber
    {
        public static Random rand = new Random();
        public void gamoicani()
        {
            try
            {
                // კონსოლს აფერადებს მწვანედ
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Modit daviwyot tamashi :)");
                Console.WriteLine("Aarchiet diapazoni: ");
                // იუზერს შემოჰყავს რიცხვი
                Console.WriteLine("Shemoitanet diapazonis dasawkisi :");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Shemoitanet diapazonis dasasruli :");
                int b = int.Parse(Console.ReadLine());
                Random rand = new Random();
                Console.WriteLine("Davagenerirot shemtxveviti ricxvi :");
                // აგენერირების რანდომ რიცხვებს რეინჯის მიხედვით
                int c = rand.Next(a, b);
                Console.WriteLine("Ricxvi dagenerirebulia, gaqvs 5 cda :)");
                bool win = false;
                // ამოწმებს მცდელობების რაოდენობას 5-მდე
                int attempts = 0;
                while (attempts < 5)
                {
                    Console.WriteLine($"Cdebis raodenoba: {5 - attempts}");
                    Console.WriteLine("Shemoitanet ricxvi: ");
                    int ricxvi = int.Parse(Console.ReadLine());
                    // უკუკავშირს აკეთებს გამოცნობაზე
                    if (ricxvi == c)
                    {
                        Console.WriteLine("Tamashi mogebulia yochag :))");
                        win = true;
                        break;
                    }
                    else if (ricxvi > c && ricxvi <= b)
                    {
                        Console.WriteLine("Ricxvi ar daemtxva, shemotanili ricxvi amosacnob ricxvze metia :)");
                        attempts++;
                    }
                    else if (ricxvi < c && ricxvi >= a)
                    {
                        Console.WriteLine("Ricxvi ar daemtxva, shemotanili ricxvi amosacnob ricxvze naklebia :)");
                        attempts++;
                    }
                    else
                    {
                        //არ აკლებს ცდების რაოდენობას
                        Console.WriteLine("Ricxvi diapazonshi ar moxvda, scadet tavidan :)");
                    }
                }
                if (!win)
                {
                    Console.WriteLine("Tamashi wagebulia, amosacnobi ricxvi iyo: " + c);
                }
                else
                {
                    Console.WriteLine("Gilocavv :)");
                }
            }
            // ამოწმებს ვალიდურობას, რომ იუზერმა ნამდვილად შემოიყვანოს რიცხვი და აფერადებს წითლად
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
        }
    }
}
*/
#endregion

#region davaleba3
/*
class Program
{
    static void Main()
    {
        Hangman hangman = new Hangman();
        // მასივში წინასწარ გამზადებული სიტყვები
        string[] mas = new string[] { "mze", "mtvare", "varskvlavi" };
        hangman.Hang(mas);
    }
    public class Hangman
    {
        private static Random random = new Random();
        public void Hang(string[] mas)
        {
            int ind = random.Next(0, mas.Length);
            string sityva = mas[ind]; // არჩეული სიტყვა
            string saveWord = sityva;
            string axali = string.Empty;
            int sicocxle = 5; //5 სიცოცხლე
            char aso = ' ';
            // ქვედა ტირეებით წერს გამოსაცნობ სიტყვას
            Console.WriteLine("Gamosacnobi sityva shercheulia");
            for (int i = 0; i < sityva.Length; i++)
            {
                axali += "_";
            }
            Console.WriteLine($"Sityva: {axali}");
            // ასოების გამოცნობა კონსოლიდან
            while (sicocxle > 0)
            {
                Console.WriteLine($"Gaqvt {sicocxle} sicocxle");
                Console.WriteLine("Gamoicani aso:");
                aso = char.Parse(Console.ReadLine());
                // სიტყვის შედარება ასოებთან
                if (sityva.Contains(aso))
                {
                    Console.WriteLine("Yochagh! Aso sworia.");
                    char[] axaliArray = axali.ToCharArray();
                    char[] dzveliArray = sityva.ToCharArray();
                    for (int i = 0; i < sityva.Length; i++)
                    {
                        if (dzveliArray[i] == aso)
                        {
                            axaliArray[i] = aso;
                            dzveliArray[i] = '_';
                        }
                    }
                    axali = new string(axaliArray);
                    sityva = new string(dzveliArray);
                    Console.WriteLine($"Ganaxlebuli sityva: {axali}");
                    if (!axali.Contains('_'))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gilocavt! Sityva gamoicanit!");
                        Console.ResetColor();
                        return;
                    }
                }
                else
                {
                    sicocxle--;
                    Console.WriteLine("Arasworia! Scadet tavidan.");
                }
            }
            //თუ 5 სიცოცხლეს გასცდა თამაში გაითიშება
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER! Aghar gaqvs sicocxle!");
            Console.ResetColor();
            Console.WriteLine($"Sityva iyo: {sityva}");
        }
    }
}
*/
#endregion

#region davaleba4

using System.ComponentModel.DataAnnotations;
namespace Gamocda1

{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();

            bool running = true;

            //კონსოლში გამოაქვს მომხმარებლისთვის ინტერფეისი
            while (running)
            {
                Console.WriteLine("\n--- Book Manager ---");

                Console.WriteLine("1. Add Book");

                Console.WriteLine("2. Remove Book");

                Console.WriteLine("3. Search Books by Title");

                Console.WriteLine("4. Search Books by Author");

                Console.WriteLine("5. Update Book");

                Console.WriteLine("6. Add Author");

                Console.WriteLine("7. Remove Author");

                Console.WriteLine("8. Update Author");

                Console.WriteLine("9. Get all author");

                Console.WriteLine("10. Get all Book");

                Console.WriteLine("11. Exit");

                Console.Write("Please select an option: ");

                var input = Console.ReadLine();

                //მომხმაებლის მიერ შემოყვანილი ციფრით გამოაქვს შედეგი
                switch (input)
                {
                    case "1":
                        AddBook(bookManager);
                        break;
                    case "2":
                        RemoveBook(bookManager);
                        break;
                    case "3":
                        SearchBooksByTitle(bookManager);
                        break;
                    case "4":
                        SearchBooksByAuthor(bookManager);
                        break;
                    case "5":
                        UpdateBook(bookManager);
                        break;
                    case "6":
                        AddAuthor(bookManager);
                        break;
                    case "7":
                        RemoveAuthor(bookManager);
                        break;
                    case "8":
                        UpdateAuthor(bookManager);
                        break;
                    case "9":
                        GetAllAuthor(bookManager);
                        break;
                    case "10":
                        GetAllBook(bookManager);
                        break;
                    case "11":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }

        #region AddBook

        //წიგნის დამატების მეთოდი
        static void AddBook(BookManager bookManager)
        {
            Console.Write("Enter book title: ");

            var title = Console.ReadLine();

            Console.Write("Enter author name: ");

            var author = Console.ReadLine();

            Console.Write("Enter release date (yyyy-mm-dd): ");

            var releaseDate = DateTime.Parse(Console.ReadLine());

            try
            {
                bookManager.AddBook(new Book(title, author, releaseDate));
                Console.WriteLine("Book added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        #endregion

        #region RemoveBook
        //წიგნის წაშლის მეთოდი
        static void RemoveBook(BookManager bookManager)
        {
            Console.Write("Enter book title to remove: ");

            var title = Console.ReadLine();

            Console.Write("Enter author name: ");

            var author = Console.ReadLine();

            try
            {
                bookManager.RemoveBook(title, author);
                Console.WriteLine("Book removed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        #endregion

        #region SearchBooksByTitle
        // ეძებს წიგნს სათაურით
        static void SearchBooksByTitle(BookManager bookManager)
        {
            Console.Write("Enter title to search: ");

            var searchTerm = Console.ReadLine();

            var books = bookManager.SearchBooksByTitle(searchTerm);

            if (books.Any())
            {
                Console.WriteLine("Books found:");

                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author} (Released: {book.ReleaseDate.ToShortDateString()})");
                }
            }
            else
            {
                Console.WriteLine("No books found.");
            }
        }

        #endregion

        #region SearchBooksByAuthor
        //ეძებს წიგნს ავტორით
        static void SearchBooksByAuthor(BookManager bookManager)
        {
            Console.Write("Enter author name to search: ");

            var searchTerm = Console.ReadLine();

            var books = bookManager.SearchBooksByAuthor(searchTerm);

            if (books.Any())
            {
                Console.WriteLine("Books found:");

                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author} (Released: {book.ReleaseDate.ToShortDateString()})");
                }
            }
            else
            {
                Console.WriteLine("No books found.");
            }
        }

        #endregion

        #region UpdateBook
        //ააფდეითებს ძველ წიგნს ახლით
        static void UpdateBook(BookManager bookManager)
        {
            Console.Write("Enter book title to update: ");

            var title = Console.ReadLine();

            Console.Write("Enter author name: ");

            var author = Console.ReadLine();

            var book = bookManager.SearchBooksByTitle(title).FirstOrDefault(b => b.Author == author);

            if (book != null)
            {
                Console.Write("Enter new title: ");

                var newTitle = Console.ReadLine();

                Console.Write("Enter new author name: ");

                var newAuthor = Console.ReadLine();

                Console.Write("Enter new release date (yyyy-mm-dd): ");

                var newReleaseDate = DateTime.Parse(Console.ReadLine());
                try
                {
                    bookManager.UpdateBook(book.Id, newTitle, newAuthor, newReleaseDate);

                    Console.WriteLine("Book updated successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        #endregion

        #region AddAuthor
        //ამატებს წიგნის ავტორს  
        static void AddAuthor(BookManager bookManager)
        {
            Console.Write("Enter author name: ");

            var authorName = Console.ReadLine();

            try
            {
                bookManager.AddAuthor(new Author(authorName));

                Console.WriteLine("Author added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        #endregion

        #region RemoveAuthor
        //შლის წიგნის ავტორს
        static void RemoveAuthor(BookManager bookManager)
        {
            Console.Write("Enter author name to remove: ");

            var authorName = Console.ReadLine();

            var author = bookManager.SearchAuthorByName(authorName);

            if (author != null)
            {
                try
                {
                    bookManager.RemoveAuthor(author.Id);

                    Console.WriteLine("Author removed successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Author not found.");
            }

        }

        #endregion

        #region UpdateAuthor
        //ააფდეითებს წიგნის ავტორს ახალი სახელით
        static void UpdateAuthor(BookManager bookManager)
        {
            Console.Write("Enter author name to update: ");

            var authorName = Console.ReadLine();

            var author = bookManager.SearchAuthorByName(authorName);

            if (author != null)
            {
                Console.Write("Enter new author name: ");

                var newAuthorName = Console.ReadLine();

                try
                {
                    bookManager.UpdateAuthor(author.Id, newAuthorName);

                    Console.WriteLine("Author updated successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }

        #endregion

        #region GetAllAuthor
        // ყველა ავტორის სახელის გამოტანა
        static void GetAllAuthor(BookManager bookManager)
        {
            var res = bookManager.GetAllAuthor();

            foreach (var item in res)
            {
                Console.WriteLine($"Book name: {item.AuthorName}, Id: {item.Id}");
            }
        }

        #endregion

        #region GetAllBook
        //ყველა წიგნის ჩვენება
        static void GetAllBook(BookManager bookManager)
        {
            var res = bookManager.GetAllBook();

            foreach (var item in res)
            {
                Console.WriteLine($"Id: {item.Id}, title: {item.Title}, author: {item.Author}, release date: {item.ReleaseDate}");
            }
        }
        #endregion
    }

    //ბეიზ კლასი მემკვიდრეობის გადასაცემად
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }

        public virtual string DisplayInfo()
        {
            return $"Entity ID: {Id}";
        }
    }

    // მემკვიდრეობით იღებს BaseEntity-ს
    public class Author : BaseEntity
    {
        //ატრიბუტები
        [Required(ErrorMessage = "Author is required.")]
        [StringLength(50, ErrorMessage = "Author cannot exceed 50 characters.")]
        [RegularExpression(@"^[^\d]*$", ErrorMessage = "Author cannot contain numbers.")]
        public string AuthorName { get; set; }

        public Author(string authorName)
        {
            Id = Guid.NewGuid();
            AuthorName = authorName;
        }

        public override string DisplayInfo()
        {
            return $"Author: {AuthorName} (ID: {Id})";
        }
    }

    // მემკვიდრეობით იღებს BaseEntity-ს
    public class Book : BaseEntity
    {
        //ატრიბუტები
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        [StringLength(50, ErrorMessage = "Author cannot exceed 50 characters.")]
        [RegularExpression(@"^[^\d]*$", ErrorMessage = "Author cannot contain numbers.")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Book(string title, string author, DateTime releaseDate)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }

        //წიგნის და ავტორის დასახელება გამოაქვს
        public override string DisplayInfo()
        {
            return $"Book: {Title} by {Author}, Released: {ReleaseDate.ToShortDateString()}";
        }
    }

    public class BookManager
    {
        //წიგნების და ავტორების ლისტი
        private List<Book> books = new List<Book>()
        {
            new Book("Shota Rustaveli", "Vefxistyaosani", new DateTime(1200, 01, 01)),
            new Book("Ilia Chavchavadze:", "Kacia Adamiani",  new DateTime(1800, 02, 02)),
            new Book("Vazha Pshavela", "Stumar-Maspindzeli", new DateTime(1900, 03, 03)),
        };

        //ავტორების ლისტი
        private List<Author> authors = new List<Author>()
        {
            new Author("Shota Rustaveli"),
            new Author("Ilia Chavchavadze"),
            new Author("Vazha Pshavela"),
        };

        //წიგნის დამატების მეთოდი
        public void AddBook(Book book)

        {
            var author = authors.FirstOrDefault(a => a.AuthorName == book.Author);

            if (author == null)
            {
                author = new Author(book.Author);
                authors.Add(author);
            }

            var existingBook = books.FirstOrDefault(x => x.Author == book.Author && x.ReleaseDate == book.ReleaseDate);

            if (existingBook != null)
            {
                throw new Exception("This book already exists.");
            }
            books.Add(book);
        }

        //ავტორის დამატების მეთოდი
        public void AddAuthor(Author author)
        {
            var res = authors.FirstOrDefault(a => a.AuthorName == author.AuthorName);

            if (res is null)
            {
                authors.Add(author);
            }

            else throw new Exception("This book already exists.");
        }

        public void RemoveBook(string title, string authorName)

        {
            var book = books.SingleOrDefault(i => i.Title == title && i.Author == authorName);

            if (book != null)
            {
                books.Remove(book);
            }

            else
            {
                throw new Exception("Book not found.");
            }
        }

        //ავტორის წაშლის მეთოდი
        public void RemoveAuthor(Guid authorId)
        {
            var res = authors.SingleOrDefault(x => x.Id == authorId);
            if (res is not null) authors.Remove(res);
            else throw new Exception("No author found");
        }

        //წიგნის ძებნა სათაურით
        public List<Book> SearchBooksByTitle(string searchTerm)
        {
            return books.Where(b => b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //წიგნის ძებნა ავტორით
        public List<Book> SearchBooksByAuthor(string searchTerm)
        {
            return books.Where(b => b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Author? SearchAuthorByName(string name) => authors.Find(x => x.AuthorName == name);

        public List<Author> GetAllAuthor()
        {
            return authors.ToList();
        }

        public List<Book> GetAllBook()
        {
            return books.ToList();
        }

        //წიგნის დააფდეითება
        public void UpdateBook(Guid bookId, string newTitle, string newAuthor, DateTime newReleaseDate)
        {
            var book = books.SingleOrDefault(b => b.Id == bookId);
            if (book != null)
            {
                var author = authors.FirstOrDefault(a => a.AuthorName == newAuthor);
                if (author == null)
                {
                    author = new Author(newAuthor);
                    authors.Add(author);
                }

                book.Title = newTitle;
                book.Author = newAuthor;
                book.ReleaseDate = newReleaseDate;
            }
            else
            {
                throw new Exception("Book not found.");
            }
        }

        //ავტორის დააფდეითება
        public void UpdateAuthor(Guid authorId, string newAuthorName)
        {
            var author = authors.SingleOrDefault(a => a.Id == authorId);
            if (author != null)
            {
                author.AuthorName = newAuthorName;
            }
            else
            {
                throw new Exception("Author not found.");
            }
        }
    }
}

#endregion