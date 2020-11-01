using System;

namespace codility.frog_jump
{
    public class FrogJump
    {
        public int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}
