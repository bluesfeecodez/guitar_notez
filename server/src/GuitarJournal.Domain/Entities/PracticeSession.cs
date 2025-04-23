namespace GuitarJournal.Domain.Entities
{
    public class PracticeSession
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public string? Category { get; set; }
    }
}
