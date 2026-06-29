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
    }
}
