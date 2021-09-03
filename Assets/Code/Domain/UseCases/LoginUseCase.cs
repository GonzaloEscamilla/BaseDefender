using System.Threading.Tasks;
using BaseDefender.Domain;
using Code.Domain.Services.Server;

namespace Code.Domain.UseCases
{
    public class LoginUseCase : ILoginRequester
    {
        private readonly IAuthenticateService _authenticateService;

        public LoginUseCase(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        public async Task Login()
        {
            await _authenticateService.Authenticate();
        }
    }
}