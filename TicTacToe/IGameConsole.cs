﻿namespace TicTacToe {
    public interface IGameConsole
    {
        void DisplayBoard();
        void Write(string input);
        void AskForInputPosition();
        int TakePlayerMove();
    }
}