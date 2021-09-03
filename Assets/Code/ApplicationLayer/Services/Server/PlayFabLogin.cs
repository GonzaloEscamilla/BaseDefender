using System;
using System.Threading.Tasks;
using SystemUtilities;
using Code.Domain.Services.Server;
using PlayFab;
using PlayFab.ClientModels;

namespace Code.ApplicationLayer.Services.Server
{
    public class PlayFabLogin: IAuthenticateService
    {
        public Task Authenticate()
        {
            var t = new TaskCompletionSource<bool>();
            
            LoginWithCustomIDRequest loginWithCustomIDRequest = new LoginWithCustomIDRequest()
            {
                CreateAccount = true,
                CustomId = "1",
            };

            

            PlayFabClientAPI.LoginWithCustomID(loginWithCustomIDRequest,
                result => OnSuccess(result,t),
                error => OnError(error,t));
            
            return Task.Run(() => t.Task);
        }

        private void OnError(PlayFabError error, TaskCompletionSource<bool> taskCompletionSource)
        {
            taskCompletionSource.SetResult(false);
            throw new Exception(error.ErrorMessage);
        }

        private void OnSuccess(LoginResult result, TaskCompletionSource<bool> taskCompletionSource)
        {
            taskCompletionSource.SetResult(true);
        }
    }
}