using Supermarker_mvp._Repositories;
using Supermarker_mvp.Models;
using Supermarker_mvp.Presenters;
using Supermarker_mvp.Properties;
using Supermarker_mvp.Views;
using Supermarket_mvp.Views;

namespace Supermarker_mvp
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
            ApplicationConfiguration.Initialize();
            string sqlconnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlconnectionString);
            Application.Run((Form)view);
        }
    }
}