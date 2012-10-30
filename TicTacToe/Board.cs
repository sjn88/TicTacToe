using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public interface IBoard
    {
        bool Finished{get;}
        IWinner Winner{get;}
    }

    public class Board : IBoard
    {
        private List<Cell> myCells;

        public Board(List<Cell> cells)
        {
            if (cells.Count != 9)
            {
                throw new ArgumentException();
            }
            myCells = cells;
        }

        public bool Finished{get;private set;}
        public IWinner Winner{get;private set;}


        public void Play(Cell cell)
        {
            myCells.Contains(cell);
        }
    }

    public interface IWinner
    {}

    public class NoughtPlayer : IWinner{}
    public class CrossPlayer : IWinner{}
    public class NoneYet : IWinner{}
    public class Both : IWinner{}
}