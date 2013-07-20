﻿using System;

namespace MarsRoverTechnicalChallenge
{
    public enum Orientation { N, E, S, W };
    public enum Direction { L, R };

    public class Position
    {
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
            if (direction == Direction.R)
            {
                if (this.Facing == Orientation.W)
                {
                    this.Facing = Orientation.N;
                }
                else
                {
                    this.Facing = (Orientation) this.Facing + 1;
                }
            }
            else if (direction == Direction.L)
            {
                if (this.Facing == Orientation.N)
                {
                    this.Facing = Orientation.E;
                }
                else
                {
                    this.Facing = (Orientation) this.Facing - 1;
                }
            }
        }
    }
}
