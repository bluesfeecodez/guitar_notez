namespace GuitarJournal.Application.DTOs
{
    public class PracticeSessionDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public string? Category { get; set; }
    }

    public class CreatePracticeSessionDto
    {
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int DurationMinutes { get; set; }
        public string? Category { get; set; }
    }

}

