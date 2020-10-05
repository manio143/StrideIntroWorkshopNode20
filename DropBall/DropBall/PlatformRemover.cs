using System.Threading.Tasks;
using Stride.Engine;
using Stride.Physics;

namespace DropBall
{
    public class PlatformRemover: AsyncScript
    {    
        public override async Task Execute()
        {
            var physics = Entity.Get<RigidbodyComponent>();
            while(Game.IsRunning)
            {
                var collision = await physics.NewCollision();
                
                var entity = collision.ColliderA == physics
                    ? collision.ColliderB.Entity
                    : collision.ColliderA.Entity;
                
                Entity.Scene.Entities.Remove(entity);
            }
        }
    }
}
