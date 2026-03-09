using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services.Interfaces
{
    public interface IHostelService
    {
        Task<(bool success, string message, Hostel? hostel)> CreateHostelAsync(Hostel hostel);
        Task<(bool success, string message)> UpdateHostelAsync(Hostel hostel);
        Task<(bool success, string message)> DeleteHostelAsync(int hostelId);
        Task<Hostel?> GetHostelByIdAsync(int hostelId);
        Task<IEnumerable<Hostel>> GetAllHostelsAsync();
    }
}
