﻿using System.Collections.Generic;
using TicTacToe.Board;
using TicTacToe.Player;

namespace TicTacToe.Game
{
    /// <summary>
    ///     Singleton class to hold the current status of the game
    /// </summary>
    public class GameStatus
    {
        static GameStatus()
        {
        }

        private GameStatus()
        {
        }

        public static GameStatus Instance { get; } = new GameStatus();

        public IPlayer CurrentPlayer { get; set; }

        public IEnumerable<IPlayer> Players { get; set; }

        public bool Finished { get; set; }

        public bool Draw { get; set; }

        public Grid Grid { get; set; }
    }
}