using Stride.Engine;

namespace DropBall
{
    class DropBallApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
