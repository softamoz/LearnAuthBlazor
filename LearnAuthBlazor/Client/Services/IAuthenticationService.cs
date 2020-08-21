using System.Threading.Tasks;
using LearnAuthBlazor.Shared.DTOs;

namespace LearnAuthBlazor.Client.Services
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
    }
}