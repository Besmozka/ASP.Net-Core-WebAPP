namespace Timesheets.Infrastructure.Constants
{
    public static class ValidationMessages
    {
        public const string SheetAmount = "Amount should be between 0 and 8 hours.";
        public const string InvoiceDate = "Date of end cannot be less then date of start";
        public const string InvalidValue = "Incorrect value";
    }
}