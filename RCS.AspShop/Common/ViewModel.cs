namespace RCS.AspShop.Common
{
    public abstract class ViewModel
    {
        protected const string databaseErrorMessage = "Error retrieving data from database.";

        public virtual void Refresh() { }

        protected static bool NullOrEmpty(string value)
        {
            return (value == null || value.Trim() == string.Empty);
        }
    }
}