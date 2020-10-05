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
            Entity.Get<RigidbodyComponent>().LinearVelocity = new Vector3(0, Velocity, 0);
        }
    }
}
