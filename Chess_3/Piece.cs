//Safiullin Rinat, 220P, 15.04.2022, Шахматные фигуры - 3
using System.Collections.Generic;
using System;

namespace Chess3
{
    class Piece
    {
        protected int x;
        protected int y;
        protected Dictionary<char, int> convertationToInt = new Dictionary<char, int>()
        {
            {'A',1},
            {'B',2},
            {'C',3},
            {'D',4},
            {'E',5},
            {'F',6},
            {'G',7},
            {'H',8}
        };
        protected Dictionary<int, char> convertationToStr = new Dictionary<int, char>()
        {
            {1,'A'},
            {2,'B'},
            {3,'C'},
            {4,'D'},
            {5,'E'},
            {6,'F'},
            {7,'G'},
            {8,'H'}
        };

        protected Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected Piece(string cell)
        {
            x = convertationToInt[cell[0]];
            y = Convert.ToInt32(cell[1].ToString());
        }

        protected virtual bool isRightMove(int x, int y)
        {
            return false;
        }

        public void Move(string sellToMove) 
        {
            int x = convertationToInt[sellToMove[0]];
            int y = Convert.ToInt32(sellToMove[1].ToString());
            Move(x,y);
        }

        public void Move(int x, int y) 
        {
            if (isRightMove(x, y))
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                throw new Exception("Невозможно сделать такой ход!");
            }
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"Coordinates - {convertationToStr[x]}{y}");
        }
    }
}