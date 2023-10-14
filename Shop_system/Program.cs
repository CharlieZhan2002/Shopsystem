namespace Shop_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserContext())
            {
                // 创建数据库（如果不存在）
                context.Database.EnsureCreated();

                bool continueRunning = true;

                while (continueRunning)
                {
                    DisplayMenu();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            AddAdmin(context);
                            break;
                        case "2":
                            AddCustomer(context);
                            break;
                        case "3":
                            ListAllUsers(context);
                            break;
                        case "4":
                            Login(context);
                            break;
                        case "5":
                            continueRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            Console.ReadKey();
                            break;
                    }

                    Console.Clear();
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add Admin");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. List All Users");
            Console.WriteLine("4. Login");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

        private static void AddAdmin(UserContext context)
        {
            AddUser(context, UserRole.Admin);
        }

        private static void AddCustomer(UserContext context)
        {
            AddUser(context, UserRole.Customer);
        }

        private static void AddUser(UserContext context, UserRole role)
        {
            Console.Clear();
            Console.WriteLine($"--- Add {role} ---");

            Console.Write("Enter Username: ");
            var username = Console.ReadLine();

            Console.Write("Enter Password: ");
            var password = Console.ReadLine();

            User newUser;
            if (role == UserRole.Admin)
            {
                newUser = new Admin { Username = username, PasswordHash = password };
            }
            else // Assume Customer
            {
                newUser = new Customer { Username = username, PasswordHash = password };
            }

            context.Users.Add(newUser);
            context.SaveChanges();

            Console.WriteLine($"{role} added successfully!");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private static void ListAllUsers(UserContext context)
        {
            Console.Clear();
            Console.WriteLine("--- List All Users ---");
            foreach (var user in context.Users)
            {
                Console.WriteLine($"ID: {user.UserId}, Username: {user.Username}, Password: {user.PasswordHash}, Role: {user.Role}");
            }
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        private static void Login(UserContext context)
        {
            Console.Clear();
            Console.WriteLine("--- Login ---");

            Console.Write("Enter Username: ");
            var username = Console.ReadLine();

            Console.Write("Enter Password: ");
            var password = Console.ReadLine();

            var user = context.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
            if (user != null)
            {
                Console.WriteLine($"Welcome, {username}!");
                bool stayLoggedIn = true;
                while (stayLoggedIn)
                {
                    Console.WriteLine("\nLogin Menu:");
                    Console.WriteLine("1. Display Your Details");
                    Console.WriteLine("2. Logout");
                    Console.Write("Choose an option: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"ID: {user.UserId}, Username: {user.Username}, Password: {user.PasswordHash}, Role: {user.Role}");
                            break;
                        case "2":
                            stayLoggedIn = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid login credentials.");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}