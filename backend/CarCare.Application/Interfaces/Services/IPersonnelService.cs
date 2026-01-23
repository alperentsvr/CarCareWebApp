using CarCare.Application.DTOs;
using CarCare.Application.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CarCare.Application.Interfaces.Services
{
    public interface IPersonnelService { Task<ServiceResponse<List<PersonnelDto>>> GetAllAsync(string? search = null); Task<ServiceResponse<int>> CreateAsync(CreatePersonnelDto r); Task<ServiceResponse<bool>> UpdateAsync(UpdatePersonnelDto r); Task<ServiceResponse<bool>> DeleteAsync(int id); }
}