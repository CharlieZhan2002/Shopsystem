using Shop_system.Model;
using Microsoft.EntityFrameworkCore;
using Shop_system.form;

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
            using (var context = new MyDbContext())
            {
                // Create a database (if it does not exist)
                context.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();

            // Run the Login form on start
            Application.Run(new Login());
        }
    }
}
