﻿using TicTacToe.Board;

namespace TicTacToeGame.GameBoard
{
    internal interface IGameBoard
    {
        void Draw();
        void Update(Cordinate cords);
        void Reset();
        void Scan();
    }
}