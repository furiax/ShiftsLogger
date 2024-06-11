namespace ShiftsLoggerAPI.Models
{
    public class ShiftModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public DateTime StartOfShift { get; set; }
        public DateTime EndOfShift { get; set; }
        public TimeSpan Duration => EndOfShift - StartOfShift;
    }
}
