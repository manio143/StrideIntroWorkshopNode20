# Lesson 9: Create sphere killer

Using knowledge from previous lessons create an entity that is a trigger reacting to the sphere.

This time, when the collision begins we're going to remove the sphere and all platform entities (which have the same name - 'Platform'). After that we'll raise a global event.

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

## Global events
Stride provides a mechanism for raising asynchronous events between different parts of your game. While they don't have to be static (and thus global) this is the easiest way to use them.

In the script above we have defined a static `EventKey` field and in the method we call `Broadcast()` on it. If any other script creates a `EventReceiver` with this event key, they can receive this event and execute some action.

You can also pass data in the event (with generic versions of those classes). But it's important to remember that a receiver can hold at most one value at a time.
