using GuitarJournal.Application.DTOs;
using GuitarJournal.Application.Interfaces;
using GuitarJournal.Domain.Entities;
using GuitarJournal.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class PracticeSessionService : IPracticeSessionService
{
    private readonly GuitarJournalDbContext _db;

    public PracticeSessionService(GuitarJournalDbContext db)
    {
        _db = db;
    }

    public async Task<PracticeSessionDto> CreateAsync(CreatePracticeSessionDto dto)
    {
        var session = new PracticeSession
        {
            Id = Guid.NewGuid(),
            Date = dto.Date,
            Description = dto.Description,
            DurationMinutes = dto.DurationMinutes,
            Category = dto.Category
        };

        _db.PracticeSessions.Add(session);
        await _db.SaveChangesAsync();

        return new PracticeSessionDto
        {
            Id = session.Id,
            Date = session.Date,
            Description = session.Description,
            DurationMinutes = session.DurationMinutes,
            Category = session.Category
        };
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var session = await _db.PracticeSessions.FindAsync(id);
        if (session == null) return false;

        _db.PracticeSessions.Remove(session);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<List<PracticeSessionDto>> GetAllAsync()
    {
        return await _db.PracticeSessions.Select(s => new PracticeSessionDto
        {
            Id = s.Id,
            Date = s.Date,
            Description = s.Description,
            DurationMinutes = s.DurationMinutes,
            Category = s.Category
        }).ToListAsync();
    }

    public async Task<PracticeSessionDto?> GetByIdAsync(Guid id)
    {
        var session = await _db.PracticeSessions.FindAsync(id);
        if (session == null) return null;

        return new PracticeSessionDto
        {
            Id = session.Id,
            Date = session.Date,
            Description = session.Description,
            Category = session.Category
        };
    }
}
