using StudentManagementSystem.Repositories.Interfaces;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Services.Implementations
{
    public class HostelService : IHostelService
    {
        private readonly IHostelRepository _hostelRepository;
        private readonly ILogger<HostelService> _logger;

        public HostelService(IHostelRepository hostelRepository, ILogger<HostelService> logger)
        {
            _hostelRepository = hostelRepository;
            _logger = logger;
        }

        public async Task<(bool success, string message, Hostel? hostel)> CreateHostelAsync(Hostel hostel)
        {
            try
            {
                await _hostelRepository.AddAsync(hostel);
                await _hostelRepository.SaveChangesAsync();

                _logger.LogInformation($"Hostel created successfully: {hostel.HostelName}");
                return (true, "Hostel created successfully.", hostel);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating hostel: {ex.Message}");
                return (false, "An error occurred while creating hostel.", null);
            }
        }

        public async Task<(bool success, string message)> UpdateHostelAsync(Hostel hostel)
        {
            try
            {
                _hostelRepository.Update(hostel);
                await _hostelRepository.SaveChangesAsync();

                _logger.LogInformation($"Hostel updated successfully: {hostel.HostelName}");
                return (true, "Hostel updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating hostel: {ex.Message}");
                return (false, "An error occurred while updating hostel.");
            }
        }

        public async Task<(bool success, string message)> DeleteHostelAsync(int hostelId)
        {
            try
            {
                var hostel = await _hostelRepository.GetByIdAsync(hostelId);
                if (hostel == null)
                {
                    return (false, "Hostel not found.");
                }

                _hostelRepository.Delete(hostel);
                await _hostelRepository.SaveChangesAsync();

                _logger.LogInformation($"Hostel deleted successfully: {hostelId}");
                return (true, "Hostel deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting hostel: {ex.Message}");
                return (false, "An error occurred while deleting hostel.");
            }
        }

        public async Task<Hostel?> GetHostelByIdAsync(int hostelId)
        {
            return await _hostelRepository.GetByIdAsync(hostelId);
        }

        public async Task<IEnumerable<Hostel>> GetAllHostelsAsync()
        {
            return await _hostelRepository.GetAllAsync();
        }
    }
}
