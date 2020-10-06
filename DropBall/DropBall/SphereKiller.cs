using System.Linq;
using System.Threading.Tasks;
using Stride.Engine;
using Stride.Engine.Events;
using Stride.Physics;

namespace DropBall
{
    public class SphereKiller: AsyncScript
    {
        public static EventKey GameOver = new EventKey();
    
        public override async Task Execute()
        {
            var physics = Entity.Get<RigidbodyComponent>();
            var collision = await physics.NewCollision();
            
            var sphere = collision.ColliderA == physics
                ? collision.ColliderB.Entity
                : collision.ColliderA.Entity;
            
            Entity.Scene.Entities.Remove(sphere);
            foreach(var platform in Entity.Scene.Entities.Where(e => e.Name == "Platform").ToList())
                Entity.Scene.Entities.Remove(platform);
                
            GameOver.Broadcast();
        }
    }
}
