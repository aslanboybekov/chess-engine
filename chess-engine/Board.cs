﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace chess_engine
{
    public class Board
    {
        public Color Turn { get; set; }
        public bool IsPartialBoard { get; set; }
        private static string columns = "abcdefgh";
        public Board()
        {
            for (int i = 0; i < 64; i++)
            {
                Cells[i] = new Cell(this);
                Cells[i].Number = i;
            }
        }
        public List<Cell> Cells { get; } = new Cell[64].ToList();
        public static int PositionToNumber(char column, int row)
        {
            return (row * 8) - 1 - (7 - ("abcdefgh".IndexOf(column))); 
        }
        public Cell Cell(char column, int row)
        {
            var columnIndex = columns.IndexOf(column);
            var cellIndex = (row - 1) * 8 + columnIndex;
            return Cells[cellIndex];
        }
        public List<Move> GetAvailableMoves(Piece piece)
        {
            return piece.GetAvailableMoves();
        }


        public void ResetBoard()
        {
            this.Turn = Color.White;
            foreach (var col in "abcdefgh")
            {
                this.Cell(col, 2).Piece = new Pawn(Color.White);
                this.Cell(col, 7).Piece = new Pawn(Color.Black);
            }

            this.Cell('a', 1).Piece = new Rook(Color.White);
            this.Cell('h', 1).Piece = new Rook(Color.White);
            this.Cell('a', 8).Piece = new Rook(Color.Black);
            this.Cell('h', 8).Piece = new Rook(Color.Black);
            
            this.Cell('b', 1).Piece = new Knight(Color.White);
            this.Cell('g', 1).Piece = new Knight(Color.White);
            this.Cell('b', 8).Piece = new Knight(Color.Black);
            this.Cell('g', 8).Piece = new Knight(Color.Black);
            
            this.Cell('c', 1).Piece = new Bishop(Color.White);
            this.Cell('f', 1).Piece = new Bishop(Color.White);
            this.Cell('c', 8).Piece = new Bishop(Color.Black);
            this.Cell('f', 8).Piece = new Bishop(Color.Black);
            
            this.Cell('d', 1).Piece = new Queen(Color.White);
            this.Cell('d', 8).Piece = new Queen(Color.Black);

            this.Cell('e', 1).Piece = new King(Color.White);
            this.Cell('e', 8).Piece = new King(Color.Black);
        }
        // Mate in 3
        public void PuzzleOne()
        {
            this.Turn = Color.White;
            this.Cell('h', 2).Piece = new Pawn(Color.White);
            this.Cell('f', 7).Piece = new Pawn(Color.Black);
            this.Cell('h', 7).Piece = new Pawn(Color.Black);
            this.Cell('f', 6).Piece = new Rook(Color.White);
            this.Cell('a', 8).Piece = new Rook(Color.Black);
            this.Cell('g', 8).Piece = new Rook(Color.Black);
            this.Cell('e', 5).Piece = new Bishop(Color.White);
            this.Cell('h', 1).Piece = new King(Color.White);
            this.Cell('h', 8).Piece = new King(Color.Black);
        }

        //Mate in 2
        public void PuzzleTwo()
        {
            this.Turn = Color.Black;
            this.Cell('h', 2).Piece = new Pawn(Color.White);
            this.Cell('g', 3).Piece = new Pawn(Color.White);
            this.Cell('g', 7).Piece = new Pawn(Color.Black);
            this.Cell('b', 2).Piece = new Pawn(Color.White);
            this.Cell('d', 5).Piece = new Pawn(Color.Black);
            this.Cell('c', 6).Piece = new Pawn(Color.Black);
            this.Cell('a', 3).Piece = new Pawn(Color.White);
            this.Cell('b', 7).Piece = new Pawn(Color.Black);
            this.Cell('a', 7).Piece = new Pawn(Color.Black);
            this.Cell('d', 1).Piece = new Rook(Color.White);
            this.Cell('e', 1).Piece = new Rook(Color.White);
            this.Cell('f', 2).Piece = new Rook(Color.Black);
            this.Cell('c', 1).Piece = new Bishop(Color.White);
            this.Cell('c', 5).Piece = new Bishop(Color.Black);
            this.Cell('h', 3).Piece = new Bishop(Color.Black);
            this.Cell('g', 1).Piece = new King(Color.White);
            this.Cell('g', 8).Piece = new King(Color.Black);
            this.Cell('f', 1).Piece = new Knight(Color.White);
        }

        public void PuzzleThree()
        {
            this.Turn = Color.White;
            this.Cell('h', 2).Piece = new Pawn(Color.White);
            this.Cell('g', 3).Piece = new Pawn(Color.White);
            this.Cell('g', 7).Piece = new Pawn(Color.Black);
            this.Cell('b', 2).Piece = new Pawn(Color.White);
            this.Cell('d', 5).Piece = new Pawn(Color.Black);
            this.Cell('c', 6).Piece = new Pawn(Color.Black);
            this.Cell('a', 3).Piece = new Pawn(Color.White);
            this.Cell('b', 7).Piece = new Pawn(Color.Black);
            this.Cell('a', 7).Piece = new Pawn(Color.Black);
            this.Cell('d', 1).Piece = new Rook(Color.White);
            this.Cell('e', 1).Piece = new Rook(Color.White);
            this.Cell('f', 2).Piece = new Rook(Color.Black);
            this.Cell('c', 1).Piece = new Bishop(Color.White);
            this.Cell('c', 5).Piece = new Bishop(Color.Black);
            this.Cell('h', 3).Piece = new Bishop(Color.Black);
            this.Cell('g', 1).Piece = new King(Color.White);
            this.Cell('g', 8).Piece = new King(Color.Black);
            this.Cell('f', 1).Piece = new Knight(Color.White);
        }

        public (Move Move,Piece OtherPiece) ApplyMove(Move move)
        {
            var pieceToMove = this.Cells[move.From].Piece;
            this.Cells[move.From].RemovePiece();
            var otherPiece = this.Cells[move.To].Piece;
            this.Cells[move.To].Piece = pieceToMove;
            this.Turn = pieceToMove.Color == Color.White ? Color.Black : Color.White;
            return (move, otherPiece);
        }

        public void RollbackMove((Move Move, Piece OtherPiece) rollBack)
        {
            var pieceToMove = this.Cells[rollBack.Move.To].Piece;
            this.Cells[rollBack.Move.To].RemovePiece();
            this.Cells[rollBack.Move.From].Piece = pieceToMove;
            if (rollBack.OtherPiece != null)
            {
                this.Cells[rollBack.Move.To].Piece = rollBack.OtherPiece;
            }
            this.Turn = pieceToMove.Color;
        }
    }
}

