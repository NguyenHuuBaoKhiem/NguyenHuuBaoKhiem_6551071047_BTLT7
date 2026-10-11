namespace Cau4_QuanLyLichKham
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(
                new Form1());
        }
    }
}