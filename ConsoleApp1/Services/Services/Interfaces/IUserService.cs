using Entities.Models;
using Services.DTOs;

namespace Services.Services.Interfaces;

public interface IUserService
{
    StatusResponseDto GetStatusById(int id, int userId);
}
