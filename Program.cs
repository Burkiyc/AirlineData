using static AirlineData.Classes.Functions;

namespace AirlineData
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Form1 form1 = new Form1();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            GetDatabaseProps();
            Application.Run(form1);
        }
    }
}