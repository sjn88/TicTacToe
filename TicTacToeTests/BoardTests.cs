using System;
using System.Collections.Generic;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTests
{
    [TestFixture]
    public class BoardTests
    {
        private Board board
                      ;

        private Cell topLeft;
        private Cell topMiddle;
        private Cell topRight;
        private Cell middleLeft;
        private Cell middleMiddle;
        private Cell middleRight;
        private Cell bottomLeft;
        private Cell bottomMiddle;
        private Cell bottomRight;

        [SetUp]
        public void SetUp()
        {
            topLeft = new Cell();
            topMiddle = new Cell();
            topRight = new Cell();
            middleLeft = new Cell();
            middleMiddle = new Cell();
            middleRight = new Cell();
            bottomLeft = new Cell();
            bottomMiddle = new Cell();
            bottomRight = new Cell();
            var cells = new List<Cell>{topLeft, topMiddle, topRight, middleLeft, middleMiddle, middleRight, bottomLeft, bottomMiddle, bottomRight};
            board = new Board(cells);
        }

        [Test]
        public void constructor_Does_Not_Throw_if_NineCells_AreGiven()
        {
            Assert.DoesNotThrow(() => new Board(new List<Cell> {new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell()}));
        }

        [Test]
        public void constructor_Throws_if_NineCells_AreNotGiven()
        {
            Assert.Throws<ArgumentException>(() => new Board(new List<Cell> { new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell(), new Cell() }));
        }

        [Test]
        public void newGame_is_Not_Finished()
        {
            Assert.False(board.Finished);
        }

        [Test]
        public void Test_That_Throws_When_Invalid_Cell_Is_Used()
        {
            Assert.Throws<ArgumentException>(() => board.Play(new Cell()));
        }

        [TestCase(0, 0)]
        public void Test_That_Does_Not_Throw_When_Valid_Coord_Is_Used(Cell cell)
        {
            Assert.DoesNotThrow(() => board.Play(cell));
        }

        //In the process of removing co-ordinates.
        public void Test_That_Cannot_Play_Same_Cell_Twice(int first, int second)
        {
            board.Play(new ThreeByThreeCoordinates(first, second));
            Assert.Throws<ArgumentException>(() => board.Play(new ThreeByThreeCoordinates(first, second)));
        }
    }
}