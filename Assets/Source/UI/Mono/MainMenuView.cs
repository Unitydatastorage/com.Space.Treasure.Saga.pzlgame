using System;
using Source.Game;
using UnityEngine;
using VContainer;

namespace Source.UI.Mono
{
    public class MainMenuView : PoliceConfirmUI
    {
        [Inject] private GameStats _gameStats;

        private void Awake()
        {
            _gameStats.OnStopGame += Show;
            Hide();
        }
    }
}