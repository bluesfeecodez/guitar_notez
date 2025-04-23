using GuitarJournal.Application.DTOs;

namespace GuitarJournal.Application.Interfaces
{
    public interface IPracticeSessionService
    {
        Task<List<PracticeSessionDto>> GetAllAsync();
        Task<PracticeSessionDto?> GetByIdAsync(Guid id);
        Task<PracticeSessionDto> CreateAsync(CreatePracticeSessionDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}