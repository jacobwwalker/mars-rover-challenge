﻿using System;

namespace MarsRoverTechnicalChallenge
{
    class Position
    {
        public static enum Orientation { N, E, S, W };
        public static enum Direction { L, R };

        public int X { get; private set; }
        public int Y { get; private set; }
        public Orientation Facing { get; private set; }

        public Position(int x, int y, Orientation facing)
        {
            this.X = x;
            this.Y = y;
            this.Facing = facing;
        }

        public void Rotate(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}