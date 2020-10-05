using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.Physics;

namespace DropBall
{
    public class ConstantVelocity : SyncScript
    {
        public float Velocity { get; set; }

        public override void Update()
        {
            var currentY = Entity.Transform.Position.Y;
            var newY = currentY + Velocity * (float)Game.UpdateTime.Elapsed.TotalSeconds;
            Entity.Transform.Position.Y = newY;
        }
    }
}
