﻿using System;
using System.Collections.Generic;

namespace chess_engine
{
    public class Piece
    {
        private Color _color;
        public virtual bool IsFirstMove() => false;
        public bool RightEdge()
        {
            return this.Color == Color.White ? this.Cell.IsRightEdge : this.Cell.IsLeftEdge;
        }
        public bool LeftEdge()
        {
            return this.Color == Color.White ? this.Cell.IsLeftEdge : this.Cell.IsRightEdge;
        }
        public int MoveRight(int Iterant)
        {
            return this.Cell.Number + (1 * Iterant) * (this.Color == Color.White ? 1 : -1);
        }
        public int MoveLeft(int iterant)
        {
            return this.Cell.Number + (1 * iterant) * (this.Color == Color.White ? -1 : 1);
        }
        public int MoveUp(int iterant)
        {
            return this.Cell.Number + (8 * iterant) * (this.Color == Color.White ? 1 : -1);
        }
        public int MoveDown(int iterant)
        {
            return this.Cell.Number + (8 * iterant) * (this.Color == Color.White ? -1 : 1);
        }
        public int MoveUpLeft(int iterant)
        {
            return this.Cell.Number + (7 * iterant) * (this.Color == Color.White ? 1 : -1);
        }
        public int MoveUpRight(int iterant)
        {
            return this.Cell.Number + (9 * iterant) * (this.Color == Color.White ? 1 : -1);
        }
        public int MoveDownLeft(int iterant)
        {
            return this.Cell.Number + (9 * iterant) * (this.Color == Color.White ? -1 : 1);
        }
        public int MoveDownRight(int iterant)
        {
            return this.Cell.Number + (7 * iterant) * (this.Color == Color.White ? -1 : 1);
        }
        public bool IsOppositeColor(Color color)
        {
            return color == this.Color ? false : true;
        }
        public Color Color
        {
            get{ return _color; }
        }
        public Figure Figure { get; set; }
        public Cell Cell { get; set;}
        public Piece(Color color, Figure figure)
        {
            _color = color;
            Figure = figure;
        }
        public virtual List<Move> GetAvailableMoves()
        {
            throw new Exception("Should not be called");
        }
    }
}

