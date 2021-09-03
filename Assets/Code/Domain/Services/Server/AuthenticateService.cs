using System.Threading.Tasks;

namespace Code.Domain.Services.Server
{
    public interface IAuthenticateService
    {
        Task Authenticate();
    }
}