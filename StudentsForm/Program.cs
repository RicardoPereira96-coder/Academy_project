using Forms;
using Forms.Models;

namespace StudentsForm
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
            GlobalConfig.InitializeConnections(DataBaseType.Sql);
            Application.Run(new HomeForm());
        }
    }
}