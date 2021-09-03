using Code.Domain.UseCases;

namespace BaseDefender.Domain
{

    public class InitializeGameUseCase : IGameInitializer
    {
        private readonly ILoginRequester _loginRequester;

        public InitializeGameUseCase(ILoginRequester loginRequester)
        {
            _loginRequester = loginRequester;
        }

        public async void InitGame()
        {
            await _loginRequester.Login();
            // Load server configuration
            // Load User Configuration
        }
    }
}
