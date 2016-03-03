﻿using System;
using System.Collections.Generic;

namespace TicTacToe {
    internal class SpyGameConsole : IGameConsole
    {
        private readonly string grid;
        private int playerMove = 0;
        public bool wasAskInputCalled = false;

        private Queue<string> data = new Queue<string>();

        public bool wasWinningResultDisplayed;
        public bool wasDisplayedBoardCalled = false;
        public bool wasTakePlayerMoveCalled;
        public int numberOftTimesDisplayedCalled;
        public bool wasDrawnResultDisplayed;

        public SpyGameConsole()
        { 
           grid = "-------\n|1|2|3|\n-------\n|4|5|6|\n-------\n|7|8|9|\n-------\n";
        }

        public void DisplayBoard(Board board)
        {
            wasDisplayedBoardCalled = true;
            numberOftTimesDisplayedCalled += 1;
            Write(grid);
        }

        public void Write(string data)
        {
            this.data.Enqueue(data);
        }

        public void AskForInputPosition()
        {
            wasAskInputCalled = true;
            Write("Please Play Move");
        }

        public int TakePlayerMove()
        {
            wasTakePlayerMoveCalled = true;
            return playerMove;
        }

        public void DisplayGameDrawnResult()
        {
            wasDrawnResultDisplayed = true;
        }

        public void DisplayGameWonResult(string playerName)
        {
            wasWinningResultDisplayed = true;
        }

        public string LastPrintedMessage()
        {
            return data.Dequeue();
        }

        public void SetPlayerMove(int playerMove)
        {
            this.playerMove = playerMove;
        }
    }
}