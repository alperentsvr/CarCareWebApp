using CarCare.Application.DTOs;
using CarCare.Application.Wrappers;
using System.Threading.Tasks;
namespace CarCare.Application.Interfaces.Services
{
    public interface IAuthService 
    { 
        Task<ServiceResponse<TokenDto>> LoginAsync(LoginDto request); 
        Task<ServiceResponse<int>> RegisterAsync(RegisterDto request);
        Task<ServiceResponse<System.Collections.Generic.List<UserListDto>>> GetAllUsersAsync();
        Task<ServiceResponse<bool>> DeleteUserAsync(int id);
    }
}