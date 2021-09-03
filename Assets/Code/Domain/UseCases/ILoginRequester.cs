using System.Threading.Tasks;

namespace BaseDefender.Domain
{
    public interface ILoginRequester
    {
        Task Login();
    }
}
