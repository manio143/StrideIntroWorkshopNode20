using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Physics;

namespace DropBall
{
    public class SphereMovement : SyncScript
    {
        public float Velocity { get; set; }
        
        private RigidbodyComponent physics;
        
        public override void Start()
        {
            physics = Entity.Get<RigidbodyComponent>();
        }

        public override void Update()
        {
            var effectiveVelocity = 0.0f;
            if (Input.IsKeyDown(Keys.Left))
                effectiveVelocity += Velocity;
            if (Input.IsKeyDown(Keys.Right))
                effectiveVelocity -= Velocity;
            physics.LinearVelocity = new Vector3(0, 0, effectiveVelocity);
        }
    }
}
