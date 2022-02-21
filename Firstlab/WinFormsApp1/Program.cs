namespace WinFormsApp1
{
    public class Lab_1
    {
        short A = 11;
        const ulong B = 7;
        double[] arr = new double[11];
        enum D: long
        {
            day1 = 1,
            day2 = 2
        }
        public void oper()
        {
            A = 2;
            A += (short)B;
            A *= (short)B;
            arr[0] = A;
        }
    }
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
            Lab_1 lab = new Lab_1();
            lab.oper();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}