namespace Shop_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
<<<<<<< HEAD
            using (var context = new UserContext())
            {
                // Create a database (if it does not exist)
                context.Database.EnsureCreated();
            }
                ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
=======
            ApplicationConfiguration.Initialize();
            Application.Run(new Splashscreen());
>>>>>>> adf409e260c0decb142ed36efcadebfe803d4f06
        }
    }
}