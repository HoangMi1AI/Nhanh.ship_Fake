namespace QuanlyGiaoVan
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
            ConnectDB connector = new ConnectDB();
            connector.connectDB();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormTaoDonHang2());
        }
    }
}