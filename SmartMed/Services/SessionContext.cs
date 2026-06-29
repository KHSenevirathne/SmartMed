using SmartMed.Models;

namespace SmartMed.Services
{
    public static class SessionContext
    {
        public static Person CurrentUser { get; private set; }

        public static bool IsAdmin
        {
            get { return CurrentUser is Admin; }
        }

        public static Customer CurrentCustomer
        {
            get { return CurrentUser as Customer; }
        }

        public static void SignIn(Person user)
        {
            CurrentUser = user;
        }

        public static void SignOut()
        {
            CurrentUser = null;
        }
    }
}
