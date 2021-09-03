using System;
using BaseDefender.Domain;
using Code.ApplicationLayer.Services.Server;
using Code.Domain.UseCases;
using UnityEngine;

namespace Code.UnityConfigurationAdapters.Installers
{
    public class GlobalInstaller: MonoBehaviour
    {
        private void Awake()
        {
            var playFabLogin = new PlayFabLogin();
            var loginUseCase = new LoginUseCase(playFabLogin);
            var initializeGameUseCase = new InitializeGameUseCase(loginUseCase);
            
            initializeGameUseCase.InitGame();
        }
    }
}