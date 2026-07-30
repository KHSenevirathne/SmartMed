using System;
using System.Globalization;
using System.Windows.Forms;
using SmartMed.Data;
using SmartMed.Forms;

namespace SmartMed
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.CurrencySymbol = "Rs. ";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;

            try
            {
                SeedData.EnsureSeeded();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to initialise application data:\n" + ex.Message,
                    "SmartMed Pharmacy",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new LoginForm());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowUnexpectedError(e.Exception);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowUnexpectedError(e.ExceptionObject as Exception);
        }

        private static void ShowUnexpectedError(Exception ex)
        {
            MessageBox.Show(
                "Something went wrong and the action could not be completed:\n" +
                (ex == null ? "Unknown error." : ex.Message),
                "SmartMed Pharmacy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
